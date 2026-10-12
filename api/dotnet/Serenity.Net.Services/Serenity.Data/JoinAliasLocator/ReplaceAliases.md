# JoinAliasLocator.ReplaceAliases method (1 of 2)

Replaces aliases in the criteria tree while preserving its structure.

```csharp
public static BaseCriteria ReplaceAliases(BaseCriteria criteria, Func<string, string> replace)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |
| replace | The alias replacement function. |

## Return Value

The criteria with aliases replaced.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | criteria or replace is null. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [JoinAliasLocator](../JoinAliasLocator.md)

---

# JoinAliasLocator.ReplaceAliases method (2 of 2)

Replaces the aliases in an SQL expression.

```csharp
public static string ReplaceAliases(string expression, Func<string, string> replace)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| replace | The replace function. |

## Return Value

The expression with aliases replaced.

## See Also

* class [JoinAliasLocator](../JoinAliasLocator.md)