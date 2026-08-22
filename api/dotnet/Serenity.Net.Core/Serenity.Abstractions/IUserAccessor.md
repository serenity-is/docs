# IUserAccessor interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides access to the current authenticated user.

```csharp
public interface IUserAccessor
```

## Members

| name | description |
| --- | --- |
| [User](IUserAccessor/User.md) { get; } | Gets the current user principal, or `null` if no user is authenticated. |

## See Also

* **Source:** *[IUserAccessor.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Authorization/IUserAccessor.cs)*