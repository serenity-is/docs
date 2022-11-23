# IImplicitBehaviorRegistry interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An interface to query list of implicit behaviors registered through the dependency resolver. Implicit behaviors are automatically activated behaviors by querying via their ActivateFor method. See [`IImplicitBehavior`](IImplicitBehavior.md)

```csharp
public interface IImplicitBehaviorRegistry
```

## Members

| name | description |
| --- | --- |
| [GetTypes](IImplicitBehaviorRegistry/GetTypes.md)() | Gets type list of implict behavior ([`IImplicitBehavior`](IImplicitBehavior.md)) types |

## See Also

* **Source:** *[IImplicitBehaviorRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Behavior/IImplicitBehaviorRegistry.cs)*