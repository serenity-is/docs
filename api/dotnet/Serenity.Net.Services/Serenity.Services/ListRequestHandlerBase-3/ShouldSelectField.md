# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.ShouldSelectField method

Returns true if the field should be selected, based on current ColumnSelection, field [`MinSelectLevelAttribute`](../../Serenity.Data.Mapping/MinSelectLevelAttribute.md), the field being a not mapped ([`NotMappedAttribute`](../../Serenity.Data.Mapping/NotMappedAttribute.md)) field, table field, or a view / expression field.

```csharp
protected virtual bool ShouldSelectField(Field field)
```

| parameter | description |
| --- | --- |
| field | The field |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)