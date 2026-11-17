# EnumEditorAttribute constructor (1 of 3)

Initializes a new instance of the [`EnumEditorAttribute`](../EnumEditorAttribute.md) class.

```csharp
public EnumEditorAttribute()
```

## See Also

* class [EnumEditorAttribute](../EnumEditorAttribute.md)

---

# EnumEditorAttribute constructor (2 of 3)

Initializes a new instance of the [`EnumEditorAttribute`](../EnumEditorAttribute.md) class for an enum or a [`StringEnum`](../../Serenity/StringEnum.md) type by its key, which is needed for a property that is not typed with it, e.g. a string property that holds the values of a [`StringEnum`](../../Serenity/StringEnum.md).

```csharp
public EnumEditorAttribute(string enumKey)
```

| parameter | description |
| --- | --- |
| enumKey | The key of the enum or string enumeration. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *enumKey* is null or empty. |

## See Also

* class [EnumEditorAttribute](../EnumEditorAttribute.md)

---

# EnumEditorAttribute constructor (3 of 3)

Initializes a new instance of the [`EnumEditorAttribute`](../EnumEditorAttribute.md) class for a numeric enum or a [`StringEnum`](../../Serenity/StringEnum.md) type, which is needed for a property that is not typed with it, e.g. a string property that holds the values of a [`StringEnum`](../../Serenity/StringEnum.md).

```csharp
public EnumEditorAttribute(Type enumType)
```

| parameter | description |
| --- | --- |
| enumType | The enum or string enumeration type. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *enumType* is null. |
| ArgumentOutOfRangeException | *enumType* is neither an enum nor a string enumeration. |

## See Also

* class [EnumEditorAttribute](../EnumEditorAttribute.md)