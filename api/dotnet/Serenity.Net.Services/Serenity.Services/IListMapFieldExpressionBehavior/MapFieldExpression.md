# IListMapFieldExpressionBehavior.MapFieldExpression method

Maps field's expression to a custom one. Returns null if not mapped to a custom expression.

```csharp
public string MapFieldExpression(IListRequestHandler handler, SqlQuery query, IField field)
```

| parameter | description |
| --- | --- |
| handler | List handler |
| query | Query |
| field | Field |

## See Also

* interface [IListRequestHandler](../IListRequestHandler.md)
* class [SqlQuery](../../Serenity.Data/SqlQuery.md)
* interface [IField](../../Serenity.Data/IField.md)
* interface [IListMapFieldExpressionBehavior](../IListMapFieldExpressionBehavior.md)