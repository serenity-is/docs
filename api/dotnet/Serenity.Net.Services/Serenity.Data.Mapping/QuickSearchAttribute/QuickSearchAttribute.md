# QuickSearchAttribute constructor
**namespace:** *[Serenity.Data.Mapping](../../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Marks the property so that it should be included in quick text searches.

```csharp
public QuickSearchAttribute(SearchType searchType = SearchType.Auto, int numericOnly = -1, 
    bool isExplicit = false)
```

| parameter | description |
| --- | --- |
| searchType | Type of the search. |
| numericOnly | The numeric only. |
| isExplicit | if set to `true` [is explicit]. |

## Remarks

Initializes a new instance of the [`QuickSearchAttribute`](../QuickSearchAttribute.md) class.

## See Also

* enum [SearchType](../SearchType.md)
* class [QuickSearchAttribute](../QuickSearchAttribute.md)