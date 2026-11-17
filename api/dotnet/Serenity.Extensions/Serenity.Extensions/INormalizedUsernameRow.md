# INormalizedUsernameRow interface
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Implemented by user rows that store the value calculated by [`NormalizeUsername`](./BaseUserRetrieveService/NormalizeUsername.md) in a separate field. [`BaseUserRetrieveService`](./BaseUserRetrieveService-1.md) looks these users up by that field, instead of comparing the username by the collation of its column.

```csharp
public interface INormalizedUsernameRow
```

## Members

| name | description |
| --- | --- |
| [NormalizedUsernameField](INormalizedUsernameRow/NormalizedUsernameField.md) { get; } | Gets the normalized username field. |

## See Also

* **Source:** *[INormalizedUsernameRow.cs](https://github.com/serenity-is/Serenity/blob/1efb5a449115952404f809bb6c70b5af38a30191/common-features/src/extensions/Modules/Authorization/INormalizedUsernameRow.cs)*