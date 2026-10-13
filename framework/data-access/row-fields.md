# Row Fields

Every row has a nested `RowFields` class that holds its field objects and table metadata. This page covers how that fields collection works and how it's resolved.

## `RowFieldsBase`

[RowFieldsBase](../api/dotnet/Serenity.Net.Services/Serenity.Data/RowFieldsBase.md) is the base class for a row's fields collection. It's a `Collection<Field>` that also implements `IAlias` and `IHaveJoins`, so it carries:

- **Table metadata** — the table name, schema, connection key, and the default alias (`T0`).
- **Field lookup** — fields are indexed by name and property name, so they can be found quickly.
- **Joins** — the joins declared on the row (via `[LeftJoin]`, `[InnerJoin]`, etc.).
- **Special fields** — the ID field, primary keys, and name field.
- **Local text prefix** — derived from the module/namespace.
- **Row factory** — creates a new row instance of the declaring row type.

The `RowFields` class is created automatically by the framework. When you declare a row:

```cs
public sealed class SimpleRow : Row<SimpleRow.RowFields>
{
    public string? Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField Name = null!;
    }
}
```

The framework matches the `Name` field to the `Name` property by name, and initializes the field objects. The `RowFields` constructor determines the table name (from `[TableName]` or the row class name), the connection key (from `[ConnectionKey]`), the local text prefix, and creates the field objects via `CreateGeneratedFields()`.

## The `T0` Alias

`RowFieldsBase` assigns the default alias `T0` to the row's own table. When you write queries, `T0` refers to the main table, and joined tables use their declared aliases (e.g. `sup`, `cat`). See [Fluent SQL](fluent-sql.md) and [Mapping](mapping.md).

## Resolving Fields

The fields instance for a row type is resolved through [IRowFieldsProvider](../api/dotnet/Serenity.Net.Services/Serenity.Data/IRowFieldsProvider.md):

```cs
public interface IRowFieldsProvider
{
    RowFieldsBase Resolve(Type fieldsType);
    RowFieldsBase ResolveWithAlias(Type fieldsType, string alias);
}
```

- `Resolve(fieldsType)` — returns the (cached) fields instance for a fields type.
- `ResolveWithAlias(fieldsType, alias)` — returns a fields instance with a different alias applied (used when a row is queried under a non-`T0` alias).

### `DefaultRowFieldsProvider`

[DefaultRowFieldsProvider](../api/dotnet/Serenity.Net.Services/Serenity.Data/DefaultRowFieldsProvider.md) is the default implementation. It creates fields instances through the DI container (`ActivatorUtilities.CreateInstance`), caches them per type (and per type+alias), and initializes them:

- Applies annotation types for the row (via `IAnnotationTypeRegistry`).
- Determines the SQL dialect from the connection string.
- Calls `fields.Initialize(annotations, dialect)`.
- Applies the alias and locks it.

### `FallbackRowFieldsProvider`

[FallbackRowFieldsProvider](../api/dotnet/Serenity.Net.Services/Serenity.Data/FallbackRowFieldsProvider.md) is a fallback that creates fields instances without DI (used in contexts where the service provider isn't available, e.g. in the code generator).

## Sensitive Field Protection

A forgotten `[MinSelectLevel(SelectLevel.Never)]`, `[Insertable(false)]` or `[Updatable(false)]` annotation could leak secrets (password hashes, tokens, API keys) in retrieve/list responses, or allow clients to mass assign them. To prevent this, `RowFieldsBase` detects fields whose property or column names look sensitive (password hash/salt, secrets, API keys, tokens, 2FA data, connection strings, etc.) and synthesizes the following attributes automatically, **only when the matching attribute was not set explicitly**, so you can still override them:

- `MinSelectLevel(SelectLevel.Never)` — the field is never selected
- `Sortable(false)`
- `Filterable(false)`
- For mapped (table) columns only: `Insertable(false)` and `Updatable(false)`

The synthesized attributes are appended to the field's `CustomAttributes`, so the behavior is visible in metadata. `NotMapped` sensitive fields (e.g. password input properties) stay insertable and updatable, as they never reach the database.

Fields implementing `IPasswordRow` (hash/salt) are denied by interface too, regardless of their names, unless a `MinSelectLevel` annotation opts them back in. List, retrieve, filter and save handlers all honor this.

[FilterableAttribute](../../api/dotnet/Serenity.Net.Core/Serenity.ComponentModel/FilterableAttribute.md) / `NotFilterableAttribute` give control over filtering separately from selection (they set or clear the field's `DenyFiltering` flag — see [Field Flags](field-flags.md#denyfiltering-flag)):

```cs
public sealed class MyUserRow : Row<MyUserRow.RowFields>, IPasswordRow
{
    // arbitrary name — still protected via IPasswordRow, unless opted back in
    [DisplayName("Password hash"), Size(100)]
    public string? Password { get => fields.Password[this]; set => fields.Password[this] = value; }

    // sensitive by name — MinSelectLevel(Never), Sortable(false), Filterable(false),
    // Insertable(false), Updatable(false) synthesized automatically
    [DisplayName("API key"), Size(100)]
    public string? ApiKey { get => fields.ApiKey[this]; set => fields.ApiKey[this] = value; }

    // opt back in explicitly if it is not actually sensitive
    [DisplayName("Access token"), Size(100), Filterable(true), MinSelectLevel(SelectLevel.Details)]
    public string? AccessToken { get => fields.AccessToken[this]; set => fields.AccessToken[this] = value; }
}
```

`[Filterable(true)]` clears the deny-filtering flag, `[Filterable(false)]` sets it. If a field with a sensitive-looking name is intentionally selectable, sortable, filterable or writable, opt it back in with the corresponding explicit attribute.

## Per-Field Comparers

String values are compared with a per-field comparer so that change detection, unique checks and local (in-memory) operations can honor a database's collation (e.g. case-insensitive or Turkish culture):

- [ComparerAttribute](../api/dotnet/Serenity.Net.Services/Serenity.Data/ComparerAttribute.md) can be applied to a row class (affecting all of its fields) or to a single field property to override the row, connection or global setting. [ComparerResolver](../api/dotnet/Serenity.Net.Services/Serenity.Data/ComparerResolver.md) parses specifications like `"OrdinalIgnoreCase"`, `"tr-TR"` or `"tr-TR:IgnoreCase"` into a `StringComparer`:

```cs
[Comparer("OrdinalIgnoreCase")] // applies to all string fields of this row
public sealed class CodeRow : Row<CodeRow.RowFields>, IIdRow
{
    // per-field override
    [Comparer("tr-TR:IgnoreCase")]
    public string? TurkishKey { get => fields.TurkishKey[this]; set => fields.TurkishKey[this] = value; }
}
```

- `ISqlDialect.WithComparer` lets a dialect carry a per-connection comparer, and `ConnectionStringEntry.Comparer` sets it per connection string in `appsettings.json` (see [SQL Connections](sql-connections.md)).
- The effective comparer is resolved per field in this order: field attribute → row attribute → dialect comparer → `SqlSettings.DefaultComparer`, and baked into each field.
- `SqlSettings.SetLocalComparer` provides an `AsyncLocal` override for tests and background work.
- `ByteArrayField`, `ListField`, `JsonField`, `VariantField` and the generic field types fall back to the field comparer instead of the type default.

## `IRowTypeRegistry`

[IRowTypeRegistry](../api/dotnet/Serenity.Net.Services/Serenity.Data/IRowTypeRegistry.md) provides a registry of all row types in the application:

```cs
public interface IRowTypeRegistry
{
    IEnumerable<Type> AllRowTypes { get; }
    IEnumerable<Type> ByConnectionKey(string connectionKey);
}
```

- `AllRowTypes` — all row types discovered through the type source.
- `ByConnectionKey(connectionKey)` — row types for a given connection key.

[DefaultRowTypeRegistry](../api/dotnet/Serenity.Net.Services/Serenity.Data/DefaultRowTypeRegistry.md) is the default implementation, which scans the type source for `IRow` types.

`IRowTypeRegistry` is used by services that need to find rows by connection or table (e.g. the `ValidateParentBehavior`, report generators, and the schema provider).

## `RowValidationContext`

[RowValidationContext](../api/dotnet/Serenity.Net.Services/Serenity.Services/RowValidationContext.md) is the validation context passed to `ICustomValidator` implementations when validating a row. It provides:

- `Connection` — the connection used for validation.
- `Row` — the row being validated.
- `Value` — the current field value.
- `Localizer` — the text localizer.
- `GetFieldValue(fieldName)` — reads a field value by name (used for cross-field validation).

## See Also

- [Entities (Rows)](entities.md)
- [Field Types](field-types.md)
- [Mapping](mapping.md)
- [Field Flags](field-flags.md)
- [Fluent SQL](fluent-sql.md)