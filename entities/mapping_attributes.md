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

## TableName Attribute

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


## Expression Attribute

[namespace: Serenity.Data.Mapping] - [assembly: Serenity.Data]

This attribute is used to specify expression of a non-basic field, e.g. one that doesn't actually exist in database.

There can be several types of such fields. 

One example is a Fullname field with a calculated expression like `(T0.[Firstname] + ' ' + T0.[Lastname])`.

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
	
	[Expression("(T0.[Firstname] + ' ' + T0.[Lastname])")]
	public string Fullname
	{
		get { return Fields.Fullname[this]; }
		set { Fields.Fullname[this] = value; }
	}
}
```

> Be careful with "+" operator here as it is Sql Server specific. If you want to target multiple databases, you should write the expression as:

> `CONCAT(T0.[Firstname], CONCAT(' ', T0.[Lastname]))`

Firstname and Lastname are table fields (actual fields in the table), but even if they don't have an expression attribute, they have basic, implicitly defined expressions, `T0.Firstname` and `T0.Lastname` (main table is assigned `T0` alias in Serenity queries).

> In this document, when we talk about a *Table Field*, it means a field that actually corresponds to a column in database table.

> *View Field* means a field with a calculated expression or a field that originates from another table, like fields that comes from joins in SQL views.

We wrote Fullname expression using `T0` alias before the fields that we reference.

> It would probably work without that prefix too. But it is better to use it. When you start to add joins, it is possible to have more than one field with same name and experience ambiguous column errors.


## ForeignKey Attribute

[namespace: Serenity.Data.Mapping] - [assembly: Serenity.Data]

This attribute is used to specify foreign key columns, and add information about primary table and primary field that they are related to.

```
public class CustomerRow : Row
{
	[ForeignKey("Countries", "Id")]
	public string CountryId
	{
		get { return Fields.Firstname[this]; }
		set { Fields.Firstname[this] = value; }
	}
}
```

Here we specified that *CountryId* field in *Customer* table has a foreign key to *Id* field in *Countries* table.

> The foreign key doesn't have to exist in database. Serenity doesn't check it.

Serenity can make use of such meta information, even though it doesn't affect generated queries alone.

ForeignKey is more meaningful when used along with the next attribute we'll see.

## LeftJoin Attribute

Where we are querying database, we tend to make many joins because of relations. Most of these joins are LEFT or INNER joins. 

> With Serenity entities, you'll usually be using LEFT JOINs.

Database admins prefers to define views to make it easier to query a combination of multiple tables, and to avoid writing these joins again and again.

Serenity entities can be used just like SQL views, so you can bring in columns from other tables to an entity, and query it as if they are one big combined table.

```cs
public class CustomerRow : Row
{
	[ForeignKey("Cities", "Id"), LeftJoin("c")]
	public Int32? CityId
	{
		get { return Fields.CityId[this]; }
		set { Fields.CityId[this] = value; }
	}
	
	[Expression("c.[Name]")]
	public string CityName
	{
		get { return Fields.CityName[this]; }
		set { Fields.CityName[this] = value; }
	}
```

Here we specified that *Cities* table should be assigned alias `c` when joined, and its join type should be `LEFT JOIN`. The join `ON` expression is determined as `c.[Id] == T0.[CountryId]` with some help from *ForeignKey* attribute.

> LEFT JOIN is preferred as it allows to retrieve all records from *left* table, *Customers*, even if they don't have a CityId set.

*CityName* is a view field (not actually a column of Customer table), which has an expression *c.Name*. It is clear that CityName originates from *Name* field in *Cities* table.

Now, if we wanted to select city names of all customers, our query text would be:

```sql
SELECT 
c.Name AS [CityName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId)
```

What if we don't have a CountryId field in Customer table, but we want to bring Country names of cities through CountryId field in city table?

```cs
public class CustomerRow : Row
{
	[ForeignKey("Cities", "Id"), LeftJoin("c")]
	public Int32? CityId
	{
		get { return Fields.CityId[this]; }
		set { Fields.CityId[this] = value; }
	}
	
	[Expression("c.[Name]")]
	public string CityName
	{
		get { return Fields.CityName[this]; }
		set { Fields.CityName[this] = value; }
	}
	
	[Expression("c.[CountryId]"), ForeignKey("Countries", "Id"), LeftJoin("o")]
	public Int32? CountryId
	{
		get { return Fields.CountryId[this]; }
		set { Fields.CountryId[this] = value; }	
	}
	
	[Expression("o.[Name]")]
	public string CountryName
	{
		get { return Fields.CountryName[this]; }
		set { Fields.CountryName[this] = value; }
	}	
}
```

This time we did a LEFT JOIN on CountryId field in Cities table. We assigned `o` alias to Countries table and bring in the name field from it.

> You can assign any table alias to joins as long as they are not reserved words, and are unique between other joins in the entity. Sergen generates aliases like jCountry, but you may rename them to shorter and more natural ones.

Let's select CityName and CountryName fields of all Customers:

```sql
SELECT 
c.[Name] AS [CityName],
o.[Name] AS [CountryName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId) 
LEFT JOIN Countries o ON (o.[Id] = c.[CountryId])
```

> We'll see how to build such queries in FluentSQL chapter.

So far, we used LeftJoin attribute with properties that has a ForeignKey attribute with them. 

It is also possible to attach LeftJoin attribute to entity classes. This is useful for joins without a corresponding field in main entity.

For example, let's say you have a CustomerDetails extension table that stores some extra details of customers (1 to 1 relation). CustomerDetails table has a primary key, *CustomerId*, which is actually a foreign key to *Id* field in *Customer* table.

```cs
[LeftJoin("cd", "CustomerDetails", "cd.[CustomerId] = T0.[Id]")]
public class CustomerRow : Row
{
	[Identity, PrimaryKey]
	public Int32? Id
	{
		get { return Fields.Id[this]; }
		set { Fields.Id[this] = value; }
	}

	[Expression("cd.[DeliveryAddress]")]
	public string DeliveryAddress
	{
		get { return Fields.DeliveryAddress[this]; }
		set { Fields.DeliveryAddress[this] = value; }
	}
```

And here what it looks like when you select DeliveryAddress:

```sql
SELECT 
cd.[DeliveryAddress] AS [DeliveryAddress] 
FROM Customer T0 
LEFT JOIN CustomerDetails cd ON (cd.[CustomerId] = T0.[Id])
```
