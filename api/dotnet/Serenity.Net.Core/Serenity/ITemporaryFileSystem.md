# ITemporaryFileSystem interface
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A file system abstraction used by [`TemporaryFileHelper`](../Serenity.IO/TemporaryFileHelper.md) that additionally exposes temporary file information.

```csharp
public interface ITemporaryFileSystem : IFileSystem
```

## Members

| name | description |
| --- | --- |
| [GetTemporaryFileInfos](ITemporaryFileSystem/GetTemporaryFileInfos.md)(…) | Gets the temporary file info objects for the files in the specified directory. |

## See Also

* interface [IFileSystem](./IFileSystem.md)
* **Source:** *[ITemporaryFileSystem.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/IO/ITemporaryFileSystem.cs)*