# RegisterSingletonAttribute constructor (1 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new instance of the attribute.

```csharp
public RegisterSingletonAttribute()
```

## See Also

* class [RegisterSingletonAttribute](../RegisterSingletonAttribute.md)

---

# RegisterSingletonAttribute constructor (2 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a new instance of the attribute for the specified types.

```csharp
public RegisterSingletonAttribute(params Type[] types)
```

| parameter | description |
| --- | --- |
| types | Service types. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if *types* is null. |

## See Also

* class [RegisterSingletonAttribute](../RegisterSingletonAttribute.md)