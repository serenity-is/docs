# UniqueAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Defines a unique constraint on the field. Sets the Unique flag and, by default, makes [`UniqueFieldSaveBehavior`](../Serenity.Services/UniqueFieldSaveBehavior.md) check the constraint before save by running an existence query, so that a user friendly validation error is returned instead of a database exception. The actual database unique index (if any) remains authoritative.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class UniqueAttribute : SetFieldFlagsAttribute
```

## Public Members

| name | description |
| --- | --- |
| [UniqueAttribute](UniqueAttribute/UniqueAttribute.md)() | Initializes a new instance of the [`UniqueAttribute`](./UniqueAttribute.md) class. |
| [CheckBeforeSave](UniqueAttribute/CheckBeforeSave.md) { get; set; } | Gets or sets a value indicating whether to check this constraint before save. |
| [DisableDefaultBehavior](UniqueAttribute/DisableDefaultBehavior.md) { get; set; } | Gets or sets a value indicating whether the default [`UniqueFieldSaveBehavior`](../Serenity.Services/UniqueFieldSaveBehavior.md) pre-check should be disabled for this field. Set to `true` if you want to replace the default behavior with your own. |
| [ErrorMessage](UniqueAttribute/ErrorMessage.md) { get; set; } | Gets or sets the error message. |
| [IgnoreDeleted](UniqueAttribute/IgnoreDeleted.md) { get; set; } | Gets or sets a value indicating whether to ignore deleted records. |
| [IgnoreNulls](UniqueAttribute/IgnoreNulls.md) { get; set; } | Gets or sets a value indicating whether to ignore null values. |
| [Name](UniqueAttribute/Name.md) { get; set; } | Gets or sets the name of the constraint. Not used. |

## Remarks

Set [`CheckBeforeSave`](./UniqueAttribute/CheckBeforeSave.md) to `false` to skip the default pre-check, or [`DisableDefaultBehavior`](./UniqueAttribute/DisableDefaultBehavior.md) to `true` to disable the default behavior entirely, e.g. when you will replace it with your own behavior (derive from [`BaseUniqueConstraintSaveBehavior`](../Serenity.Services/BaseUniqueConstraintSaveBehavior.md) or implement your own save behavior). The default pre-check query may be unscoped; override [`BuildUniqueConstraintQuery`](../Serenity.Services/BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) to add row level scoping (e.g. tenant/owner) so that it matches the actual database constraint.

## See Also

* class [SetFieldFlagsAttribute](./SetFieldFlagsAttribute.md)
* **Source:** *[UniqueAttribute.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/Data/Mapping/UniqueAttribute.cs)*