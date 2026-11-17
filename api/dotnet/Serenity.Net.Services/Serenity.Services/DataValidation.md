# DataValidation class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains validation related helper methods for service handlers

```csharp
public static class DataValidation
```

## Public Members

| name | description |
| --- | --- |
| static [ArgumentNull](DataValidation/ArgumentNull.md)(…) | Returns an argument null error. |
| static [ArgumentOutOfRange](DataValidation/ArgumentOutOfRange.md)(…) | Returns an argument out of range error. |
| static [AutoTrim](DataValidation/AutoTrim.md)(…) | Automatically trims a string field value based on its TrimToEmpty and Trim flags. |
| static [ConcurrencyConflictError](DataValidation/ConcurrencyConflictError.md)(…) | Returns a concurrency conflict error, e.g. the record was modified by another user since the version value the client sent. |
| static [EnsureUniversalTime](DataValidation/EnsureUniversalTime.md)(…) | Converts the field value to universal time |
| static [EntityNotFoundError](DataValidation/EntityNotFoundError.md)(…) | Returns an entity not found error |
| static [EntityReadAccessError](DataValidation/EntityReadAccessError.md)(…) | Returns an entity read access error |
| static [EntityWriteAccessError](DataValidation/EntityWriteAccessError.md)(…) | Returns an entity write access error |
| static [GetEntitySingular](DataValidation/GetEntitySingular.md)(…) | Gets singular entity name for a table |
| static [InvalidDateRangeError](DataValidation/InvalidDateRangeError.md)(…) | Returns an invalid date range error |
| static [InvalidIdError](DataValidation/InvalidIdError.md)(…) | Returns a Invalid ID error (2 methods) |
| static [InvalidValueError](DataValidation/InvalidValueError.md)(…) | Returns an invalid value error. (2 methods) |
| static [ObjectValidationError](DataValidation/ObjectValidationError.md)(…) | Gets the error of a property of an object that is not valid: a required error for a missing value, with the title of the property, else the message of the rule it is not valid by. |
| static [ParentRecordDeleted](DataValidation/ParentRecordDeleted.md)(…) | Returns a parent record deleted error |
| static [ReadOnlyError](DataValidation/ReadOnlyError.md)(…) | Returns a field is readonly error |
| static [RecordNotActive](DataValidation/RecordNotActive.md)(…) | Returns a record not active error |
| static [RelatedRecordExist](DataValidation/RelatedRecordExist.md)(…) | Returns a related record exist error. |
| static [RequiredError](DataValidation/RequiredError.md)(…) | Returns a required validation error (2 methods) |
| static [UnexpectedError](DataValidation/UnexpectedError.md)(…) | Returns an unexpected error |
| static [ValidateDateRange](DataValidation/ValidateDateRange.md)(…) | Validates date range is valid, e.g. start date is before end date etc. |
| static [ValidateEnum](DataValidation/ValidateEnum.md)(…) | Validates enum is within allowed values, e.g. one its members |
| static [ValidateEnum&lt;T&gt;](DataValidation/ValidateEnum.md)(…) | Validates enum is within allowed values, e.g. one of its members (2 methods) |
| static [ValidateObject](DataValidation/ValidateObject.md)(…) | Validates an object, e.g. the options of a service that is not a row, see ObjectValidationOptions). |
| static [ValidateObjectAsync](DataValidation/ValidateObjectAsync.md)(…) | Validates an object, like [`ValidateObject`](./DataValidation/ValidateObject.md), awaiting the rules that can be checked asynchronously. |
| static [ValidateRequired](DataValidation/ValidateRequired.md)(…) | Validates that the field does not contain a null value or an empty string. (2 methods) |
| static [ValidateRequiredIfModified](DataValidation/ValidateRequiredIfModified.md)(…) | Validates that field values does not contain a null or empty string if the field is assigned |

## See Also

* **Source:** *[DataValidation.cs](https://github.com/serenity-is/Serenity/blob/b1dab073ad31646cd015787ead45f6004717e72a/src/services/RequestHandlers/IntegratedFeatures/Validation/DataValidation.cs)*