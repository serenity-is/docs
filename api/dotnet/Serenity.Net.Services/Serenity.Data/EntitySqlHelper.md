# EntitySqlHelper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extension methods to query entities directly.

```csharp
public static class EntitySqlHelper
```

## Public Members

| name | description |
| --- | --- |
| static [ForEach](EntitySqlHelper/ForEach.md)(…) | Executes the specified callback for all rows returned from executing the query. (2 methods) |
| static [ForEachAsync](EntitySqlHelper/ForEachAsync.md)(…) | Asynchronously executes the specified callback for all rows returned from executing the query. (2 methods) |
| static [GetFirst](EntitySqlHelper/GetFirst.md)(…) | Gets the first entity returned by executing the query. The result is loaded into the loader row of the query. |
| static [GetFirstAsync](EntitySqlHelper/GetFirstAsync.md)(…) | Gets the first entity returned by executing the query asynchronously. The result is loaded into the loader row of the query. |
| static [GetFromReader](EntitySqlHelper/GetFromReader.md)(…) | Gets field values from data reader into the query loader row. (2 methods) |
| static [GetSingle](EntitySqlHelper/GetSingle.md)(…) | Gets the single entity returned by executing the query. The values are loaded into the loader row of the query. |
| static [GetSingleAsync](EntitySqlHelper/GetSingleAsync.md)(…) | Gets the single entity returned by executing the query asynchronously. The values are loaded into the loader row of the query. |
| static [List&lt;TRow&gt;](EntitySqlHelper/List.md)(…) | Lists the rows returned from executing the query. |
| static [ListAsync&lt;TRow&gt;](EntitySqlHelper/ListAsync.md)(…) | Asynchronously lists the rows returned from executing the query. |

## See Also

* **Source:** *[EntitySqlHelper.cs](https://github.com/serenity-is/Serenity/blob/41745e6f6cee341e0662ee7a59c54637f6b1e8de/src/services/Entity/Extensions/EntitySqlHelper.cs)*