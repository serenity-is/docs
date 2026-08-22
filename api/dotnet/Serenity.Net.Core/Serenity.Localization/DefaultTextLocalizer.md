# DefaultTextLocalizer class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An [`ITextLocalizer`](../Serenity/ITextLocalizer.md) implementation that resolves translations from an [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) using the current UI culture.

```csharp
public class DefaultTextLocalizer : ITextLocalizer
```

| parameter | description |
| --- | --- |
| registry | The local text registry to resolve translations from. |

## Public Members

| name | description |
| --- | --- |
| [DefaultTextLocalizer](DefaultTextLocalizer/DefaultTextLocalizer.md)(…) | An [`ITextLocalizer`](../Serenity/ITextLocalizer.md) implementation that resolves translations from an [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) using the current UI culture. |
| [TryGet](DefaultTextLocalizer/TryGet.md)(…) | Gets the translation for a key based on the current UI culture language. |

## Remarks

Creates a new default text localizer instance.

## See Also

* interface [ITextLocalizer](../Serenity/ITextLocalizer.md)
* **Source:** *[DefaultTextLocalizer.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/DefaultTextLocalizer.cs)*