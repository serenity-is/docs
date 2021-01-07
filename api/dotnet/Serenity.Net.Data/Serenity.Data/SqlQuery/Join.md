# SqlQuery.Join method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Joins the specified join.

```csharp
public SqlQuery Join(Join join)
```

| parameter | description |
| --- | --- |
| join | The join. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | join |
| InvalidOperationException | Another join with different expression is already in the query. |

## See Also

* class [Join](../Join.md)
* class [SqlQuery](../SqlQuery.md)