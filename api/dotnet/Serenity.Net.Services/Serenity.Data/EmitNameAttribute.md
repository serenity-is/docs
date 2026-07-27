# EmitNameAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Declares that the property generated for this template property should have the specified name, instead of the auto generated one.

```csharp
[AttributeUsage(AttributeTargets.Property, Inherited = false)]
public class EmitNameAttribute : Attribute
```

| parameter | description |
| --- | --- |
| name | Property name to use for this property in generated source. |

## Public Members

| name | description |
| --- | --- |
| [EmitNameAttribute](EmitNameAttribute/EmitNameAttribute.md)(…) | Declares that the property generated for this template property should have the specified name, instead of the auto generated one. |
| [Name](EmitNameAttribute/Name.md) { get; } | The property name |

## Remarks

Creates an instance of EmitNameAttribute attribute

## See Also

* **Source:** *[EmitNameAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/EmitNameAttribute.cs)*