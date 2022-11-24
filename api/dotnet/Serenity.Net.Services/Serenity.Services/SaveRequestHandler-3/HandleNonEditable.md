# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.HandleNonEditable method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Handles assignment to a non-editable field. If the field did not change in an update operation, it will be ignored by clearing the assignment. For non-table fields it will also be ignored.

```csharp
protected virtual void HandleNonEditable(Field field)
```

| parameter | description |
| --- | --- |
| field |  |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)