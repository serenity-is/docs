# Criteria Objects

When you are creating dynamic SQL for SELECT, UPDATE or DELETE, you might have to write complex WHERE statements.

Building these statements using string concentanation is possible but it is tedious to avoid syntax errors and opens your code to SQL injection attacks.

Using parameters might solve SQL injection problems but it involves too much manual work to add parameters.

Luckily, Serenity has a criteria system that helps you build parameterized queries with a syntax similar LINQ expression trees. 

Serenity criterias are implemented by utilitizing operator overloading features of C#, unlike LINQ which uses expression trees.

Let's write a basic SQL where statement as string first:

```cs
new SqlQuery()
    .From("MyTable")
    .Select("Name")
    .Where("Month > 5 AND Year < 2015 AND Name LIKE N'%a%'")
```

and same statement using criteria objects:

```
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

and you could write it with intellisense if you had an entity:

```
var m = MyTableRow.Fields;
new SqlQuery()
    .From(m)
    .Select(m.Name)
    .Where(
        m.Month > 5 &
        m.Year < 4 &
        m.Name.Contains("a")
```

