# EntityQueryExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Extensions for objects implementing IDbWhere interface.

```csharp
public static class EntityQueryExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [SelectForeignFields](EntityQueryExtensions/SelectForeignFields.md)(…) | Adds foreign / calculated table fields in a row to select list of a query. |
| static [SelectNonTableFields](EntityQueryExtensions/SelectNonTableFields.md)(…) | Adds foreign / calculated table fields in a row to select list of a query. |
| static [SelectTableFields](EntityQueryExtensions/SelectTableFields.md)(…) | Adds actual table fields in a row to select list of a query. (2 methods) |
| static [Set&lt;T&gt;](EntityQueryExtensions/Set.md)(…) | Sets all field values in a row with auto named parameters (field name prefixed with '@'). (2 methods) |
| static [WhereEqual&lt;T&gt;](EntityQueryExtensions/WhereEqual.md)(…) | Adds all field values in a row to where clause with equality operator and auto named parameters (field name prefixed with '@'). |

## See Also

* **Source:** *[EntityQueryExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntityQueryExtensions.cs)*