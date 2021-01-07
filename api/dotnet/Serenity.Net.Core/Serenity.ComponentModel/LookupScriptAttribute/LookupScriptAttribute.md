# LookupScriptAttribute constructor (1 of 3)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a LookupScriptAttribute with auto determined lookup key

```csharp
public LookupScriptAttribute()
```

## See Also

* class [LookupScriptAttribute](../LookupScriptAttribute.md)

---

# LookupScriptAttribute constructor (2 of 3)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Creates a LookupScriptAttribute.

```csharp
public LookupScriptAttribute(string key)
```

| parameter | description |
| --- | --- |
| key | Lookup key, usually in "Module.EntityName" format. |

## See Also

* class [LookupScriptAttribute](../LookupScriptAttribute.md)

---

# LookupScriptAttribute constructor (3 of 3)
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Defines that this type has an external lookup script type, and the lookup key is available on that type. Use this overload only for row types that have external lookups.

```csharp
public LookupScriptAttribute(Type lookupType)
```

| parameter | description |
| --- | --- |
| lookupType | Script type with LookupScript attribute of its own. |

## See Also

* class [LookupScriptAttribute](../LookupScriptAttribute.md)