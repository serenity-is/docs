# DialectExpressionSelector class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Selects field expressions based on dialect

```csharp
public class DialectExpressionSelector
```

| parameter | description |
| --- | --- |
| dialect | The dialect. |

## Public Members

| name | description |
| --- | --- |
| [DialectExpressionSelector](DialectExpressionSelector/DialectExpressionSelector.md)(…) | Selects field expressions based on dialect |
| [Dialect](DialectExpressionSelector/Dialect.md) { get; } | Gets the dialect used for this expression selector |
| [GetBestMatch&lt;TAttribute&gt;](DialectExpressionSelector/GetBestMatch.md)(…) | Gets the best match. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | dialect |

## Remarks

Initializes a new instance of the [`DialectExpressionSelector`](DialectExpressionSelector.md) class.

## See Also

* **Source:** *[DialectExpressionSelector.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Row/DialectExpressionSelector.cs)*