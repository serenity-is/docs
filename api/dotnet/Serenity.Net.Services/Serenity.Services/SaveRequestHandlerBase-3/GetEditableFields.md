# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetEditableFields method

Gets the list of editable fields. These are fields that have Insertable (if Create), or Updatable (if Update) flags, and have the insert or update permission based on the type of the current operation.

```csharp
protected virtual void GetEditableFields(HashSet<Field> editable)
```

| parameter | description |
| --- | --- |
| editable |  |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)