# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.MapFieldExpression method

Maps a field using IListFieldMappingBehavior's if any

```csharp
protected abstract string MapFieldExpression(IField field, SqlQuery query)
```

| parameter | description |
| --- | --- |
| field | Field |
| query | Query |

## Return Value

Field itself or mapped field

## See Also

* interface [IField](../../Serenity.Data/IField.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)