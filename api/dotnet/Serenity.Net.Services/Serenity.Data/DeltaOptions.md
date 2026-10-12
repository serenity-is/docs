# DeltaOptions enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Delta options flags.

```csharp
[Flags]
public enum DeltaOptions
```

## Values

| name | value | description |
| --- | --- | --- |
| Default | `0x0` | The default options (strict: a new item id unknown in the old list throws). Pass IgnoreInvalidNewId explicitly to turn such items into inserts. |
| IgnoreInvalidNewId | `0x1` | Ignore new item identifiers that are not present in the old list. |

## See Also

* **Source:** *[DeltaOptions.cs](https://github.com/serenity-is/Serenity/blob/d748714b860f1252c29163a50bf91db03aa25ea2/src/services/Data/Utility/DeltaOptions.cs)*