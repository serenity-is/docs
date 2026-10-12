# AliasExtensions.WithTableHint method

Adds a WITH(...) table hint to the alias and returns a new alias. The alias name itself stays clean, so column references are unaffected; only FROM / JOIN rendering includes the hint.

```csharp
public static Alias WithTableHint(this IAlias alias, params string[] hints)
```

| parameter | description |
| --- | --- |
| alias | The alias. |
| hints | Table hint keywords, e.g. "NOLOCK", "READUNCOMMITTED". Multiple hints are comma-separated in the rendered WITH clause. Hints from previous calls are retained, without adding duplicates. |

## Return Value

A new alias carrying the table hint.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null. |
| ArgumentException | No hint is provided, or a hint is null, empty or whitespace. |

## Remarks

Table hints are SQL Server specific and are emitted as-is on all dialects.

## See Also

* class [Alias](../Alias.md)
* interface [IAlias](../IAlias.md)
* class [AliasExtensions](../AliasExtensions.md)