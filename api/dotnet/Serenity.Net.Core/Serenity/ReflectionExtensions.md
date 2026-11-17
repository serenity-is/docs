# ReflectionExtensions class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Reflection extensions.

```csharp
public static class ReflectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetPropertyAttribute&lt;TAttribute&gt;](ReflectionExtensions/GetPropertyAttribute.md)(…) | Gets an attribute of a property as Serenity resolves it: its own, the ones it inherits from its base classes and from the members of the interfaces it implements, and the ones of its combination attributes, see [`IIntrinsicPropertyAttributeProvider`](../Serenity.Reflection/IIntrinsicPropertyAttributeProvider.md), as [`WrappedProperty`](../Serenity.Reflection/WrappedProperty.md) does. Unlike MemberInfo), which only has its own and the inherited ones. |
| static [GetPropertyAttributes&lt;TAttribute&gt;](ReflectionExtensions/GetPropertyAttributes.md)(…) | Gets the attributes of a property as Serenity resolves them, see [`GetPropertyAttribute`](./ReflectionExtensions/GetPropertyAttribute.md). |

## See Also

* **Source:** *[ReflectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/139827c0d64d7cacac31f2ec4d72112fcfe40f45/src/core/Reflection/ReflectionExtensions.cs)*