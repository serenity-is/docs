# GlobFilter constructor (1 of 2)

Creates a new [`GlobFilter`](../GlobFilter.md) with just the include globs.

```csharp
public GlobFilter(IEnumerable<string> globs)
```

| parameter | description |
| --- | --- |
| globs | The list of patterns. |

## See Also

* class [GlobFilter](../GlobFilter.md)

---

# GlobFilter constructor (2 of 2)

Creates a new [`GlobFilter`](../GlobFilter.md) containing both include and exclude patterns. When *include* is `null` or empty, all files are included by default, unless they match a pattern in the *exclude* list. When *exclude* is `null`, it is ignored.

```csharp
public GlobFilter(IEnumerable<string> include, IEnumerable<string> exclude)
```

| parameter | description |
| --- | --- |
| include | The list of include patterns. |
| exclude | The list of exclude patterns. |

## See Also

* class [GlobFilter](../GlobFilter.md)