# SqlErrorValidationTexts class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Validation error texts for database constraint violations.

```csharp
public static class SqlErrorValidationTexts
```

## Public Members

| name | description |
| --- | --- |
| static readonly [DeleteForeignKeyError](SqlErrorValidationTexts/DeleteForeignKeyError.md) | Text for a foreign key violation that occurs while deleting a record, when the referencing table is known. |
| static readonly [DeleteForeignKeyErrorGeneric](SqlErrorValidationTexts/DeleteForeignKeyErrorGeneric.md) | Text for a foreign key violation that occurs while deleting a record, when the referencing table is not known. |
| static readonly [SaveForeignKeyError](SqlErrorValidationTexts/SaveForeignKeyError.md) | Text for a foreign key violation that occurs while saving a record, when the referenced table is known. |
| static readonly [SaveForeignKeyErrorGeneric](SqlErrorValidationTexts/SaveForeignKeyErrorGeneric.md) | Text for a foreign key violation that occurs while saving a record, when the referenced table is not known. |
| static readonly [SavePrimaryKeyError](SqlErrorValidationTexts/SavePrimaryKeyError.md) | Text for a primary key or unique constraint violation while saving a record, when the field is known. |
| static readonly [SavePrimaryKeyErrorGeneric](SqlErrorValidationTexts/SavePrimaryKeyErrorGeneric.md) | Text for a primary key or unique constraint violation while saving a record, when the field is not known. |

## See Also

* **Source:** *[SqlErrorValidationTexts.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/SqlErrorValidationTexts.cs)*