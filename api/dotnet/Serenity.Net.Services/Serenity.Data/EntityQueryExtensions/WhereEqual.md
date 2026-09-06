# EntityQueryExtensions.WhereEqual&lt;T&gt; method

Adds all field values in a row to the where clause with equality operator and auto named parameters (field name prefixed with '@').

```csharp
public static T WhereEqual<T>(this T self, IRow row)
    where T : IFilterableQuery
```

| parameter | description |
| --- | --- |
| self | The query to add the where clause to. |
| row | The row with modified field values to be added to the where clause (key row). Must be in TrackAssignments mode, or an exception is raised. |

## Return Value

The object itself.

## See Also

* interface [IRow](../IRow.md)
* interface [IFilterableQuery](../IFilterableQuery.md)
* class [EntityQueryExtensions](../EntityQueryExtensions.md)