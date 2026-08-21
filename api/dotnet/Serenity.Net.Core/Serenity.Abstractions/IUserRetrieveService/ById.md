# IUserRetrieveService.ById method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the user definition with the specified identifier.

```csharp
public IUserDefinition ById(string id)
```

| parameter | description |
| --- | --- |
| id | The unique user identifier. |

## Return Value

The matching [`IUserDefinition`](../../Serenity/IUserDefinition.md) or `null` if not found.

## See Also

* interface [IUserDefinition](../../Serenity/IUserDefinition.md)
* interface [IUserRetrieveService](../IUserRetrieveService.md)