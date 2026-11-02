# FilteredFileProvider class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A file provider that only exposes the files of another file provider that a filter accepts, e.g. by the include / exclude patterns of [`StaticAssetPatternFilter`](./StaticAssetPatternFilter.md). Directories are always exposed, their contents are filtered.

```csharp
public sealed class FilteredFileProvider : IFileProvider
```

| parameter | description |
| --- | --- |
| inner | Inner file provider |
| isMatch | Filter that receives a path relative to the provider root, like "css/site.css" |

## Public Members

| name | description |
| --- | --- |
| [FilteredFileProvider](FilteredFileProvider/FilteredFileProvider.md)(…) | A file provider that only exposes the files of another file provider that a filter accepts, e.g. by the include / exclude patterns of [`StaticAssetPatternFilter`](./StaticAssetPatternFilter.md). Directories are always exposed, their contents are filtered. |
| [GetDirectoryContents](FilteredFileProvider/GetDirectoryContents.md)(…) |  |
| [GetFileInfo](FilteredFileProvider/GetFileInfo.md)(…) |  |
| [Watch](FilteredFileProvider/Watch.md)(…) |  |

## See Also

* **Source:** *[FilteredFileProvider.cs](https://github.com/serenity-is/Serenity/blob/e47a2cd5941a7d46d224a3a91cacc6f4c372a0ed/src/web/Mvc/StaticAssets/FilteredFileProvider.cs)*