# ForeignRowAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines the foreign key property on this row for a foreign row property. This is used to locate the FK property.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public sealed class ForeignRowAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The name of the FK property on this row. |

## Public Members

| name | description |
| --- | --- |
| [ForeignRowAttribute](ForeignRowAttribute/ForeignRowAttribute.md)(…) | Determines the foreign key property on this row for a foreign row property. This is used to locate the FK property. |
| [ForeignKeyProperty](ForeignRowAttribute/ForeignKeyProperty.md) { get; } | Gets the FK property name. |

## See Also

* **Source:** *[ForeignRowAttribute.cs](https://github.com/serenity-is/Serenity/blob/ce95b00ba531cafa96a528778e70b472de44bf68/src/services/Data/Mapping/ForeignRowAttribute.cs)*