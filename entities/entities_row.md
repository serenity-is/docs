# 实体(Row)


Serenity 实体系统是一个微 ORM，它像 Dapper 那样对 SQL 情有独钟。

不同于完全成熟的ORM，如 NHibernate/Entity Framework，Serenity 提供智能感知地映射和查询数据库所需的最小功能、编译时检查和容易的重构。

Serenity 的实体通常像 *XYZRow* 这样命名。它们是 *Serenity.Data.Row* 子类。

让我们来定义一个简单的行类：


```cs
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;

public class SimpleRow : Row
{
	public string Name
	{
		get { return Fields.Name[this]; }
		set { Fields.Name[this] = value; }
	}
	
	public Int32? Age
	{
		get { return Fields.Age[this]; }
		set { Fields.Age[this] = value; }
	}
	
	public static RowFields Fields = new RowFields().Init();
	
	public SimpleRow()
		: base(Fields)
	{
	}

	public class RowFields : RowFieldsBase
	{
		public StringField Name;
		public Int32Field Age;
	}	
}
```

> 是的，与一个简单的 POCO 类相比，它看起来有点复杂。它不需要像一些 Orm （实体框架，NHibernate 等）那样使用代理类来让一些功能工作。

> 这种结构使我们能够用零反射构建查询，在需要时启用 INotifyPropertyChanged 跟踪作业。它也可以与用户自定义的字段一起工作。

> 行(Row)被序列化为 JSON ，这样就可以从服务器返回。你不需要额外的 POCO/DTO 类，除非你有使用它们的好理由。

让我们先学习行的声明部分。

```cs
public class SimpleRow : Row
```

我们在这里定义了一个名为 SimpleRow 的实体，它可能映射数据库中名为 `Simple` 的表。

这里的 *Row* 后缀不是必须的，但通常加上该后缀可避免与其他的类名称发生冲突。

所有的实体类继承自 `Serenity.Data.Row` 基类。

```cs
public string Name
{
	get { return Fields.Name[this]; }
	set { Fields.Name[this] = value; }
}
```

我们现在声明第一个属性。此属性映射到数据库的 `Simple` 表 `Name` 列。

这里不能使用自动属性（如 `get; set;`）。必须通过称为 *Field* 的特定对象来读取和设置字段的值。

Field 对象非常类似于 WPF 的依赖属性。下面是依赖属性的声明示例：

```cs
public static readonly DependencyProperty MyCustomProperty = 
    DependencyProperty.Register("MyCustom", typeof(string), typeof(Window1));

public string MyCustom
{
    get { return this.GetValue(MyCustomProperty) as string; }
    set { this.SetValue(MyCustomProperty, value); }
}
```

我们在这里定义了一个静态依赖属性对象(MyCustomProperty)，它包含属性元数据可以允许我们通过 *GetValue* 和 *SetValue* 方法读取和设置属性的值。依赖属性允许 WPF 提供验证、 数据绑定、 动画及更多的功能。

类似于依赖属性，Field 对象包含列的元数据和一些如任务跟踪（assignment tracking）、不使用表达式树构建的查询、变更通知等辅助功能。

虽然依赖属性被声明为所使用类的静态成员， Field 对象在一个名为 RowFields 的嵌套类中声明。这样可更容易分组和获取引用，而不用添加 *Field* 或 *Property* 后缀，并从实体中保持清晰的字段声明。

```cs
public Int32? Age
{
	get { return Fields.Age[this]; }
	set { Fields.Age[this] = value; }
}
```

这是我们的第二个属性： `Int32?` 类型的 `Age`。

Serenity 实体属性始终是可空的，即使数据库中的列类型不是可空类型。

> Serenity 从不会在 null 的位置使用 0。

如果你有使用其他 ORM 的经验，会发现这似乎不合逻辑，但请考虑这种情况：

一个非空字段不可能有 null 值，但如果通过 left/right 联接查询呢？在这种情况下，如果检索到的值是 null 或 0 ，你要怎么处理呢？

> 引用类型已经是可空类型，所以你不能使用 `String?`。

```cs
public static RowFields Fields = new RowFields().Init();

```

我们注意到，Field 对象在名为 *RowFields*（通常）嵌套子类中声明。在这里，我们创建它的唯一静态实例。因此，每个行类型(row type)只有一个 RowFields 实例，并且每个行属性(row property)只有一个 Field 实例 。

`Init` 是初始化 *RowFields* 成员的扩展方法，它将创建没有显式初始化的 Field 对象。

```cs
public SimpleRow()
	: base(Fields)
{
}
```

现在我们定义 SimpleRow 带参数的构造函数。基类 *Row* 需要一个 RowFields 实例，我们为其传递静态对象 *Fields* 。因此，行类型(SimpleRow)的所有实例共享单个 *RowFields* (SimpleRow.RowFields) 实例。这意味着它们共享所有元数据。

```cs
public class RowFields : RowFieldsBase
{
	public StringField Name;
	public Int32Field Age;
}
```

我们在这里定义包含字段对象的嵌套类。它继承自 `Serenity.Data.RowFieldsBase`。*RowFieldsBase* 是一个与 *Row* 相关的特殊类，包含表的元数据。

我们分别声明一个 *StringField* 和 *Int32Field* 类型的字段。它们的类型基于其属性的类型，并且必须完全匹配。

它们的名称必须与属性名称匹配，否则你将得到一个初始化错误。

我们没有初始化这些字段对象，因此它们的初始值为 null。

记得我们上面写的 `new RowFields().Init()`，这是字段对象自动创建的地方。

> 也可以在 RowFields 构造函数中手动初始化它们，但是除了需要特殊定制，不建议这样做。

