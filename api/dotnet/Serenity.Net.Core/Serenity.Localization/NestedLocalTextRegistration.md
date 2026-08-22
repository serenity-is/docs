# NestedLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper methods for registration of local texts in nested static classes. Nested static classes contain [`LocalText`](../Serenity/LocalText.md) objects with actual translations as keys. This class locates them (with [`NestedLocalTextsAttribute`](../Serenity.ComponentModel/NestedLocalTextsAttribute.md) at the outermost class), determines keys by the path from the outermost to the nested class name, replaces the existing [`LocalText`](../Serenity/LocalText.md) instance with an initialized instance containing this generated key and initial translation, and registers this translation in the [`ILocalTextRegistry`](../Serenity.Abstractions/ILocalTextRegistry.md) provider.

```csharp
public static class NestedLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddNestedTexts](NestedLocalTextRegistration/AddNestedTexts.md)(…) | Adds translations from static nested local text classes marked with [`NestedLocalTextsAttribute`](../Serenity.ComponentModel/NestedLocalTextsAttribute.md). |

## See Also

* **Source:** *[NestedLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/Localization/NestedLocalTextRegistration.cs)*