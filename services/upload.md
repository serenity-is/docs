# Uploads

Serenity has a complete upload infrastructure for handling file and image uploads in your row-based services. It covers storing the file, validating it, optionally processing images (scaling/thumbnails), moving the temporary file to its permanent location on save, deleting old files, and serving the file back to the client.

## How Uploads Work

Uploads follow a two-phase flow so that a file isn't committed to permanent storage until the row is actually saved:

1. **Temporary upload.** The client-side upload editor posts the file to a temporary upload endpoint (`/File/TemporaryUpload`). The endpoint uses [IUploadProcessor](../api/dotnet/Serenity.Net.Services/Serenity.Web/IUploadProcessor.md) to validate the file and write it to the temporary folder, returning a temporary path (prefixed `temporary/`). The row field is set to this temporary path.
2. **Save.** When the row is saved, the [FileUploadBehavior](../api/dotnet/Serenity.Net.Web/Serenity.Services/FileUploadBehavior.md) moves the temporary file to its permanent location, writes the permanent path into the field, and deletes (or archives) the previous file. Old temporary files are purged periodically.

Files are served back through [IUploadFileResponder](../api/dotnet/Serenity.Net.Web/Serenity.Web/IUploadFileResponder.md), which exposes files at `/upload/{path}`.

## Declaring an Upload Field

Decorating a `String` field on your **row** (not the form) with an upload editor attribute is enough to enable uploads. The attribute provides the editor type for the client and the options used by `FileUploadBehavior`.

```cs
[DisplayName("User Image"), Size(100)]
[ImageUploadEditor(FilenameFormat = "UserImage/~", CopyToHistory = true)]
public string UserImage { get => fields.UserImage[this]; set => fields.UserImage[this] = value; }
```

The Northwind sample uses the same pattern:

```cs
[DisplayName("Product Image"), Size(100)]
[ImageUploadEditor(FilenameFormat = "ProductImage/~", CopyToHistory = true)]
public string ProductImage { get => fields.ProductImage[this]; set => fields.ProductImage[this] = value; }
```

### Upload editor attributes

| Attribute | Editor type | Multiple? | Description |
| --- | --- | --- | --- |
| [ImageUploadEditor](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ImageUploadEditorAttribute.md) | `ImageUpload` | No | Allows only image files by default |
| [FileUploadEditor](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FileUploadEditorAttribute.md) | `ImageUpload` | No | Allows image and non-image files |
| [MultipleImageUploadEditor](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/MultipleImageUploadEditorAttribute.md) | `MultipleImageUpload` | Yes | Multiple images; stores a JSON array |
| [MultipleFileUploadEditor](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/MultipleFileUploadEditorAttribute.md) | `MultipleImageUpload` | Yes | Multiple files; stores a JSON array |

> **Important:** put the attribute in `Row.cs`, not `Form.cs`. The `FileUploadBehavior` only runs when the attribute is on the field, so if you only put it on the form your files will stay in the temporary folder.

### Common options

All upload editor attributes derive from `BaseUploadEditorAttribute`, which exposes options such as:

- `FilenameFormat` — folder/file naming, e.g. `"UserImage/~"`.
- `OriginalNameProperty` — the name of another field in the row that stores the original file name.
- `MaxSize` / `MinSize` (bytes), `MaxWidth`/`MaxHeight`/`MinWidth`/`MinHeight`.
- `AllowNonImage`, `ImageExtensions`, `AllowedExtensions`.
- `ScaleWidth`/`ScaleHeight`, `ScaleSmaller`, `ScaleMode`, `ScaleQuality`, `ScaleBackColor`.
- `ThumbWidth`/`ThumbHeight`, `ThumbSizes`, `ThumbMode`, `ThumbQuality`, `ThumbBackColor`.
- `CopyToHistory` — archive the previous file instead of deleting it.
- `JsonEncodeValue` — multiple editors store the file list as a JSON array.

For multiple uploads, each item in the stored JSON array is an [`UploadedFile`](../api/dotnet/Serenity.Net.Services/Serenity.Services/UploadedFile.md) with `Filename` and `OriginalName`. The `FilenameFormat` pattern is expanded by [UploadFormatting](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadFormatting.md) (`FormatFilename`), which substitutes the entity ID, group key, random code, date, and original file name.

## Upload Storage

[IUploadStorage](../api/dotnet/Serenity.Net.Services/Serenity.Web/IUploadStorage.md) abstracts where files live. It provides methods to write, read, delete, and copy files, get file URLs and sizes, and manage file metadata.

The default implementation, `DefaultUploadStorage`, is disk-based and writes files under `App_Data/upload/`. Related implementations include `DiskUploadStorage`, `TempUploadStorage`, and `CombinedUploadStorage`. `DiskUploadStorage` writes through [PhysicalDiskUploadFileSystem](../api/dotnet/Serenity.Net.Services/Serenity.Web/PhysicalDiskUploadFileSystem.md) (an `IDiskUploadFileSystem` implementation over the physical file system).

`DefaultUploadStorage` itself is a `CombinedUploadStorage` of two `DiskUploadStorage` instances: a **permanent** storage rooted at `UploadSettings.Path` (default `App_Data/upload/`) served at `UploadSettings.Url` (default `/upload/`), and a **temporary** storage under `<path>/temporary` served at `<url>/temporary/`. The temporary prefix is what lets the framework distinguish temporary files (from the upload editor) from permanent ones, and is what `FileUploadBehavior` checks before copying a file into place.

[UploadPathHelper](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadPathHelper.md) contains path utilities (thumbnail names, security checks), and `UploadStorageExtensions` provides helpers such as `CopyTemporaryFile` and `GetThumbnailUrl`.

Storage is registered by `AddUploadStorage()`:

```cs
public static IServiceCollection AddUploadStorage(this IServiceCollection collection)
{
    collection.TryAddSingleton<IFilenameFormatSanitizer, DefaultFilenameFormatSanitizer>();
    collection.TryAddSingleton<IUploadStorage, DefaultUploadStorage>();
    collection.TryAddSingleton<IUploadValidator, DefaultUploadValidator>();
    collection.TryAddSingleton<IImageProcessor, DefaultImageProcessor>();
    collection.TryAddSingleton<IUploadProcessor, DefaultUploadProcessor>();
    collection.TryAddSingleton<IUploadFileResponder, DefaultUploadFileResponder>();
    return collection;
}
```

## Processing and Validation

The pipeline is handled by [IUploadProcessor](../api/dotnet/Serenity.Net.Services/Serenity.Web/IUploadProcessor.md), whose default implementation does the following when a file is posted:

1. **Security check** on the file name (via `UploadPathHelper.CheckFileNameSecurity`).
2. Optional **antivirus scan** through [IUploadAVScanner](../api/dotnet/Serenity.Net.Services/Serenity.Web/IUploadAVScanner.md).
3. **Validation** with [IUploadValidator](../api/dotnet/Serenity.Net.Services/Serenity.Web/IUploadValidator.md) — checks file size and allowed extensions, and image constraints (dimensions).
4. **Write the temporary file** to storage.
5. **Image processing** with [IImageProcessor](../api/dotnet/Serenity.Net.Services/Serenity.Web/IImageProcessor.md) — scale the main image and generate thumbnails if options specify sizes.
6. Returns a `ProcessedUploadInfo` whose `TemporaryFile` is the new temporary path.

If anything fails, the partially written temporary file is cleaned up and the exception is thrown (so the client shows a validation error).

> The old `UploadProcessor` class is obsolete — inject and use `IUploadProcessor` instead.

### Image processing

`DefaultImageProcessor` uses `ImageChecker` to validate image content and `ThumbnailGenerator` to create thumbnails. `ImageChecker` returns an [`ImageCheckResult`](../api/dotnet/Serenity.Net.Services/Serenity.Web/ImageCheckResult.md) code describing why an image was rejected (e.g. `InvalidImage`, `WidthTooHigh`, `SizeMismatch`), and [`ImageEncoderParams`](../api/dotnet/Serenity.Net.Services/Serenity.Web/ImageEncoderParams.md) carries the JPEG quality used when encoding. The scaling options (`ScaleWidth`, `ScaleHeight`, `ThumbWidth`, etc.) on the editor attribute control what happens.

## Configuration

[UploadSettings](../api/dotnet/Serenity.Net.Services/Serenity.Web/UploadSettings.md) are read from the `UploadSettings` section of `appsettings.json`:

```json
{
  "UploadSettings": {
    "Path": "App_Data/upload/",
    "Url": "~/upload/",
    "ExtensionBlacklistInclude": ".exe;.dll;",
    "ExtensionWhitelistExclude": ".zip;"
  }
}
```

- `Path` — the root folder for uploads (default `App_Data/upload/`).
- `Url` — the public URL prefix (default `~/upload/`).
- `ExtensionBlacklist` / `ExtensionWhitelist` (plus `*Include` / `*Exclude` variants) — control which file extensions are allowed.
- `EditableMetadataKeys` — metadata keys clients are allowed to set.

## Deleting and Archiving Files

When a field value changes, `FileUploadBehavior` registers the old file for deletion through `FilesToDelete` (via `UnitOfWork.RegisterFilesToDelete`), so the file is removed only if the transaction commits. If `CopyToHistory` is set, the old file is archived instead of deleted. The same happens on row delete (`OnAfterDelete`), unless the row uses soft delete.

`FilesToDelete` implements [IFilesToDelete](../api/dotnet/Serenity.Net.Services/Serenity.Web/IFilesToDelete.md), which tracks new and old files. [FilesToDeleteExtensions](../api/dotnet/Serenity.Net.Services/Serenity.Web/FilesToDeleteExtensions.md) provides `RegisterFilesToDelete`, which hooks the container into the unit of work so old files are deleted on commit and new files on rollback. [FileMetadataKeys](../api/dotnet/Serenity.Net.Services/Serenity.Web/FileMetadataKeys.md) defines the metadata keys stored alongside files (e.g. `OriginalName`, `EntityId`, `ImageSize`).

## Temporary → Permanent Copy

When a row is saved, `FileUploadBehavior` moves the temporary file to its permanent location. The copy is driven by `UploadStorageExtensions.CopyTemporaryFile`, which takes a [`CopyTemporaryFileOptions`](../api/dotnet/Serenity.Net.Services/Serenity.Web/CopyTemporaryFileOptions.md) (the temporary file, the target `FilenameFormat`, and an `IFilesToDelete` container) and returns a [`CopyTemporaryFileResult`](../api/dotnet/Serenity.Net.Services/Serenity.Web/CopyTemporaryFileResult.md) with the new path, original name, thumbnail flag, and file size. `FileUploadBehavior` also writes file metadata (entity table, type, field, property, and ID) via `SetFileMetadata`.

The [`OverwriteOption`](../api/dotnet/Serenity.Net.Services/Serenity.Web/OverwriteOption.md) controls what happens when a file already exists at the target path:

| Value | Behavior |
| --- | --- |
| `Disallowed` | Raise an error |
| `Overwrite` | Overwrite the target file |
| `AutoRename` | Find a suitable new name for the source file |

## File Read Access

Uploaded files are served through `/upload/{path}`. By default, access to a file is controlled by the **read permission of the entity** that owns it. You can refine this with file read access attributes on the upload field.

> **Note:** The file read access checks described in this section are enforced by `SecureUploadFileResponder`, which is provided by **Serenity.Pro.Extensions** (a premium package). It is available in **StartSharp** but **not in Serene**. The default `DefaultUploadFileResponder` (in the open-source framework) serves files without checking these attributes. In StartSharp, `SecureUploadFileResponder` is registered as the `IUploadFileResponder` via `AddSecureUploadFileResponder()` in `Startup.cs`:
>
> ```cs
> services.AddSecureUploadFileResponder();
> ```

### `[FileReadPermission]`

[FileReadPermissionAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Data/FileReadPermissionAttribute.md) specifies a permission required to read the file for a field:

```cs
[ImageUploadEditor(FilenameFormat = "UserImage/~")]
[FileReadPermission("Administration:Security")]
public string UserImage { get; set; }
```

### `[FileReadAccess]`

[FileReadAccessAttribute](../api/dotnet/Serenity.Net.Core/Serenity.Data/FileReadAccessAttribute.md) is the base attribute with more options:

- `Permission` — the permission to check. Use `"*"` for public access, `"?"` for any logged-in user, or a specific key. If `LogicOperatorPermissionService` is registered, this can also be a logical expression like `A|B&!C`.
- `AllowBypass` — whether users with the bypass permission (see settings below) are allowed to read the file. Default `true`.
- `PermissionOnly` — skip entity-level access control and use only permission-based access.

### `FileReadAccessSettings`

[FileReadAccessSettings](../api/dotnet/Serenity.Net.Core/Serenity.Web/FileReadAccessSettings.md) configures file read access from the `FileReadAccess` section of `appsettings.json`:

```json
{
  "FileReadAccess": {
    "BypassPermission": "Administration:General",
    "DefaultPermission": "*",
    "PathPermissions": "^public/:*;^temporary/:*"
  }
}
```

- `BypassPermission` — a permission that bypasses all file read access checks (e.g. give administrators access to all files).
- `DefaultPermission` — the permission to check when no `[FileReadAccess]` attribute is present (default `"*"`).
- `MissingMetadataPermission` — permission to check when file metadata is missing.
- `PathPermissions` — regex patterns for paths and their permissions, evaluated in order (default allows public access to `public/` and `temporary/`).
- `EnableAccessLogging` — log access control decisions for debugging.
- `ReturnForbidResult` — return a 403 instead of the default 404 when access is denied.

## Serving Uploaded Files

Uploaded files are served through an `IUploadFileResponder`, which reads a file from the upload storage and writes it to the HTTP response.

### IUploadFileResponder

[IUploadFileResponder](../api/dotnet/Serenity.Net.Web/Serenity.Web/IUploadFileResponder.md) is the abstraction for reading a file via the `/upload/{path}` route:

```cs
public interface IUploadFileResponder
{
    IActionResult Read(string pathInfo, IHeaderDictionary responseHeaders);
}
```

It takes the path from the URL and the response headers, and returns an `IActionResult` based on the file's MIME type.

### DefaultUploadFileResponder

[DefaultUploadFileResponder](../api/dotnet/Serenity.Net.Web/Serenity.Web/DefaultUploadFileResponder.md) is the default implementation. Its `Read` method:

1. Checks the path for security (`UploadPathHelper.CheckFileNameSecurity`).
2. Returns `404` if the file doesn't exist in the upload storage.
3. Determines the MIME type via `KnownMimeTypes.Get(path)`.
4. Adds an `X-Content-Type-Options: nosniff` header.
5. For PDFs, plain text, and images, returns the file **inline** (`FileStreamResult` with the detected MIME type).
6. For everything else, returns the file as an **attachment** (`application/octet-stream` with a `Content-Disposition` header), so the browser downloads it instead of rendering it.

### The /upload route

The route is defined by the template's `FilePage` controller, which delegates to the responder:

```cs
public class FilePage(IUploadStorage uploadStorage, IUploadProcessor uploadProcessor) : Controller
{
    [Route("upload/{*pathInfo}")]
    public IActionResult Read(string pathInfo,
        [FromServices] IUploadFileResponder responder)
    {
        return responder.Read(pathInfo, Response.Headers);
    }
}
```

So a stored file with path `product/00001/00000001_abc.jpg` is served at `/upload/product/00001/00000001_abc.jpg`.

### KnownMimeTypes

[KnownMimeTypes](../api/dotnet/Serenity.Net.Web/Serenity.Web/KnownMimeTypes.md) is a static helper for determining the MIME type of a file from its extension:

- `Get(path)` — returns the MIME type, or `application/octet-stream` if unknown.
- `TryGet(path)` — returns the MIME type, or `null` if unknown.

It uses ASP.NET Core's `FileExtensionContentTypeProvider` for the standard mappings, plus a small set of additional known types (e.g. `.apng`, `.avif`). This is what `DefaultUploadFileResponder` uses to decide whether to serve a file inline or as a download.

## See Also

- [Service Behaviors](behaviors.md)
- [Built-in Service Behaviors](built-in-behaviors.md)
- [Save Request Handler](save_request_handler.md)
- [Antivirus Scan](../av.md)
