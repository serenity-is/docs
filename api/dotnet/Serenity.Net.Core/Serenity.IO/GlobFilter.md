# GlobFilter class
**namespace:** *[Serenity.IO](../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A fast glob implementation, compatible with the .gitignore patterns of GIT.

```csharp
public class GlobFilter
```

## Public Members

| name | description |
| --- | --- |
| [GlobFilter](GlobFilter/GlobFilter.md)(…) | Creates a new [`GlobFilter`](GlobFilter.md) containing both include and exclude patterns. When *include* is `null` or empty, all files are included by default, unless they match a pattern in the *exclude* list. When *exclude* is `null`, it is ignored. (2 constructors) |
| [IsMatch](GlobFilter/IsMatch.md)(…) | Determines whether the specified path is matching this filter. |

## See Also

* **Source:** *[GlobFilter.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/IO/GlobFilter.cs)*