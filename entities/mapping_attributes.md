# Mapping Attributes

Serenity provides some mapping attributes, to match database table, column names with rows.

## Column and Table Mapping Conventions

By default, a row class is considered to match a table in database with the same name, but *Row* suffix removed.

A property is considered to match a column in database with the same name.


Let's say we have such a row definition:

```cs
public class CustomerRow : Row
{
    public string StreetAddress
    {
        get { return Fields.StreetAddress[this]; }
        set { Fields.StreetAddress[this] = value; }
    }
}
```

If we wrote a query, selecting *StreetAddress* field from *CustomerRow*, it would be generated like below:

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM Customer T0
```

*CustomerRow* matches table *Customer* by convention. Similarly, *StreetAddress* property matches a column named *StreetAddress*.

`T0` is a special alias assigned to main table by Serenity rows.

As, *StreetAddress* column belongs to main table (*Customer*), it is selected with an expression of `T0.StreetAddress` and with a column alias of `[StreetAddress]`. 

> Property name is used as a column alias.

## SqlSettings.AutoQuotedIdentifiers Flag (Defaults to False)

In some database systems, identifiers are case sensitive. 

For example, in Postgress, if you create a column with quoted identifier `"StreetAddress"`, you have to use quotes when selecting it, even if you write `SELECT StreetAddress ...` (same case) it won't work. 

You have to use the form `SELECT "StreetAddress"`.

Thus, Postgres users usually prefer lowercase identifiers. But FluentMigrator always quotes identifiers, so we need a workaround to add brackets/quotes to identifiers.

Serenity doesn't quote/bracket column and table names by default, but it has a setting for compability.

If *SqlSettings.AutoQuotedIdentifiers* flag is set to true, previous query would look like this:

```sql
SELECT 
T0.[StreetAddress] AS [StreetAddress] 
FROM [Customer] T0
```

And if we used Postgress dialect, output would be:

```sql
SELECT 
T0."StreetAddress" AS "StreetAddress"
FROM "Customer" T0
```


## Column Attribute

[**namespace**: *Serenity.Data.Mapping*] - [**assembly**: *Serenity.Data*]

You can map a property to some other column name in database using *Column* attribute:

```cs
public class CustomerRow : Row
{
    [Column("street_address")]
    public string StreetAddress
    {
        get { return Fields.StreetAddress[this]; }
        set { Fields.StreetAddress[this] = value; }
    }
}
```

Now the query becomes:

```sql
SELECT 
T0.street_address AS [StreetAddress] 
FROM Customer T0
```

It is also possible to manually add brackets:

```cs
public class CustomerRow : Row
{
    [Column("[street_address]")]
    public string StreetAddress
    {
        get { return Fields.StreetAddress[this]; }
        set { Fields.StreetAddress[this] = value; }
    }
}
```

```sql
SELECT 
T0.[street_address] AS [StreetAddress] 
FROM Customer T0
```

> If SqlSettings.AutoQuotedIdentifiers is true, brackets are automatically added.

Use SqlServer specific brackets (`[]`) if you need to work with multiple database types. These brackets are converted to dialect specific quotes before running queries.

But, if you only target one type of database, you may prefer using quotes specific to that database type.