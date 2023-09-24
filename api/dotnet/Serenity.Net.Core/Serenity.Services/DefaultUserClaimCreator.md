# DefaultUserClaimCreator class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Default implementation for IUserClaimCreator

```csharp
public class DefaultUserClaimCreator : IUserClaimCreator
```

## Public Members

| name | description |
| --- | --- |
| [DefaultUserClaimCreator](DefaultUserClaimCreator/DefaultUserClaimCreator.md)(…) | Creates an instance of the class |
| virtual [CreatePrincipal](DefaultUserClaimCreator/CreatePrincipal.md)(…) | Create user Principal |

## Protected Members

| name | description |
| --- | --- |
| virtual [AddClaims](DefaultUserClaimCreator/AddClaims.md)(…) | Add User Claims To Identity |

## See Also

* interface [IUserClaimCreator](../Serenity.Abstractions/IUserClaimCreator.md)
* **Source:** *[DefaultUserClaimCreator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/DefaultUserClaimCreator.cs)*