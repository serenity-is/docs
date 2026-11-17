# IAsyncValidationRule interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A validation attribute that can also be checked asynchronously, e.g. by a query to the database, which the asynchronous save handlers await instead of calling ValidationContext). It still has to be valid to check synchronously, as the synchronous save handlers and other validators, like the ones of ASP.NET, only do that. [`ValidationRuleAttribute`](./ValidationRuleAttribute.md) implements it, see its `IsValidValueAsync`.

```csharp
public interface IAsyncValidationRule
```

## Members

| name | description |
| --- | --- |
| [IsValidAsync](IAsyncValidationRule/IsValidAsync.md)(…) | Checks a value asynchronously. |

## See Also

* **Source:** *[IAsyncValidationRule.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/IAsyncValidationRule.cs)*