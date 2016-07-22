# Widget 类

## 部件的类图

![Widget Class Diagram](img/widget_hierarchy.jpg)

## 一个简单的部件示例

让我们来构建一个小部件，让 DIV 在每次单击后增加其字体的大小：

```cs
namespace MySamples
{
    public class MyCoolWidget : Widget
    {
        private int fontSize = 10;

        public MyCoolWidget(jQueryObject div)
            : base(div)
        {
            div.Click(e => {
                fontSize++;
                this.Element.Css("font-size", fontSize + "pt");
            });
        }
    }
}
```

```html
<div id="SomeDiv">Sample Text</div>
```

我们可以在 HTML 元素上创建该小部件，如：

```cs
var div = jQuery.Select("#SomeDiv");
new MyCoolWidget(div);
```

## Widget 类的成员

```cs
public abstract class Widget : ScriptContext
{
    private static int NextWidgetNumber = 0;

    protected Widget(jQueryObject element);
    public virtual void Destroy();

    protected virtual void OnInit();
    protected virtual void AddCssClass();

    public jQueryObject Element { get; }
    public string WidgetName { get; }
    public string UniqueName { get; }
}
```

### *Widget.Element* 属性

继承自 Widget 的类，可以通过 `Element` 属性得到它们创建的元素。

```cs
public jQueryObject Element { get; }
```

此属性的类型为 jQueryObject，并返回该元素，以在创建部件时使用。在我们的示例中。在点击事件中使用 `this.Element` 引用容器 DIV 元素。

### HTML 元素和部件的 *CSS 类*

当在 HTML 元素上创建部件时，它对元素进行一些修改。

首先，根据部件的类型，HTML 元素得到一个 CSS 类。

在我们示例中，`.s-MyCoolWidget` 样式类被添加到 ID 为 `#SomeDiv` 的 `DIV`。

因此，在创建部件之后，DIV 看起来类似于：

```html
<div id="SomeDiv" class="s-MyCoolWidget">Sample Text</div>
```

此 CSS 类是由部件类名前面添加 `s-` 前缀组成（可以通过重写 Widget.AddCssClass 方法改变该前缀）。

### 使用部件 CSS 类对 HTML 元素进行样式化

部件 CSS 类可以用于部件创建的 HTML 元素。

```css
.s-MyCoolWidget {
	background-color: red;
}
```

###  使用 *jQuery.Data* 函数从 HTML 元素获得部件

随着添加 CSS 类，部件的另一个信息也被添加到 HTML 元素，即使它不是明显的标签。可以通过在 Chrome 控制台输入如下代码查看此信息：

```js
> $('#SomeDiv').data()

> Object { MySamples_MyCoolWidget: $MySamples_MyCoolWidget }
```

因此，可以使用 `$.data` 函数获得一个附加到 HTML 元素的部件。在 C# 中，可以写成：

```cs
var myWidget = (MyCoolWidget)(J("#SomeDiv").GetDataValue('MySamples_MyCoolWidget'));
```

### WidgetExtensions.GetWidget 扩展方法

上面那行代码看起来有点长且复杂，可以用 Serenity 的快捷方式替代：

```cs
var myWidget = J("#SomeDiv").GetWidget<MyCoolWidget>();
```

如果 HTML 元素存在部件，上述代码则返回部件，否则将抛出异常：

```text
Element has no widget of type 'MySamples_MyCoolWidget'!
```

### WidgetExtensions.TryGetWidget 扩展方法

TryGetWidget 可以用于检查是否存在部件，如果不存在，则返回 `null`：

```cs
var myWidget = $('#SomeDiv').TryGetWidget<MyCoolWidget>();
```


### 在 HTML 元素创建多个部件

在同一类中只可以附加一个部件到 HTML 元素。

试图在一个元素上创建同一类(class) 的辅助部件，将引发以下错误：

```text
The element already has widget 'MySamples_MyCoolWidget'.
```

只要部件的行为不相互影响，可以向单个元素附加任意数量来自不同类(class) 的部件。

### Widget.*UniqueName* 属性

每个部件实例自动获得一个唯一的名称（如 `MySamples_MyCoolWidget3`），可以通过 `this.UniqueName` 属性访问该名称。

把这个唯一名称作为 HTML 元素和其它由部件自身产生的子元素的 ID 前缀非常有用。

它也可以用在事件类 `$.bind` 和 `'$.unbind'` ，附加 / 移除事件不会影响其它可能附加到元素的事件：

```cs
jQuery("body").Bind("click." + this.UniqueName, delegate { ... });
...

jQUery("body").Unbind("click." + this.UniqueName);
```

### Widget.Destroy 方法

有时可能需要释放附加的部件，而不是删除 HTML 元素自身。

Widget 类为该目的提供了 `Destroy` 方法。

在 Destroy 方法的默认实现中，由部件自身指定事件（通过使用 UniqueName 事件类）进行清理并从 HTML 元素中移除 CSS 类 (`.s-WidgetClass`) 。

自定义的部件类可能需要重写 Destroy 方法，以撤消更改 HTML 元素和释放资源（虽然不需要移除以前使用 UniqueName 类附加的事件）。

当从 DOM 中删除含部件的 HTML 元素时，会自动调用 Destroy 方法。也可以手动调用该方法。

如果销毁(destory) 操作不能被正确执行，在某些浏览器中就可能会出现内存泄漏。

