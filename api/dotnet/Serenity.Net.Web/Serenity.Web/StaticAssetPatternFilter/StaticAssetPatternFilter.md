# StaticAssetPatternFilter constructor

Creates a new instance.

```csharp
public StaticAssetPatternFilter(string? includes, string? excludes, bool wellKnown = false, 
    string? wellKnownExcludes = null, string? folder = null)
```

| parameter | description |
| --- | --- |
| includes | Include patterns separated with ;, all files if empty |
| excludes | Exclude patterns separated with ; |
| wellKnown | True to include files under .well-known even if excludes match them, like the static web assets SDK does (it excludes dot folders but keeps .well-known) |
| wellKnownExcludes | Exclude patterns separated with ; for the .well-known folder |
| folder | Asset folder, relative to the project, that project relative patterns are rooted at, e.g. "wwwroot". Null if the patterns are already relative to the asset folder. |

## See Also

* class [StaticAssetPatternFilter](../StaticAssetPatternFilter.md)