# IUndeleteBehaviorSync.OnPrepareQuery method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when query to load old entity is built

```csharp
public void OnPrepareQuery(IUndeleteRequestHandler handler, SqlQuery query)
```

| parameter | description |
| --- | --- |
| handler | Calling undelete request handler |
| query | The query |

## See Also

* interface [IUndeleteRequestHandler](../IUndeleteRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IUndeleteBehaviorSync](../IUndeleteBehaviorSync.md)