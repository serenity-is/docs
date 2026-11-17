# Validation

Serenity's request handlers validate incoming data automatically before any
record is inserted, updated, deleted, or undeleted. The validation pipeline
checks permissions, editable fields, required fields, the validation rules of
the fields, and optionally the rules of a form, then reports failures back to
the client as a
[`ValidationError`](../api/dotnet/Serenity.Net.Core/Serenity.Services/ValidationError.md)
wrapped in a `ServiceError` response.

For most entities you never write validation code — the `[NotNull]`, `[Size]`,
and field-permission attributes on your row already drive the checks. (The
`[Required]` attribute is a form-level marker that makes a field required in the
UI; the server-side required check is driven by `[NotNull]`.) You add custom
validation when a rule can't be expressed with attributes, e.g. "start date must
be before end date" or "this code must be unique within the tenant".

> From 10.7.0, the server and the forms check the **same** validation rules: the
> constraints of a property are declared once, enforced in the browser and in
> the save handlers, and share the same localized messages. See
> [Unified validation rules](#unified-validation-rules).

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
5. **`ValidateFieldValues()`** — checks the value of every assigned field by the
   `ValidationAttribute`s of its property (and the ones its other attributes
   imply), e.g. `[ValidateRange]`. Asynchronous handlers await rules that
   implement `IAsyncValidationRule` instead.
6. **`ValidateRequiredWhen()`** — checks the fields made required by their
   [`[RequiredWhen]`](#conditional-fields-requiredwhen) conditions.
7. **`ValidateForm(formType)`** — when the handler or the row has a
   [`[FormValidation]`](#validating-what-the-form-checks) attribute, checks the
   row by that form's rules, e.g. the form-only `[Required]` fields and the
   rules of its properties.
8. **Behaviors' `OnValidateRequest()`** — every attached save behavior gets a
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

## Unified validation rules

> **Breaking change in 10.7.0:** `ICustomValidator`, `IValidationContext` / `RowValidationContext` were **removed**.
> Validation is now based on DataAnnotations: a property's rules are its `ValidationAttribute`s, checked by
> [`ValidationRules`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ValidationRules.md)
> (`ObjectValidator` internally), and the rules you want the browser to check as well
> implement `IClientValidationRule`.

Validation rules are the `System.ComponentModel.DataAnnotations.ValidationAttribute`s
of a property, plus the ones its other attributes *imply* (see
`IImpliesValidation`, e.g. an editor attribute that implies an email check).
[`ValidationRules`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ValidationRules.md)
is the static helper that finds and checks them:

| Member | Purpose |
| --- | --- |
| `GetRules(attributes)` | The rules among a property's attributes, including implied ones |
| `Validate(rule, value, context)` | Checks a value by one rule, returning the message or `null` |
| `ValidateAsync(...)` | The same, awaiting rules implementing `IAsyncValidationRule` |
| `ValidateObject(obj, options)` / `ValidateObjectAsync(...)` | Checks a whole object (e.g. a row by a form) and returns the first `ObjectValidationFailure` |
| `GetTextKeySuffix(rule)` | The suffix of the implied text key of a rule's message, e.g. `_ValidateRange` |

### The `Validate*` attributes

The `Serenity.ComponentModel` namespace ships attributes that mirror the
DataAnnotations ones, but also describe themselves to the client
(`IClientValidationRule`), so the same attribute is enforced by the forms and by
the save handlers:

| Attribute | Derives from | Client rule | Implied message key |
| --- | --- | --- | --- |
| `ValidateRange` | `RangeAttribute` | `Serenity.RangeValidationRule` | `Field_ValidateRange` |
| `ValidateLength` | `StringLengthAttribute` | `Serenity.LengthValidationRule` | `Field_ValidateLength` |
| `ValidatePattern` | `RegularExpressionAttribute` | `Serenity.PatternValidationRule` | `Field_ValidatePattern` |
| `ValidateEmail` | `DataTypeAttribute` (EmailAddress) | `Serenity.EmailValidationRule` | `Field_ValidateEmail` |
| `ValidateUrl` | `DataTypeAttribute` (Url) | `Serenity.UrlValidationRule` | `Field_ValidateUrl` |
| `ValidateCompare` | `CompareAttribute` | `Serenity.CompareValidationRule` | `Field_ValidateCompare` |

```cs
public class OrderForm
{
    [ValidateRange(1, 100)]
    public int? Quantity { get; set; }

    [ValidateLength(6, 20), ValidatePattern("[A-Z0-9-]+")]
    public string? Code { get; set; }

    [ValidateEmail, TextKey("MyApp.Validation.Email")]
    public string? Email { get; set; }
}
```

- An **empty value is always valid**; being required is `[Required]`'s concern.
- `ValidatePattern` matches the **whole** text with ECMAScript semantics (as the
  browsers do), so avoid named groups or lookbehinds in the expression.
- The range limits are parsed and a text value is converted in the **invariant**
  culture.
- Messages are localized by an **implied key**: the text key of the property plus
  the attribute name, e.g. `Db.Northwind.Customer.Quantity_ValidateRange` for a
  form field `Quantity` of `CustomerForm`. The order is an explicit `TextKey`,
  then the implied key, then a plain `ErrorMessage`, then the default
  `Validation.*` text.

### Custom rules (`ValidationRuleAttribute`)

[`ValidationRuleAttribute`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ValidationRuleAttribute.md)
is the base of a custom rule that the forms also check. Its client-side class is
found by a type key, given to its constructor (usually a `Key` constant), or by
the convention `ValidateEvenAttribute` → `MyApp.EvenValidationRule`:

```cs
public class ValidateEvenAttribute() : ValidationRuleAttribute(Key)
{
    public const string Key = "MyApp.EvenValidationRule";

    protected override string DefaultTextKey => "Validation.Even";

    protected override bool IsValidValue(object? value, ValidationContext context) =>
        Convert.ToInt64(value, CultureInfo.InvariantCulture) % 2 == 0;
}
```

The server typings generator imports that class into the forms that have the
rule, and a rule class implementing `LazyLoadInclude` can be loaded on demand
instead. The client side class derives from `ValidationRule` and is registered by
its key:

```ts
export class EvenValidationRule extends ValidationRule implements LazyLoadInclude {
    static override [Symbol.typeInfo] = this.registerRule("MyApp.");
    override textKey = "Validation.Even";
    override defaultText = "Please enter an even number.";

    check(value: any) { return Number(value) % 2 === 0; }
}
```

- A rule that needs to wait (a query, for instance) overrides
  `IsValidValueAsync` (`IAsyncValidationRule`), which asynchronous save handlers
  await while synchronous callers still use the synchronous check.
- `ValidationSide` (`Both`, `Client`, `Server`) chooses where a rule is checked.
  The default is both.
- A rule can't be repeated on a property, since its implied text key and client
  rule would collide. A derived class with `AllowMultiple = true` gets a key that
  also has the rule name (`Field_ValidateClient_even`).

### The validation context

Rules are checked in a DataAnnotations
`System.ComponentModel.DataAnnotations.ValidationContext`, whose
`ObjectInstance` is the row and whose `MemberName` is the field's property name.
The save handler fills its services so a rule can reach what it needs:

| Extension | Returns |
| --- | --- |
| `context.GetConnection()` | The connection, in the handler's transaction (for uniqueness checks) |
| `context.GetLocalizer()` | The `ITextLocalizer` for the messages |
| `context.GetPropertyValue(name)` | The value of another property of the row, for cross-field rules |
| `context.GetService(typeof(...))` | `IUnitOfWork`, `IRequestContext`, `ISaveRequestHandler`, then the request's service provider |

A rule that checks a date range across two fields still works the same way:

```cs
public class ValidDateRangeAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext context)
    {
        var start = context.GetPropertyValue("StartDate") as DateTime?;
        var finish = context.GetPropertyValue("FinishDate") as DateTime?;

        if (start.HasValue && finish.HasValue && start > finish)
            return new ValidationResult("Start date can't be after finish date!");

        return ValidationResult.Success;
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

## Conditional fields (`[RequiredWhen]`)

The conditions described in [Conditional Form Fields](../framework/forms-editors.md#conditional-fields)
are enforced on the server for the one that matters to data integrity:
`[RequiredWhen]` is checked by `ValidateRequiredWhen()`, on create and on update
(reading the old values of the fields the request doesn't contain). Note that a
condition is **not a security boundary** — a field hidden or read-only by a
condition can still be sent, so permissions and the service decide what is
saved.

## Validating what the form checks

A row field's `[Required]` attribute only makes a field required in the UI, and
rules declared only on a form are invisible to the handlers. Add
[`FormValidation`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FormValidationAttribute.md)
to make a save handler also check the row by a form's rules — the form's
`[Required]`s, `[RequiredWhen]`s and validation rules, skipping the fields the
form hides or makes read only, like the browser does:

```cs
[FormValidation(typeof(OrderForm))]
public class OrderSaveHandler(IRequestContext context) : SaveRequestHandlerAsync<OrderRow>(context)
{
}
```

- The attribute can be on the handler or on the row (for the handlers that have
  none). A handler with more than one form can choose one by overriding
  `GetValidationForm()`.
- On update only the fields in the request are checked, with the conditions
  reading the old values of the others.
- `ValidationRules.ValidateObject(row, options)` does the same directly, with
  `ObjectValidationOptions` (`RulesType`, `Services`, `IsInsert`,
  `IncludeProperty`, `GetValue`, `CheckRules`, `CheckRequiredAttribute`,
  `TextKeyPrefix`).

A failed rule is reported as a `ValidationError` with the code
`CustomValidationError`, the field name as its arguments, and the localized
message (a missing value is reported like any required field). So the client can
highlight the field the same way, whatever side caught the error.

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

## Localized SQL Constraint Violations

Database constraint violations (unique, foreign key, not null, primary key) are
converted to localized validation errors instead of leaking provider exceptions
as server errors, for SQL Server, PostgreSQL, MySQL, Oracle, Firebird and
SQLite:

- [ISqlErrorExtractor](../api/dotnet/Serenity.Net.Services/Serenity.Services.SqlErrors/ISqlErrorExtractor.md) /
  [DefaultSqlErrorExtractor](../api/dotnet/Serenity.Net.Services/Serenity.Services.SqlErrors/DefaultSqlErrorExtractor.md)
  recognize the violations from error numbers, SQL states and messages — without
  taking a direct dependency on any provider package.
- [HumanizeSqlExceptionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services.SqlErrors/HumanizeSqlExceptionBehavior.md)
  is an implicit save/delete/undelete behavior that converts recognized
  violations into `ValidationError`s, using the messages in
  [SqlErrorValidationTexts](../api/dotnet/Serenity.Net.Services/Serenity.Services.SqlErrors/SqlErrorValidationTexts.md)
  (under the `services.texts.*` local text prefixes, plus generic messages when
  table/column names are unknown).

The unique pre-check logic shared by [`[Unique]` and `[UniqueConstraint]`](built-in-behaviors.md#unique-constraints)
lives in [BaseUniqueConstraintSaveBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/BaseUniqueConstraintSaveBehavior.md)
with virtual query building (`BuildUniqueConstraintQuery`), so applications can
scope or replace it — for example to apply row-level (tenant/owner) scoping so
the pre-check matches the actual database constraint. `[Unique]` and
`[UniqueConstraint]` accept a `DisableDefaultBehavior` option to opt out of
the default behavior entirely (e.g. when you replace it with your own).

## Where to put custom validation

| Approach | When to use |
| --- | --- |
| `Validate*` attribute on a field | A common constraint (range, length, pattern, email, url, compare) the browser should check too |
| `ValidationRuleAttribute` on a field | A custom rule the browser should check, with a client-side `ValidationRule` class |
| Plain `ValidationAttribute` on a field | A server-only rule, e.g. one that needs the database |
| `[FormValidation(typeof(MyForm))]` | The same rules as the form, including form-only required fields |
| Override `OnValidateRequest()` in the save handler | A rule specific to one entity's save flow |
| A save behavior's `OnValidateRequest` | A cross-cutting rule that applies to many entities |

## See Also

- [Save Request Handler](save_request_handler.md)
- [Service Behaviors](behaviors.md)
- [Built-in Service Behaviors](built-in-behaviors.md)
- [Service Endpoints](service_endpoints.md)
- [Entity Contracts](../framework/data-access/entity-contracts.md) — `IParentIdRow`, `IIsActiveRow`, etc.
- [Mapping](../framework/data-access/mapping.md) — `[NotNull]`, `[Size]`, field permissions
- [Property Items & Metadata](../framework/property-items.md) — how rules and conditions reach the forms
- API reference: [`ValidationRuleAttribute`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ValidationRuleAttribute.md),
  [`ValidationRules`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ValidationRules.md),
  [`FormValidationAttribute`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FormValidationAttribute.md),
  [`ObjectValidationOptions`](../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/ObjectValidationOptions.md),
  [`DataValidation`](../api/dotnet/Serenity.Net.Services/Serenity.Services/DataValidation.md),
  [`ValidationError`](../api/dotnet/Serenity.Net.Core/Serenity.Services/ValidationError.md),
  [`ServiceError`](../api/dotnet/Serenity.Net.Services/Serenity.Services/ServiceError.md)