# JsonLocalTextRegistration.AddJsonResourceTexts method (1 of 2)
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds json texts from embedded resources

```csharp
public static ILocalTextRegistry AddJsonResourceTexts(this ILocalTextRegistry registry, 
    IEnumerable<Assembly> assemblies)
```

| parameter | description |
| --- | --- |
| registry | The text registry |
| assemblies | List of assemblies |

## Return Value

The text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | registry, provider or sub path is null |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)

---

# JsonLocalTextRegistration.AddJsonResourceTexts method (2 of 2)
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds json texts from embedded resources

```csharp
public static ILocalTextRegistry AddJsonResourceTexts(this ILocalTextRegistry registry, 
    ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| registry | The text registry |
| typeSource | Type source |

## Return Value

The text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | registry, provider or sub path is null |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [JsonLocalTextRegistration](../JsonLocalTextRegistration.md)