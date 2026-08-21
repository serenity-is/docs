# RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;.AllowSelectField method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Returns true if the field should be allowed to be selected, based on its read permission and the SelectLevel.Never flag.

```csharp
protected virtual bool AllowSelectField(Field field)
```

| parameter | description |
| --- | --- |
| field | The field. |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](../RetrieveRequestHandler-3.md)