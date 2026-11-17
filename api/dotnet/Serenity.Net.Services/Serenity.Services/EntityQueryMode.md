# EntityQueryMode enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies how an entity is read when it is used as a source of another query, e.g. by an entity query of a data source, see [`EntityQueryAttribute`](./EntityQueryAttribute.md). Each mode decides which filters of the application apply, e.g. those limiting the rows to a tenant or the user's own records.

```csharp
public enum EntityQueryMode
```

## Values

| name | value | description |
| --- | --- | --- |
| ListHandler | `0` | The entity is read through the query its list handler builds, with the handler's and its behaviors' filters, see [`IListQueryCapture`](./IListQueryCapture.md). This is the default, while a consumer may still refuse a handler that does something after its query is executed, e.g. drops rows in ProcessEntity or OnReturn, unless the entity specifies this mode explicitly, which confirms that all its filtering is done in the query. |
| Behaviors | `1` | The entity is read through the query of a generic list handler with the entity's list behaviors, ignoring its custom list handler, e.g. when that one is only meant for a page, while the behaviors do all the filtering. |
| Unfiltered | `2` | The entity is read from its table and joins, with the permissions declared on it and its fields, but without any filter of its list handler or behaviors. Consumers should not allow it for entities whose rows must be filtered, e.g. multi tenant ones. |
| Disabled | `3` | The entity can't be used as a source of another query. |

## See Also

* **Source:** *[EntityQueryMode.cs](https://github.com/serenity-is/Serenity/blob/c9de1423e8c163e87ed25856ef3b74517aea2c6c/src/services/RequestHandlers/List/EntityQueryMode.cs)*