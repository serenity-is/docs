# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.GetDistinctFields method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets an array of distinct fields by checking Request.DistinctFields. It might be different than the passed list, if the list contains an invalid field or a field that is not allowed to be selected, like NotMapped and Never etc.

```csharp
public Field[] GetDistinctFields()
```

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)