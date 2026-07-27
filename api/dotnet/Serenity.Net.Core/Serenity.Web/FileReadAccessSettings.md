# FileReadAccessSettings class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Settings for file read access control

```csharp
public class FileReadAccessSettings : IOptions<FileReadAccessSettings>
```

## Public Members

| name | description |
| --- | --- |
| [FileReadAccessSettings](FileReadAccessSettings/FileReadAccessSettings.md)() | The default constructor. |
| [BypassPermission](FileReadAccessSettings/BypassPermission.md) { get; set; } | Permission that bypasses all file read access checks. You may set this to a special permission like "Administration:General" to allow administrators to read all files. |
| [DefaultPermission](FileReadAccessSettings/DefaultPermission.md) { get; set; } | Permission to check when no FileReadAccess attribute is present, or its PermissionOnly is true but no permission is specified. Default is "*" for compat, e.g. allow access to anyone that have access to the entity. |
| [EnableAccessLogging](FileReadAccessSettings/EnableAccessLogging.md) { get; set; } | Whether to log access control decisions for debugging |
| [MissingMetadataPermission](FileReadAccessSettings/MissingMetadataPermission.md) { get; set; } | Permission to check when file metadata is missing or cannot be read. Default is null, e.g. DefaultPermission is used. |
| [PathPermissions](FileReadAccessSettings/PathPermissions.md) { get; set; } | Regular expression patterns for paths and corresponding permissions that are handled before checking file access permissions. Default is "^public/:*;^temporary/:*" for allowing public access to files under "public/" and "temporary/". Separate multiple patterns with semicolon (;). The format is "pattern:permission", where pattern is a regular expression to match the file path, and permission is the permission to check if the pattern matches. Use "*" for public access, "?" for logged-in users, "NEVER" to block access or a specific permission. Patterns are evaluated in order, and the first match is used. |
| [ReturnForbidResult](FileReadAccessSettings/ReturnForbidResult.md) { get; set; } | Whether to return "forbidden" (403) result instead of the default "not found" (404). |
| [Value](FileReadAccessSettings/Value.md) { get; } |  |
| const [SectionKey](FileReadAccessSettings/SectionKey.md) | The default section key in appsettings.json |

## See Also

* **Source:** *[FileReadAccessSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/FileAccess/FileReadAccessSettings.cs)*