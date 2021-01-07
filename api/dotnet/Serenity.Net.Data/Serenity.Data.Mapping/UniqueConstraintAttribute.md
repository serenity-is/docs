# UniqueConstraintAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Adds a unique constraint check to the row.

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class UniqueConstraintAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [UniqueConstraintAttribute](UniqueConstraintAttribute/UniqueConstraintAttribute.md)(…) | Initializes a new instance of the [`UniqueConstraintAttribute`](UniqueConstraintAttribute.md) class. |
| [CheckBeforeSave](UniqueConstraintAttribute/CheckBeforeSave.md) { get; set; } | Gets or sets a value indicating whether constraint should be checked before save, default true. |
| [ErrorMessage](UniqueConstraintAttribute/ErrorMessage.md) { get; set; } | Gets or sets the error message. |
| [Fields](UniqueConstraintAttribute/Fields.md) { get; } | Gets the fields. |
| [IgnoreDeleted](UniqueConstraintAttribute/IgnoreDeleted.md) { get; set; } | Gets or sets a value indicating whether to ignore deleted records while checking the constraint. |
| [Name](UniqueConstraintAttribute/Name.md) { get; set; } | Gets or sets the constraint name. Not used at the moment. |

## See Also

* **Source:** *[UniqueConstraintAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/UniqueConstraintAttribute.cs)*