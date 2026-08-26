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
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public StringField Name;
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