# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.AllowFilterField method

Returns true if the field can be used in a filter, based on its flags, minimum select level, read permission, and lookup access mode.

```csharp
protected virtual bool AllowFilterField(Field field)
```

| parameter | description |
| --- | --- |
| field | The field |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)