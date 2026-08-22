# OverwriteOption enumeration
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Enum that contains what to do when a file at desired path exists

```csharp
public enum OverwriteOption
```

## Values

| name | value | description |
| --- | --- | --- |
| Disallowed | `0` | Raise an error |
| Overwrite | `1` | Overwrite the target file |
| AutoRename | `2` | Try to find a suitable name for the source file to be written |

## See Also

* **Source:** *[OverwriteOption.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/Upload/OverwriteOption.cs)*