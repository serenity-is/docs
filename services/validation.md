# Validation

Serenity's request handlers validate incoming data automatically before any
record is inserted, updated, deleted, or undeleted. The validation pipeline
checks permissions, editable fields, required fields, and any custom validators
you attach to fields, then reports failures back to the client as a
[`ValidationError`](../api/dotnet/Serenity.Net.Core/Serenity.Services/ValidationError.md)
wrapped in a `ServiceError` response.

For most entities you never write validation code — the `[NotNull]`, `[Size]`,
and field-permission attributes on your row already drive the checks. (The
`[Required]` attribute is a form-level marker that makes a field required in the
UI; the server-side required check is driven by `[NotNull]`.) You add custom
validation when a rule can't be expressed with attributes, e.g. "start date must
be before end date" or "this code must be unique within the tenant".

## The validation pipeline

Validation runs inside `SaveRequestHandler.ValidateRequest()` (and the matching
methods of the delete/undelete/retrieve handlers). For a save, the steps are:

1. **`ValidatePermissions()`** — checks the row's insert/update permission and
   any `[AuthorizeCreate]` / `[AuthorizeUpdate]` attributes.
2. **`ValidateEditable()`** — builds the set of editable fields (those with the
   `Insertable`/`Updatable` flag and whose field-level insert/update permission
   the current user has), auto-trims string values, and rejects assignments to
   non-editable fields.
3. **`ValidateRequired()`** — checks that required fields have values.
4. **`ValidateIsActive()`** — on update, verifies the record isn't soft-deleted.
5. **`ValidateFieldValues()`** — runs every [`ICustomValidator`](../api/dotnet/Serenity.Net.Services/Serenity/ICustomValidator.md)
   attached to an assigned field.
6. **Behaviors' `OnValidateRequest()`** — every attached save behavior gets a
   chance to validate (e.g. `ValidateParentBehavior`).

You can override `OnValidateRequest()` in your own save handler to add
handler-specific checks, or implement a save behavior for cross-cutting rules
(see [Service Behaviors](behaviors.md)).

## Required fields

A field is *required* when it has the `[NotNull]` attribute (which sets
`FieldFlags.NotNull`) and is not `[TrimToEmpty]`. `GetRequiredFields()` collects
those fields from the editable set, and the handler then calls
[`DataValidation.ValidateRequired`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DataValidation.md)
on create, or `ValidateRequiredIfModified` on update (so an existing record can
be saved without re-supplying unchanged required values).

A missing required value throws a `ValidationError` with error code `Required`
and the localized message `"{0} field is required!"`.

## Custom validators (`ICustomValidator`)

[`ICustomValidator`](../api/dotnet/Serenity.Net.Services/Serenity/ICustomValidator.md)
is the extension point for per-field validation. It is a single-method
interface:

```cs
public interface ICustomValidator
{
    string Validate(IValidationContext context);
}
```

`Validate` returns `null` when the value is valid, or a localized error message
when it isn't. The handler throws a `ValidationError` with error code
`CustomValidationError` and the field name as its arguments.

### Applying a validator to a field

`ICustomValidator` is designed to be implemented by an attribute class, which is
then applied to a row field. Serenity's own
[`EmailEditorAttribute`](../api/dotnet/Serenity.Net.Web/Serenity.ComponentModel/EmailEditorAttribute.md)
is a real example — it is both an editor attribute and a validator:

```cs
public partial class EmailEditorAttribute : CustomEditorAttribute, ICustomValidator
{
    public string Validate(IValidationContext context)
    {
        if (context.Value == null)
            return null;

        var value = context.Value.ToString();

        if (!EmailPattern.IsMatch(value))
            return Web.FormValidationTexts.Email.ToString(context.Localizer);

        return null;
    }
}
```

Applied to a row field, the same attribute drives both the editor used in forms
and the server-side validation on save:

```cs
[EmailEditor]
public class EmailField : StringField { }
```

### The validation context

`Validate` receives an
[`IValidationContext`](../api/dotnet/Serenity.Net.Services/Serenity/IValidationContext.md).
For rows, the handler passes a
[`RowValidationContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/RowValidationContext.md):

| Member | Purpose |
| --- | --- |
| `Value` | The value of the field being validated |
| `GetFieldValue(fieldName)` | Read another field's value from the same row (by property or field name) |
| `Connection` | The current `IDbConnection` (for database lookups, e.g. uniqueness checks) |
| `Localizer` | The `ITextLocalizer` for translating error messages |

A validator that checks a date range across two fields:

```cs
public class ValidDateRangeAttribute : Attribute, ICustomValidator
{
    public string Validate(IValidationContext context)
    {
        var start = context.GetFieldValue("StartDate") as DateTime?;
        var finish = context.GetFieldValue("FinishDate") as DateTime?;

        if (start.HasValue && finish.HasValue && start > finish)
            return "Start date can't be after finish date!";

        return null;
    }
}
```

## The `DataValidation` helper

[`DataValidation`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DataValidation.md)
is a static helper used by handlers and behaviors for common checks and for
building `ValidationError`s with the standard localized messages (from
[`DataValidationTexts`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DataValidationTexts.md),
all under the `Validation.` local text prefix):

| Method | Purpose |
| --- | --- |
| `ValidateRequired` / `ValidateRequiredIfModified` | Required-field checks |
| `ValidateEnum` | Value is one of the enum's defined members |
| `ValidateDateRange` | Start date is not after finish date |
| `AutoTrim` | Trim string fields per `FieldFlags.Trim` / `TrimToEmpty` |
| `EnsureUniversalTime` | Convert a `DateTimeField` value to UTC |
| `RequiredError`, `InvalidValueError`, `InvalidIdError`, `InvalidDateRangeError`, `ReadOnlyError` | Build the corresponding `ValidationError` |
| `EntityNotFoundError`, `EntityReadAccessError`, `EntityWriteAccessError`, `RelatedRecordExist`, `ParentRecordDeleted`, `RecordNotActive`, `UnexpectedError` | Build errors used by handlers/behaviors |

## `ValidationError` and the client response

[`ValidationError`](../api/dotnet/Serenity.Net.Core/Serenity.Services/ValidationError.md)
is the exception thrown for any validation failure. Besides the message it
carries:

- `ErrorCode` — a stable code such as `Required`, `InvalidValue`,
  `CustomValidationError`, `EntityNotFound`, `RecordNotActive`, etc.
- `Arguments` — usually the field name the error relates to.
- `IsSensitiveMessage` — `false` by default, meaning the message is safe to show
  to end users.

When a service endpoint catches a `ValidationError`, it converts it to a
[`ServiceError`](../api/dotnet/Serenity.Net.Services/Serenity.Services/ServiceError.md)
(`Code`, `Arguments`, `Message`, `Details`, `ErrorId`) and returns it in the
response with **HTTP 400**. Other exceptions become HTTP 500 with a generic
message (unless details are enabled). The client-side `ServiceGrid`/`ServiceDialog`
base classes read the `Error` object and display the message, highlighting the
field named in `Arguments` when possible.

## `ValidateParentBehavior`

[`ValidateParentBehavior`](../api/dotnet/Serenity.Net.Services/Serenity.Services/ValidateParentBehavior.md)
is a built-in save behavior that runs for rows implementing
[`IParentIdRow`](../api/dotnet/Serenity.Net.Services/Serenity.Data/IParentIdRow.md)
(a `ParentId` field with a `[ForeignKey]`). When the parent record is
soft-deleted, saving the child throws a `ParentRecordDeleted` validation error.
It is registered automatically with the other built-in behaviors.

## Where to put custom validation

| Approach | When to use |
| --- | --- |
| `ICustomValidator` attribute on a field | A rule tied to one field's value (possibly reading other fields via `GetFieldValue`) |
| Override `OnValidateRequest()` in the save handler | A rule specific to one entity's save flow |
| A save behavior's `OnValidateRequest` | A cross-cutting rule that applies to many entities |

## See Also

- [Save Request Handler](save_request_handler.md)
- [Service Behaviors](behaviors.md)
- [Built-in Service Behaviors](built-in-behaviors.md)
- [Service Endpoints](service_endpoints.md)
- [Entity Contracts](framework/data-access/entity-contracts.md) — `IParentIdRow`, `IIsActiveRow`, etc.
- [Mapping](framework/data-access/mapping.md) — `[NotNull]`, `[Size]`, field permissions
- API reference: [`ICustomValidator`](../api/dotnet/Serenity.Net.Services/Serenity/ICustomValidator.md),
  [`IValidationContext`](../api/dotnet/Serenity.Net.Services/Serenity/IValidationContext.md),
  [`RowValidationContext`](../api/dotnet/Serenity.Net.Services/Serenity.Services/RowValidationContext.md),
  [`DataValidation`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DataValidation.md),
  [`ValidationError`](../api/dotnet/Serenity.Net.Core/Serenity.Services/ValidationError.md),
  [`ServiceError`](../api/dotnet/Serenity.Net.Services/Serenity.Services/ServiceError.md)