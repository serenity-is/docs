# TemplatedWidget Class

A widget that generates a complicated HTML markup in its constructor or other methods might lead to a class with much spaghetti code that is hard to maintain. Besides, as markup lies in program code, it might be difficult to customize output.

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

Such problems can be avoided by using HTML templates. For example, lets add the following template into the HTML page:

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

Here, a `SCRIPT` tag is used, but by specifying its type as `"text/html"`, browser won't recognize it as a real scriptto execute.

By making use of TemplatedWidget, lets rewrite previous spaghetti code block:

```cs
public class MyComplexWidget : TemplatedWidget
{
	public MyComplexWidget(jQueryObject div)
    	: base(div)
    {
    }
}
```

When this widget is created on an HTML element like following:

```html
<div id="SampleElement">
</div>
```

You'll end up with such an HTML markup:

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

TemplatedWidget automatically locates the template for your class and applies it to the HTML element.

## TemplatedWidget ID Generation

If you watch carefully, in our template we specified ID for descendant elements as `~_MyToolbar` and `~_MyTable`.

But when this template is applied to the HTML element, resulting markup contained ID's of **MySamples_MyComplexWidget1_MyToolbar** and `MySamples_MyComplexWidget1_MyTable` instead.

TemplatedWidget replaces prefixes like `~_` with the widget's `UniqueName` and underscore ("_") (`this.idPrefix` contains the combined prefix).

Using this strategy, even if the same widget template is used in a page for more than one HTML element, their ID's won't conflict with each other as they will have unique ID's.

## TemplatedWidget.ByID Method

As TemplateWidget appends a unique name to them, the ID attributes in a widget template can't be used to access elements after widget creation.

Widget's unique name and an underscore should be prepended to the original ID attribute in the template to find an element:

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

TemplatedWidget's ByID method can be used instead:

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

## TemplatedWidget.GetTemplateName Method

In the last sample `MyComplexWidget` located its template automatically.

TemplatedWidget makes use of a convention to find its template (convention based programming). It inserts `Template_` prefix before the class name and searches for a `SCRIPT` element with this ID attribute (`Template_MyComplexWidget`) and uses its HTML content as a template.

If we wanted to use another ID like following:

```html
<script id="TheMyComplexWidgetTemplate" type="text/html">
	...
</script>
```

An error like this would be seen in the browser console:

```text
Can't locate template for widget 'MyComplexWidget' with name 'Template_MyComplexWidget'!
```

We might fix our template ID or ask the widget to use our custom ID:

```cs
public class MyComplexWidget
{
	protected override string GetTemplateName()
    {
    	return "TheMyComplexWidgetTemplate";
    }
}
```

## TemplatedWidget.GetTemplate Method

`GetTemplate` method might be overriden to provide a template from another source or specify it manually:

```cs
public class MyCompleWidget
{
	protected override string GetTemplate()
    {
    	return $('#TheMyComplexWidgetTemplate').GetHtml();
    }
}
```

## Q.GetTemplate Method and Server Side Templates

Default implementation for `TemplatedWidget.GetTemplate` method calls `GetTemplateName` and searches for a `SCRIPT` element with that ID.

If no such SCRIPT element is found, `Q.GetTemplate` is called with the same ID.

An error is thrown if neither returns a result.

`Q.GetTemplate` method provides access to templates defined on the server side. These templates are compiled from files with `.template.cshtml` extension in `~/Views/Template` or `~/Modules` folders or their subfolders.

For example, we could create a template for MyComplexWidget in a server side file like `~/Views/Template/SomeFolder/MyComplexWidget.template.cshtml` with the following content:

```html
<div id="~_MyToolbar">
</div>
<table id="~_MyTable">
	<thead><tr><th>Name</th><th>Surname</th>...</tr></thead>
    <tbody>...</tbody>
</table>
```

Template file name and extension is important while its folder is simply ignored.

By using this strategy there would be no need to insert widget templates into the page markup.

Also, as such server side templates are loaded on the first use (*lazy loading*) and cached in the browser and the server, page markup doesn't get polluted with templates for widgets that we might never use in a specific page. Thus, server side templates are favored over inline SCRIPT templates.
