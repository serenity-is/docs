# AsyncLookupEditorAttribute constructor (1 of 2)

Initializes a new instance of the [`AsyncLookupEditorAttribute`](../AsyncLookupEditorAttribute.md) class.

```csharp
public AsyncLookupEditorAttribute(string lookupKey)
```

| parameter | description |
| --- | --- |
| lookupKey | The lookup key. |

## See Also

* class [AsyncLookupEditorAttribute](../AsyncLookupEditorAttribute.md)

---

# AsyncLookupEditorAttribute constructor (2 of 2)

Initializes a new instance of the [`AsyncLookupEditorAttribute`](../AsyncLookupEditorAttribute.md) class.

```csharp
public AsyncLookupEditorAttribute(Type lookupType)
```

| parameter | description |
| --- | --- |
| lookupType | Type of the lookup. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if *lookupType* is null. |
| ArgumentException | Thrown if the type has no [LookupScript] attribute. |

## See Also

* class [AsyncLookupEditorAttribute](../AsyncLookupEditorAttribute.md)