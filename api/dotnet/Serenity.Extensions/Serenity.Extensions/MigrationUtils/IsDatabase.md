# MigrationUtils.IsDatabase method (1 of 2)

Determines whether the migration is running against a database matching the specified predicate.

```csharp
public static bool IsDatabase(this MigrationBase migration, Predicate<string> predicate)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |
| predicate | The predicate to test the database type against. |

## Return Value

`true` if the database type matches; otherwise, `false`.

## See Also

* class [MigrationUtils](../MigrationUtils.md)

---

# MigrationUtils.IsDatabase method (2 of 2)

Determines whether the migration is running against a database whose type starts with the specified name.

```csharp
public static bool IsDatabase(this MigrationBase migration, string type)
```

| parameter | description |
| --- | --- |
| migration | The migration reference. |
| type | The database type prefix, e.g. "SqlServer". |

## Return Value

`true` if the database type matches; otherwise, `false`.

## See Also

* class [MigrationUtils](../MigrationUtils.md)