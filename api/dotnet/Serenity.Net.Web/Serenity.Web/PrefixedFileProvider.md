# PrefixedFileProvider class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A file provider that exposes the contents of another file provider under a path prefix, e.g. files of a package's wwwroot under "/Serenity.Corelib".

```csharp
public sealed class PrefixedFileProvider : IFileProvider
```

| parameter | description |
| --- | --- |
| prefix | Path prefix, like "Serenity.Corelib" or "/Serenity.Corelib" |
| inner | Provider for the files under the prefix |

## Public Members

| name | description |
| --- | --- |
| [PrefixedFileProvider](PrefixedFileProvider/PrefixedFileProvider.md)(…) | A file provider that exposes the contents of another file provider under a path prefix, e.g. files of a package's wwwroot under "/Serenity.Corelib". |
| [Inner](PrefixedFileProvider/Inner.md) { get; } | Gets the inner file provider. |
| [Prefix](PrefixedFileProvider/Prefix.md) { get; } | Gets the path prefix, with a leading slash and no trailing slash. |
| [GetDirectoryContents](PrefixedFileProvider/GetDirectoryContents.md)(…) |  |
| [GetFileInfo](PrefixedFileProvider/GetFileInfo.md)(…) |  |
| [Watch](PrefixedFileProvider/Watch.md)(…) |  |

## See Also

* **Source:** *[PrefixedFileProvider.cs](https://github.com/serenity-is/Serenity/blob/ae08987262bfd3bd08860207c9039a51f9f54a17/src/web/Mvc/StaticAssets/PrefixedFileProvider.cs)*