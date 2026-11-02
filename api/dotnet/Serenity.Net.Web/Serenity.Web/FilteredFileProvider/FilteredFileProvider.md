# FilteredFileProvider constructor

A file provider that only exposes the files of another file provider that a filter accepts, e.g. by the include / exclude patterns of [`StaticAssetPatternFilter`](../StaticAssetPatternFilter.md). Directories are always exposed, their contents are filtered.

```csharp
public FilteredFileProvider(IFileProvider inner, Func<string, bool> isMatch)
```

| parameter | description |
| --- | --- |
| inner | Inner file provider |
| isMatch | Filter that receives a path relative to the provider root, like "css/site.css" |

## See Also

* class [FilteredFileProvider](../FilteredFileProvider.md)