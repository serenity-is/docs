# RegisterTransientAttribute constructor (1 of 2)

Creates a new instance of the attribute.

```csharp
public RegisterTransientAttribute()
```

## See Also

* class [RegisterTransientAttribute](../RegisterTransientAttribute.md)

---

# RegisterTransientAttribute constructor (2 of 2)

Creates a new instance of the attribute for the specified types.

```csharp
public RegisterTransientAttribute(params Type[] types)
```

| parameter | description |
| --- | --- |
| types | Service types. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if *types* is null. |

## See Also

* class [RegisterTransientAttribute](../RegisterTransientAttribute.md)