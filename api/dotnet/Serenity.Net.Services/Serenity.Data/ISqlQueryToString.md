# ISqlQueryToString interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for types that can convert an [`ISqlQuery`](./ISqlQuery.md) to its string representation.

```csharp
public interface ISqlQueryToString
```

## Members

| name | description |
| --- | --- |
| [ToString](ISqlQueryToString/ToString.md)(…) | Converts the query to string. |

## Remarks

Implementations are responsible for validating that the query is renderable, including rejecting queries without selected columns when their SQL format requires them.

## See Also

* **Source:** *[ISqlQueryToString.cs](https://github.com/serenity-is/Serenity/blob/f40ba07f1d350319f6406dd649f20896e314937d/src/services/Data/QueryModel/ISqlQueryToString.cs)*