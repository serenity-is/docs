# ReflectionExtensions.GetPropertyAttributes&lt;TAttribute&gt; method

Gets the attributes of a property as Serenity resolves them, see [`GetPropertyAttribute`](./GetPropertyAttribute.md).

```csharp
public static IEnumerable<TAttribute> GetPropertyAttributes<TAttribute>(this PropertyInfo property)
    where TAttribute : Attribute
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attributes. |
| property | The property. |

## Return Value

The attributes.

## See Also

* class [ReflectionExtensions](../ReflectionExtensions.md)