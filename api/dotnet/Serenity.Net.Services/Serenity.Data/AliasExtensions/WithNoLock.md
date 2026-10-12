# AliasExtensions.WithNoLock method

Adds a WITH(NOLOCK) to the alias and returns a new alias. The alias name itself stays clean, so column references are unaffected; only FROM / JOIN rendering includes the hint.

```csharp
public static Alias WithNoLock(this IAlias alias)
```

| parameter | description |
| --- | --- |
| alias | The alias. |

## Return Value

A new alias with the WITH(NOLOCK) hint appended.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null. |

## Remarks

Table hints are SQL Server specific and are emitted as-is on all dialects.

## See Also

* class [Alias](../Alias.md)
* interface [IAlias](../IAlias.md)
* class [AliasExtensions](../AliasExtensions.md)