# EntityFieldExtensions.GetAttributes&lt;TAttribute&gt; method

Gets the attributes.

```csharp
public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this Field field)
    where TAttribute : Attribute
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attribute. |
| field | The field. |

## Return Value

Attributes with specified type.

## See Also

* class [Field](../Field.md)
* class [EntityFieldExtensions](../EntityFieldExtensions.md)