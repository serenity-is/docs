# IDeleteBehavior.OnPrepareQuery method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Called when query to load old entity is built

```csharp
public void OnPrepareQuery(IDeleteRequestHandler handler, SqlQuery query)
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| query | The query |

## See Also

* interface [IDeleteRequestHandler](../IDeleteRequestHandler.md)
* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* interface [IDeleteBehavior](../IDeleteBehavior.md)