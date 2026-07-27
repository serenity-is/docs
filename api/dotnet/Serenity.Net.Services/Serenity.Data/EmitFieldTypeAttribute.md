# EmitFieldTypeAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Declares that the field generated for this template property should be of type specified.

```csharp
[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class EmitFieldTypeAttribute : Attribute
```

| parameter | description |
| --- | --- |
| fieldType | Field type to use for this property in generated source. |

## Public Members

| name | description |
| --- | --- |
| [EmitFieldTypeAttribute](EmitFieldTypeAttribute/EmitFieldTypeAttribute.md)(…) | Declares that the field generated for this template property should be of type specified. |
| [FieldType](EmitFieldTypeAttribute/FieldType.md) { get; } | The field type |

## Remarks

Creates an instance of FieldTypeAttribute attribute

## See Also

* **Source:** *[EmitFieldTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/EmitFieldTypeAttribute.cs)*