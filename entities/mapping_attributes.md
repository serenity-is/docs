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

> Property name is used as a column alias by default

## SqlSettings.AutoQuotedIdentifiers Flag

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

> This setting defaults to *false* in Serenity for backwards compability, but Serene 1.8.6+ sets it to *true* on application startup.


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

> Use SqlServer specific brackets (`[]`) if you need to work with multiple database types. These brackets are converted to dialect specific quotes (double quote, backtick etc.) before running queries.

> But, if you only target one type of database, you may prefer using quotes specific to that database type.

## TableNameAttribute

[**namespace**: *Serenity.Data.Mapping*] - [**assembly**: *Serenity.Data*]

If table name in database is different from row class name, use this attribute:

```cs
[TableName("TheCustomers")]
public class CustomerRow : Row
{
    public string StreetAddress
    {
        get { return Fields.StreetAddress[this]; }
        set { Fields.StreetAddress[this] = value; }
    }
}
```

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM TheCustomers T0
```

You may also use brackets or quotes:

```cs
[TableName("[My Customers]")]
public class CustomerRow : Row
{
    public string StreetAddress
    {
        get { return Fields.StreetAddress[this]; }
        set { Fields.StreetAddress[this] = value; }
    }
}
```

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM [My Customers] T0
```

> Again, prefer brackets for database compability


## ExpressionAttribute

[namespace: Serenity.Data.Mapping] - [assembly: Serenity.Data]

This attribute is used to specify expression of a non-basic field, e.g. one that doesn't actually exist in database.

There can be several types of such fields. 

One example is a Fullname field with a calculated expression like `(T0.Firstname + ' ' + T0.Lastname)`.

```cs
public class CustomerRow : Row
{
	public string Firstname
	{
		get { return Fields.Firstname[this]; }
		set { Fields.Firstname[this] = value; }
	}
	
	public string Lastname
	{
		get { return Fields.Lastname[this]; }
		set { Fields.Lastname[this] = value; }
	}
	
	[Expression("(T0.Firstname + ' ' + T0.Lastname)")]
	public string Fullname
	{
		get { return Fields.Fullname[this]; }
		set { Fields.Fullname[this] = value; }
	}
}
```

> Be careful with "+" operator here as it is Sql Server specific. If you want to target multiple databases, you should write the expression as:

> `CONCAT(T0.Firstname, CONCAT(' ', T0.Lastname))`

Firstname and Lastname are table fields (actual fields in the table), but even if they don't have an expression attribute, they have basic, implicitly defined expressions, `T0.Firstname` and `T0.Lastname` (main table is assigned `T0` alias in Serenity queries).


> In this document, when we talk about a *Table Field*, it means a field that actually corresponds to a column in database table.

> *View Field* means a field with a calculated expression or a field that originates from another table, like fields that comes from joins in SQL views.

