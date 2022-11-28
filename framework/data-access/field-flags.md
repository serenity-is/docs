# Field Flags and Relevant Attributes

## Field Flags

Serenity has a set of field flags that controls the field behavior. 

```cs
public enum FieldFlags
{
    None = 0,
    Insertable = 1,
    Updatable = 2,
    NotNull = 4,
    PrimaryKey = 8,
    AutoIncrement = 16,
    Foreign = 32,
    Calculated = 64,
    Reflective = 128,
    NotMapped = 256,
    Trim = 512,
    TrimToEmpty = 512 + 1024,
    DenyFiltering = 2048,
    Unique = 4096,
    Default = Insertable | Updatable | Trim,
    Required = Default | NotNull,
    Identity = PrimaryKey | AutoIncrement | NotNull
}
```

An ordinary table field has the `Insertable`, `Updatable`, and `Trim` flags set by default which corresponds to the `Default` combination flag.

## Insertable Flag

The `Insertable` flag controls if the field is editable in new record mode. By default, all the ordinary fields are considered to be insertable.

Some fields might not be insertable in the database table, e.g. identity columns shouldn't have this flag set. 

When a field doesn't have this flag, it won't be editable in forms in new record mode. This is also validated in services at the request handler level.

Sometimes, there might be internal fields that are perfectly valid in an SQL INSERT statement but shouldn't be edited in forms. 

One example might be an `InsertedByUserId` field which should be set on the service level, and not by an end user. If we would let an end user edit it in forms, this would be a security hole. Such fields shouldn't have the `Insertable` flag set too.

This also means field flags don't have to exactly match the database table settings, as they are meant to be used at the application level, not SQL.

## Insertable Attribute

To turn off the `Insertable` flag for a field put an `Insertable(false)` attribute on it:

```cs
[Insertable(false)]
public string MyField
{
    get => fields.MyField[this];
    set => fields.MyField[this] = value;
}
```

Use `Insertable(true)` to turn it back on.

The non-insertable fields are not hidden. They are just read-only. If you want to hide them, use the `HideOnInsert` attribute or write something like `this.form.MyField.getGridField().toggle(this.isNew())` by overriding the `updateInterface` method of your dialog.

## Updatable Flag

This flag is just like the `Insertable` flag, but controls edit record mode in forms and update operations in services. By default, all ordinary fields are considered to be updatable.

## Updatable Attribute

To turn off the `Updatable` flag for a field, put an `[Updatable(false)]` attribute on it:

```cs
[Updatable(false)]
public string MyField
{
    get => return fields.MyField[this];
    set => fields.MyField[this] = value;
}
```


Use `Updatable(true)` to turn it on. 

Non-updatable fields are not hidden in dialogs. They are just read-only. If you want to hide them, use the `HideOnUpdate` attribute or write something like `this.form.MyField.getGridField().toggle(!this.isNew())` by overriding the `updateInterface` method of your dialog.

## Trim Flag

This flag is only meaningful for string-typed fields and controls whether their value should be trimmed before the save. All string fields have this flag on by default.

When a field value is an empty string or whitespace only, it is trimmed to null.

## TrimToEmpty Flag

Use this flag if you prefer to trim string fields to an empty string instead of null.

When a field value is null or whitespace only, it is trimmed to an empty string.

## SetFieldFlags Attribute

This attribute can be used on fields to include or exclude a set of flags. It takes a first required parameter to include flags, and a second optional parameter to exclude flags.

To turn on the TrimToEmpty flag on a field, we use it like this:

```cs
[SetFieldFlags(FieldFlags.TrimToEmpty)]
public string MyField
{
    get => fields.MyField[this];
    set => fields.MyField[this] = value;
}
```

To turn off the Trim flag:

```cs
[SetFieldFlags(FieldFlags.None, FieldFlags.TrimToEmpty)]
public string MyField
{
    get => return fields.MyField[this];
    set => fields.MyField[this] = value;
}
```

To include TrimToEmpty and Updatable but remove Insertable:

```cs
[SetFieldFlags(
    FieldFlags.Updatable | FieldFlags.TrimToEmpty,
    FieldFlags.Insertable)]
public string MyField
{
    get => fields.MyField[this];
    set => fields.MyField[this] = value;
}
```

Insertable and Updatable attributes are subclasses of the SetFieldFlags attribute.

## NotNull Flag

Use this flag to set fields as not nullable. By default, this flag is set for fields that are not nullable in the database, using the `NotNull` attribute.

When a field is not nullable, its corresponding label in forms has a red asterisk and they are required to be entered.

## NotNull Attribute

This sets the NotNull attribute on a field to ON. Remove the attribute to turn it off. 

You may also use `[Required(false)]` to make a field not required in forms, even if it is not nullable in the database. This doesn't clear the NotNull flag.

## Required Flag

This is a combination of Default and NotNullable flags. 

It has no relation to the `[Required]` attribute which controls validation in forms.

## PrimaryKey Flag and PrimaryKey Attribute

Set this for primary key fields in the table. 

Primary key fields are selected on Key column selection mode in List and Retrieve request handlers.

The `[PrimaryKey]` attribute sets this flag ON.

## AutoIncrement Flag and AutoIncrement Attribute

Set this for fields that are auto-incremented on the server side, e.g. identity columns, or columns using a generator.

## Identity Flag and Identity Attribute

This is a combination of PrimaryKey, AutoIncrement, and NotNull flags, which is common for identity columns.

## `IdProperty` Attribute

This determines the ID property of a row class. It does not have to be an identity e.g. autoincrement property.

## Foreign Flag

This flag is set for foreign view fields, that are originating from other tables through a join.

It is automatically set for fields with expressions containing table aliases other than T0.

For example, if a field has an attribute like `[Expression("jCountry.CountryName")]` it will have this flag.

> This has no relation to the ForeignKey attribute

## Calculated Flag

If a field has an expression involving more than one field or some mathematical operations, it will have this flag.

This could also be set for fields that are calculated on the SQL server side.

## NotMapped Flag and NotMapped Attribute

Corresponds to an unmapped field in Serenity entities. They don't have a corresponding field in the database table. 

These kinds of fields can be used for temporary calculation, storage and transfer on client and service layers.

## Reflective Flag

This is used for an advanced form of unmapped fields, where they don't have a storage of their own in the row, but reflect the value of another field in a different form. For example, a field that displays the absolute (positive) value of an integer field that could be negative.

This should only be used in rare cases for such unmapped fields.

## DenyFiltering Flag

If set, it denies filtering operations on a sensitive field. This can be useful for secret fields like PasswordHash that shouldn't be allowed to be selected or filtered on the client side.

## Unique Flag and Unique Attribute

When a field has this flag, its value is checked against existing values in the database to be unique.

You can turn on this flag with the `Unique` attribute and determine if this constraint should be checked on the service level (before the check on the database level to avoid cryptic constraint errors).