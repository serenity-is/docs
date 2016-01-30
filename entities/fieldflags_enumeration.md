# FieldFlags Enumeration

[**namespace**: *Serenity.Data.Mapping*] - [**assembly**: *Serenity.Data*]

Serenity has a set of field flags that controls field behavior. 

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
    ClientSide = 256,
    Trim = 512,
    TrimToEmpty = 512 + 1024,
    DenyFiltering = 2048,
    Unique = 4096,
    Default = Insertable | Updatable | Trim,
    Required = Default | NotNull,
    Identity = PrimaryKey | AutoIncrement | NotNull
}
```

An ordinary table field has *Insertable*, *Updatable* and *Trim* flags set by default which corresponds to *Default* combination flag.

## Insertable Flag

*Insertable* flag controls if the field is editable in new record mode. By default, all ordinary  fields are considered to be insertable.

Some fields might not be insertable in database table, e.g. identity columns shouldn't have this flags set. 

When a field doesn't have this flag, it won't be editable in forms in new record mode. This is also validated in services at repository level.

Sometimes, there might be internal fields that are perfectly valid in SQL INSERT statements, but shouldn't be edited in forms. One example might be a InsertedByUserId which should be set on service level, and not by end user. If we would let end user to edit it in forms, this would be a security hole. Such fields shouldn't have Insertable flag set too.

> This means field flags don't have to match database table settings.


## Insertable Attribute

To turn off Insertable flag for a field, put a [Insertable(false)] attribute on it:

```vs
[Insertable(false)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```


Use *Insertable(true)* to turn it on. 

> Non insertable fields are not hidden. They are just readonly. If you want to hide them, use [HideOnInsert] attribute (Serenity 1.9.8+) or write something like *form.MyField.GetGridField().Toggle(IsNew)* by overriding *UpdateInterface* method of your dialog.

## Updatable Flag

This flag is just like *Insertable* flag, but controls edit record mode in forms and update operations in services. By default, all ordinary fields are considered to be updatable.

## Updatable Attribute

To turn off Updatable flag for a field, put a [Updatable(false)] attribute on it:

```vs
[Updatable(false)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```


Use *Updatable(true)* to turn it on. 

> Non updatable fields are not hidden in dialogs. They are just readonly. If you want to hide them, use [HideOnUpdate] attribute (Serenity 1.9.8+) or write something like *form.MyField.GetGridField().Toggle(!IsNew)* by overriding *UpdateInterface* method of your dialog.

## Trim Flag

This flag is only meaningful for string typed fields and controls whether their value should be trimmed before save. All string fields have this flag on by default.

When a field value is empty string or whitespace only, it is trimmed to null.

## TrimToEmpty Flag

Use this flag if you prefer to trim string fields to empty string instead of null.

When a field value is null or whitespace only, it is trimmed to empty string.

## SetFieldFlags Attribute

This attribute can be used on fields to include or exclude a set of flags. It takes a first required parameter to include flags, and a second optional parameter to exclude flags.

To turn on TrimToEmpty flag on a field, we use it like this:

```vs
[SetFieldFlags(FieldFlags.TrimToEmpty)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

To turn off Trim flag:

```vs
[SetFieldFlags(FieldFlags.None, FieldFlags.TrimToEmpty)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

To include TrimToEmpty and Updatable but remove Insertable:
```vs
[SetFieldFlags(
    FieldFlags.Updatable | FieldFlags.TrimToEmpty,
    FieldFlags.Insertable)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

> Insertable and Updatable attributes are subclasses of SetFieldFlags attribute.

## NotNull Flag

Use this flag to set fields as not nullable. By default, this flag is set for fields that are not nullable in database, using NotNull attribute.

When a field is not nullable, its corresponding label in forms has a red asterisk and they are required to be entered.

## NotNullable Attribute

This sets the NotNull atttribute on a field to ON. Remove attribute to turn it off. 

You may also use [Required(false)] to make field not required in forms, even if it is not nullable in database. This doesn't clear the NotNull flag.

## Required Flag

This is a combination of Default and NotNullable flags. 

> It has no relation to [Required] attribute which controls validation in forms.

## PrimaryKey Flag and PrimaryKey Attribute

Set this for primary key fields in table. 

> Primary key fields are selected on Key column selection mode in List and Retrieve request handlers.

[PrimaryKey] attribute sets this flag ON.

## AutoIncrement Flag and AutoIncrement Attribute

Set this for fields that are auto incremented on server side, e.g. identity columns, or columns using a generator.

## Identity Flag and Identity Attribute

This is a combination of PrimaryKey, AutoIncrement and NotNull flags, which is common for identity columns.

## Foreign Flag

This flag is set for foreign view fields, that are originating from other tables through a join.

It is automatically set for fields with expressions containing table aliases other than T0.

For example, if a field has an attribute like [Expression("jCountry.CountryName")] it will have this flag.

> This has no relation to ForeignKey attribute

## Calculated Flag

If a field has an expression involving more than one field or some mathematical operations, it will have this flag.

This could also be set for fields that are calculated on SQL server side.

## ClientSide Flag and ClientSide Attribute

Corresponds to an unmapped field in Serenity entities. They don't have a corresponding field in database table. 

These kinds of fields can be used for temporary calculation, storage and transfer on client and service layers.

## Reflective Flag

This is used for an advanced form of unmapped fields, where they don't have a storage of their own in row, but reflects value of another field in a different form. For example, a field that displays absolute value of a integer field that can be negative.

This should only be used in rare cases for such unmapped fields.

## DenyFiltering Flag

If set, denies filtering operations on a sensitive field. This can be useful for secret fields like PasswordHash, that shouldn't be allowed to be selected or filtered by client side.

## Unique Flag and Unique Attribute

When a field has this flag, its value is checked against existing values in database to be unique.

You can turn on this flag with Unique attribute and determine if this constraint should be checked on service level (in addition to database level).