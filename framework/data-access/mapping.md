# Entity Mapping

Serenity provides some mapping attributes, to match database table and column names with rows.

## Column and Table Mapping Conventions

By default, a row class is considered to match a table in the database with the same name, but with the *Row* suffix removed.

A property is considered to match a column in the database with the same name.

Let's say we have such a row definition:

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    public string StreetAddress
    {
        get => fields.StreetAddress[this];
        set => fields.StreetAddress[this] = value;
    }
}
```

If we wrote a query, selecting the `StreetAddress` field from `CustomerRow`, it would be generated like the below:

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM Customer T0
```

`CustomerRow` matches table `Customer` by convention. Similarly, the `StreetAddress` property matches a column named `StreetAddress`.

`T0` is a special alias assigned to the main table by Serenity entities.

As the `StreetAddress` column belongs to the main table (`Customer`), it is selected with an expression of `T0.StreetAddress` and with a column alias of `[StreetAddress]`. 

> Property name is used as a column alias by default

## SqlSettings.AutoQuotedIdentifiers Flag

In some database systems, identifiers are case-sensitive. 

For example, in Postgress, if you create a column with quoted identifier `"StreetAddress"`, you have to use quotes when selecting it, even if you write `SELECT StreetAddress ...` (same case) it won't work. 

You have to use the form `SELECT "StreetAddress"`.

Thus, Postgres users usually prefer lowercase identifiers. But FluentMigrator always quotes identifiers, so we need a workaround to add brackets/quotes to identifiers.

Serenity doesn't quote/bracket column and table names by default, but it has a compatibility setting. If [SqlSettings.AutoQuotedIdentifiers](../../api/dotnet/Serenity.Net.Data/Serenity.Data/SqlSettings/AutoQuotedIdentifiers.md) flag is set to true, the previous query would look like this:

```sql
SELECT 
T0.[StreetAddress] AS [StreetAddress] 
FROM [Customer] T0
```

This setting defaults to `false` in Serenity for compatibility reasons, but Serene and StartSharp set it to `true` in the `Startup.cs` file.

And if we used the Postgress dialect, the output would be:

```sql
SELECT 
T0."StreetAddress" AS "StreetAddress"
FROM "Customer" T0
```

Serenity provides a set of attributes in the [Serenity.Data.Mapping](../../api/dotnet/Serenity.Net.Data/README.md#serenity.data.mapping-namespace) namespace that can be used to adjust mappings for entities and their properties to the corresponding tables in the database.

We'll talk about the most commonly used ones below.

## Column Attribute

You can map a property to some other column name in the database using the [Column](../../api/dotnet/Serenity.Net.Data/Serenity.Data.Mapping/ColumnAttribute.md) attribute:

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [Column("street_address")]
    public string StreetAddress
    {
        get => fields.StreetAddress[this];
        set => fields.StreetAddress[this] = value;
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
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [Column("[street_address]")]
    public string StreetAddress
    {
        get => fields.StreetAddress[this];
        set => fields.StreetAddress[this] = value;
    }
}
```

```sql
SELECT 
T0.[street_address] AS [StreetAddress] 
FROM Customer T0
```

If SqlSettings.AutoQuotedIdentifiers is true, brackets are automatically included.

Use the SqlServer-specific brackets (`[]`) if you need to work with multiple database types. These brackets are converted to dialect-specific quotes (double quote, backtick, etc.) before running queries.

But, if you only target one type of database, you could prefer using quotes specific to that database type.

## TableName Attribute

If the table name in the database is different from the row class name, use the[TableName](../../api/dotnet/Serenity.Net.Data/Serenity.Data.Mapping/TableNameAttribute.md) attribute:

```cs
[TableName("TheCustomers")]
public class CustomerRow : Row<CustomerRow.RowFields>
{
    public string StreetAddress
    {
        get => fields.StreetAddress[this];
        set => fields.StreetAddress[this] = value;
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
public class CustomerRow : Row<CustomerRow.RowFields>
{
    public string StreetAddress
    {
        get => fields.StreetAddress[this];
        set => fields.StreetAddress[this] = value;
    }
}
```

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM [My Customers] T0
```

Again, prefer brackets for database compatibility

## Expression Attribute

The [Expression](../../api/dotnet/Serenity.Net.Data/Serenity.Data.Mapping/ExpressionAttribute.md) attribute is used to specify the expression of a non-basic field, e.g. one that doesn't exist in the table.

There can be several types of such fields. 

One example is a Fullname field with a calculated expression like `(T0.[Firstname] + ' ' + T0.[Lastname])`.

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    public string Firstname
    {
        get => fields.Firstname[this];
        set => fields.Firstname[this] = value;
    }
    
    public string Lastname
    {
        get => fields.Lastname[this];
        set => fields.Lastname[this] = value;
    }
    
    [Expression("(T0.[Firstname] + ' ' + T0.[Lastname])")]
    public string Fullname
    {
        get => fields.Fullname[this];
        set => fields.Fullname[this] = value;
    }
}
```

Be careful with the `+` operator here as it is SQL Server specific. If you want to target multiple databases, you should write the expression as:

`CONCAT(T0.[Firstname], CONCAT(' ', T0.[Lastname]))`

Firstname and Lastname are table fields (actual fields in the table), but even if they don't have an expression attribute, they have basic, implicitly defined expressions, `"T0.Firstname"` and `"T0.Lastname"` (the main table is assigned `T0` alias in Serenity queries).

In this document, when we talk about a `Table Field`, it means a field that corresponds to a column in the database table.

`View Field` means a field with a calculated expression or a field that originates from another table, like fields that originate from joins in SQL views.

We wrote the `Fullname` expression using the `T0` alias before the fields that we reference.

It would probably work without that prefix too. But it is better to use it. When you start to add joins, it is possible to have more than one field with the same name and experience ambiguous column errors.



## ForeignKey Attribute

The [ForeignKey](../../api/dotnet/Serenity.Net.Data/Serenity.Data.Mapping/ForeignKeyAttribute.md) attribute is used to specify foreign key columns and adds information about the primary table and primary field that they are related to.

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [ForeignKey("Countries", "Id")]
    public string CountryId
    {
        get => fields.CountryId[this];
        set => fields.CountryId[this] = value;
    }
}
```

Here we specified that the `CountryId` field in the `Customer` table has a foreign key to the `Id` field in the `Countries` table.

> The foreign key doesn't have to exist in database. Serenity doesn't check it.

If you have a Row class defined for the `Countries` table, it is also possible to use the type directly in the `ForeignKey` constructor, as long as the `CountryRow` has a property with the `IdProperty` attribute:

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [typeof(CountryRow)]
    public string CountryId
    {
        get => fields.CountryId[this];
        set => fields.CountryId[this] = value;
    }
}

public class CountryRow : Row<CountryRow.RowFields>
{
    [IdProperty]
    public string Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }
}
```

Serenity can make use of the `[ForeignKey]` and other such meta information, even though it doesn't affect generated queries alone.

ForeignKey is more meaningful when used along with the attribute (LeftJoin) we'll see next.

## `LeftJoin` Attribute

Where we are querying the database, we tend to make many joins because of relations. Most of these joins are LEFT, INNER or RIGHT joins, though, with the Serenity entities, you'll usually be using LEFT JOINs.

Database admins prefer to define views to make it easier to query a combination of multiple tables and to avoid writing these joins over and over.

Serenity entities can be used just like SQL views, so you can bring in columns from other tables to an entity, and query it as if they are one big combined table.

One of the ways to do this is via the [LeftJoin](../../api/dotnet/Serenity.Net.Data/Serenity.Data.Mapping/LeftJoinAttribute.md) attribute.
```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [ForeignKey("Cities", "Id"), LeftJoin("c")]
    public int? CityId
    {
        get => fields.CityId[this];
        set => fields.CityId[this] = value;
    }
    
    [Expression("c.[Name]")]
    public string CityName
    {
        get => Fields.CityName[this];
        set => Fields.CityName[this] = value;
    }
}
```

Here we specified that the *Cities* table should be assigned alias `c` when it is joined, and its join type should be `LEFT JOIN`. The join `ON` expression is determined as `c.[Id] == T0.[CityId]` with some help from the `ForeignKey` attribute.

Left joins are preferred in Serenity entities as it allows retrieving all the records from the *left* table, *Customers*, even if they don't have a `CityId` value.

`CityName` is a view field (not an actual column of the Customer table), which has an expression `c.Name`. It should be obvious that CityName originates from the `Name` field in the `Cities` table.

Now, if we wanted to select the city names of all customers, our query text would be:

```sql
SELECT 
c.Name AS [CityName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId)
```

What if we don't have a `CountryId` field in the `Customer` table, but we want to bring Country names of cities indirectly through the `CountryId` field in the city table?

```cs
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [ForeignKey("Cities", "Id"), LeftJoin("c")]
    public int? CityId
    {
        get => fields.CityId[this];
        set => fields.CityId[this] = value;
    }
    
    [Expression("c.[Name]")]
    public string CityName
    {
        get => fields.CityName[this];
        set => fields.CityName[this] = value;
    }
    
    [Expression("c.[CountryId]"), ForeignKey("Countries", "Id"), LeftJoin("o")]
    public int? CountryId
    {
        get => fields.CountryId[this];
        set => fields.CountryId[this] = value;
    }
    
    [Expression("o.[Name]")]
    public string CountryName
    {
        get => fields.CountryName[this];
        set => fields.CountryName[this] = value;
    }
}
```

This time we did a LEFT JOIN on the `CountryId` field in `Cities` table. We assigned the `"o"` alias to Countries table and bring in the `name` field from it.

You can assign any table alias to joins as long as they are not reserved words, and are unique between other joins in the entity. Sergen generates aliases like jCountry, but you may rename them to shorter and more natural ones.

Let's select the `CityName` and `CountryName` fields of all Customers:

```sql
SELECT 
c.[Name] AS [CityName],
o.[Name] AS [CountryName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId) 
LEFT JOIN Countries o ON (o.[Id] = c.[CountryId])
```

> We'll see how to build such queries in the FluentSQL chapter.

So far, we used LeftJoin attribute with properties that has a ForeignKey attribute on them.

It is also possible to attach LeftJoin attribute to the entity classes. This is useful for joins without a corresponding field in main entity, or joins that involve multiple fields.

For example, let's say you have a `CustomerDetails` extension table that stores some extra details of customers (1 to 1 relation). CustomerDetails table has a primary key, `CustomerId`, which is actually a foreign key to the `Id` field in the `Customer` table.

```cs
[LeftJoin("cd", "CustomerDetails", "cd.[CustomerId] = T0.[Id]")]
public class CustomerRow : Row<CustomerRow.RowFields>
{
    [Identity, PrimaryKey]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [Expression("cd.[DeliveryAddress]")]
    public string DeliveryAddress
    {
        get => return Fields.DeliveryAddress[this];
        set => Fields.DeliveryAddress[this] = value;
    }
```

And here what it looks like when you select DeliveryAddress:

```sql
SELECT 
cd.[DeliveryAddress] AS [DeliveryAddress] 
FROM Customer T0 
LEFT JOIN CustomerDetails cd ON (cd.[CustomerId] = T0.[Id])
```

## Dialect Based Expressions

Sometimes it might not be possible to use a common expression. For example, Sqlite has no CONCAT operator. For this, the `Expression`, `Tablename`, `LeftJoin` attribute and some other attributes accept a `Dialect` option.

```cs
[DisplayName("FullName"), QuickSearch]
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
[Expression("(T0.FirstName || ' ' || T0.LastName)", Dialect = nameof(ServerType.Sqlite))]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

Here, as the first Expression has no dialect, it will be used for any database type, unless the connection corresponding to this row has dialect of `Sqlite`, e.g. it is a *System.Data.Sqlite* connection.

[ServerType](../../api/dotnet/Serenity.Net.Data/Serenity.Data/ServerType.md) is an enum that contains common server type names. It is possible to use a string, but we prefer the enum with `nameof` operator to avoid typing errors.

### How Dialect for a Row is Determined

To determine dialect type for a row, the *ConnectionKey* attribute on row is used (if any), otherwise the default dialect (*SqlSettings.DefaultDialect*) is used.

Expression for a field is determined (fixed) while a `RowFields` instance is first created, which is shared by all row instances.

It is also possible to specify multiple dialects:

```cs
[DisplayName("FullName"), QuickSearch]
[Expression("CONCAT(T0.[FirstName], CONCAT(' ', T0.[LastName]))")]
[Expression("T0.[FirstName] + ' ' + T0.[LastName]", 
     Dialect = "SqlServer2000,SqlServer2005")]
[Expression("(T0.FirstName || ' ' || T0.LastName)", 
     Dialect = "Sqlite,MySql,Postgres")]
public String FullName
{
    get { return Fields.FullName[this]; }
    set { Fields.FullName[this] = value; }
}
```

## Dialect Matching

The [ISqlDialect](../../api/dotnet/Serenity.Net.Data/Serenity.Data/ISqlDialect.md) interface has a `ServerType` property. It is `Postgres` for PostgresDialect, `SqlServer` for `SqlServer2012Dialect`, `SqlServer2008Dialect` and `SqlServer2005Dialect`.

For an expression dialect to match a connection dialect, it should start with the `ServerType` and/or the class name of the connection dialect (e.g. SqlServer2012Dialect).

If multiple dialect types match a targeted expression, the one with the longest name wins.

Let's say we wrote these two expressions:

```cs
[Expression("CONCAT(T0.[FirstName], T0.[LastName])", Dialect = "SqlServer")]
[Expression("T0.[FirstName] + T0.[LastName]", Dialect = "SqlServer200")]
```

If connection dialect is `SqlServer2008`, both expressions would match, but as `SqlServer200` is a longer match than `SqlServer`, the second expression will be used.

If connection dialect is `SqlServer2012`, only the first expression would match.

When specifying a dialect name, it is also possible to negate the match by starting the dialect name with an exclamation (`!`) or use `NegateDialect`:

```cs
[Expression("SomeExpression", Dialect = "!SqlServer")]
[Expression("SomeExpression", Dialect = nameof(ServerTypes.SqlServer), NegateDialect = true)]
```

The above expressions will only apply to dialects that does not match `SqlServer`.