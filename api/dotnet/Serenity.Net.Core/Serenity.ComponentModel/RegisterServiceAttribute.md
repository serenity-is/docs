# RegisterServiceAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Enables auto registering for the implementation type this attribute is placed on.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public abstract class RegisterServiceAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [RegisterServiceAttribute](RegisterServiceAttribute/RegisterServiceAttribute.md)() | Creates a new instance of RegisterServiceAttribute |
| [AsSelf](RegisterServiceAttribute/AsSelf.md) { get; set; } | Register the type itself as concrete implementation for itself in addition to any [`Types`](RegisterServiceAttribute/Types.md) specified, or the type's auto-detected interface. To register only itself with no interfaces, pass an empty array as Types: `[]`. Note that AsSelf cannot be used with keyed service registrations and Key property will be ignored. |
| [Key](RegisterServiceAttribute/Key.md) { get; set; } | The key identifier for keyed service registration. |
| [Lifetime](RegisterServiceAttribute/Lifetime.md) { get; protected set; } | Gets lifetime, which is transient by default |
| [Order](RegisterServiceAttribute/Order.md) { get; set; } | Gets or sets the order of registration. Services with lower order will be registered first. This can be used to ensure that certain services are registered before others, e.g. when multiple implementations of the same service type are registered and the order matters. The default value is 0, and a higher value means a later registration. |
| [ReplaceExisting](RegisterServiceAttribute/ReplaceExisting.md) { get; set; } | Indicates whether to replace existing registration. Note that when ReplaceExisting is true, SkipExisting is ignored. |
| [SkipExisting](RegisterServiceAttribute/SkipExisting.md) { get; set; } | Gets or sets a value indicating whether to skip registration if a registration for the service already exists (default true), e.g. use TryAddSingleton etc. methods instead of AddSingleton. |
| [Types](RegisterServiceAttribute/Types.md) { get; set; } | The list of types that this service will be registered for. If no types are specified, the system will try to auto determine the interface. It will skip interfaces from those in "System." / "Microsoft." namespaces. It will also skip interfaces that implement IRequestHandler, e.g. service request handlers, as they should be auto-registered by AddServiceHandlers. If only one interface is found, it will use that, or if multiple is found, it will prefer the one with I{ClassName}. Otherwise an exception will be raised. Note that all the types specified must be assignable from the current type. |

## See Also

* **Source:** *[RegisterServiceAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/AutoRegister/RegisterServiceAttribute.cs)*