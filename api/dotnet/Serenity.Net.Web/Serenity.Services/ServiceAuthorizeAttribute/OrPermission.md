# ServiceAuthorizeAttribute.OrPermission property
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

And optional secondary permission to check by OR, e.g. if this is specified an user does not have the Permission, the user will still be allowed access if he has the OrPermission.

```csharp
protected string OrPermission { get; set; }
```

## See Also

* class [ServiceAuthorizeAttribute](../ServiceAuthorizeAttribute.md)