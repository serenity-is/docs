# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.ApplyFieldContainsText method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies a field contains criteria to the query by calling [`AddFieldContainsCriteria`](AddFieldContainsCriteria.md)

```csharp
protected virtual void ApplyFieldContainsText(Field field, string containsText, long? id, 
    ref BaseCriteria criteria, ref bool orFalse)
```

| parameter | description |
| --- | --- |
| field | Field |
| containsText | Contains text |
| id | containsText parsed as a long if possible |
| criteria | Current contains criteria build up from other fields if any. The result should be returned via this argument. |
| orFalse | Should return true from this parameter if this contains criteria should cause search to return no records |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [BaseCriteria](../Serenity.Net.Data/../../Serenity.Data/BaseCriteria.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)