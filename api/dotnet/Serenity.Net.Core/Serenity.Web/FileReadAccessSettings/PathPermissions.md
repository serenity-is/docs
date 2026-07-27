# FileReadAccessSettings.PathPermissions property
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Regular expression patterns for paths and corresponding permissions that are handled before checking file access permissions. Default is "^public/:*;^temporary/:*" for allowing public access to files under "public/" and "temporary/". Separate multiple patterns with semicolon (;). The format is "pattern:permission", where pattern is a regular expression to match the file path, and permission is the permission to check if the pattern matches. Use "*" for public access, "?" for logged-in users, "NEVER" to block access or a specific permission. Patterns are evaluated in order, and the first match is used.

```csharp
public string PathPermissions { get; set; }
```

## See Also

* class [FileReadAccessSettings](../FileReadAccessSettings.md)