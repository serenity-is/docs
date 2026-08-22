# IPropertySource interface
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstracts the property source that returns PropertyInfo and some other info

```csharp
public interface IPropertySource : IPropertyInfo
```

## Members

| name | description |
| --- | --- |
| [BasedOnField](IPropertySource/BasedOnField.md) { get; } | Gets the based on field. |
| [EnumType](IPropertySource/EnumType.md) { get; } | Gets the type of the enum. |
| [Property](IPropertySource/Property.md) { get; } | Gets the property. |
| [ReflectedType](IPropertySource/ReflectedType.md) { get; } | Gets the reflected type that this property belongs to. This is used for some attribute providers that need to know the reflected type, such as based on row field provider. |
| [ValueType](IPropertySource/ValueType.md) { get; } | Gets the type of the value. |

## See Also

* interface [IPropertyInfo](../Serenity.Net.Core/../Serenity.Reflection/IPropertyInfo.md)
* **Source:** *[IPropertySource.cs](https://github.com/serenity-is/Serenity/blob/4d2aea70b1129eefd7b1c32874a242aeee51b48a/src/services/Entity/PropertyGrid/IPropertySource.cs)*