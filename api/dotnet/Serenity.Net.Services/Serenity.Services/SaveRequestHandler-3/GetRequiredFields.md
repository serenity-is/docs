# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetRequiredFields method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the list of required fields based on editable list, and NotNull

```csharp
protected virtual void GetRequiredFields(HashSet<Field> required, HashSet<Field> editable)
```

| parameter | description |
| --- | --- |
| required | List of required fields to populate |
| editable | Editable fields returned from [`GetEditableFields`](GetEditableFields.md) |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)