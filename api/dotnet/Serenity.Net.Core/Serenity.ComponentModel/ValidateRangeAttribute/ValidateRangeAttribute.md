# ValidateRangeAttribute constructor (1 of 3)

Creates a range of numbers.

```csharp
public ValidateRangeAttribute(double minimum, double maximum)
```

| parameter | description |
| --- | --- |
| minimum | The minimum. |
| maximum | The maximum. |

## See Also

* class [ValidateRangeAttribute](../ValidateRangeAttribute.md)

---

# ValidateRangeAttribute constructor (2 of 3)

Creates a range of integers.

```csharp
public ValidateRangeAttribute(int minimum, int maximum)
```

| parameter | description |
| --- | --- |
| minimum | The minimum. |
| maximum | The maximum. |

## See Also

* class [ValidateRangeAttribute](../ValidateRangeAttribute.md)

---

# ValidateRangeAttribute constructor (3 of 3)

Creates a range of another type, e.g. dates, whose limits are given as text, e.g. `2026-01-01`.

```csharp
public ValidateRangeAttribute(Type type, string minimum, string maximum)
```

| parameter | description |
| --- | --- |
| type | The type of the value. |
| minimum | The minimum, as text in the invariant culture. |
| maximum | The maximum, as text in the invariant culture. |

## See Also

* class [ValidateRangeAttribute](../ValidateRangeAttribute.md)