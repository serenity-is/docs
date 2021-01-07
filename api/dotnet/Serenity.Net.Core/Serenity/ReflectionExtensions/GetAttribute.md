# ReflectionExtensions.GetAttribute&lt;TAttribute&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the attribute.

```csharp
public static TAttribute GetAttribute<TAttribute>(this MemberInfo member, bool inherit = false)
    where TAttribute : Attribute
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attribute. |
| member | The member. |
| inherit | if set to `true` [inherit]. |

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException |  |

## See Also

* class [TAttribute](../Serenity.Net.Core/../ReflectionExtensions.TAttribute.md)
* class [ReflectionExtensions](../ReflectionExtensions.md)