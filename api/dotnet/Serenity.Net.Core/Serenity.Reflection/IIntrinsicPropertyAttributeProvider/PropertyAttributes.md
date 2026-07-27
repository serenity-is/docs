# IIntrinsicPropertyAttributeProvider.PropertyAttributes property
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Implementing attributes expose additional intrinsic property attributes by applying them to this property. This is useful because some attributes can only target properties due to AttributeUsageAttribute restrictions.

```csharp
public object PropertyAttributes { get; }
```

## See Also

* interface [IIntrinsicPropertyAttributeProvider](../IIntrinsicPropertyAttributeProvider.md)