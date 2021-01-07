# UniqueAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Defines a unique constraint on the field

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class UniqueAttribute : SetFieldFlagsAttribute
```

## Public Members

| name | description |
| --- | --- |
| [UniqueAttribute](UniqueAttribute/UniqueAttribute.md)() | Initializes a new instance of the [`UniqueAttribute`](UniqueAttribute.md) class. |
| [CheckBeforeSave](UniqueAttribute/CheckBeforeSave.md) { get; set; } | Gets or sets a value indicating whether to check this constraint before save. |
| [ErrorMessage](UniqueAttribute/ErrorMessage.md) { get; set; } | Gets or sets the error message. |
| [IgnoreDeleted](UniqueAttribute/IgnoreDeleted.md) { get; set; } | Gets or sets a value indicating whether to ignore deleted records. |
| [Name](UniqueAttribute/Name.md) { get; set; } | Gets or sets the name of the constraint. Not used. |

## See Also

* class [SetFieldFlagsAttribute](SetFieldFlagsAttribute.md)
* **Source:** *[UniqueAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/UniqueAttribute.cs)*