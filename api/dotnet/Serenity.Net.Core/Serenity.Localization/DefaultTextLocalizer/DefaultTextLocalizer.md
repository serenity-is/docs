# DefaultTextLocalizer constructor
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

An [`ITextLocalizer`](../../Serenity/ITextLocalizer.md) implementation that resolves translations from an [`ILocalTextRegistry`](../../Serenity.Abstractions/ILocalTextRegistry.md) using the current UI culture.

```csharp
public DefaultTextLocalizer(ILocalTextRegistry registry)
```

| parameter | description |
| --- | --- |
| registry | The local text registry to resolve translations from. |

## Remarks

Creates a new default text localizer instance.

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [DefaultTextLocalizer](../DefaultTextLocalizer.md)