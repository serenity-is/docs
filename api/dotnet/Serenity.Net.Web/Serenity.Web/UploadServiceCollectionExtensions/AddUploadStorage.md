# UploadServiceCollectionExtensions.AddUploadStorage method (1 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default implementations of IUploadStorage, IUploadValidator, IImageProcessor and IUploadProcessor interfaces.

```csharp
public static void AddUploadStorage(this IServiceCollection collection)
```

| parameter | description |
| --- | --- |
| collection | Service collection |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Collection is null |

## See Also

* class [UploadServiceCollectionExtensions](../UploadServiceCollectionExtensions.md)

---

# UploadServiceCollectionExtensions.AddUploadStorage method (2 of 2)
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Registers the default implementations of IUploadStorage, IUploadValidator, IImageProcessor and IUploadProcessor interfaces.

```csharp
public static void AddUploadStorage(this IServiceCollection collection, 
    Action<UploadSettings> setupAction)
```

| parameter | description |
| --- | --- |
| collection | Service collection |
| setupAction | Callback to edit options |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Collection is null |

## See Also

* class [UploadSettings](../Serenity.Net.Services/../UploadSettings.md)
* class [UploadServiceCollectionExtensions](../UploadServiceCollectionExtensions.md)