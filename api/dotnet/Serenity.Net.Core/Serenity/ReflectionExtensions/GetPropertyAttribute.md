# ReflectionExtensions.GetPropertyAttribute&lt;TAttribute&gt; method

Gets an attribute of a property as Serenity resolves it: its own, the ones it inherits from its base classes and from the members of the interfaces it implements, and the ones of its combination attributes, see [`IIntrinsicPropertyAttributeProvider`](../../Serenity.Reflection/IIntrinsicPropertyAttributeProvider.md), as [`WrappedProperty`](../../Serenity.Reflection/WrappedProperty.md) does. Unlike MemberInfo), which only has its own and the inherited ones.

```csharp
public static TAttribute? GetPropertyAttribute<TAttribute>(this PropertyInfo property)
    where TAttribute : Attribute
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attribute. |
| property | The property. |

## Return Value

The attribute, or null when the property has none.

## Exceptions

| exception | condition |
| --- | --- |
| AmbiguousMatchException | The property has more than one attribute of the type. |

## Remarks

Only the attributes of the type, and the combination attributes, are created, so it can be used where creating the others would recurse, e.g. in the constructor of an attribute that reads the properties of another type, which can have the same attribute.

## See Also

* class [ReflectionExtensions](../ReflectionExtensions.md)