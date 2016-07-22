# FieldFlags 枚举

[**命名空间**: *Serenity.Data.Mapping*] - [**程序集**: *Serenity.Data*]

Serenity 有一组字段标识控制字段行为。

```cs
public enum FieldFlags
{
    None = 0,
    Insertable = 1,
    Updatable = 2,
    NotNull = 4,
    PrimaryKey = 8,
    AutoIncrement = 16,
    Foreign = 32,
    Calculated = 64,
    Reflective = 128,
    ClientSide = 256,
    Trim = 512,
    TrimToEmpty = 512 + 1024,
    DenyFiltering = 2048,
    Unique = 4096,
    Default = Insertable | Updatable | Trim,
    Required = Default | NotNull,
    Identity = PrimaryKey | AutoIncrement | NotNull
}
```

普通表字段有 *Insertable*、*Updatable* 和 *Trim* 默认设置，对应于 *Default* 组合标识。

## Insertable 标识

*Insertable* 标识控制字段在新增记录状态下是否可编辑。默认情况下，所有普通字段都被认为是可插入的。

某些字段可能不是在数据库表中插入的，如，标识(identity) 列不应该有该标识设置。

当字段没有该标识，在新增记录状态的表单下不能编辑该字段。在服务端的仓库层同样有效。

有时候，内部字段可能在 SQL INSERT 声明中完全有效，但不应该在表单中编辑。一个例子是 InsertedByUserId 应在服务层面上设置，而不是由终端用户设置。如果我们让终端用户可以在表单中编辑它，这将是一个安全漏洞。此类字段也不应该具有 Insertable 标识设置。

> 这意味着字段标识不需要与数据库表的设置相匹配。


## Insertable 特性

要取消字段的 Insertable 标识，可以使用 [Insertable(false)] 特性：

```vs
[Insertable(false)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```


使用 *Insertable(true)* 启用标识符功能。

> 非可插入字段在表单中是不隐藏的。它们只是处于只读状态。如果你想隐藏它们，请使用 [HideOnInsert] 特性 (Serenity 1.9.8+) ，或者使用 *form.MyField.GetGridField().Toggle(IsNew)* 重写对话框中 *UpdateInterface* 方法。

## Updatable 标识

该标识就像 *Insertable* 标识，但是控制表单记录的编辑状态和服务端的更新操作。默认情况下，所有普通字段都被认为是可更新的。

## Updatable 特性

要取消字段的 Updatable 标识，可以使用 [Updatable(false)] 特性：

```vs
[Updatable(false)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```


使用 *Updatable(true)* 启用标识符功能。

> 非可插入字段在表单中是不隐藏的。它们只是处于只读状态。如果你想隐藏它们，请使用 [HideOnInsert] 特性 (Serenity 1.9.8+) ，或者使用 *form.MyField.GetGridField().Toggle(IsNew)* 重写对话框中 *UpdateInterface* 方法。

## Trim 标识

该标识只对字符串类型的字段有效，它控制着值在保存之前是否被修剪。所有字符串默认包含该标识。

当字段值是空字符串或全是空格，它将被修剪为 null 。

## TrimToEmpty 标识

如果你更喜欢把字符串字段修剪为空的字符串，而不是 null，则使用此标识。

当字段值是 null 或全是空格，它将被修剪为空字符串。

## SetFieldFlags 特性

此属性可用于在字段中包含或排除一组标识。第一个参数是必需的，表示包含的标识；第二个是可选参数，表示排除的标识。

要启用字段中的 TrimToEmpty 标识，我们可以这样使用：

```vs
[SetFieldFlags(FieldFlags.TrimToEmpty)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

要取消 Trim 标识，则：

```vs
[SetFieldFlags(FieldFlags.None, FieldFlags.TrimToEmpty)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

要包含 TrimToEmpty 和 Updatable ，并移除 Insertable，则：
```vs
[SetFieldFlags(
    FieldFlags.Updatable | FieldFlags.TrimToEmpty,
    FieldFlags.Insertable)]
public string MyField
{
    get { return Fields.MyField[this];
    set { Fields.MyField[this] = value;
}
```

> Insertable 和 Updatable 特性是 SetFieldFlags 特性的子类。

## NotNull 标识

使用该标识设置字段为不可空。默认情况下，该标识使用 NotNull 特性设置字段在数据库为不可空字段。

当字段是不可空的，它在表单对应的标签中有一个红色的星号，并要求必须输入值。

## NotNullable 特性

在字段中使用 NotNull 特性启用非空限制，移除该特性表示取消该限制。

即使字段在数据库中不是可空的，也可以使用 [Required(false)] 让字段在表单中变为非必填字段。它不会清除 NotNull 标识。 

## Required 标识

这是 Default 和 NotNullable 标识的组合。

> 它与表单中控制验证的 [Required] 特性没有关系。

## PrimaryKey 标识和 PrimaryKey 特性

为表中的主键字段设置该标识。

> 列表和检索请求处理程序的 Key 列选择模式选择主键字段。

使用 [PrimaryKey] 特性启用该标识。

## AutoIncrement 标识和 AutoIncrement 特性

设置此字段在服务器端是自动递增，例如，标识列或使用生成器（generator）的列。

## Identity 标识和 Identity 特性

这是 PrimaryKey、AutoIncrement 和 NotNull 标识的组合，常用于标识列。

## Foreign 标识

该标识设置通过联接其他表得到的外来视图字段。

它自动为字段设置表达式，该表达式包含 T0 以外的表别名。

例如，如果一个字段有像 [Expression("jCountry.CountryName")] 这样的特性，它将有此标识。

> 该标识与 ForeignKey 特性没有关系。

## Calculated 标识

如果字段的表达式有涉及多个字段或一些数学运算，它将有此标识。

也可以为在 SQL 服务器端计算的字段设置此标识。

## ClientSide 标识和 ClientSide 特性

对应于 Serenity 实体未映射的字段。它们没有在数据库表中对应的字段。

这些类型的字段可以用于临时计算、存储及客户端和服务层上的传输。

## Reflective 标识

是用于未映射字段的一种高级形式，这些字段没有存储在行中，但反映了另一个不同形式的字段值。例如，绝对值显示为整数的字段也可以是负整数。

应该只在极少数情况下，对这类未映射的字段使用该标识。

## DenyFiltering 标识

如果设置该标识，则表示拒绝对敏感字段进行过滤操作。对于像 PasswordHash 这样的机密字段很有用，不应该允许由客户端选择或过滤这些机密字段。

## Unique 标识和 Unique 特性

当字段有该标识，在数据库中与现有值进行检查以确保其值必须是唯一的。

你可以使用 Unique 特性启用该标识，并确定是否应在服务级别检查此约束（在数据库级别检查以避免出现神秘约束的错误）。