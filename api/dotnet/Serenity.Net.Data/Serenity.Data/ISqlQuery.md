# ISqlQuery interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

SqlQuery interface.

```csharp
public interface ISqlQuery : IChainable, IQueryWithParams
```

## Members

| name | description |
| --- | --- |
| [Columns](ISqlQuery/Columns.md) { get; } | Gets the columns. |
| [CountRecords](ISqlQuery/CountRecords.md) { get; } | Gets if to count records |
| [Distinct](ISqlQuery/Distinct.md) { get; } | Gets if distinct query |
| [ForJson](ISqlQuery/ForJson.md) { get; } | Gets FOR JSON part if any |
| [ForXml](ISqlQuery/ForXml.md) { get; } | Gets FOR XML part if any |
| [From](ISqlQuery/From.md) { get; } | Gets access to FROM part if any |
| [GroupBy](ISqlQuery/GroupBy.md) { get; } | Gets access to GROUP BY part if any |
| [Having](ISqlQuery/Having.md) { get; } | Gets access to HAVING part if any |
| [OmitParens](ISqlQuery/OmitParens.md) { get; } | Where to omit params while converting to string |
| [OrderBy](ISqlQuery/OrderBy.md) { get; } | Gets order by list |
| [Parent](ISqlQuery/Parent.md) { get; } | Gets access to parent query if any |
| [Skip](ISqlQuery/Skip.md) { get; } | Gets skip number |
| [Take](ISqlQuery/Take.md) { get; } | Gets take number |
| [UnionQuery](ISqlQuery/UnionQuery.md) { get; } | Gets access to internal union query if any |
| [UnionType](ISqlQuery/UnionType.md) { get; } | Gets access to internal union type if any |
| [Where](ISqlQuery/Where.md) { get; } | Gets access to WHERE part if any |

## See Also

* interface [IQueryWithParams](IQueryWithParams.md)
* interface [IChainable](../Serenity/IChainable.md)
* **Source:** *[ISqlQuery.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/QueryModel/ISqlQuery.cs)*