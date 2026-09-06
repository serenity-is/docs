# DefaultUserClaimCreator.AddClaims method

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