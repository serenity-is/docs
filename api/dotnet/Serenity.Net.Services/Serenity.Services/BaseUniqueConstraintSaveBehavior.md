# BaseUniqueConstraintSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for unique constraint save behaviors (e.g. [`UniqueFieldSaveBehavior`](./UniqueFieldSaveBehavior.md) and [`UniqueConstraintSaveBehavior`](./UniqueConstraintSaveBehavior.md)). Contains the shared query building and validation logic, with virtual hooks so applications can customize how the pre-check query is built, for example to apply row-level (tenant/owner) scoping so the pre-check matches the actual database unique constraint.

```csharp
public abstract class BaseUniqueConstraintSaveBehavior : BaseSaveBehaviorAsync, ISaveBehaviorSync
```

## Protected Members

| name | description |
| --- | --- |
| [BaseUniqueConstraintSaveBehavior](BaseUniqueConstraintSaveBehavior/BaseUniqueConstraintSaveBehavior.md)() | The default constructor. |
| virtual [BuildUniqueConstraintQuery](BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md)(…) | Builds the query used to check the unique constraint. Override this method to customize the pre-check, for example to add row-level scoping (tenant/owner filters) so that the check matches the actual database unique constraint, or to skip the pre-check entirely. |
| virtual [ValidateUniqueConstraint](BaseUniqueConstraintSaveBehavior/ValidateUniqueConstraint.md)(…) | Validates that no record violates the unique constraint defined by the passed fields. |
| virtual [ValidateUniqueConstraintAsync](BaseUniqueConstraintSaveBehavior/ValidateUniqueConstraintAsync.md)(…) | Asynchronous version of [`ValidateUniqueConstraint`](./BaseUniqueConstraintSaveBehavior/ValidateUniqueConstraint.md). |
| static [UniqueViolation](BaseUniqueConstraintSaveBehavior/UniqueViolation.md)(…) | Creates the validation error that is thrown when a unique constraint is violated. |

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[BaseUniqueConstraintSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/842eeed9c1017bb2110e654fdf17bd169a31f7a0/src/services/RequestHandlers/IntegratedFeatures/UniqueConstraints/BaseUniqueConstraintSaveBehavior.cs)*