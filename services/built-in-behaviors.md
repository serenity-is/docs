# Built-in Service Behaviors

Serenity ships a set of built-in features that are implemented as service behaviors (see [Service Behaviors](behaviors.md)). These are enabled by decorating your row or field with an attribute, or by implementing a marker interface — you only need to wire them up once, and they run for every matching request handler.

| Feature | How it's enabled | What it does |
| --- | --- | --- |
| **Insert/Update Log** | Implement `ILoggingRow` (or the insert/update log interfaces) | Fills `InsertUserId`, `InsertDate`, `UpdateUserId`, `UpdateDate` automatically |
| **Capture Log** | `[CaptureLog(typeof(LogRow))]` on the row | Writes an audit trail of who changed what, and when |
| **Localization** | `[LocalizationRow(typeof(LangRow))]` on the row | Stores per-language values in a localization table |
| **Master-Detail** | `[MasterDetailRelation("ForeignKey")]` on a `List<DetailRow>` property | Persists child rows when the parent is saved |
| **Linking Set** | `[LinkingSetRelation(typeof(LinkRow), "ThisKey", "ItemKey")]` on a `List<int>` property | Syncs a many-to-many link table when the parent is saved |
| **Unique Constraints** | `[Unique]` on a field or `[UniqueConstraint]` on the row | Checks uniqueness before save |
| **Updatable Extension** | `[UpdatableExtension("alias", typeof(ExtensionRow))]` on the row | Persists fields from a joined detail table |
| **Display Order** | Implement `IDisplayOrderRow` | Maintains an ordered list and renumbers on save/delete/undelete |
| **Parent Validation** | `IParentIdRow` on the row | Validates that a referenced parent record is not deleted |

## Insert/Update Log

The `UpdateInsertLogBehavior` automatically sets the standard audit fields on rows that implement the insert/update logging interfaces (`IInsertDateRow`, `IInsertUserIdRow`, `IUpdateDateRow`, `IUpdateUserIdRow`). [ILoggingRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/ILoggingRow.md) combines `IUpdateLogRow` and `IInsertLogRow`:

```cs
public interface ILoggingRow : IUpdateLogRow, IInsertLogRow
{
}
```

On Create, the behavior fills the insert fields (`InsertDate`, `InsertUserId`) and on Update it fills the update fields (`UpdateDate`, `UpdateUserId`). It requires no attribute — just make your row implement the relevant interface. The easiest way is to derive from the `LoggingRow<TFields>` base class in `Serenity.Extensions.Entities`:

```cs
using Serenity.Extensions.Entities;

public class MyRowFields : LoggingRowFields
{
}

public sealed class MyRow : LoggingRow<MyRowFields>, IIdRow
{
    // your own fields
}
```

The `LoggingRow` base class exposes the four audit fields (`InsertUserId`, `InsertDate`, `UpdateUserId`, `UpdateDate`) and implements `ILoggingRow` for you. You can also implement the interfaces yourself if your field names differ.

See the [Save Request Handler](save_request_handler.md) for how these fields are set in the `OnSetInternalFields` phase.

## Capture Log (Audit Trail)

The [CaptureLogAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data/CaptureLogAttribute.md) enables an audit trail: every insert/update/delete is recorded in a separate "capture log" table, including the user and the validity dates, so you can reconstruct the history of a record. The actual work is done by [CaptureLogBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/CaptureLogBehavior.md), which writes the log entries through an `ICaptureLogHandler`.

Apply it to a row that has a corresponding log row implementing [ICaptureLogRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/ICaptureLogRow.md):

```cs
[ConnectionKey("Northwind"), Module("Northwind"), TableName("Products")]
[CaptureLog(typeof(ProductLogRow))]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    // ...
}
```

The log row must implement `ICaptureLogRow`, which provides the operation type, changing user, and validity date fields:

```cs
public interface ICaptureLogRow : IIdRow
{
    EnumField<CaptureOperationType> OperationTypeField { get; }
    Field ChangingUserIdField { get; }
    DateTimeField ValidFromField { get; }
    DateTimeField ValidUntilField { get; }
}
```

`CaptureOperationType` records whether the entry is an `Insert`, `Update`, `Before` (the old value before an update), or `Delete` operation.

## Localization

The [LocalizationRowAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data/LocalizationRowAttribute.md) maps a row to a localization row that stores per-language values. The [LocalizationBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/LocalizationBehavior.md) then reads and writes the localized values automatically.

The Northwind `ProductRow` is localized along with its capture log:

```cs
[CaptureLog(typeof(ProductLogRow))]
[LocalizationRow(typeof(ProductLangRow), LocalizeListByDefault = true)]
public sealed class ProductRow : Row<ProductRow.RowFields>, IIdRow, INameRow
{
    // ...
}
```

The localization row must implement [ILocalizationRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/ILocalizationRow.md), which requires a culture ID field:

```cs
public interface ILocalizationRow : IIdRow
{
    StringField CultureIdField { get; }
}
```

Fields that are localizable are detected by `LocalizablePropertyProcessor`, which marks the corresponding form/grid properties as `Localizable`. The `LocalizeListByDefault` option makes the list handler return translated values by default (this is used by the extension packages).

## Master-Detail

The [MasterDetailRelationAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/MasterDetailRelationAttribute.md) declares a 1-N relation: the master row has a `List<DetailRow>` property, and the detail rows are inserted/updated/deleted when the master is saved. The [MasterDetailRelationBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/MasterDetailRelationBehavior.md) implements this.

The pro-features `MeetingRow` uses it for its attendee list:

```cs
[DisplayName("Attendee List")]
[MasterDetailRelation(nameof(MeetingAttendeeRow.MeetingId),
    ColumnsType = typeof(Columns.MeetingAttendeeColumns)), MeetingAttendeeEditor]
public List<MeetingAttendeeRow> AttendeeList { get => fields.AttendeeList[this]; set => fields.AttendeeList[this] = value; }
```

- `ForeignKey` (or the first argument) is the property name of the FK field in the detail table that matches the master's key.
- The detail table rows are saved through their own save handlers (the behavior resolves them via the [IDefaultHandlerFactory](../api/dotnet/Serenity.Net.Services/Serenity.Services/IDefaultHandlerFactory.md)).
- `ColumnsType`, `IncludeColumns`/`IncludeColumnNames`, `FilterField`/`FilterValue`, `CheckChangesOnUpdate`, and `ForceCascadeDelete` control which detail columns are loaded/saved and how deletes behave.

## Linking Set (Many-to-Many)

The [LinkingSetRelationAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/LinkingSetRelationAttribute.md) declares a many-to-many relation backed by a link table. The field holds a list of item IDs (e.g. `List<int>`), and the [LinkingSetRelationBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/LinkingSetRelationBehavior.md) syncs the link table when the parent is saved.

The Northwind `CustomerRow` uses it for its representatives:

```cs
[DisplayName("Representatives"), AsyncLookupEditor(typeof(EmployeeRow), Multiple = true), NotMapped]
[LinkingSetRelation(typeof(CustomerRepresentativesRow), "CustomerId", "EmployeeId")]
[MinSelectLevel(SelectLevel.Details), QuickFilter(CssClass = "hidden-xs")]
public List<int> Representatives { get => fields.Representatives[this]; set => fields.Representatives[this] = value; }
```

- `rowType` — the link row type.
- `thisKey` — the field in the link row that references the parent's ID.
- `itemKey` — the field in the link row that holds the selected item IDs.
- `FilterField`/`FilterValue`, `PreserveOrder`, `HandleEqualityFilter`, and `ForceCascadeDelete` configure the relation.

## Unique Constraints

Serenity has two ways to declare a unique constraint, both checked before save:

### Per-field `[Unique]`

[UniqueAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/UniqueAttribute.md) marks a single field as unique:

```cs
[DisplayName("Product Name"), Size(40), NotNull, Unique]
public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }
```

Options include `CheckBeforeSave`, `IgnoreDeleted`, `IgnoreNulls`, and `ErrorMessage`.

### Row-level `[UniqueConstraint]`

[UniqueConstraintAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/UniqueConstraintAttribute.md) declares a composite unique constraint across several fields:

```cs
[UniqueConstraint(nameof(FieldA), nameof(FieldB))]
public sealed class MyRow : Row<MyRow.RowFields>, IIdRow
{
    // ...
}
```

These are enforced by `UniqueFieldSaveBehavior` (field-level) and `UniqueConstraintSaveBehavior` (row-level) before the record is saved.

## Updatable Extension

The [UpdatableExtensionAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data.Mapping/UpdatableExtensionAttribute.md) lets you persist fields from a joined detail table. This is useful when a row has a one-to-one extension (e.g. `CustomerDetails`) whose fields are exposed on the row via a join. The [UpdatableExtensionBehavior](../api/dotnet/Serenity.Net.Services/Serenity.Services/UpdatableExtensionBehavior.md) implements this.

The Northwind `CustomerRow` has a full `CustomerDetails` extension:

```cs
[LeftJoin("cd", "CustomerDetails", "cd.[CustomerID] = T0.[CustomerID]",
    RowType = typeof(CustomerDetailsRow), TitlePrefix = "")]
[UpdatableExtension("cd", typeof(CustomerDetailsRow), CascadeDelete = true)]
public sealed class CustomerRow : Row<CustomerRow.RowFields>, IIdRow, INameRow
{
    // ...
}
```

- `alias` — the join alias in this row (must match the `[LeftJoin]`).
- `rowType` — the extension row type.
- `ThisKey`/`OtherKey` — override the key fields (defaults to the row's ID field).
- `FilterField`/`FilterValue` — used when the extension row has a discriminating field (e.g. an address type).
- `PresenceField`/`PresenceValue` — only insert the extension when a field equals a value.
- `CascadeDelete` — delete the extension record when the parent is deleted.

## Display Order

Rows that implement [IDisplayOrderRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IDisplayOrderRow.md) are automatically kept in order. The save/delete/undelete handlers call [DisplayOrderHelper](../api/dotnet/Serenity.Net.Services/Serenity.Data/DisplayOrderHelper.md) to assign and renumber the display order values.

```cs
public interface IDisplayOrderRow : IRow
{
    Int32Field DisplayOrderField { get; }
}
```

`DisplayOrderHelper.GetNextValue` returns the next order value for a table or group, and `ReorderValues` renumbers a group (optionally scoped by a filter). [DisplayOrderFilterHelper](../api/dotnet/Serenity.Net.Services/Serenity.Services/DisplayOrderFilterHelper.md) builds a filter that groups records by a parent ID and active state, so order values are maintained per group.

## Parent Validation

The `ValidateParentBehavior` runs as part of the save lifecycle for rows implementing [IParentIdRow](../api/dotnet/Serenity.Net.Services/Serenity.Data/IParentIdRow.md). It checks that a referenced parent record is not marked as deleted before the child is saved.

```cs
public sealed class MyRow : Row<MyRow.RowFields>, IIdRow, IParentIdRow
{
    [ForeignKey(typeof(ParentRow), LeftJoin("p")), NotNull]
    public int? ParentId { get => fields.ParentId[this]; set => fields.ParentId[this] = value; }
    // ...
}
```

## See Also

- [Service Behaviors](behaviors.md)
- [Save Request Handler](save_request_handler.md)
- [List Request Handler](list_request_handler.md)
- [Delete Request Handler](delete_request_handler.md)
- [Rows & Fields](../framework/data-access/entities.md)
- [Field Flags](../framework/data-access/field-flags.md)
- [Mapping Attributes](../framework/data-access/mapping.md)
