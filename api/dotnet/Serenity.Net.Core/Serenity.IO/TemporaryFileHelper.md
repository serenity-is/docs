# TemporaryFileHelper class
**namespace:** *[Serenity.IO](../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains helper functions for temporary files and folders.

```csharp
public class TemporaryFileHelper
```

## Public Members

| name | description |
| --- | --- |
| [TemporaryFileHelper](TemporaryFileHelper/TemporaryFileHelper.md)() | The default constructor. |
| static readonly [DefaultAutoExpireTime](TemporaryFileHelper/DefaultAutoExpireTime.md) | By default, files older than this duration are cleared. |
| const [DefaultMaxFilesInDirectory](TemporaryFileHelper/DefaultMaxFilesInDirectory.md) | By default, if more than this many files exist in a directory, they are deleted. |
| const [DefaultTemporaryCheckFile](TemporaryFileHelper/DefaultTemporaryCheckFile.md) | A signature file that marks a folder as a temporary folder, ensuring that it actually contains temporary files and can be safely cleaned. |
| static [Delete](TemporaryFileHelper/Delete.md)(…) | Deletes the file at the given path. (2 methods) |
| static [PurgeDirectory](TemporaryFileHelper/PurgeDirectory.md)(…) | Clears a folder based on the specified conditions. |
| static [PurgeDirectoryDefault](TemporaryFileHelper/PurgeDirectoryDefault.md)(…) | Clears a folder based on the default conditions. |
| static [RandomFileCode](TemporaryFileHelper/RandomFileCode.md)() | Gets a 13 character random code that can be used safely in a file name. |
| static [TryDelete](TemporaryFileHelper/TryDelete.md)(…) | Tries to delete the file at the given path, ignoring any errors. |
| static [TryDeleteMarkedFiles](TemporaryFileHelper/TryDeleteMarkedFiles.md)(…) | Tries to delete all files in a folder that were marked for deletion by [`TryDeleteOrMark`](TemporaryFileHelper/TryDeleteOrMark.md). |
| static [TryDeleteOrMark](TemporaryFileHelper/TryDeleteOrMark.md)(…) | Tries to delete a file, or marks it for deletion by [`TryDeleteMarkedFiles`](TemporaryFileHelper/TryDeleteMarkedFiles.md) by creating a ".delete" file. |

## See Also

* **Source:** *[TemporaryFileHelper.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/IO/TemporaryFileHelper.cs)*