# GlobFilter class
**namespace:** *[Serenity.IO](../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A fast glob implementation, compatible with .gitignore patterns of GIT

```csharp
public class GlobFilter
```

## Public Members

| name | description |
| --- | --- |
| [GlobFilter](GlobFilter/GlobFilter.md)(…) | Creates a new GlobFilter, containing both include and exclude patterns. When "include" is null / empty, all files are included by default, unless they match a pattern in "exclude" list. When "exclude" is null, it is ignored. (2 constructors) |
| [IsMatch](GlobFilter/IsMatch.md)(…) | Determines whether the specified path is matching this filter. |
| static [NormalizeGlob](GlobFilter/NormalizeGlob.md)(…) | Normalizes the glob by replacing back slashes etc. |
| static [WildcardToRegex](GlobFilter/WildcardToRegex.md)(…) | Wildcards to regex conversion. Inspired from NuGet source code. |

## See Also

* **Source:** *[GlobFilter.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/IO/GlobFilter.cs)*