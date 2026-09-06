# CheckLookupEditorAttribute constructor (1 of 2)

Initializes a new instance of the [`CheckLookupEditorAttribute`](../CheckLookupEditorAttribute.md) class.

```csharp
public CheckLookupEditorAttribute(string lookupKey)
```

| parameter | description |
| --- | --- |
| lookupKey | The lookup key. |

## See Also

* class [CheckLookupEditorAttribute](../CheckLookupEditorAttribute.md)

---

# CheckLookupEditorAttribute constructor (2 of 2)

If you use this constructor, lookupKey will be determined by [LookupScript] attribute on specified lookup type. If this is a row type, make sure it has [LookupScript] attribute on it.

```csharp
public CheckLookupEditorAttribute(Type lookupType)
```

## See Also

* class [CheckLookupEditorAttribute](../CheckLookupEditorAttribute.md)