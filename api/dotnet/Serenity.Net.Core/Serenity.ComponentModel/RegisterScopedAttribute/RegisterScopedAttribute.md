# RegisterScopedAttribute constructor (1 of 2)

Creates a new instance of the attribute.

```csharp
public RegisterScopedAttribute()
```

## See Also

* class [RegisterScopedAttribute](../RegisterScopedAttribute.md)

---

# RegisterScopedAttribute constructor (2 of 2)

Creates a new instance of the attribute for the specified types.

```csharp
public RegisterScopedAttribute(params Type[] types)
```

| parameter | description |
| --- | --- |
| types | Service types. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if *types* is null. |

## See Also

* class [RegisterScopedAttribute](../RegisterScopedAttribute.md)