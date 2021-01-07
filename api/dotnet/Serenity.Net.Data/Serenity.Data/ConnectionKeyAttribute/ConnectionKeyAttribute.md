# ConnectionKeyAttribute constructor (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`ConnectionKeyAttribute`](../ConnectionKeyAttribute.md) class.

```csharp
public ConnectionKeyAttribute(string connectionKey)
```

| parameter | description |
| --- | --- |
| connectionKey | The connection key. |

## See Also

* class [ConnectionKeyAttribute](../ConnectionKeyAttribute.md)

---

# ConnectionKeyAttribute constructor (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Initializes a new instance of the [`ConnectionKeyAttribute`](../ConnectionKeyAttribute.md) class with a type that has a ConnectionKey attribute to read the connection key from.

```csharp
public ConnectionKeyAttribute(Type sourceType)
```

| parameter | description |
| --- | --- |
| sourceType | Type of the source. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | sourceType is null |
| ArgumentOutOfRangeException | sourceType has no ConnectionKey attribute. |

## See Also

* class [ConnectionKeyAttribute](../ConnectionKeyAttribute.md)