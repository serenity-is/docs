# File System

Serenity provides a small file system abstraction so that file and directory operations can be mocked or replaced in tests, and so that code doesn't depend directly on `System.IO`.

## `IFileSystem`

[IFileSystem](../api/dotnet/Serenity.Net.Core/Serenity/IFileSystem.md) is the base abstraction. It covers the common file and directory operations you'd expect:

- `CreateFile` / `CreateDirectory`
- `DeleteFile` / `DeleteDirectory`
- `FileExists` / `DirectoryExists`
- `GetFiles` / `GetDirectories` (with search pattern and recursive options)
- `GetFileSize`
- `ReadAllText` / `ReadAllBytes` / `WriteAllText` / `WriteAllBytes`
- `OpenRead`
- `GetFullPath` / `GetRelativePath` / `GetLastWriteTimeUtc`

Because it's an interface, you can replace it with a mock or an in-memory implementation in tests.

## `PhysicalFileSystem`

[PhysicalFileSystem](../api/dotnet/Serenity.Net.Core/Serenity/PhysicalFileSystem.md) is the default implementation that operates on the physical disk, delegating to `System.IO`.

`IFileSystem` is **not registered in the DI container by default**. You typically construct it directly or accept it as an optional constructor parameter:

```cs
public class SomeService(IFileSystem fileSystem = null)
{
    private readonly IFileSystem fileSystem = fileSystem ?? new PhysicalFileSystem();
}
```

This lets callers pass a mock file system in tests while defaulting to the physical disk.

## `FileSystemExtensions`

[FileSystemExtensions](../api/dotnet/Serenity.Net.Core/Serenity/FileSystemExtensions.md) provides extension methods on `IFileSystem` that delegate to `System.IO.Path` helpers (e.g. `Combine`, `GetFileName`, `GetExtension`, `ChangeExtension`, `GetDirectoryName`, `IsPathRooted`). This reduces direct dependency on `System.IO` in case those methods are later added to `IFileSystem`.

## Temporary Files

Serenity has a dedicated abstraction and helpers for temporary files and folders.

### `ITemporaryFileSystem`

[ITemporaryFileSystem](../api/dotnet/Serenity.Net.Core/Serenity/ITemporaryFileSystem.md) extends `IFileSystem` with `GetTemporaryFileInfos(path)`, which returns [TemporaryFileInfo](../api/dotnet/Serenity.Net.Core/Serenity/TemporaryFileInfo.md) objects (file name, full name, and creation time) for the files in a directory.

### `TemporaryFileHelper`

[TemporaryFileHelper](../api/dotnet/Serenity.Net.Core/Serenity.IO/TemporaryFileHelper.md) is a static helper for cleaning up temporary folders. It's used by the upload system to purge old temporary uploads.

Key members:

- `DefaultTemporaryCheckFile` (`.temporary`) — a signature file that marks a folder as a temporary folder, so it can be safely cleaned.
- `DefaultAutoExpireTime` (1 day) — files older than this are cleared.
- `DefaultMaxFilesInDirectory` (1000) — if more than this many files exist, the oldest are deleted.
- `PurgeDirectoryDefault(directory)` — clears a folder using the default conditions.
- `PurgeDirectory(directory, autoExpireTime, maxFilesInDirectory, checkFileName)` — clears a folder with custom conditions.
- `Delete` / `TryDelete` / `TryDeleteOrMark` — delete a file, optionally ignoring errors or marking it for later deletion.
- `RandomFileCode()` — generates a random file code (used for temporary file names).

The cleanup is safe: it only operates on folders that contain the `.temporary` signature file, and it ignores individual deletion errors.

### `DeleteType`

[DeleteType](../api/dotnet/Serenity.Net.Core/Serenity.IO/DeleteType.md) specifies how a file should be deleted:

| Value | Behavior |
| --- | --- |
| `Delete` | Force delete the file |
| `TryDelete` | Try to delete, ignoring any errors |
| `TryDeleteOrMark` | Try to delete, or mark it for deletion if it can't be deleted |

## `GlobFilter`

[GlobFilter](../api/dotnet/Serenity.Net.Core/Serenity.IO/GlobFilter.md) is a fast glob matcher compatible with `.gitignore` patterns. It supports include and exclude pattern lists:

```cs
var filter = new GlobFilter(
    include: ["*.txt", "*.md"],
    exclude: ["**/obj/**", "**/bin/**"]);

if (filter.IsMatch("some/file.txt"))
    // ...
```

It's used internally for things like filtering files in a directory tree.

## See Also

- [Uploads](../services/upload.md) — uses `IFileSystem` and `TemporaryFileHelper` for upload storage and temp cleanup
- [Dependency Injection](dependency-injection.md) — `IServiceResolver` and service resolution