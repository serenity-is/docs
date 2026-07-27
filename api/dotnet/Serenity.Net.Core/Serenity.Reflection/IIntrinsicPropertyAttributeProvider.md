# IIntrinsicPropertyAttributeProvider interface
**namespace:** *[Serenity.Reflection](../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Marks a composite attribute that can provide additional intrinsic attributes for a target property. The intrinsic attributes should be declared on its [`PropertyAttributes`](IIntrinsicPropertyAttributeProvider/PropertyAttributes.md) property.

```csharp
public interface IIntrinsicPropertyAttributeProvider
```

## Members

| name | description |
| --- | --- |
| [PropertyAttributes](IIntrinsicPropertyAttributeProvider/PropertyAttributes.md) { get; } | Implementing attributes expose additional intrinsic property attributes by applying them to this property. This is useful because some attributes can only target properties due to AttributeUsageAttribute restrictions. |

## See Also

* **Source:** *[IIntrinsicPropertyAttributeProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Reflection/IIntrinsicPropertyAttributeProvider.cs)*