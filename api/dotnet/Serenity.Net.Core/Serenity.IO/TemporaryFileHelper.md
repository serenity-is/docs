# TemporaryFileHelper class
**namespace:** *[Serenity.IO](../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper functions for temporary files and folders

```csharp
public class TemporaryFileHelper
```

## Public Members

| name | description |
| --- | --- |
| [TemporaryFileHelper](TemporaryFileHelper/TemporaryFileHelper.md)() | The default constructor. |
| static readonly [DefaultAutoExpireTime](TemporaryFileHelper/DefaultAutoExpireTime.md) | By default, files older than 1 hour is cleared |
| const [DefaultMaxFilesInDirectory](TemporaryFileHelper/DefaultMaxFilesInDirectory.md) | By default, if more than 1000 files exists in directory, they are deleted |
| const [DefaultTemporaryCheckFile](TemporaryFileHelper/DefaultTemporaryCheckFile.md) | A signature file that marks a folder as a temporary file to ensure that it actually contains temporary files and can be safely cleaned |
| static [ClearTempFiles](TemporaryFileHelper/ClearTempFiles.md)(…) | Clears the temporary files. |
| static [Delete](TemporaryFileHelper/Delete.md)(…) | Deletes a file. (2 methods) |
| static [PurgeDirectory](TemporaryFileHelper/PurgeDirectory.md)(…) | Clears a folder based on specified conditions |
| static [PurgeDirectoryDefault](TemporaryFileHelper/PurgeDirectoryDefault.md)(…) | Clears a folder based on default conditions |
| static [RandomFileCode](TemporaryFileHelper/RandomFileCode.md)() | Gets a 13 character random code that can be used safely in a filename |
| static [RegisterTempFile](TemporaryFileHelper/RegisterTempFile.md)(…) | Registers the temporary file. |
| static [TryDelete](TemporaryFileHelper/TryDelete.md)(…) | Tries to delete a file with given path. |
| static [TryDeleteMarkedFiles](TemporaryFileHelper/TryDeleteMarkedFiles.md)(…) | Tries to delete all files that is marked for deletion by TryDeleteOrMark in a folder. |
| static [TryDeleteOrMark](TemporaryFileHelper/TryDeleteOrMark.md)(…) | Tries to delete a file or marks it for deletion by DeleteMarkedFiles method by creating a ".delete" file. |

## See Also

* **Source:** *[TemporaryFileHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/IO/TemporaryFileHelper.cs)*