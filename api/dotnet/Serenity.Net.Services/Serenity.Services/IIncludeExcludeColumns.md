# IIncludeExcludeColumns interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for service objects containing include / exclude column sets. See [`ListRequest`](ListRequest.md) and [`RetrieveRequest`](RetrieveRequest.md).

```csharp
public interface IIncludeExcludeColumns
```

## Members

| name | description |
| --- | --- |
| [ExcludeColumns](IIncludeExcludeColumns/ExcludeColumns.md) { get; set; } | Set of exclude columns. These columns should not be selected even if they are selected by default by the select level. |
| [IncludeColumns](IIncludeExcludeColumns/IncludeColumns.md) { get; set; } | Set of include columns. These columns are supposed to be additionally selected. |

## See Also

* **Source:** *[IIncludeExcludeColumns.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/IIncludeExcludeColumns.cs)*