# INormalizedEmailRow interface
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Implemented by user rows that store the value calculated by [`NormalizeEmail`](./BaseUserRetrieveService/NormalizeEmail.md) in a separate field. Users are looked up by that field when they request a password reset, instead of comparing the email by the collation of its column.

```csharp
public interface INormalizedEmailRow
```

## Members

| name | description |
| --- | --- |
| [NormalizedEmailField](INormalizedEmailRow/NormalizedEmailField.md) { get; } | Gets the normalized email field. |

## Remarks

The normalized field must be updated whenever the email changes, otherwise the user can't be found by the new email.

## See Also

* **Source:** *[INormalizedEmailRow.cs](https://github.com/serenity-is/Serenity/blob/c23ad0526a306b9ddfab6f55b122c219de50f57f/common-features/src/extensions/Modules/Authorization/INormalizedEmailRow.cs)*