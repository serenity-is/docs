# SqlErrorConstraintType enumeration
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Type of a database constraint violation.

```csharp
public enum SqlErrorConstraintType
```

## Values

| name | value | description |
| --- | --- | --- |
| PrimaryKey | `0` | A primary key violation. |
| Unique | `1` | A unique constraint or unique index violation. |
| ForeignKey | `2` | A foreign key violation. |
| NotNull | `3` | A not null constraint violation. |

## See Also

* **Source:** *[SqlErrorConstraintType.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/SqlErrorConstraintType.cs)*