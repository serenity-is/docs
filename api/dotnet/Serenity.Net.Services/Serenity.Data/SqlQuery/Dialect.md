# SqlQuery.Dialect method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Sets the dialect (SQL server type / version) for query.

```csharp
public SqlQuery Dialect(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | The dialect to use. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect is null. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlQuery](../SqlQuery.md)