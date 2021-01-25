# EntityQueryExtensions.WhereEqual&lt;T&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds all field values in a row to where clause with equality operator and auto named parameters (field name prefixed with '@').

```csharp
public static T WhereEqual<T>(this T self, IRow row)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
|  | The row with modified field values to be added to the where clause (key row). Must be in TrackAssignments mode, or an exception is raised. |

## Return Value

Object itself.

## See Also

* class [T](../Serenity.Net.Entity/../EntityQueryExtensions.T.md)
* interface [IRow](../IRow.md)
* interface [IFilterableQuery](../Serenity.Net.Data/../IFilterableQuery.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)