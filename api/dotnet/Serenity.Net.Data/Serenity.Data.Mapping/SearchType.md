# SearchType enumeration
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Quick search type enumeration

```csharp
public enum SearchType
```

## Values

| name | value | description |
| --- | --- | --- |
| Auto | `0` | Automatic mode. Equals for integer types, Contains for other. |
| Equals | `1` | Search with equality |
| Contains | `2` | Search with contains |
| StartsWith | `3` | Search with STARTS WITH |
| FullTextContains | `4` | Use full text CONTAINS |

## See Also

* **Source:** *[SearchType.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/SearchType.cs)*