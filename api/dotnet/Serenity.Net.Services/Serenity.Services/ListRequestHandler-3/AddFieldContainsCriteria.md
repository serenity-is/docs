# ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;.AddFieldContainsCriteria method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Applies a contains criteria based on containsText, id (if the contains text can be parsed to an integer ID), searchType and numericOnly parameters.

```csharp
protected virtual void AddFieldContainsCriteria(Field field, string containsText, long? id, 
    SearchType searchType, bool numericOnly, ref BaseCriteria criteria, ref bool orFalse)
```

| parameter | description |
| --- | --- |
| field | Search field |
| containsText | Contains text |
| id | The containsText argument parsed to a long if possible |
| searchType | Search type |
| numericOnly | True if numeric, e.g. equality to the id is requested |
| criteria | Current contains criteria build up from other fields if any. The result should be returned via this argument. |
| orFalse | Should return true from this parameter if this contains criteria should cause search to return no records |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException |  |

## See Also

* class [Field](../Serenity.Net.Entity/../../Serenity.Data/Field.md)
* enum [SearchType](../Serenity.Net.Data/../../Serenity.Data.Mapping/SearchType.md)
* class [BaseCriteria](../Serenity.Net.Data/../../Serenity.Data/BaseCriteria.md)
* class [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](../ListRequestHandler-3.md)