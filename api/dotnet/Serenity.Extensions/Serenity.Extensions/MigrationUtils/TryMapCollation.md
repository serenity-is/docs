# MigrationUtils.TryMapCollation method

Tries to get the column collation for the specified comparison on the database the migration is running against, in the form to pass to `AsString`.

```csharp
public static string? TryMapCollation(this MigrationBase migration, string comparer, 
    bool tolerant = false, Func<string, bool>? exists = null)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |
| comparer | The comparer specification, e.g. "OrdinalIgnoreCase" or "tr-TR:IgnoreCase". |
| tolerant | True to allow a collation that only differs in case or accent sensitivity. |
| exists | Optional check for whether a collation exists, e.g. the Contains method of a set of names read from the server. It is called with unquoted names, and the first candidate it accepts is used. If not specified, the first candidate is used without checking the server. |

## Return Value

The collation, or null if there is no such collation, which uses the default of the database.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | The comparer can't be mapped to a collation. |

## See Also

* class [MigrationUtils](../MigrationUtils.md)