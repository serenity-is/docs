# IUserRetrieveService.ByUsername method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the user definition with the specified username.

```csharp
public IUserDefinition ByUsername(string username)
```

| parameter | description |
| --- | --- |
| username | The username to look up. |

## Return Value

The matching [`IUserDefinition`](../../Serenity/IUserDefinition.md) or `null` if not found.

## See Also

* interface [IUserDefinition](../../Serenity/IUserDefinition.md)
* interface [IUserRetrieveService](../IUserRetrieveService.md)