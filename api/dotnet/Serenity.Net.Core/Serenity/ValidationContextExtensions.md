# ValidationContextExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Gets what a validation rule may need from the context it is checked in, e.g. the localizer of its message, which the save handlers and the other places that check the rules give as the services of the context.

```csharp
public static class ValidationContextExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetConnection](ValidationContextExtensions/GetConnection.md)(…) | Gets the connection the value is saved with, e.g. in the transaction of a save handler, or null when the context has none. |
| static [GetLocalizer](ValidationContextExtensions/GetLocalizer.md)(…) | Gets the localizer of the messages, or null when the context has none. |
| static [GetPropertyValue](ValidationContextExtensions/GetPropertyValue.md)(…) | Gets the value of another property of the object being validated, e.g. a row, for a rule on more than one field. |

## See Also

* **Source:** *[ValidationContextExtensions.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/core/ComponentModel/Validation/ValidationContextExtensions.cs)*