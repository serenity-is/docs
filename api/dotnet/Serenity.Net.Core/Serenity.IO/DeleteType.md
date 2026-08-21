# DeleteType enumeration
**namespace:** *[Serenity.IO](../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies how a file should be deleted.

```csharp
public enum DeleteType
```

## Values

| name | value | description |
| --- | --- | --- |
| Delete | `0` | Force delete the file. |
| TryDelete | `1` | Try to delete the file, ignoring any errors. |
| TryDeleteOrMark | `2` | Try to delete the file, or mark it for deletion if it cannot be deleted. |

## See Also

* **Source:** *[DeleteType.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/IO/DeleteType.cs)*