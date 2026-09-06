# LookupEditorAttribute constructor (1 of 2)

Initializes a new instance of the [`LookupEditorAttribute`](../LookupEditorAttribute.md) class.

```csharp
public LookupEditorAttribute(string lookupKey)
```

| parameter | description |
| --- | --- |
| lookupKey | The lookup key. |

## See Also

* class [LookupEditorAttribute](../LookupEditorAttribute.md)

---

# LookupEditorAttribute constructor (2 of 2)

If you use this constructor, lookupKey will be determined by [LookupScript] attribute on specified lookup type. If this is a row type, make sure it has [LookupScript] attribute on it.

```csharp
public LookupEditorAttribute(Type lookupType)
```

## See Also

* class [LookupEditorAttribute](../LookupEditorAttribute.md)