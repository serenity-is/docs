# AuditedAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Indicates if the field is audited. For DataAuditLog, all fields are audited by default, but if the field has [Audited(false)] it will not be logged.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class AuditedAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [AuditedAttribute](AuditedAttribute/AuditedAttribute.md)(…) | Indicates if the field is audited. For DataAuditLog, all fields are audited by default, but if the field has [Audited(false)] it will not be logged. |
| [Value](AuditedAttribute/Value.md) { get; } | Gets the value of the attribute |

## Remarks

Initializes a new instance of the attribute.

## See Also

* **Source:** *[AuditedAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/AuditedAttribute.cs)*