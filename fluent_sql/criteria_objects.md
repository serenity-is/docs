# Criteria 对象

当为 SELECT、 UPDATE 或 DELETE 创建动态 SQL 时，可能需要编写复杂的 WHERE 子句。

也可以使用拼接字符串构建这些语句，但避免语法错误是很繁琐的事且容易遭到 SQL 注入攻击。

使用参数化可以解决 SQL 注入问题，但为了添加参数需要过多的手动工作。

幸运的是，Serenity 有一个条件系统（criteria system），可以帮助你用类似 LINQ 表达式树的方式构建参数化的查询。 

Serenity criterias 是通过 C# 的运算符（utilitizing operator）重载特性来实现的，而不像 LINQ 使用表达式树。

让我们首先在 where 子句写一个基本的 SQL 字符串：

```cs
new SqlQuery()
    .From("MyTable")
    .Select("Name")
    .Where("Month > 5 AND Year < 2015 AND Name LIKE N'%a%'")
```

使用 criteria 对象实现相同的声明：

```
new SqlQuery()
    .From("MyTable")
    .Select("Name")
    .Where(
        new Criteria("Month") > 5 &
        new Criteria("Year") < 4 &
        new Criteria("Name").Contains("a")
```

这看起来有点长，但它使用了参数：

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

如果你有一个实体，你可以在智能提示的帮助下写该语句：

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

> 我们这里没有使用 *new Criteria()*，因为 Field 对象已经有构建条件的重载操作。

## BaseCriteria 对象

BaseCriteria 是所有条件（criteria）对象类型的基类。 

它重载了几个 C# 操作运算符，包括 `>`、 `<`、 `&`、 `|`，它们可以用在 C# 表态式中，以构建复杂的条件。

BaseCriteria 自身没有构造函数，所以你需要创建一个从它派生的对象。*Criteria* 可能是最常使用的一个子类。

## Criteria 对象

Criteria 是一个简单对象，包含 SQL 表达式的字符串，通常该字符串是一个字段名称。 

```
new Criteria("MyField")
```

它也可以包含一个 SQL 表达式（尽管不建议使用这种方式）：

```
new Criteria("a + b")
```

系统不会检查该参数的语法，因此构建的条件中可能含有无效的表达式。

```
new Criteria("Some invalid expression()///''^')
```


## AND (&) 操作

可以使用 C# 的 `&` 运算符对两个条件对象进行 与（AND） 运算：

```
new Criteria("Field1 > 5") &
new Criteria("Field2 < 4")
````

> 请注意，我们这里不是使用短路运算符 && 。

它使用运算符 (AND) 创建新的条件对象（BinaryCriteria），并引用这两个条件对象。它并不修改原始的条件对象。

> BinaryCriteria 类似于表达式树的二元表达式（BinaryExpression）。

它的 SQL 输出将是：

```sql
Field1 > 5 AND Field2 < 4
```

也可以使用 C# 的 &= 运算符：

```
BaseCriteria c = new Criteria("Field1 > 5)";
c &= new Criteria("Field2 < 4")
```

> BaseCriteria 是所有条件对象类型的基类。如果在第一行使用 *Criteria c = ...*，第二行将得到编译时错误，因为 & 运算符返回 BinaryCriteria 对象，而不是返回 Criteria 对象。

## OR (|) 操作

类似于 AND 操作，但它使用 OR。 

```
new Criteria("Field1 > 5") |
new Criteria("Field2 < 4")
````

```sql
Field1 > 5 OR Field2 < 4
```

## 括号操作 (~) 

当使用多个 AND/OR 子句，你可能想使用括号。

```
new Criteria("Field1 > 5") &
(new Criteria("Field2 > 7") | new Criteria("Field2 < 3"))
```

但是这不可以与条件对象一起工作，因为上述的条件将输出：

```sql
Field1 > 5 AND Field2 > 7 OR Field2 < 3
```

> 这里的信息适用于 Serenity 1.9.8 之前的版本。在该版本之后，Serenity 在所有二元条件（AND OR 等）周围添加括号，即使你没有使用括号。

> 所以，如果你想在某些地方显式地使用括号，你只能使用 ~ 。 


我们的括号被怎么处理？让我们试着添加更多的括号。

```
new Criteria("Field1 > 5") &
((((new Criteria("Field2 > 7") | new Criteria("Field2 < 3")))))
```

一直还是输出：

```sql
Field1 > 5 AND Field2 > 7 OR Field2 < 3
```

C# 没有提供重载括号的方法，它只被用来决定运算的顺序，因此，Serenity criteria 不能确定你是否在使用括号。

我们必须使用特殊的运算符：`~`（实际上它是 C# 的补码）。

```
new Criteria("Field1 > 5") &
~(new Criteria("Field2 > 7") | new Criteria("Field2 < 3"))
```

现在 SQL 看起来像我们之前所希望的：

```sql
Field1 > 5 AND (Field2 > 7 OR Field2 < 3)
```

> 由于 Serenity 1.9.8+ 自动向二元条件添加括号，上面的表达式事实上将变为：
>```sql
>(Field1 > 5) AND (((Field2 > 7) OR (Field2 < 3)))
>```

## 比较运算符 (>, >=, <, <=, ==, !=)

我们重载了大多数 C# 比较运算符，所以你可以在条件中使用它们。

```
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

## 内联值（Inline Values）

当比较运算符的一侧是条件对象，而另一侧是整数、字符串、日期、guid 等值，这些值将被转换为条件参数。
 
```
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

当含有该条件的查询发送到 SQL，这些参数将具有相应的值。

自动参数编号默认从 1 开始，但最后一个编号存储在查询中，被条件使用，所以编号可能会变化。

让我们在查询中使用该条件：

```
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

这里是与之前列出表达式有相同的条件，参数编号从 3 而不是 1 开始。因为 2 之前的编号被用于其他 WHERE 子句。

所以参数编号使用查询作为上下文。你不应该做出参数名称将是什么的假设。

## ParamCriteria 和显式参数名

如果想要使用一些显式命名的参数，你可以使用 ParamCriteria：

```cs
new SqlQuery()
    .From("SomeTable")
    .Select("SomeField")
    .Where(new Criteria("SomeField") <= new ParamCriteria("@myparam"))
    .Where(new Criteria("SomeOtherField") == new ParamCriteria("@myparam"))
    .SetParam("@myparam", 5);
```

我们这里使用 SqlQuery 的 SetParam 扩展方法设置参数的值。

也可以事先声明此参数，然后重用它：

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

如果你不想使用参数化的查询，可以使用 ConstantCriteria 对象存储值。它们将不会转换为自动参数。

```
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

## Null 比较

在 SQL 中，使用像 ==，!= 的运算符比较 NULL 值，将返回 NULL。对于这样的比较，应使用 IS NULL 或 IS NOT NULL。

Criteria 对象没有重载防止 null（或 object）的比较，所以如果你尝试写下面的表达式，可能会得到错误：

```
new Criteria("a") == null; // what is type of null?

int b? = null;
new Criteria("c") == b; // no overload for nullable types
```

这些表达式都可以使用 IsNull 和 Nullable.Value 方法编写：

```
new Criteria("a").IsNull();
new Criteria("a").IsNotNull();
int? b = 5;
new Criteria("c") == b.Value;
```

如果你迫切希望这样写：Field = NULL，可以这样做：

```
new Criteria("Field") == new Criteria("NULL")
```

## LIKE 操作

Criteria 有 *Like, NotLike, StartsWith, EndsWith, Contains, NotContains* 方法，以帮助使用 LIKE 操作。

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

## IN 和 NOT IN 操作

在内联数组中使用 IN 或 NOT IN： 

```
new Criteria("A").In(1, 2, 3, 4, 5)
```

```sql
A IN (@p1, @p2, @p3, @p4, @p5) 
-- @p1 = 1, @p2 = 2, @p3 = 3, @p4 = 4, @p5 = 5
```

```
new Criteria("A").NotIn(1, 2, 3, 4, 5)
```

```sql
A NOT IN (@p1, @p2, @p3, @p4, @p5)
-- @p1 = 1, @p2 = 2, @p3 = 3, @p4 = 4, @p5 = 5
```

也可以向 IN 方法传递任何可枚举的参数：

```cs
IEnumerable<int> x = new int[] { 1, 3, 5, 7, 9 };
new Criteria("A").In(x);
```

```sql
A IN (1, 3, 5, 7, 9)
-- @p1 = 1, @p2 = 3, @p3 = 5, @p4 = 7, @p5 = 9
```

也可以使用子查询：

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

## NOT 操作

使用 C# 的 ! (not) 运算符表示 NOT 运算操作：

```cs
!(new Criteria("a") >= 5)
```

```sql
NOT (a >= @p1) -- @p1 = 5
```

## Field 对象的用法

到目前为止，我们已经使用 Criteria 对象构造函数来构建条件。Field 对象也有类似的重载，所以它们可以相互替代。

例如，以 Northwind 的 Order、 Detail 和 Customer 行（row）为例：

```
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

它将输出：

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