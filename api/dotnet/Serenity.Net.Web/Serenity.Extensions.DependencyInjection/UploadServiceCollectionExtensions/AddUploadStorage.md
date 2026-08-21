# UploadServiceCollectionExtensions.AddUploadStorage method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default implementations of IUploadStorage, IUploadValidator, IImageProcessor and IUploadProcessor interfaces.

```csharp
public static IServiceCollection AddUploadStorage(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | The service collection. |

## Return Value

The same service collection so that calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *collection* is `null`. |

## See Also

* class [UploadServiceCollectionExtensions](../UploadServiceCollectionExtensions.md)

---

# UploadServiceCollectionExtensions.AddUploadStorage method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default implementations of IUploadStorage, IUploadValidator, IImageProcessor and IUploadProcessor interfaces.

```csharp
public static IServiceCollection AddUploadStorage(this IServiceCollection collection, 
    Action<UploadSettings> setupAction)
```

| parameter | description |
| --- | --- |
| collection | The service collection. |
| setupAction | The callback to edit options. |

## Return Value

The same service collection so that calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *collection* or *setupAction* is `null`. |

## See Also

* class [UploadSettings](../Serenity.Net.Services/../../Serenity.Web/UploadSettings.md)
* class [UploadServiceCollectionExtensions](../UploadServiceCollectionExtensions.md)