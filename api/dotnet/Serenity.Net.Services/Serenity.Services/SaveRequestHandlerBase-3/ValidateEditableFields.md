# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateEditableFields method

Validates editable fields, e.g. checks if the assigned fields are all in the editable set. Calls [`HandleNonEditable`](./HandleNonEditable.md) if not.

```csharp
protected virtual void ValidateEditableFields(HashSet<Field> editable)
```

| parameter | description |
| --- | --- |
| editable | Set of editable fields |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)