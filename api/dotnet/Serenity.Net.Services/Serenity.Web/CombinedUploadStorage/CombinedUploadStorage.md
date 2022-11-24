# CombinedUploadStorage constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new instance of the class

```csharp
public CombinedUploadStorage(IUploadStorage mainStorage, IUploadStorage subStorage, 
    string subPrefix)
```

| parameter | description |
| --- | --- |
| mainStorage | The main storage |
| subStorage | The sub storage |
| subPrefix | Prefix path for the substorage like "temporary/" |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is null |

## See Also

* interface [IUploadStorage](../IUploadStorage.md)
* class [CombinedUploadStorage](../CombinedUploadStorage.md)