# IHasPassword interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates whether a user account has a password set.

```csharp
public interface IHasPassword
```

## Members

| name | description |
| --- | --- |
| [HasPassword](IHasPassword/HasPassword.md) { get; } | Gets a value indicating whether the user has a password. |

## Remarks

When a user definition does not implement this interface, the system assumes that the user has a password.

## See Also

* **Source:** *[IHasPassword.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/IHasPassword.cs)*