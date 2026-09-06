# IIntrinsicPropertyAttributeProvider.PropertyAttributes property

Implementing attributes expose additional intrinsic property attributes by applying them to this property. This is useful because some attributes can only target properties due to AttributeUsageAttribute restrictions.

```csharp
public object PropertyAttributes { get; }
```

## See Also

* interface [IIntrinsicPropertyAttributeProvider](../IIntrinsicPropertyAttributeProvider.md)