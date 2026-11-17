# TargetDBAttribute class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Marks a migration to run only on the specified database type.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true)]
public class TargetDBAttribute : TagsAttribute
```

## Public Members

| name | description |
| --- | --- |
| [TargetDBAttribute](TargetDBAttribute/TargetDBAttribute.md)(…) | Marks a migration to run only on the specified database type. |
| [DatabaseKey](TargetDBAttribute/DatabaseKey.md) { get; } | The connection key of the database this migration targets. |
| const [TagPrefix](TargetDBAttribute/TagPrefix.md) | The prefix used for database tags, e.g. `db:Default` for the `Default` connection. |
| static [GetTag](TargetDBAttribute/GetTag.md)(…) | Returns the tag for the specified database key. |

## Remarks

Both the [`TagPrefix`](./TargetDBAttribute/TagPrefix.md) and a legacy `DatabaseKey + "DB"` form of the tag are declared, so data migrations that still generate the requested tags in the legacy form (e.g. `DefaultDB`) keep matching. As TagsAttribute is applied once and the behavior is RequireAny, the extra tag cannot restrict matching for runners that do not group tags by dimension.

## See Also

* **Source:** *[TargetDBAttribute.cs](https://github.com/serenity-is/Serenity/blob/adf2390792b97eb9cd7cc6be227249ddb2b3b9d6/common-features/src/extensions/Modules/MigrationUtils/TargetDBAttribute.cs)*