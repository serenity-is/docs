# Mapping 特性

Serenity 提供一些映射特性，以匹配数据库的表、行的列名称。

## 列与表的映射约定

默认情况下，行(row)类移除 *Row* 后缀后，被认为匹配数据库中具有相同名称的表。

属性被认为匹配数据库中具有相同名称的列。


比方说我们有这样一个行定义：

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

如果我们写一个从 *CustomerRow* 中选择 *StreetAddress* 字段的查询，它就会产生下面语句：

```sql
SELECT 
T0.StreetAddress AS [StreetAddress] 
FROM Customer T0
```

根据约定，*CustomerRow* 匹配 *Customer* 表。类似地，*StreetAddress* 属性匹配名为 *StreetAddress* 的列。

`T0` 是一个特殊的别名，由 Serenity 行分配给主表。

由于 *StreetAddress* 列属于主表(*Customer*)，它具有选择表达式 `T0.StreetAddress` ，并且列别名为 `[StreetAddress]`。  

> 默认情况下使用属性名称作为列别名。

## SqlSettings.AutoQuotedIdentifiers 标识

在一些数据库系统，标识符是大小写敏感的。 

例如在 Postgress 中，如果创建一个带引号的标识符列 `"StreetAddress"`，当查找该列时，你必须使用引号。即使你这样写 `SELECT StreetAddress ...`（相同的大小写），它也不会工作。 

你必须使用这种形式 `SELECT "StreetAddress"`。

因此，Postgres 用户通常喜欢用小写字母的标识符。但 FluentMigrator 总是向标识符添加引号，所以我们需要一种变通方法来向标识符添加方括号/引号。

默认情况下，Serenity 不会向列和表名添加方括号/引号，但是它有兼容的设置。

如果 *SqlSettings.AutoQuotedIdentifiers* 标识设置为 true，上面的查询将会变为：

```sql
SELECT 
T0.[StreetAddress] AS [StreetAddress] 
FROM [Customer] T0
```

> Serenity 为了向后兼容，此标识设置默认为 *false*，但 Serene 1.8.6+ 在应用程序启动时把该标识设置为 *true*。


如果我们使用 Postgress 方言，将输出：

```sql
SELECT 
T0."StreetAddress" AS "StreetAddress"
FROM "Customer" T0
```

## Column 特性

[**命名空间**: *Serenity.Data.Mapping*] - [**程序集**: *Serenity.Data*]

使用 *Column* 特性，可以把属性映射为数据库的一些其它列名称。

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

现在查询将变为：

```sql
SELECT 
T0.street_address AS [StreetAddress] 
FROM Customer T0
```

也可以手动添加方括号：

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

> 如果 SqlSettings.AutoQuotedIdentifiers 为 true，将自动添加方括号。

> 如果需要使用多个数据库类型，请使用 SqlServer 特定的方括号(`[]`)。这些方括号在运行查询之前，将转换为方言特定的引号（双引号，引号等）。 

> 但是，如果只针对一种类型的数据库，你可能更喜欢使用特定于该数据库类型的引号。

## TableName 特性 

[**命名空间**: *Serenity.Data.Mapping*] - [**程序集**: *Serenity.Data*]

如果数据库的表名称不同于行(row)的类名，请使用此特性：

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

也可以使用方括号或引号：

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

> 此外，更喜欢兼容数据库的方括号。


## Expression 特性 

[**命名空间**: *Serenity.Data.Mapping*] - [**程序集**: *Serenity.Data*]

此特性用于指定一个非基本（non-basic）字段的表达式，例如，一个实际上不存在于数据库中的字段。

此类字段可以有几种类型。 

其中一个例子是：含计算表达式 `(T0.[Firstname] + ' ' + T0.[Lastname])` 的 Fullname 字段。如：

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

> 小心 "+" 运算符，因为在这里它是 Sql Server 特定的运算符。如果想要使用多种类型的数据库，你应该以这种方式写表达式：

> `CONCAT(T0.[Firstname], CONCAT(' ', T0.[Lastname]))`

Firstname 和 Lastname 是表字段（表的实际字段），但即使没有 Expression 特性，它们也有基本的隐式定义的表达式：`T0.Firstname` 和 `T0.Lastname` （在 Serenity 查询中，主表指定使用 `T0` 作为别名 ）。

> 在此文档中，当我们谈论一个 *表字段* 时，是指数据库表中实际对应的列字段。

> *视图字段(View Field)* 是指具有计算表达式的字段，或另一张表的字段（如 SQL 视图中来自联接的字段）。

 Fullname 表达式中使用 `T0` 别名引用字段。

> 在没有该前缀的情况下也可能工作。但最好使用前缀。当你开始添加联接时，可能有多个字段具有相同名称而导致列不明确的错误。 


## ForeignKey 特性

[**命名空间**: *Serenity.Data.Mapping*] - [**程序集**: *Serenity.Data*]

该特性用于指定外键列，并添加主表和相关主字段信息。

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

我们这里指定 *Customer* 表的 *CountryId* 字段有一个外键是 *Countries* 表的 *Id* 字段。

> 外键并不需要在数据库中存在。Serenity 不会检查它。

Serenity 可以利用这样的元信息，即使它不会影响生成单独的查询。

当我们与即将介绍的下一个特性一起使用时，ForeignKey 将更有意义。

## LeftJoin 特性

当查询数据库时，由于关联关系，往往会使用许多联接。大多数联接是 LEFT 或 INNER 连接。 

> 使用 Serenity 实体，通常会使用 LEFT JOIN。

数据库管理员更喜欢定义视图，使它更容易查询多个表的组合，并避免一次次编写这些联接。

Serenity 实体可以像 SQL 视图那样使用，所以你可以获得实体中其他表的列，并对其进行查询，就好像它们是一个大的组合表。

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

我们这里指定 *Cities* 表在关联时应分配别名 `c`，并且其关联类型应该是 `LEFT JOIN`。关联的 `ON` 条件表达式根据 *ForeignKey* 特性确定为 `c.[Id] == T0.[CountryId]`。

> 首选 LEFT JOIN ，因为即使 *Customers* 没有 CityId 设置，它也允许检索 *左（left）* 表的所有记录。

*CityName* 是一个视图字段（不是 Customer 表的字段），它有一个 *c.Name* 表达式。它表明 *CityName* 来自 *Cities* 表的 *Name* 字段。

现在，如果想要选择所有客户的城市名称，查询文本将变为：

```sql
SELECT 
c.Name AS [CityName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId)
```

如果我们 Customer 表没有 CountryId 字段，但我们想通过 city 表中的 CountryId 字段得到城市所属国家的名称，该怎么做呢？

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

这次我们在 Cities 表的 CountryId 字段使用 LEFT JOIN。指定 `o` 作为 Countries 表的别名，并从该表获得国家名称字段。

> 只要不是保留的关键字，你可以给联接分配任何表别名，并且实体中联接的别名应该是唯一的。Sergen 生成像 jCountry 这样的别名，但你可以用更短和更自然的方式重命名它们。

让我们从所有客户中选择 CityName 和 CountryName 字段：

```sql
SELECT 
c.[Name] AS [CityName],
o.[Name] AS [CountryName] 
FROM Customer T0 
LEFT JOIN Cities c ON (c.[Id] = T0.CityId) 
LEFT JOIN Countries o ON (o.[Id] = c.[CountryId])
```

> 我们将在 FluentSQL 章节看到如何生成这类查询。

到目前为止，我们已经在属性中同时使用 LeftJoin 和 ForeignKey 特性。 

也可以在实体类中附加 LeftJoin 特性。这在主实体没有相应字段的关联中非常有用。

例如，假设有一张 CustomerDetails 扩展表，存储一些客户的额外信息（一对一关系）。CustomerDetails 表有一个主键 *CustomerId*，它实际是 *Customer* 表 *Id* 字段的外键。

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

当选择 DeliveryAddress 时，在这里它看起来像：

```sql
SELECT 
cd.[DeliveryAddress] AS [DeliveryAddress] 
FROM Customer T0 
LEFT JOIN CustomerDetails cd ON (cd.[CustomerId] = T0.[Id])
```
