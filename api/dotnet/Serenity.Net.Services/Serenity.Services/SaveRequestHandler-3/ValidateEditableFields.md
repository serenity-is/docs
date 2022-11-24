# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateEditableFields method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates editable fields, e.g. checks if the assigned fields are all in the editable set. Calls [`HandleNonEditable`](HandleNonEditable.md) if not.

```csharp
protected virtual void ValidateEditableFields(HashSet<Field> editable)
```

| parameter | description |
| --- | --- |
| editable | Set of editable fields |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)