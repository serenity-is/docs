# TemplatedWidget 类

部件在其构造函数或其它方法生成复杂的 HTML 标签，因此可能导致类具有很多难以维护的意大利面条式的代码。此外，由于标签就定在程序代码中，可能难以自定义输出。

```cs
public class MyComplexWidget : Widget
{
	public MyComplexWidget(jQueryObject div)
    	: base(div)
    {
		var toolbar = J("<div>")
        	.Attribute("id", this.UniqueName + "_MyToolbar")
            .AppendTo(div);

        var table = J("<table>")
        	.AddClass("myTable")
            .Attribute("id", this.UniqueName + "_MyTable")
            .AppendTo(div);

        var header = J("<thead/>").AppendTo(table);
        var body = J("<tbody/>").AppendTo(table);
        ...
        ...
        ...
    }
}
```

通过使用 HTML 模板，可以避免这种问题。例如，我们可以向 HTML 页面添加下列模板：

```html
<script id="Template_MyComplexWidget" type="text/html">
<div id="~_MyToolbar">
</div>
<table id="~_MyTable">
	<thead><tr><th>Name</th><th>Surname</th>...</tr></thead>
    <tbody>...</tbody>
</table>
</script>
```

在这里使用了 `SCRIPT` 标签，但通过指定其类型为 `"text/html"`，浏览器不会把它当成真正的脚本来执行。

让我们通过使用 TemplatedWidget 重写之前的意大利面条式的代码块：

```cs
public class MyComplexWidget : TemplatedWidget
{
	public MyComplexWidget(jQueryObject div)
    	: base(div)
    {
    }
}
```

当在一个 HTML 元素上创建该小部件，其内容如下：

```html
<div id="SampleElement">
</div>
```

你最终将得到这样的 HTML 标签：

```html
<div id="SampleElement">
    <div id="MySamples_MyComplexWidget1_MyToolbar">
    </div>
    <table id="MySamples_MyComplexWidget1_MyTable">
        <thead><tr><th>Name</th><th>Surname</th>...</tr></thead>
        <tbody>...</tbody>
    </table>
</div>
```

TemplatedWidget 自动查找类的模板，并将它应用于 HTML 元素。

## 生成 TemplatedWidget 的 ID

如果你仔细观察，在模板中我们为子元素指定 ID ： `~_MyToolbar` 和 `~_MyTable` 。

但是当该模板应用到 HTML 元素时，结果标签使用的 ID 却是 **MySamples_MyComplexWidget1_MyToolbar** 和 `MySamples_MyComplexWidget1_MyTable`。

TemplatedWidget 使用部件的 `唯一名称` 和下划线 ("_") (`this.idPrefix` 包含合并的前缀) 替换 `~_` 前缀。

使用该策略，即使同一部件模板在页面中用于多个 HTML 元素，其 ID 也不会互相冲突，因为它们都有唯一的 ID。

## TemplatedWidget.ByID 方法

TemplateWidget 向生成的标签追加一个唯一的名称，部件模板中的 ID 属性不能用于访问创建部件后的元素。

部件的唯一名称和下划线应该放在查找元素的模板中的原始 ID 属性前面：

```cs
public class MyComplexWidget : TemplatedWidget
{
	public MyComplexWidget(jQueryObject div)
    	: base(div)
    {
    	J(this.uniqueName + "_" + "Toolbar").AddClass("some-class");
    }
}
```

也可以使用 TemplatedWidget 的 ByID 方法替代：

```cs
public class MyComplexWidget
{
	public MyComplexWidget(jQueryObject div)
    	: base(div)
    {
    	ByID("Toolbar").AddClass("some-class");
    }
}
```

## TemplatedWidget.GetTemplateName 方法

在最近的示例中，`MyComplexWidget` 自动查找其模板。

TemplatedWidget 根据约定找到其模板（根据编码约定）。它在类名称之前插入 `Template_` 前缀，搜索含此 ID 属性 (`Template_MyComplexWidget`) 的 `SCRIPT` 元素，并使用其 HTML 内容作为模板。

如果我们想使用另一个像下面的 ID ：

```html
<script id="TheMyComplexWidgetTemplate" type="text/html">
	...
</script>
```

在浏览器控制台中将看到下面的错误：

```text
Can't locate template for widget 'MyComplexWidget' with name 'Template_MyComplexWidget'!
```

我们可以修改模板 ID 或要求部件使用自定义 ID ：

```cs
public class MyComplexWidget
{
	protected override string GetTemplateName()
    {
    	return "TheMyComplexWidgetTemplate";
    }
}
```

## TemplatedWidget.GetTemplate 方法

`GetTemplate` 方法可以被重写，以从另一个资源提供或手动指定模板：

```cs
public class MyCompleWidget
{
	protected override string GetTemplate()
    {
    	return $('#TheMyComplexWidgetTemplate').GetHtml();
    }
}
```

## Q.GetTemplate 方法和服务端模板

默认调用 `GetTemplateName` 方法并搜索具有该 ID 的 `SCRIPT` 元素来实现 `TemplatedWidget.GetTemplate` 方法。

如果没有找到这样的 SCRIPT 元素，可使用同一 ID 调用 `Q.GetTemplate` 方法获取模板。

如果也不返回结果，则会抛出错误。

`Q.GetTemplate` 可访问定义在服务端的模板。这些模板从 `~/Views/Template` 、 `~/Modules` 或它们的子文件夹中含 `.template.cshtml` 扩展的文件编译而来。

例如，我们在服务端为 MyComplexWidget 创建一个模板文件 `~/Views/Template/SomeFolder/MyComplexWidget.template.cshtml`，其内容如下：

```html
<div id="~_MyToolbar">
</div>
<table id="~_MyTable">
	<thead><tr><th>Name</th><th>Surname</th>...</tr></thead>
    <tbody>...</tbody>
</table>
```

模板文件名和扩展名是很重要的，而其文件夹会被完全忽略。

使用该策略就不需要将部件模板插入到页面标签中。

此外，由于这种服务端的模板在首次使用时加载（延迟加载），并在浏览器和服务器中缓存，页面标签没有被可能永远不会在特定网页使用的部件模板污染。因此，服务端模板青睐内嵌 SCRIPT 模板。
