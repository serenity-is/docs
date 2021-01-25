# EntitySqlHelper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Contains extension methods to query entities directly

```csharp
public static class EntitySqlHelper
```

## Public Members

| name | description |
| --- | --- |
| static [ForEach](EntitySqlHelper/ForEach.md)(…) | Executes the specified callback for all rows returned from executing the query. (2 methods) |
| static [ForFirst](EntitySqlHelper/ForFirst.md)(…) | Executes the specified callback for the first result returned from executing the query. (2 methods) |
| static [GetFirst](EntitySqlHelper/GetFirst.md)(…) | Gets the first entity returned by executing the query. The result is loaded into the loader row of the query. (2 methods) |
| static [GetFromReader](EntitySqlHelper/GetFromReader.md)(…) | Gets field values from data reader into the query loader row. (2 methods) |
| static [GetSingle](EntitySqlHelper/GetSingle.md)(…) | Gets the single entity returned by executing the query. The values are loaded into the loader row of the query. (2 methods) |
| static [List&lt;TRow&gt;](EntitySqlHelper/List.md)(…) | Lists the rows returned from executing the query. |

## See Also

* **Source:** *[EntitySqlHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntitySqlHelper.cs)*