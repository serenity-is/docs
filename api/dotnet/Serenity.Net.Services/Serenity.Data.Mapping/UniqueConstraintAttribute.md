# UniqueConstraintAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Adds a unique constraint check to the row. By default [`UniqueConstraintSaveBehavior`](../Serenity.Services/UniqueConstraintSaveBehavior.md) checks the constraint before save by running an existence query, so that a user friendly validation error is returned instead of a database exception. The actual database unique index (if any) remains authoritative.

```csharp
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public class UniqueConstraintAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [UniqueConstraintAttribute](UniqueConstraintAttribute/UniqueConstraintAttribute.md)(…) | Initializes a new instance of the [`UniqueConstraintAttribute`](./UniqueConstraintAttribute.md) class. |
| [CheckBeforeSave](UniqueConstraintAttribute/CheckBeforeSave.md) { get; set; } | Gets or sets a value indicating whether constraint should be checked before save, default true. |
| [DisableDefaultBehavior](UniqueConstraintAttribute/DisableDefaultBehavior.md) { get; set; } | Gets or sets a value indicating whether the default [`UniqueConstraintSaveBehavior`](../Serenity.Services/UniqueConstraintSaveBehavior.md) pre-check should be disabled for this constraint. Set to `true` if you want to replace the default behavior with your own. |
| [ErrorMessage](UniqueConstraintAttribute/ErrorMessage.md) { get; set; } | Gets or sets the error message. |
| [Fields](UniqueConstraintAttribute/Fields.md) { get; } | Gets the fields. |
| [IgnoreDeleted](UniqueConstraintAttribute/IgnoreDeleted.md) { get; set; } | Gets or sets a value indicating whether to ignore deleted records while checking the constraint. |
| [Name](UniqueConstraintAttribute/Name.md) { get; set; } | Gets or sets the constraint name. Not used at the moment. |

## Remarks

Set [`CheckBeforeSave`](./UniqueConstraintAttribute/CheckBeforeSave.md) to `false` to skip the default pre-check, or [`DisableDefaultBehavior`](./UniqueConstraintAttribute/DisableDefaultBehavior.md) to `true` to disable the default behavior entirely, e.g. when you will replace it with your own behavior (derive from [`BaseUniqueConstraintSaveBehavior`](../Serenity.Services/BaseUniqueConstraintSaveBehavior.md) or implement your own save behavior). The default pre-check query may be unscoped; override [`BuildUniqueConstraintQuery`](../Serenity.Services/BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) to add row level scoping (e.g. tenant/owner) so that it matches the actual database constraint.

## See Also

* **Source:** *[UniqueConstraintAttribute.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/Data/Mapping/UniqueConstraintAttribute.cs)*