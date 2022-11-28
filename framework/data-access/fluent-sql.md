# Fluent SQL

Serenity contains a set of query builders for SELECT, INSERT, UPDATE, and DELETE statements.

These builders can be used with simple strings or the Serenity entity (row) system.

Their output can be executed directly, through a micro-ORM like Dapper (which is integrated with Serenity), or Serenity extensions.

## SQL Query

[SqlQuery](../../api/dotnet/Serenity.Net.Data/Serenity.Data/SqlQuery.md) is an object to compose dynamic SQL SELECT queries through a fluent interface.

SqlQuery offers some advantages over hand-crafted SQL:

* Using the intelli-sense feature of Visual Studio while composing SQL

* Fluent interface with minimal overhead

* Reduced syntax errors as the queries are checked compile time, not execution time.

* Clauses like Select, Where and Order By can be used in any order. They are placed at the correct positions when converting the query to a string. Similarly, such clauses can be used more than once and they are merged during string conversion. So you can conditionally build SQL depending on input parameters.

* No need to mess up with parameters and parameter names. All values used are converted to auto-named parameters (as long as you don't use string concatenation or pass non-escaped user input). You can also use manually named parameters if required.

* It can generate a special query to perform paging on server types that don't support it natively (e.g. SQL Server 2000)

* With the dialect system, the query can be targeted at specific server types and versions.

* If it is used along with Serenity entities (it can also be used with micro ORMs like Dapper), helps to load query results from a data reader with zero reflection. It also does left/right joins automatically.

## IMPORTANT WARNING!

Never pass a user-provided string to one of the SQLQuery methods. It is VERY DANGEROUS as it would open your code to SQL-Injection attacks! This includes using the user-provided string in a string concatenation operation and passing it.

The `user-provided string` here includes anything entered on a client-side form, in addition to any parameters that are sent to one of your API/actions/services via JSON, XML, query-string, form, request-body, etc.

https://en.wikipedia.org/wiki/SQL_injection


## A Simple Select Query

```csharp
var query = new SqlQuery();
query.Select("Firstname");
query.Select("Surname");
query.From("People");
query.OrderBy("Age");

Console.WriteLine(query.ToString());
```

This will result in output:

```sql
SELECT 
Firstname,
Surname 
FROM People 
ORDER BY Age
```

In the first line of our program, we called SqlQuery with its sole parameterless constructor. If `ToString()` was called at this point, the output would be:

```sql
SELECT FROM
```

SqlQuery doesn't perform any syntax validation. It just converts the query you build yourself, by calling its methods. Even if you don't select any fields or call from methods, it will generate this basic *SELECT FROM* statement.

> SqlQuery can't generate empty queries.

Next, we called the `Select` method with a string parameter `"FirstName"`. Our query is now like this:

```sql
SELECT Firstname FROM
```

When the `Select("Surname")` statement is executed, SqlQuery put a comma between the previously selected field (`Firstname`) and this one:

```sql
SELECT Firstname, Surname FROM
```

After executing `From` and `OrderBy` methods, our final output is:

```sql
SELECT Firstname, Surname FROM People ORDER BY Age
```

## Method Call Order and Its Effects

In the previous sample, the output wouldn't change even if we reordered `From`, `OrderBy`, and `Select` lines. It would change only if we changed the order of `Select` statements...

```csharp
var query = new SqlQuery();
query.From("People");
query.OrderBy("Age");
query.Select("Surname");
query.Select("Firstname");

Console.WriteLine(query.ToString());
```

...but, only the column ordering inside the SELECT statement would change:

```sql
SELECT 
Surname,
Firstname 
FROM People 
ORDER BY Age
```

You might use methods like Select, From, OrderBy and GroupBy in any order, and can also mix them (e.g. call Select, then OrderBy, Select again...)

> Putting FROM at start is recommended, especially when used with Serenity entities, as it helps with auto joins and determining database dialect etc.

## Method Chaining

It is a bit verbose and not so readable to start every line with `"query."`. Almost all `SqlQuery` methods are chainable and return the query itself as result. 

We may rewrite the query like this:

```csharp
var query = new SqlQuery()
    .From("People")
    .Select("Firstname")
    .Select("Surname")
    .OrderBy("Age");
Console.WriteLine(query.ToString());
}
```

> This feature is similar to jQuery and LINQ enumerable method chaining.

We could even get rid of the query variable:

```csharp
Console.WriteLine(
    new SqlQuery()
        .From("People")
        .Select("Firstname")
        .Select("Surname")
        .OrderBy("Age")
        .ToString());
```


> It is strongly recommended to put every method on its own line, and indent properly for readability and consistency reasons.

## Select Method

```csharp
public SqlQuery Select(string expression)
```

In the samples we had so far, we used the overload of the `Select` method shown above (it has about 11 overloads).

The `expression` parameter can be a simple field name or an expression like `"FirstName + ' ' + LastName"`

Whenever this method is called, the expression you set is added to the SELECT statement of the resulting query with a comma in-between.

There is also a SelectMany method to select multiple fields in one call:

```csharp
public SqlQuery SelectMany(params string[] expressions)
```

For example:

```csharp
var query = new SqlQuery()
    .From("People")
    .SelectMany("Firstname", "Surname", "Age", "Gender")
    .ToString();

Console.WriteLine(query.ToString());
```

```sql
SELECT 
Firstname,
Surname,
Age,
Gender 
FROM People
```

> I'd personally prefer calling Select method multiple times.

You might be wondering, why multi-select is not just another `Select` overload. It's because the `Select` method has a more commonly used overload to select a column with an alias:

```csharp
public SqlQuery Select(string expression, string alias)
```

```csharp
var query = new SqlQuery()
    .Select("(Firstname + ' ' + Surname)", "Fullname")
    .From("People")
    .ToString();

Console.WriteLine(query.ToString());
```

```sql
SELECT 
(Firstname + ' ' + Surname) AS [Fullname] 
FROM People
```

## From Method

```csharp
public SqlQuery From(string table)
```

SqlQuery.From method should be called at least once (and usually once). 

> ..and it is recommended to be called first.

When you call it a second time, the table name will be added to FROM statement with a comma between. Thus, it will be a CROSS JOIN:

```csharp
var query = new SqlQuery()
    .From("People")
    .From("City")
    .From("Country")
    .Select("Firstname")
    .Select("Surname")
    .OrderBy("Age");

Console.WriteLine(query.ToString());
```

```sql
SELECT 
Firstname,
Surname 
FROM People, City, Country 
ORDER BY Age
```

## Using Alias Object with SqlQuery

It is common to use table aliases when the number of referenced tables increases and our queries become longer:

```csharp
var query = new SqlQuery()
    .From("Person p")
    .From("City c")
    .From("Country o")
    .Select("p.Firstname")
    .Select("p.Surname")
    .Select("c.Name", "CityName")
    .Select("o.Name", "CountryName")
    .OrderBy("p.Age")
    .ToString();

Console.WriteLine(query.ToString());
}
```

```sql
SELECT 
p.Firstname,
p.Surname,
c.Name AS [CityName],
o.Name AS [CountryName] 
FROM Person p, City c, Country o 
ORDER BY p.Age
```

Although it works like this, it is better to define `p`, `c`, and `o` as the `Alias` objects:

```cs
var p = new Alias("Person", "p");
```

The `Alias` object is like a short name assigned to a table. It has an indexer and operator overload to generate SQL member access expressions like `p.Surname`:

```csharp
var p = new Alias("Person", "p");
Console.WriteLine(p + "Surname"); // + operator overload
Console.WriteLine(p["Firstname"]); // through indexer
```

```
p.Surname
p.Firstname
```

Unfortunately, the `C#` member access operator (.) can't be overridden, so we had to use (+). A workaround could be possible with dynamic, but it would perform poorly.

Let's modify our query by making use of `Alias` objects:

```csharp
var p = new Alias("Person", "p");
var c = new Alias("City", "c");
var o = new Alias("Country", "o");

var query = new SqlQuery()
    .From(p)
    .From(c)
    .From(o)
    .Select(p + "Firstname")
    .Select(p + "Surname")
    .Select(c + "Name", "CityName")
    .Select(o + "Name", "CountryName")
    .OrderBy(p + "Age")
    .ToString();

Console.WriteLine(query.ToString());
```

```sql
SELECT 
p.Firstname,
p.Surname,
c.Name AS [CityName],
o.Name AS [CountryName] 
FROM Person p, City c, Country o 
ORDER BY p.Age
```

As seen above, the result is the same, but the code we wrote is a bit longer. So what is the advantage of using an alias? 

If we had a list of constants with field names…

```csharp
const string Firstname = "Firstname";
const string Surname = "Surname";
const string Name = "Name";
const string Age = "Age";

var p = new Alias("Person", "p");
var c = new Alias("City", "c");
var o = new Alias("Country", "o");
var query = new SqlQuery()
    .From(p)
    .From(c)
    .From(o)
    .Select(p + Firstname)
    .Select(p + Surname)
    .Select(c + Name, "CityName")
    .Select(o + Name, "CountryName")
    .OrderBy(p + Age)
    .ToString();

Console.WriteLine(query.ToString());
```

We would take advantage of the intelli-sense feature and have some more compile time checks.

As obvious, it is not logical and easy to define field names for every query. This should be in a central location or our entity declarations.

Let's create a poor mans simple ORM using Alias:

```csharp
public class PeopleAlias : Alias
{
    public PeopleAlias(string alias) 
        : base("People", alias) { }

    public string ID { get { return this["ID"]; } }
    public string Firstname { get { return this["Firstname"]; } }
    public string Surname { get { return this["Surname"]; } }
    public string Age { get { return this["Age"]; } }
}

public class CityAlias : Alias
{
  public CityAlias(string alias)
      : base("City", alias) { }

  public string ID { get { return this["ID"]; } }
  public string CountryID { get { return this["CountryID"]; } }
  public new string Name { get { return this["Name"]; } }
}

public class CountryAlias : Alias
{
  public CountryAlias(string alias)
      : base("Country", alias) { }

  public string ID { get { return this["ID"]; } }
  public new string Name { get { return this["Name"]; } }
}

void Main()
{
    var p = new PeopleAlias("p");
    var c = new CityAlias("c");
    var o = new CountryAlias("o");
    var query = new SqlQuery()
        .From(p)
        .From(c)
        .From(o)
        .Select(p.Firstname)
        .Select(p.Surname)
        .Select(c.Name, "CityName")
        .Select(o.Name, "CountryName")
        .OrderBy(p.Age)
        .ToString();
    
    Console.WriteLine(query.ToString());
}
```


Now we have a set of table alias classes with field names and they can be reused in all queries.

> This is just a sample to explain aliases. I don't recommend writing such classes. Entities offers much more.

In the sample above, we used `SqlQuery.From` overload that takes an `Alias` parameter:

```csharp
public SqlQuery From(Alias alias)
```

When this method is called, the table name and its aliased name are added to *FROM* statement of the query.


## OrderBy Method

```csharp
public SqlQuery OrderBy(string expression, bool desc = false)
```

OrderBy can also be called with a field name or expression like Select. 

If you assign the `desc` optional argument as true, the `DESC` keyword is appended to the field name or expression.

By default, OrderBy appends specified expressions to the end of the ORDER BY statement. Sometimes, you might want to insert an expression/field to start. 

For example, you might have a query with some predefined order, but if the user orders by a column in a grid, the name of the column should be inserted at index 0.

```csharp
public SqlQuery OrderByFirst(string expression, bool desc = false)
```

```csharp
var query = new SqlQuery()
    .Select("Firstname")
    .Select("Surname")
    .From("Person")
    .OrderBy("PersonID");
    
query.OrderByFirst("Age");
    
Console.WriteLine(query.ToString());
}
```

```sql
SELECT 
Firstname,
Surname 
FROM Person 
ORDER BY Age, PersonID
```

## Distinct Method

```csharp
public SqlQuery Distinct(bool distinct)
```

Use this method to prepend a DISTINCT keyword before the SELECT statement.

```csharp
var query = new SqlQuery()
    .Select("Firstname")
    .Select("Surname")
    .From("Person")
    .OrderBy("PersonID")
    .Distinct(true);
    
Console.WriteLine(query.ToString());
```

```sql
SELECT DISTINCT 
Firstname,
Surname 
FROM Person 
ORDER BY PersonID 
```

## GroupBy Method

```csharp
public SqlQuery GroupBy(string expression)
```

`GroupBy` works similarly to the `OrderBy` but it doesn't have a GroupByFirst variant.


```csharp
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
GROUP BY Firstname, LastName
```

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
GROUP BY Firstname, LastName
```

## Having Method

```csharp
public SqlQuery Having(string expression)
```

Having can be used with GroupBy (though it doesn't check for GroupBy) and appends the expression to the end of the HAVING statement.


```csharp
var query = new SqlQuery()
    .From("Person")
    .Select("Firstname")
    .Select("Lastname")
    .Select("Count(*)")
    .GroupBy("Firstname")
    .GroupBy("LastName")
    .Having("Count(*) > 5");
    
Console.WriteLine(query.ToString());
```

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
GROUP BY Firstname, LastName 
HAVING Count(*) > 5

```

## Paging Operations (SKIP / TAKE / TOP / LIMIT)

```csharp
public SqlQuery Skip(int skipRows)

public SqlQuery Take(int rowCount)
```

SqlQuery has paging methods similar to LINQ Take and Skip.

These are mapped to SQL keywords depending on the database type. 

> As SqlServer versions before 2012 doesn't have a SKIP equivalent, to use SKIP your query should have at least one ORDER BY statement as ROW_NUMBER() will be used. This is not required if you are using SqlServer 2012+ dialect.

```csharp
var query = new SqlQuery()
    .From("Person")
    .Select("Firstname")
    .Select("Lastname")
    .Select("Count(*)")
    .OrderBy("PersonId")
    .Skip(100)
    .Take(50);
    
Console.WriteLine(query.ToString());
```

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
ORDER BY PersonId OFFSET 100 ROWS FETCH NEXT 50 ROWS ONLY
```

> In this sample we are using the default SQLServer2012 dialect.

## Database Dialect Support

In our paging sample, SqlQuery used a syntax that is compatible with the SQL Server 2012.

With the Dialect method, we can change the server type that SqlQuery targets:

```csharp
public SqlQuery Dialect(ISqlDialect dialect)
```

As of writing, this is the list of dialect types supported:

- FirebirdDialect
- PostgresDialect
- SqliteDialect
- SqlServer2000Dialect
- SqlServer2005Dialect
- SqlServer2012Dialect

If we wanted to target our query to the SQL Server 2005:

```csharp
var query = new SqlQuery()
    .Dialect(SqlServer2005Dialect.Instance)
    .From("Person")
    .Select("Firstname")
    .Select("Lastname")
    .Select("Count(*)")
    .OrderBy("PersonId")
    .Skip(100)
    .Take(50);
    
Console.WriteLine(query.ToString());
```

```sql
SELECT * FROM (
SELECT TOP 150 
Firstname,
Lastname,
Count(*), ROW_NUMBER() OVER (ORDER BY PersonId) AS __num__ 
FROM Person) __results__ WHERE __num__ > 100
```

With SqliteDialect.Instance, the output would be:

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
ORDER BY PersonId LIMIT 50 OFFSET 100
```

If you are using only one type of database server with your application, you may avoid having to choose a dialect every time you start a query by setting the default dialect:

```csharp
SqlSettings.DefaultDialect = SqliteDialect.Instance;
```

The dialect for a connection string is derived from the `ProviderName` field, or `Dialect` property of the connection string in `appsettings.json`. SqlSettings.DefaultDialect is just a fallback.
