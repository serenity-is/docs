# RegisterServiceAttribute.AsSelf property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Register the type itself as concrete implementation for itself in addition to any [`Types`](Types.md) specified, or the type's auto-detected interface. To register only itself with no interfaces, pass an empty array as Types: `[]`. Note that AsSelf cannot be used with keyed service registrations and Key property will be ignored.

```csharp
public bool AsSelf { get; set; }
```

## See Also

* class [RegisterServiceAttribute](../RegisterServiceAttribute.md)