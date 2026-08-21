# RadioButtonEditorAttribute constructor (1 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new instance of the [`RadioButtonEditorAttribute`](../RadioButtonEditorAttribute.md) class.

```csharp
public RadioButtonEditorAttribute()
```

## See Also

* class [RadioButtonEditorAttribute](../RadioButtonEditorAttribute.md)

---

# RadioButtonEditorAttribute constructor (2 of 2)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Initializes a new instance of the [`RadioButtonEditorAttribute`](../RadioButtonEditorAttribute.md) class.

```csharp
public RadioButtonEditorAttribute(Type enumOrLookupType)
```

| parameter | description |
| --- | --- |
| enumOrLookupType | Type of the enum or lookup. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if *enumOrLookupType* is null. |
| ArgumentException | Thrown if the type is not an enum and has no [LookupScript] attribute. |

## See Also

* class [RadioButtonEditorAttribute](../RadioButtonEditorAttribute.md)