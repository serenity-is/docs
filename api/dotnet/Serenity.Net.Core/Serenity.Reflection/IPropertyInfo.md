# IPropertyInfo interface
**namespace:** *[Serenity.Reflection](../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An interface to virtualize property attribute access.

```csharp
public interface IPropertyInfo
```

## Members

| name | description |
| --- | --- |
| [Name](IPropertyInfo/Name.md) { get; } | Gets the name. |
| [PropertyType](IPropertyInfo/PropertyType.md) { get; } | Gets the type of the property. |
| [GetAttribute&lt;TAttr&gt;](IPropertyInfo/GetAttribute.md)(…) | Gets the attribute of the specified type. |
| [GetAttributes&lt;TAttr&gt;](IPropertyInfo/GetAttributes.md)(…) | Gets the attributes of the specified type. |

## See Also

* **Source:** *[IPropertyInfo.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Reflection/IPropertyInfo.cs)*