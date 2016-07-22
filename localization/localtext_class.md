# LocalText 类

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

字符串本地化的核心是 LocalText 类。

```cs
    public class LocalText
    {

        public LocalText(string key);
        public string Key { get; }
        public override string ToString();
        public static implicit operator string(LocalText localText);
        public static implicit operator LocalText(string key);
        public static string Get(string key);
        public static string TryGet(string key);

        public const string InvariantLanguageID = "";
        public static readonly LocalText Empty;
    }
```

它的构造函数接受一个 key 参数，它定义将要包含的本地化文本键（local text key）。一些键的示例：

- Enums.Month.January
- Enums.Month.December
- Db.Northwind.Customer.CustomerName
- Dialogs.YesButton

> 虽然它不是一个规则，但遵循 *点* 约定（如，本地化文本键）的命名空间是一个好的主意。

在运行时，通过 ToString() 函数，本地化文本键被翻译为当前语言（即 *CultureInfo.CurrentUICulture*）的表示形式。

```cs
var text = new LocalText("Dialogs.YesButton");
Console.WriteLine(text.ToString());
```

```
> Yes
```

如果本地化文本表（我们将在后面谈论它）中找不到该翻译，则返回 key 自身。

```cs
var text = new LocalText("Unknown.Local.Text.Key");
Console.WriteLine(text.ToString());
```

```
> Unknown.Local.Text.Key
```

> 这是特意设计的，以便开发人员可以查明没有被翻译的文本。


## LocalText.Key 属性

获取 LocalText 实例包含的本地化文本键。

## 从字符串中隐式转换

LocalText 可以从 String 类型隐式转换。

```cs
LocalText someText = "Dialogs.YesButton";
```

这里的 *someText* 变量得到一个键为 *Dialogs.YesButton* 的新 LocalText 实例引用。所以它是只是一个 LocalText 构造函数的快捷方式。

## 隐式转换为字符串

LocalText 也实现了 String 类型的隐式转换，但是它返回翻译而不是键（像调用 *ToString* 方法）。

```cs
var lt = new LocalText("Dialogs.NoButton");
string text = lt;
Console.WriteLine(text);
```

```
> No
```

## LocalText.Get 静态方法

若要访问本地化文本键翻译而无须创建一个 LocalText 实例，请使用 Get 方法：

```cs
Console.WriteLine(LocalText.Get("Dialogs.YesButton"));
```

```
> Yes
```

> *ToString()* 在 Get 方法内部被调用。

## LocalText.TryGet 静态方法

不像 Get 方法在找不到翻译时返回本地化文本键，TryGet 返回 null。因此，合并运算符（coalesce operator）必须与 TryGet 一起使用：

```cs
var translation = LocalText.TryGet("Looking.For.This.Key") ?? "Default Text";
Console.WriteLine(translation);
```

```
> Default Text
```

## LocalText.Empty 字段

类似于 String.Empty，LocalText 包含一个含空键（empty key）的空本地化文本对象。


## LocalText.InvariantLanguageID 常量

这只是固定语言ID (invariant language ID) 的空字符串，它是固定区域语言标识符（通常默认语言为英语）。

我们将在后面的章节谈论语言标识符（language identifiers）。
