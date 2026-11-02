# StaticAssetPatternFilter class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Decides which files of a static asset folder (e.g. a project's wwwroot) are served, using the same include / exclude patterns that are used to select the files to publish / pack, so that a file that would not be published is not served while running from the build output either. Patterns are relative to the asset folder (e.g. **/*.tmp), as in the manifest. When a folder is passed, patterns are MSBuild style and relative to the project folder instead (e.g. wwwroot\**, wwwroot\**\*.tmp, **\node_modules\**), and converted to be relative to the asset folder: patterns that start with the folder (wwwroot\) lose that prefix, patterns that start with **\ are kept, others can't match files under the folder and are ignored.

```csharp
public sealed class StaticAssetPatternFilter
```

## Public Members

| name | description |
| --- | --- |
| [StaticAssetPatternFilter](StaticAssetPatternFilter/StaticAssetPatternFilter.md)(…) | Creates a new instance. |
| [IsMatch](StaticAssetPatternFilter/IsMatch.md)(…) | Gets if the file should be served. |

## See Also

* **Source:** *[StaticAssetPatternFilter.cs](https://github.com/serenity-is/Serenity/blob/4454657c2d936efdadbb406a7a7e589bd4371521/src/web/Mvc/StaticAssets/StaticAssetPatternFilter.cs)*