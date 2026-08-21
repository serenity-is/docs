# DefaultUserClaimCreator.AddClaims method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds claims to the specified identity for the given user definition.

```csharp
protected virtual void AddClaims(ClaimsIdentity identity, IUserDefinition userDefinition)
```

| parameter | description |
| --- | --- |
| identity | The identity to add claims to. |
| userDefinition | The user definition that provides claim values. |

## See Also

* interface [IUserDefinition](../../Serenity/IUserDefinition.md)
* class [DefaultUserClaimCreator](../DefaultUserClaimCreator.md)