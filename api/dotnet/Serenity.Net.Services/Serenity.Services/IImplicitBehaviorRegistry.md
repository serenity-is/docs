# IImplicitBehaviorRegistry interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface to query list of implicit behaviors registered through the dependency resolver. Implicit behaviors are automatically activated behaviors by querying via their ActivateFor method. See [`IImplicitBehavior`](./IImplicitBehavior.md)

```csharp
public interface IImplicitBehaviorRegistry
```

## Members

| name | description |
| --- | --- |
| [GetTypes](IImplicitBehaviorRegistry/GetTypes.md)() | Gets type list of implicit behavior ([`IImplicitBehavior`](./IImplicitBehavior.md)) types |

## See Also

* **Source:** *[IImplicitBehaviorRegistry.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/Behavior/IImplicitBehaviorRegistry.cs)*