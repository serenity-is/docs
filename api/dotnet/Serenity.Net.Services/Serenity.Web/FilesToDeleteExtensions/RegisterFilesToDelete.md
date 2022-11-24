# FilesToDeleteExtensions.RegisterFilesToDelete method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Registers a [`FilesToDelete`](../FilesToDelete.md) in the target unit of work. This deletes the old files on commit, and new files on rollback

```csharp
public static void RegisterFilesToDelete(this IUnitOfWork unitOfWork, FilesToDelete filesToDelete)
```

| parameter | description |
| --- | --- |
| unitOfWork | Unit of work |
| filesToDelete | Files to delete container |

## See Also

* interface [IUnitOfWork](../Serenity.Net.Data/../../Serenity.Data/IUnitOfWork.md)
* class [FilesToDelete](../FilesToDelete.md)
* class [FilesToDeleteExtensions](../FilesToDeleteExtensions.md)