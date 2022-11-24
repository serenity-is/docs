# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetEditableFields method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets the list of editable fields. These are fields that have Insertable (if Create), or Updatable (if Update) flags, and have the insert or update permission based on the type of the current operation.

```csharp
protected virtual void GetEditableFields(HashSet<Field> editable)
```

| parameter | description |
| --- | --- |
| editable |  |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)