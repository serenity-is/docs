# RegisterServiceAttribute.Types property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

The list of types that this service will be registered for. If no types are specified, the system will try to auto determine the interface. It will skip interfaces from those in "System." / "Microsoft." namespaces. It will also skip interfaces that implement IRequestHandler, e.g. service request handlers, as they should be auto-registered by AddServiceHandlers. If only one interface is found, it will use that, or if multiple is found, it will prefer the one with I{ClassName}. Otherwise an exception will be raised. Note that all the types specified must be assignable from the current type.

```csharp
public Type[] Types { get; set; }
```

## See Also

* class [RegisterServiceAttribute](../RegisterServiceAttribute.md)