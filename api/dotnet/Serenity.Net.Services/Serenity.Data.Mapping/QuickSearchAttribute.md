# QuickSearchAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marks the property so that it should be included in quick text searches.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class QuickSearchAttribute : Attribute
```

| parameter | description |
| --- | --- |
| searchType | Type of the search. |
| numericOnly | The numeric only. |
| isExplicit | if set to `true` [is explicit]. |

## Public Members

| name | description |
| --- | --- |
| [QuickSearchAttribute](QuickSearchAttribute/QuickSearchAttribute.md)(…) | Marks the property so that it should be included in quick text searches. |
| [IsExplicit](QuickSearchAttribute/IsExplicit.md) { get; } | Gets a value indicating whether this instance is explicit. |
| [NumericOnly](QuickSearchAttribute/NumericOnly.md) { get; } | Gets the numeric only. |
| [SearchType](QuickSearchAttribute/SearchType.md) { get; } | Gets the type of the search. |

## Remarks

Initializes a new instance of the [`QuickSearchAttribute`](QuickSearchAttribute.md) class.

## See Also

* **Source:** *[QuickSearchAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/QuickSearchAttribute.cs)*