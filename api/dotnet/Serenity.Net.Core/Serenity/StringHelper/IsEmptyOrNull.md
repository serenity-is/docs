# StringHelper.IsEmptyOrNull method (1 of 2)

Determines whether the collection is empty or null.

```csharp
public static bool IsEmptyOrNull(this ICollection collection)
```

| parameter | description |
| --- | --- |
| collection | The collection. |

## Return Value

`true` if the collection is empty or null; otherwise, `false`.

## See Also

* class [StringHelper](../StringHelper.md)

---

# StringHelper.IsEmptyOrNull method (2 of 2)

This function is just an extension method version of string.IsNullOrEmpty and is effectively obsolete.

```csharp
public static bool IsEmptyOrNull(this string? str)
```

| parameter | description |
| --- | --- |
| str | String. |

## Return Value

If *str* is `null` or empty, `true`

## See Also

* class [StringHelper](../StringHelper.md)