# Field Types

Every property in a row is backed by a **field object** of a specific type. The field type determines the C# value type, how the value is read from/written to the database, and how it's compared and serialized.

## The `Field` Base Class

[Field](../api/dotnet/Serenity.Net.Services/Serenity.Data/Field.md) is the abstract base for all field types. It carries the metadata that makes a row work:

- `Name` — the column name.
- `Type` — the [FieldType](../api/dotnet/Serenity.Net.Services/Serenity.Data/FieldType.md) enum value (String, Int32, DateTime, etc.).
- `Caption` — the display caption (local text).
- `Size` — the column size (e.g. from `[Size]`).
- `Flags` — the [FieldFlags](field-flags.md) (NotNull, Insertable, Updatable, etc.).
- `Expression` — the SQL expression (defaults to `T0.<ColumnName>`).
- `DefaultValue` — the default value.
- `Index` — the field's index in the fields collection.
- `Fields` — the owning `RowFieldsBase`.
- `Join` / `JoinAlias` — the join this field comes from, if any.
- `Origin` — the origin alias for view fields.
- `MinSelectLevel` — the minimum select level.
- `TextualField` — the field used for display text.
- `ReadPermission` / `InsertPermission` / `UpdatePermission` — field-level permissions.

Fields also provide the operations used by queries and services: `AsObject`/`AsSqlValue` (get/set values), `ConvertValue`, `GetFromReader`, `IndexCompare`, `IsNull`, `Clone`, and criteria operators (`field == value`, `field > value`, etc.).

## Field Type Hierarchy

The concrete field types derive from a few generic bases:

- [GenericValueField&lt;TValue&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/GenericValueField-1.md) — base for value-type fields (`int`, `long`, `decimal`, `DateTime`, `bool`, `Guid`, etc.). It stores values via get/set delegates and supports enum types.
- `GenericClassField<TValue>` — base for reference-type fields (`string`, `byte[]`, `Stream`, etc.).
- `CustomClassField<TValue>` — base for custom class-valued fields (`List<T>`, `List<TRow>`, JSON objects).
- `GenericField<TValue>` — a general-purpose field for any value type.

## Concrete Field Types

| Field type | C# value type | Notes |
| --- | --- | --- |
| [StringField](../api/dotnet/Serenity.Net.Services/Serenity.Data/StringField.md) | `string` | Text columns |
| [Int16Field](../api/dotnet/Serenity.Net.Services/Serenity.Data/Int16Field.md) | `short?` | |
| [Int32Field](../api/dotnet/Serenity.Net.Services/Serenity.Data/Int32Field.md) | `int?` | Most common numeric field |
| [Int64Field](../api/dotnet/Serenity.Net.Services/Serenity.Data/Int64Field.md) | `long?` | |
| [SingleField](../api/dotnet/Serenity.Net.Services/Serenity.Data/SingleField.md) | `float?` | |
| [DoubleField](../api/dotnet/Serenity.Net.Services/Serenity.Data/DoubleField.md) | `double?` | |
| [DecimalField](../api/dotnet/Serenity.Net.Services/Serenity.Data/DecimalField.md) | `decimal?` | Money/amounts; use `[Scale]` for precision |
| [BooleanField](../api/dotnet/Serenity.Net.Services/Serenity.Data/BooleanField.md) | `bool?` | |
| [DateTimeField](../api/dotnet/Serenity.Net.Services/Serenity.Data/DateTimeField.md) | `DateTime?` | Date/time columns |
| [DateTimeOffsetField](../api/dotnet/Serenity.Net.Services/Serenity.Data/DateTimeOffsetField.md) | `DateTimeOffset?` | |
| [DateOnlyField](../api/dotnet/Serenity.Net.Services/Serenity.Data/DateOnlyField.md) | `DateOnly?` | Date-only columns |
| [TimeSpanField](../api/dotnet/Serenity.Net.Services/Serenity.Data/TimeSpanField.md) | `TimeSpan?` | Time columns |
| [GuidField](../api/dotnet/Serenity.Net.Services/Serenity.Data/GuidField.md) | `Guid?` | |
| [ByteArrayField](../api/dotnet/Serenity.Net.Services/Serenity.Data/ByteArrayField.md) | `byte[]` | Binary data |
| [StreamField](../api/dotnet/Serenity.Net.Services/Serenity.Data/StreamField.md) | `Stream` | Stream data |
| [EnumField&lt;TEnum&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/EnumField-1.md) | `TEnum?` | Enum columns (e.g. `Gender?`) |
| [JsonField&lt;TValue&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/JsonField-1.md) | `TValue` | JSON-serialized object column |
| [ListField&lt;TValue&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/ListField-1.md) | `List<TValue>` | List of values (e.g. linking set) |
| [RowListField&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/RowListField-1.md) | `List<TRow>` | List of rows (e.g. master-detail) |
| [RowField&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/RowField-1.md) | `TRow` | A single row value |
| `VariantField` | `object` | Dynamic/object value |

## Choosing the Right Field Type

The field type must match the property type exactly. For example:

```cs
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Person Id"), Identity, IdProperty]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }

    [DisplayName("First Name"), Size(50), NotNull]
    public string FirstName { get => fields.FirstName[this]; set => fields.FirstName[this] = value; }

    [DisplayName("Gender")]
    public Gender? Gender { get => fields.Gender[this]; set => fields.Gender[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PersonId;
        public StringField FirstName;
        public EnumField<Gender> Gender;
    }
}
```

- `int?` → `Int32Field`
- `string` → `StringField`
- `Gender?` (enum) → `EnumField<Gender>`

The `[Size]` attribute sets the field's `Size` (used for string length and numeric precision). The `[Scale]` attribute sets decimal precision.

## Row and RowList Fields

- [RowField&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/RowField-1.md) holds a single row value.
- [RowListField&lt;TRow&gt;](../api/dotnet/Serenity.Net.Services/Serenity.Data/RowListField-1.md) holds a list of rows. It's used for master-detail relations (e.g. a `List<MovieCastRow>` property with `[MasterDetailRelation]`) and is marked `[NotMapped]` by default.

These fields are typically `[NotMapped]` — they hold related data in memory but aren't columns in the row's own table.

## See Also

- [Entities (Rows)](entities.md)
- [Row Fields](row-fields.md)
- [Mapping](mapping.md)
- [Field Flags](field-flags.md)
- [Fluent SQL](fluent-sql.md)