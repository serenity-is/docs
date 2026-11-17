# MigrationTagUtils.MatchesTags method

Determines whether the tags declared by a migration type match the requested tags.

```csharp
public static bool MatchesTags(Type type, IEnumerable<string>? requestedTags)
```

| parameter | description |
| --- | --- |
| type | The migration type. |
| requestedTags | The tags passed to the migration runner, e.g. `db:Default`. |

## Return Value

`true` if the type matches the requested tags.

## Remarks

A type without any TagsAttribute always returns `false`, even if no tags are requested, so it is up to the caller (e.g. `IncludeUntaggedMigrations`) to decide whether untagged migrations should run.

## See Also

* class [MigrationTagUtils](../MigrationTagUtils.md)