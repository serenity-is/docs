# HostMigrationExtensions class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Helper methods for app host migration commands, e.g. "migrate" to run database migrations before starting the app.

```csharp
public static class HostMigrationExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [RunMigrationsIf](HostMigrationExtensions/RunMigrationsIf.md)(…) | Runs [`Initialize`](./IDataMigrations/Initialize.md) when the first argument is "migrate". |
| static [RunMigrationsIf&lt;TService&gt;](HostMigrationExtensions/RunMigrationsIf.md)(…) | Runs the migrations via the provided runner when the first argument is "migrate". |

## See Also

* **Source:** *[HostMigrationExtensions.cs](https://github.com/serenity-is/Serenity/blob/88446beca303039b3d0ead2e38f6c3b940c9df86/common-features/src/extensions/Modules/MigrationUtils/HostMigrationExtensions.cs)*