# SetFieldFlagsAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Used to turn on (include) or turn off (exclude) field flags.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class SetFieldFlagsAttribute : Attribute
```

| parameter | description |
| --- | --- |
| add | Set of flags to turn on (include) |
| remove | Set of flags to turn off (exclude) |

## Public Members

| name | description |
| --- | --- |
| [SetFieldFlagsAttribute](SetFieldFlagsAttribute/SetFieldFlagsAttribute.md)(…) | Used to turn on (include) or turn off (exclude) field flags. |
| [Add](SetFieldFlagsAttribute/Add.md) { get; } | Gets the include flags. |
| [Remove](SetFieldFlagsAttribute/Remove.md) { get; } | Gets the exclude flags. |

## Remarks

Turn on or off field flags.

## See Also

* **Source:** *[SetFieldFlagsAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/SetFieldFlagsAttribute.cs)*