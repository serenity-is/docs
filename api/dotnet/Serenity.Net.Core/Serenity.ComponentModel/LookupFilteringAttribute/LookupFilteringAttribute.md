# LookupFilteringAttribute constructor (1 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new instance of the [`LookupFilteringAttribute`](../LookupFilteringAttribute.md) class.

```csharp
public LookupFilteringAttribute(string lookupKey)
```

| parameter | description |
| --- | --- |
| lookupKey | The lookup key. |

## See Also

* class [LookupFilteringAttribute](../LookupFilteringAttribute.md)

---

# LookupFilteringAttribute constructor (2 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new instance of the [`LookupFilteringAttribute`](../LookupFilteringAttribute.md) class.

```csharp
public LookupFilteringAttribute(Type lookupType)
```

| parameter | description |
| --- | --- |
| lookupType | Type of the lookup to get lookup key from. Can be a row with [LookupScript] attribute or a custom lookup script. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | lookupType is null |

## See Also

* class [LookupFilteringAttribute](../LookupFilteringAttribute.md)