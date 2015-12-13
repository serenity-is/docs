# Mapping Attributes

Serenity provides some mapping attributes, to match database table, column names with rows.

## Column Attribute

By default, a property is considered to match a column in database with the same name and case.

```cs
public string SomeValue
{
    get { return Fields.SomeValue[this]; }
    set { Fields.SomeValue[this] = value; }
}
```

You can map this property to some other column name using *Column* attribute:

```cs
[Column("some_value")]
public string SomeValue
{
    get { return Fields.SomeValue[this]; }
    set { Fields.SomeValue[this] = value; }
}
```
