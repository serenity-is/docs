# MigrationTagUtils class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Tag matching utilities for migrations that use dimensioned tags, e.g. `db:Default` for the database a migration targets, or `env:Staging` for the environments it may run in.

```csharp
public static class MigrationTagUtils
```

## Public Members

| name | description |
| --- | --- |
| static [CreateMatcher](MigrationTagUtils/CreateMatcher.md)() | Creates a function that can be assigned to `IMigrationRunnerConventions.TypeHasMatchingTags` to match migrations by dimensions. |
| static [GetGroup](MigrationTagUtils/GetGroup.md)(…) | Gets the dimension of a tag as written, e.g. `db` for `db:Default`, `env` for `env:Staging`, and an empty string for a tag that has no dimension, e.g. `Core` or the legacy `DefaultDB`. |
| static [MatchesTags](MigrationTagUtils/MatchesTags.md)(…) | Determines whether the tags declared by a migration type match the requested tags. |

## Remarks

FluentMigrator treats all tags of a migration as a single flat set, so tags coming from different dimensions interfere with each other: a RequireAny database tag makes the migration run regardless of any RequireAll environment tag on the same class, as the two attributes are OR'ed.

This matcher groups the tags by their dimension (the part before the `:`), applies the same rule as FluentMigrator within each group, but requires all groups to match. A dimension that a migration declares must also be requested by the migration runner, otherwise the migration is skipped, which is what makes e.g. an `env:Staging` tag a real gate.

The database dimension is a partition and not a requirement: a migration matches when any of the databases it declares is requested, regardless of the TagsAttribute behavior, so a hand written `[Tags("db:Default")]` and [`TargetDBAttribute`](./TargetDBAttribute.md) behave the same, even when the runner requests several databases at once, e.g. all the connection keys that fall back to the one being migrated.

[`TargetDBAttribute`](./TargetDBAttribute.md) also declares its tag in a legacy `DatabaseKey + "DB"` form, e.g. `DefaultDB`, for migration runners that do not group tags by dimension (e.g. ones using the default FluentMigrator matching). A legacy tag is treated like its [`TagPrefix`](./TargetDBAttribute/TagPrefix.md) form, e.g. `[Tags("DefaultDB")]` like `db:Default`, but only when that database is actually requested; otherwise it stays an ordinary tag without a dimension, as it was before tags had dimensions. Tags of other dimensions, e.g. `env:BackupDB`, are never treated as database tags.

Tag comparison is case sensitive, as in FluentMigrator. See [`CreateMatcher`](./MigrationTagUtils/CreateMatcher.md) for a function that can be assigned to `IMigrationRunnerConventions.TypeHasMatchingTags`.

## See Also

* **Source:** *[MigrationTagUtils.cs](https://github.com/serenity-is/Serenity/blob/adf2390792b97eb9cd7cc6be227249ddb2b3b9d6/common-features/src/extensions/Modules/MigrationUtils/MigrationTagUtils.cs)*