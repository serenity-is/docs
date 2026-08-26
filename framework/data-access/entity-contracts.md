# Entity Contracts

Serenity uses **marker interfaces** (contracts) to give a row special capabilities. By implementing one of these interfaces, your row tells the framework "I have an ID field", "I support soft delete", "I have logging fields", etc. — and the corresponding behaviors, handlers, and UI features activate automatically.

## Identity & Name

- [IIdRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIdRow.md) — the row has an ID field. Put `[IdProperty]` on the corresponding field. This is the most common contract; most rows implement it.
- [INameRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/INameRow.md) — the row has a name/description field. Put `[NameProperty]` on the corresponding field. Used for the row's display title and quick search.
- [IDisplayNameRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IDisplayNameRow.md) — exposes a `DisplayNameField` (a `StringField`).

```cs
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Person Id"), Identity, IdProperty]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }

    [DisplayName("Full Name"), NameProperty]
    public string FullName { get => fields.FullName[this]; set => fields.FullName[this] = value; }
}
```

## Active / Deleted (Soft Delete)

- [IIsActiveRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsActiveRow.md) — the row has an `IsActiveField` (`Int16Field`). `1` = active, `0` = inactive.
- [IIsActiveDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsActiveDeletedRow.md) — an `IIsActiveRow` where `-1` means deleted (soft delete via the active flag).
- [IIsDeletedRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IIsDeletedRow.md) — the row has an `IsDeletedField` (`BooleanField`) for soft delete.

Rows implementing these are not physically deleted — the delete handler sets the flag instead, and list queries filter out deleted rows.

## Logging Fields

- [IInsertDateRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IInsertDateRow.md) — has an `InsertDateField`.
- [IInsertUserIdRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IInsertUserIdRow.md) — has an `InsertUserIdField`.
- [IUpdateDateRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IUpdateDateRow.md) — has an `UpdateDateField`.
- [IUpdateUserIdRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IUpdateUserIdRow.md) — has an `UpdateUserIdField`.
- [IInsertLogRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IInsertLogRow.md) — combination of `IInsertDateRow` + `IInsertUserIdRow`.
- [IUpdateLogRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IUpdateLogRow.md) — combination of `IUpdateDateRow` + `IUpdateUserIdRow`.
- [ILoggingRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/ILoggingRow.md) — combination of `IUpdateLogRow` + `IInsertLogRow`. This is the one you implement for full insert/update audit logging.
- [IDeleteLogRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IDeleteLogRow.md) — has `DeleteUserIdField` and `DeleteDateField` (delete audit logging).

The `UpdateInsertLogBehavior` fills these fields automatically on save. See [Built-in Service Behaviors](../../services/built-in-behaviors.md).

## Ordering & Hierarchy

- [IDisplayOrderRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IDisplayOrderRow.md) — has a `DisplayOrderField` (`Int32Field`); the row is kept in order automatically.
- [IParentIdRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IParentIdRow.md) — has a `ParentIdField`; used for tree/hierarchical rows and parent validation.

## Other Contracts

- [IEmailRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IEmailRow.md) — exposes an `EmailField` (used by membership/account features).
- [IPasswordRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IPasswordRow.md) — exposes `PasswordHashField` and `PasswordSaltField` (used by authentication).
- [IFieldWithJoinInfo](../api/dotnet/Serenity.Net.Services/Serenity.Data/IFieldWithJoinInfo.md) — a field that exposes its referenced aliases and the row's joins (used by query building).

## How Contracts Are Used

These interfaces are what make the framework's conventions work:

- **Request handlers** check for `IIdRow` to know the ID field, `INameRow` for the name field, `IIsActiveRow`/`IIsDeletedRow` for soft delete, `ILoggingRow` for audit fields.
- **Behaviors** activate based on these interfaces (e.g. `CaptureLogBehavior` requires `IIdRow`; `UpdateInsertLogBehavior` activates for logging rows).
- **The UI** uses `IIdRow`/`INameRow` for dialog titles, quick search, and lookup scripts.

Implementing a contract is usually just adding the interface to the row declaration and marking the corresponding field with the matching attribute (`[IdProperty]`, `[NameProperty]`, etc.).

## See Also

- [Entities (Rows)](entities.md)
- [Row Fields](row-fields.md)
- [Field Types](field-types.md)
- [Built-in Service Behaviors](../../services/built-in-behaviors.md)
- [Mapping](mapping.md)