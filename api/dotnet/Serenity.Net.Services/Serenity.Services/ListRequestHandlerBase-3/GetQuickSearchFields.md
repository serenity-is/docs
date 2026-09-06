# ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;.GetQuickSearchFields method

Gets the list of quick search fields ([`QuickSearchAttribute`](../../Serenity.Data.Mapping/QuickSearchAttribute.md)) based on the containsField argument.

```csharp
protected virtual IEnumerable<Field> GetQuickSearchFields(string containsField)
```

| parameter | description |
| --- | --- |
| containsField | Contains field argument, can be null |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | The containsField has Never or it does not have a [`QuickSearchAttribute`](../../Serenity.Data.Mapping/QuickSearchAttribute.md) |

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [ListRequestHandlerBase&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandlerBase-3.md)