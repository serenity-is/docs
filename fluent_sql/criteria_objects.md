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

> Here we didn't have to use *new Criteria()* because field objects also has operator overloads that builds criteria.

## BaseCriteria Object

BaseCriteria is the base class for all types of criteria objects. 

It has overloads for several C# operators, including `>`, `<`, `&`, `|` that can be used to build complex criteria using C# expressions.

BaseCriteria doesn't have a constructor of itself
so you need to create one of the objects that derive from it. *Criteria* is the most common one that you might use.

## Criteria Object

Criteria is a simple object that contains an SQL expression as a string, which is usually a field name. 

```
new Criteria("MyField")
```

It can also contain an SQL expression (though not recommended this way)

```
new Criteria("a + b")
```

This parameter is not syntax checked, so it is possible to build a criteria with invalid expression:

```
new Criteria("Some invalid expression()///''^')
```


## AND (&) Operator

It is possible to AND two criteria objects with C# `&` operator:

```
new Criteria("Field1 > 5") &
new Criteria("Field2 < 4")
````

> Please notice that we are not using shortcircuit && operator here.

This creates a new criteria object (BinaryCriteria) with operator (AND) and reference to these two criterias. It doesn't modify original criteria objects.

> BinaryCriteria is similar to BinaryExpression in expression trees

It's SQL output would be:

```sql
Field1 > 5 AND Field2 < 4
```

It is also possible to use C# &= operator:

```
BaseCriteria c = new Criteria("Field1 > 5)";
c &= new Criteria("Field2 < 4")
```

> BaseCriteria is the base class for all criteria object types. If we used *Criteria c = ...* in the first line, we would have a compile time error on second line as & operator returns a BinaryCriteria object, which is not assignable to a Criteria object.

## OR (|) Operator

This is similar to AND operator, though it uses OR.

```
new Criteria("Field1 > 5") |
new Criteria("Field2 < 4")
````

```sql
Field1 > 5 OR Field2 < 4
```

## Parenthesis Operator (~)

When you are using several AND/OR statements, you might want to put paranthesis.

```
new Criteria("Field1 > 5") &
(new Criteria("Field2 > 7") | new Criteria("Field2 < 3"))
```

But this won't work with criteria objects, as output of above criteria would be:

```sql
Field1 > 5 AND Field2 > 7 OR Field2 < 3
```

> Information here applies to Serenity versions before 1.9.8. After this version Serenity puts paranthesis around all binary criteria (AND OR etc) even if you don't use paranthesis.

> So only use ~ if you want to put an explicit parenthesis somewhere.


What happened to our paranthesis? Let's try putting more paranthesis.

```
new Criteria("Field1 > 5") &
((((new Criteria("Field2 > 7") | new Criteria("Field2 < 3")))))
```

Still:

```sql
Field1 > 5 AND Field2 > 7 OR Field2 < 3
```

C# doesn't provide a way to overload paranthesis, it just uses them to determine calculation order, so Serenity criteria has no idea if you used them with paranthesis or not.

We have to use a special operator, `~` (which is actually two's complement in C#):

```
new Criteria("Field1 > 5") &
~(new Criteria("Field2 > 7") | new Criteria("Field2 < 3"))
```

Now SQL looks like we hoped before:

```sql
Field1 > 5 AND (Field2 > 7 OR Field2 < 3)
```
