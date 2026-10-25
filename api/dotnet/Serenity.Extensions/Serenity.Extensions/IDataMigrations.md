# IDataMigrations interface
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Applies the migrations of the application. Implemented by the project template (`AppServices.DataMigrations`) and resolved by [`RunMigrationsIf`](./HostMigrationExtensions/RunMigrationsIf.md) for the `migrate` command, and by `Startup` on every normal start.

```csharp
public interface IDataMigrations
```

## Members

| name | description |
| --- | --- |
| [Initialize](IDataMigrations/Initialize.md)() | Ensures the databases exist and applies any pending migrations. |

## Remarks

Lives next to [`MigrationUtils`](./MigrationUtils.md) so that a host can offer the command without knowing the application assembly, and so the Serene and StartSharp templates share one definition instead of each shipping its own copy.

## See Also

* **Source:** *[IDataMigrations.cs](https://github.com/serenity-is/Serenity/blob/88446beca303039b3d0ead2e38f6c3b940c9df86/common-features/src/extensions/Modules/MigrationUtils/IDataMigrations.cs)*