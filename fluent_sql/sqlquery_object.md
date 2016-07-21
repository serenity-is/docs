# SqlQuery 对象

[**命名空间**: *Serenity.Data*] - [**程序集**: *Serenity.Data*]

SqlQuery 通过一个流式接口编写动态 SQL SELECT 查询。

# 优点

SqlQuery 比手写 SQL 有如下优势：

* 使用 Visual Studio 的智能感知功能编写 SQL；

* 最小开销的流式接口；

* 由于在编译时而不是运行时检查查询语法，所以可减少语法错误；

* 像 Select、 Where、 Order By 这样的子句可以按任何顺序使用。当查询转换为字符串时，它们被放到正确的位置。类似地，这些子句可以使用多次并且在转换为字符串时被合并。因此你可以根据输入参数有条件地构建 SQL。

* 不再搞砸参数和参数名称。所有使用的值转换为自动命名参数。如果需要，你也可以使用手动命名的参数；

* 可以生成一个特殊的查询，可以在非原生支持分页的服务器类型 （如 SQL Server 2000）中执行分页；

* 通过方言系统，可以针对特定的服务器类型和版本进行查询；

* 如果与 Serenity 实体（可以像 Dapper 那样使用的微型 ORM）一起使用，有助于从 DataReader 零反射加载查询结果。它也支持自动左/右联接。


## 如何使用这里的示例

我推荐使用 LinqPad 执行这里给出的示例。

你应该添加 *Serenity.Core*、 *Serenity.Data* 和 *Serenity.Data.Entity* 的 NuGet 程序包引用。

另一种做法是从一个 Serene 的应用程序的 *bin* 或程序包目录中找到并直接引用这些 DLL。

请确保在查询属性（Query Properties）对话框中的导入额外命名空间（Additional Namespace Imports）中添加 *Serenity* 和 *Serenity.Data* 。

## 一个简单的 Select 查询示例

```csharp
void Main()
{
    var query = new SqlQuery();
    query.Select("Firstname");
    query.Select("Surname");
    query.From("People");
    query.OrderBy("Age");
    
    Console.WriteLine(query.ToString());
}
```

这将输出结果：

```sql
SELECT 
Firstname,
Surname 
FROM People 
ORDER BY Age
```

在程序的第一行，我们调用 SqlQuery 的唯一无参构造函数。如果此时调用 *ToString()*，将输出：

```sql
SELECT FROM
```

SqlQuery 不会进行任何语法验证。它只是通过调用其方法转换成你自己构建的查询。即使你没有选择任何字段或调用 From 方法，它也将生成基本的 SELECT FROM 语句。

> SqlQuery 不能生成空查询。

然后，我们调用 `Select` 方法，并向其传递 `"FirstName"` 字符串参数。现在我们的查询将变为：

```sql
SELECT Firstname FROM
```

当执行 `Select("Surname")` 声明时，SqlQuery 在上一检索字段（*Firstname*）和当前检索字段之间添加逗号：

```sql
SELECT Firstname, Surname FROM
```

在执行 *From* 和 *OrderBy* 方法之后，最终输出：

```sql
SELECT Firstname, Surname FROM People ORDER BY Age
```


## 方法调用顺序和它的影响

在前面的示例，即使我们重新调整 *From*、 *OrderBy* 和 *Select* 行的顺序，输出的结果也不会发生变化。只有修改 *Select* 声明的顺序才会改变输出结果。

```csharp
void Main()
{
    var query = new SqlQuery();
    query.From("People");
    query.OrderBy("Age");
    query.Select("Surname");
	query.Select("Firstname");
    
    Console.WriteLine(query.ToString());
}
```

但是，只有 SELECT 语句内部的列顺序会发生改变：

```sql
SELECT 
Surname,
Firstname 
FROM People 
ORDER BY Age
```

你可以按任意顺序使用 Select、 From、 OrderBy、 GroupBy 方法，并且可混合使用（如：先调用 Select，然后调用 OrderBy，之后再次调用 Select …… ）。

> 建议把 FROM 放在查询的开头，特别是与 Serenity 实体一起使用时，因为这样做有助于自动联接、决定数据库方言等。


## 方法链

每行使用 `query.` 开头显得冗长且可读性比较差。几乎所有的 *SqlQuery* 方法是链式的，并把查询本身作为结果返回。

我们可以像下面这样重写该查询：

```csharp
void Main()
{
    var query = new SqlQuery()
    	.From("People")
    	.Select("Firstname")
    	.Select("Surname")
    	.OrderBy("Age");
    
    Console.WriteLine(query.ToString());
}
```

> 该功能类似于 jQuery 和 LINQ 可枚举方法链。

我们甚至可以去掉查询变量：

```csharp
void Main()
{
    Console.WriteLine(
        new SqlQuery()
        	.From("People")
        	.Select("Firstname")
        	.Select("Surname")
        	.OrderBy("Age")
    		.ToString());
}```


> 强烈建议把每个方法放在它自己的行中，且为了可读性和一致性，请使用合适的缩进。

## Select Method

```csharp
public SqlQuery Select(string expression)
```

在前面的示例中，我们使用上述的 *Select* 重载方法（它大约有 11 个重载方法）。

Expression 参数可以是简单的字段名称或像 `"FirstName + ' ' + LastName"` 这样的表达式。

每当调用此方法，设置的表达式以逗号间隔添加到 SELECT 语句的查询结果。

还有一个 SelectMany 方法，可以在一个调用中选择多个字段：

```csharp
public SqlQuery SelectMany(params string[] expressions)
```

例如：

```csharp
void Main()
{
    var query = new SqlQuery()
        .From("People")
        .SelectMany("Firstname", "Surname", "Age", "Gender")
        .ToString();
    
    Console.WriteLine(query.ToString());
}
```

```sql
SELECT 
Firstname,
Surname,
Age,
Gender 
FROM People
```

> 我个人更喜欢通过多次调用 Select 方法来实现该目的。

你可能会想：为什么 *SelectMany* 并不是 *Select* 的另一重载？这是因为 *Select* 有一个更为常用的重载，可以选择含别名的列：

```csharp
public SqlQuery Select(string expression, string alias)
```

```csharp
void Main()
{
    var query = new SqlQuery()
        .Select("(Firstname + ' ' + Surname)", "Fullname")
        .From("People")
        .ToString();
    
    Console.WriteLine(query.ToString());
}```

```sql
SELECT 
(Firstname + ' ' + Surname) AS [Fullname] 
FROM People
```


## From 方法

```csharp
public SqlQuery From(string table)
```

SqlQuery.From 方法至少应被调用一次（通常一次）。

> 建议在查询中首先调用该方法。

当第二次调用该方法，表名称将以逗号间隔添加到 FROM 声明。因此，它将变为 CROSS JOIN：

```csharp
void Main()
{
	var query = new SqlQuery()
		.From("People")
		.From("City")
		.From("Country")
		.Select("Firstname")
		.Select("Surname")
		.OrderBy("Age");
    
    Console.WriteLine(query.ToString());
}
```

```sql
SELECT 
Firstname,
Surname 
FROM People, City, Country 
ORDER BY Age
```

## 在 SqlQuery 中使用别名对象

当引用表的数量增加时，通常使用表别名，此时我们的查询变得更长：


```csharp
void Main()
{
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

虽然它可以这样工作，但可以更好地把 `p`、 `c` 和 `o` 定义为 *Alias* 对象。

```csharp
var p = new Alias("Person", "p");
```

Alias 对象为表指定简称。它有索引和操作运算符的重载来生成访问 SQL 成员的表达式，如 `p.Surname` 。

```csharp
void Main()
{
	var p = new Alias("Person", "p");
	Console.WriteLine(p + "Surname"); // + operator overload
	Console.WriteLine(p["Firstname"]); // through indexer
}
```

```
p.Surname
p.Firstname
```

> 不幸的是，不能重载 C# 的成员访问运算符 (.)，因此，我们不得不使用 (+) 。一种替代方法是使用 dynamic，但是它的表现并不佳。

让我们使用 Alias 对象修改查询：

```csharp
void Main()
{
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

如上所示，结果是相同的，但代码有点长。那么使用别名有什么优点呢？

如果我们有一个含字段名称的常量列表：

```csharp
void Main()
{
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
}
```

我们就可以利用智能感知功能和编译时检查。

显然，它不是很符合逻辑并且难以定义每个查询的字段名称。应该在一个集中的位置或实体声明中定义别名。

让我们使用 Alias 创建一个人员的简单 ORM：

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
}```


现在我们有一组含字段名称和可以在所有查询中重用的表别名类。

> 这只是一个解释别名的示例，我并不推荐写这样的类。实体(Entities) 提供了更多的功能。

在上面的示例，我们使用包含 *Alias* 参数的 *SqlQuery.From* 重载：

```csharp
public SqlQuery From(Alias alias)
```

当调用此方法时，表名称和它的别名被添加到查询的 *FROM* 子句。


## OrderBy 方法

```csharp
public SqlQuery OrderBy(string expression, bool desc = false)
```

OrderBy 也可以在调用时含字段名称或表达式（如，Select）。

如果你指定可选参数  *desc* 为 true，将在字段名称或表达式附加关键词 `DESC`。

默认情况下，OrderBy 附加指定的表达式到 ORDER BY 语句末尾。但有时你可能想在起始处插入表达式/字段。

例如，有一些预定义顺序的查询，但如果用户在网格中对列进行排序，列名称应被插入到索引为 0 的位置。

```csharp
public SqlQuery OrderByFirst(string expression, bool desc = false)
```

```csharp
void Main()
{
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

## Distinct 方法

```csharp
public SqlQuery Distinct(bool distinct)
```

使用此方法在 SELECT 语句预置 DISTINCT 关键字。

```csharp
void Main()
{
	var query = new SqlQuery()
    	.Select("Firstname")
    	.Select("Surname")
        .From("Person")
        .OrderBy("PersonID")
		.Distinct(true);
		
    Console.WriteLine(query.ToString());
}
```

```sql
SELECT DISTINCT 
Firstname,
Surname 
FROM Person 
ORDER BY PersonID 
```

## GroupBy 方法

```csharp
public SqlQuery GroupBy(string expression)
```

GroupBy  的行为类似于 OrderBy，但没有 GroupByFirst 变体。


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


## Having 方法

```csharp
public SqlQuery Having(string expression)
```

Having 可以和 GroupBy （尽管它并不检查 GroupBy）一起使用，并且在表达式末尾追加 HAVING 语句。


```csharp
void Main()
{
	var query = new SqlQuery()
        .From("Person")
        .Select("Firstname")
		.Select("Lastname")
		.Select("Count(*)")
        .GroupBy("Firstname")
        .GroupBy("LastName")
		.Having("Count(*) > 5");
		
    Console.WriteLine(query.ToString());
}
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

## 分页操作(SKIP / TAKE / TOP / LIMIT)

```csharp
public SqlQuery Skip(int skipRows)

public SqlQuery Take(int rowCount)
```

SqlQuery 有类似于 LINQ 的 Take 和 Skip 的分页方法。

数据库类型决定映射的 SQL 关键字。

> 由于 SqlServer 2012 之前的版本没有等效的 SKIP 方法，若要使用 SKIP 方法，你的查询应该至少有一个 ORDER BY 语句，因为需要使用 ROW_NUMBER() 。如果你使用 SqlServer 2012+ 的方言，就没有该要求。

```csharp
void Main()
{
	var query = new SqlQuery()
        .From("Person")
        .Select("Firstname")
		.Select("Lastname")
		.Select("Count(*)")
        .OrderBy("PersonId")
		.Skip(100)
		.Take(50);
		
    Console.WriteLine(query.ToString());
}
```

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
ORDER BY PersonId OFFSET 100 ROWS FETCH NEXT 50 ROWS ONLY
```

> 在该示例中，默认使用 SQLServer2012 方言。

## 支持数据库方言

在我们的分页示例中，SqlQuery 使用与 Sql Server 2012 兼容的语法。

通过 Dialect 方法，可以更改 SqlQuery 的目标服务器类型：

```csharp
public SqlQuery Dialect(ISqlDialect dialect)
```

这些是支持的方言类型列表：

```csharp
FirebirdDialect
PostgresDialect
SqliteDialect
SqlServer2000Dialect
SqlServer2005Dialect
SqlServer2012Dialect
```

如果我们想在 Sql Server 2005 中查询：

```csharp
void Main()
{
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
}
```

```sql
SELECT * FROM (
SELECT TOP 150 
Firstname,
Lastname,
Count(*), ROW_NUMBER() OVER (ORDER BY PersonId) AS __num__ 
FROM Person) __results__ WHERE __num__ > 100
```

若使用 SqliteDialect.Instance，将输出：

```sql
SELECT 
Firstname,
Lastname,
Count(*) 
FROM Person 
ORDER BY PersonId LIMIT 50 OFFSET 100
```

如果在应用程序中只使用一种类型的数据库，你可以通过设置默认方言以避免每次开始查询时都要选择方言：

```csharp
SqlSettings.DefaultDialect = SqliteDialect.Instance;
```

在应用程序的启动方法（如 global.asax.cs）中添加上述代码。
