# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.SelectFields method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Calls query.Select(field) for all the fields without NotMapped, and if [`AllowSelectField`](AllowSelectField.md) and [`ShouldSelectField`](ShouldSelectField.md) returns true.

```csharp
protected virtual void SelectFields(SqlQuery query)
```

| parameter | description |
| --- | --- |
| query | Query |

## See Also

* class [SqlQuery](../Serenity.Net.Data/../../Serenity.Data/SqlQuery.md)
* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandler-3.md)