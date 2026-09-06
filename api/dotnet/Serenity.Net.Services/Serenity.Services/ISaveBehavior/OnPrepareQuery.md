# ISaveBehavior.OnPrepareQuery method

Called when query to load old entity is built

```csharp
public void OnPrepareQuery(ISaveRequestHandler handler, SqlQuery query)
```

| parameter | description |
| --- | --- |
| handler | Calling save request handler |
| query | Query |

## See Also

* interface [ISaveRequestHandler](../ISaveRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [ISaveBehavior](../ISaveBehavior.md)