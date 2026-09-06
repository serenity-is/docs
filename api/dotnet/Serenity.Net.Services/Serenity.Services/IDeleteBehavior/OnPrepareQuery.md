# IDeleteBehavior.OnPrepareQuery method

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
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IDeleteBehavior](../IDeleteBehavior.md)