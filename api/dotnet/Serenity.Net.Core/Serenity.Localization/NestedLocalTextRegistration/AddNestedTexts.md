# NestedLocalTextRegistration.AddNestedTexts method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds translations from static nested local text classes marked with [`NestedLocalTextsAttribute`](../../Serenity.ComponentModel/NestedLocalTextsAttribute.md).

```csharp
public static void AddNestedTexts(this ILocalTextRegistry registry, ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| registry | The registry to add texts to. |
| typeSource | The type source to search for nested local text classes in. |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [NestedLocalTextRegistration](../NestedLocalTextRegistration.md)