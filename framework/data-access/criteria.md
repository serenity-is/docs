# Criteria Objects

When you are creating dynamic SQL for SELECT, UPDATE, or DELETE, you might have to write complex where-statements.

Building these statements using string concatenation is possible but it is tedious to avoid syntax errors and opens your code to SQL injection attacks.

Using parameters might solve SQL injection problems but it involves too much manual work to add parameters.

Luckily, Serenity has a criteria system that helps you build parameterized queries with a syntax similar to the `LINQ` expression trees. 

Serenity criteria are implemented by utilizing operator overloading features of C#, unlike LINQ which uses expression trees.

Let's write a basic SQL WHERE statement as a string first:

```cs
new SqlQuery()
    .From("MyTable")
    .Select("Name")
    .Where("Month > 5 AND Year < 2015 AND Name LIKE N'%a%'")
```

and the same statement using criteria objects:

```cs
new SqlQuery()
    .From("MyTable")
    .Select("Name")
    .Where(
        new Criteria("Month") > 5 &
        new Criteria("Year") < 4 &
        new Criteria("Name").Contains("a")
```

It looks a bit longer, but it uses parameters

```sql
SELECT 
    Name
FROM
    MyTable
WHERE
    Month > @p1 AND
    Year < @p2 AND
    Name LIKE N'%a%'
```

and you could write it with the intelli-sense support if you had an entity:

```cs
var m = MyTableRow.Fields;
new SqlQuery()
    .From(m)
    .Select(m.Name)
    .Where(
        m.Month > 5 &
        m.Year < 4 &
        m.Name.Contains("a")
```

Here we didn't have to use *new Criteria()* because field objects also have the operator overloads that build criteria.

## BaseCriteria Object

BaseCriteria is the base class for all types of criteria objects. 

It has overloads for several C# operators, including `>`, `<`, `&`, `|` that can be used to build complex criteria using C# expressions.

BaseCriteria doesn't have a constructor of itself
so you need to create one of the objects that derive from it. The `Criteria` class is the most common one that you might use.

## Criteria Class

The `Criteria` class is a simple object that contains an SQL expression as a string, which is usually a field name. 

```cs
new Criteria("MyField")
```

It can also contain an SQL expression (though not recommended this way)

```cs
new Criteria("a + b")
```

This parameter is not syntax checked, so it is possible to build a criterion with an invalid or dangerous expression:

```cs
new Criteria("Some invalid expression()///''^')
```

## IMPORTANT WARNING!

Never pass a user-provided string to one of the Criteria constructors. It is VERY DANGEROUS as it would open your code to SQL-Injection attacks! This includes using the user-provided string in a string concatenation operation and passing it.

The `user-provided string` here includes anything entered on a client-side form, in addition to any parameters that are sent to one of your API/actions/services via JSON, XML, query-string, form, request-body, etc.

https://en.wikipedia.org/wiki/SQL_injection

## AND (&) Operator

It is possible to AND two criteria objects with C# `&` operator:

```
new Criteria("Field1 > 5") &
new Criteria("Field2 < 4")
````

It is also possible to use the short-circuit `&&` operator here.

This creates a new criteria object (BinaryCriteria) with the operator (`AND`) and a reference to these two criteria. It doesn't modify the original criteria objects.

> BinaryCriteria is similar to BinaryExpression in expression trees

Its SQL output would be:

```sql
Field1 > 5 AND Field2 < 4
```

It is also possible to use C# &= operator:

```cs
BaseCriteria c = new Criteria("Field1 > 5)";
c &= new Criteria("Field2 < 4")
```

BaseCriteria is the base class for all criteria object types. If we used *Criteria c = ...* in the first line, we would have a compile-time error on the second line as the `&` operator returns a BinaryCriteria object, which is not assignable to a Criteria object.

## OR (|) Operator

This is similar to the `AND` operator, though it uses `OR`.

```cs
new Criteria("Field1 > 5") |
new Criteria("Field2 < 4")
````

```sql
Field1 > 5 OR Field2 < 4
```

## Comparison Operators (>, >=, <, <=, ==, !=)

The most of C# comparison operators are overloaded, so you can use them as is with criteria.

```cs
new Criteria("Field1") == new Criteria("1") &
new Criteria("Field2") != new Criteria("2") &
new Criteria("Field3") > new Criteria("3") &
new Criteria("Field4") >= new Criteria("4") &
new Criteria("Field5") < new Criteria("5") &
new Criteria("Field6") <= new Criteria("6")
```

```sql
Field1 == 1 AND
Field2 <> 2 AND
Field3 > 3 AND
Field4 >= 4 AND
Field5 < 5 AND
Field6 <= 6
```

## Inline Values

When one side of a comparison operator is criteria and the other side is an integer, string, date, guid, etc. value, it is converted to a parameter criteria.
 
```cs
new Criteria("Field1") == 1 &
new Criteria("Field2") != "ABC" &
new Criteria("Field3") > DateTime.Now &
new Criteria("Field4") >= Guid.NewGuid() &
new Criteria("Field5") < 5L
```

```sql
Field1 == @p1 AND
Field2 <> @p2 AND
Field3 > @p3 AND
Field4 >= @p4 AND
Field5 < @p5
```

These parameters have corresponding values when a query containing the criteria is sent to SQL.

Automatic parameter numbering starts from 1 by default, but the last number is stored in the query the criteria is used with, so numbers might change.

Let's use the criteria in a query:

```cs
new SqlQuery()
    .From("MyTable")
    .Select("Field999")
    .Where(new Criteria("FirstOne") >= 999)
    .Where(new Criteria("SecondOne") >= 999)
    .Where(
        new Criteria("Field1") == 1 &
        new Criteria("Field2") != "ABC" &
        new Criteria("Field3") > DateTime.Now &
        new Criteria("Field4") >= Guid.NewGuid() &
        new Criteria("Field5") < 5L
    )
```

```sql
SELECT 
  Field999
FROM
  MyTable
WHERE
  FirstOne >= @p1 AND -- @p1 = 999
  SecondOne >= @p2 AND -- @p2 = 999
  Field1 == @p3 AND -- @p3 = 1
  Field2 <> @p4 AND -- @p4 = N'ABC'
  Field3 > @p5 AND -- @p5 = '2016-01-31T01:16:23'
  Field4 >= @p6 AND -- @p6 = '23123-DEFCD-....'
  Field5 < @p7 -- @p7 = 5
```

Here the same criteria that is listed before, used parameter numbers starting from 3, instead of 1. Because the prior 2 numbers were used for the other `WHERE` statements coming before it.

So parameter numbering uses the query as context. You shouldn't make assumptions about what the parameter name will be.

## ParamCriteria and Explicit Param Names

If you want to use some explicitly named parameter, you can make use of ParamCriteria:

```cs
new SqlQuery()
    .From("SomeTable")
    .Select("SomeField")
    .Where(new Criteria("SomeField") <= new ParamCriteria("@myparam"))
    .Where(new Criteria("SomeOtherField") == new ParamCriteria("@myparam"))
    .SetParam("@myparam", 5);
```

Here we set the param value using the `SetParam` extension of SqlQuery.

We could also declare this param beforehand and reuse it:

```cs
var myParam = new ParamCriteria("@myparam");

new SqlQuery()
    .From("SomeTable")
    .Select("SomeField")
    .Where(new Criteria("SomeField") <= myParam)
    .Where(new Criteria("SomeOtherField") == myParam)
    .SetParam(myParam.Name, 5);
```

## ConstantCriteria

If you don't want to use parameterized queries for some reason, you may put your values as ConstantCriteria objects. They will not be converted to auto parameters.

```cs
new SqlQuery()
    .From("MyTable")
    .Select("MyField")
    .Where(
        new Criteria("Field1") == new ConstantCriteria(1) &
        new Criteria("Field2") != new ConstantCriteria("ABC")
    )
```

```sql
SELECT 
  MyField
FROM
  MyTable
WHERE
  FirstOne >= 1
  SecondOne >= N'ABC'
```

## Null Comparison

In SQL, comparing against NULL values using operators like `==`, `!=` returns NULL. You should use IS NULL or IS NOT NULL for such comparisons.

Criteria objects don't overload comparisons against null (or object), so you may get errors if you try to write expressions like the below:

```cs
new Criteria("a") == null; // what is type of null?

int b? = null;
new Criteria("c") == b; // no overload for nullable types
```

These could be written using `IsNull` and the `Nullable Value` methods:

```cs
new Criteria("a").IsNull();
new Criteria("a").IsNotNull();
int? b = 5;
new Criteria("c") == b.Value;
```

If you are desperate to write Field = NULL, you could do this:

```cs
new Criteria("Field") == new Criteria("NULL")
```

## LIKE Operators

The `Criteria` object has methods `Like`, `NotLike`, `StartsWith`, `EndsWith`, `Contains`, and `NotContains` to help with `LIKE` operations.

```cs
new Criteria("a").Like("__C%") &
new Criteria("b").NotLike("D%") &
new Criteria("c").StartsWith("S") &
new Criteria("d").EndsWith("X") &
new Criteria("e").Contains("This") &
new Criteria("f").NotContains("That")
```

```sql
a LIKE @p1 AND -- @p1 = N'__C%'
b NOT LIKE @p2 AND -- @p2 = N'D%'
c LIKE @p3 AND -- @p3 = 'S%'
d LIKE @p4 AND -- @p4 = N'%X'
e LIKE @p5 AND -- @p5 = N'%This%'
f NOT LIKE @p6 -- @p6 = N'%That%'
```

## IN and NOT IN Operators

Use an inline array to use IN or NOT IN:

```cs
new Criteria("A").In(1, 2, 3, 4, 5)
```

```sql
A IN (@p1, @p2, @p3, @p4, @p5) 
-- @p1 = 1, @p2 = 2, @p3 = 3, @p4 = 4, @p5 = 5
```

```cs
new Criteria("A").NotIn(1, 2, 3, 4, 5)
```

```sql
A NOT IN (@p1, @p2, @p3, @p4, @p5)
-- @p1 = 1, @p2 = 2, @p3 = 3, @p4 = 4, @p5 = 5
```

You may also pass any enumerable to IN method:

```cs
IEnumerable<int> x = new int[] { 1, 3, 5, 7, 9 };
new Criteria("A").In(x);
```

```sql
A IN (1, 3, 5, 7, 9)
-- @p1 = 1, @p2 = 3, @p3 = 5, @p4 = 7, @p5 = 9
```

It is also possible to use a subquery:

```cs
var query = new SqlQuery()
    .From("MyTable")
    .Select("MyField");
    
query.Where("SomeID").In(
    query.SubQuery()
        .From("SomeTable")
        .Select("SomeID")
        .Where(new Criteria("Balance") < 0));
```

```sql
SELECT 
  MyField
FROM
  MyTable
WHERE
  SomeID IN (
    SELECT 
        SomeID 
    FROM
        SomeTable
    WHERE
        Balance < @p1 -- @p1 = 0
  )
```

## NOT Operator

Use C# `!` (not) operator to use NOT:

```cs
!(new Criteria("a") >= 5)
```

```sql
NOT (a >= @p1) -- @p1 = 5
```

## Usage with Field Objects

We have used the Criteria object constructor so far to build criteria. Field objects also have similar overloads, so they can be used in place of them and it is recommended.

For example, using Order, Detail, and Customer rows from the Northwind sample:

```cs
var o = OrderRow.Fields.As("o");
var od = OrderDetailRow.Fields.As("od");
var c = CustomerRow.Fields.As("c");
var query = new SqlQuery()
    .From(o)
    .Select(o.CustomerID);
    
query.Where(
    o.CustomerCountry == "France" &
    o.ShippingState == 1 &
    o.CustomerID.In(
        query.SubQuery()
            .From(c)
            .Select(c.CustomerID)
            .Where(c.Region == "North")) &
    new Criteria(
        query.SubQuery()
            .From(od)
            .Select(Sql.Sum(od.LineTotal.Expression))
            .Where(od.OrderID == o.OrderID)) >= 1000);
```

Its output would be:

```sql
SELECT 
    o.CustomerID AS [CustomerID] 
FROM 
    Orders o 
LEFT JOIN 
    Customers o_c ON (o_c.CustomerID = o.CustomerID) 
WHERE 
    o_c.[Country] = @p2
    AND (CASE WHEN 
        o.[ShippedDate] IS NULL THEN 0
     ELSE 1 
     END) = @p3 
    AND o.CustomerID IN (
        SELECT 
            c.CustomerID AS [CustomerID] 
        FROM 
            Customers c 
        WHERE 
            c.Region = @p1) 
    AND (SELECT 
        SUM((od.[UnitPrice] * od.[Quantity] - od.[Discount])) 
     FROM
        [Order Details] od 
     WHERE 
        od.OrderID = o.OrderID) >= @p4
```