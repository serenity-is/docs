# How To: Use a SlickGrid Formatter


** This section is pending update for TypeScript **



To use a SlickGrid formatter function, like percent complete bar formatter at *%Complete* column of SlickGrid example:

http://mleibman.github.io/SlickGrid/examples/example2-formatters.html


### Including Required Resources

First include javascript file containing these formatters in your *_LayoutHead.cshtml* file (MyProject.Web/Views/Shared/_LayoutHead.cshtml):

```cshtml
//...
@Html.Script("~/Scripts/jquery.slimscroll.js")
@Html.Script("~/Scripts/SlickGrid/slick.formatters.js")
@Html.Script("~/Scripts/Site/MovieTutorial.Script.js")
//...
```

You also need to include following CSS from example.css (can be inserted in site.less):

```css
.percent-complete-bar {
  display: inline-block;
  height: 6px;
  -moz-border-radius: 3px;
  -webkit-border-radius: 3px;
}
```

### Declaring a Serenity DataGrid Formatter


Let's say we have *StudentCourseGrid* with a *CourseCompletion* column that we wan't to use *Slick.Formatters.PercentCompleteBar* formatter with. 

```cs
public class StudentCourseColumns
{
    //...
    [Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```

To reference a SlickGrid formatter at server side, you need to declare a formatter type for Serenity grids.

In MyApplication.Script project, next to StudentCourseGrid.cs for example, define a file (PercentCompleteBarFormatter.cs) with contents:

```cs
using Serenity;
using System;

namespace MyApplication
{
    public class PercentCompleteBarFormatter : ISlickFormatter
    {
        private SlickColumnFormatter formatter = 
            Type.GetType("Slick.Formatters.PercentCompleteBar").As<SlickColumnFormatter>();

        public string Format(SlickFormatterContext ctx)
        {
            return formatter(ctx.Row, ctx.Cell, ctx.Value, ctx.Column, ctx.Item);
        }
    }
}
```

> Replace MyApplication with your root namespace (solution name).

Now you can reference it at server side:

```cs
public class StudentCourseColumns
{
    //...
    [FormatterType("PercentCompleteBar"), Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```

Rebuild your project and you will see that CourseCompletion column has a percentage bar just like in SlickGrid example.


### Getting Intellisense and Compile Time Checking To Work

To get intellisense for PercentCompleteBarFormatter server side (so to avoid using magic strings), you should transform T4 templates (make sure solution builds successfully before transforming).

After this you can reference it like this server side:


```cs
public class StudentCourseColumns
{
    //...
    [PercentCompleteBarFormatter, Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```


### Alternate Option (Not Recommended)


It is also possible to set SlickGrid column formatter function directly in script side code without defining a Serenity formatter class, e.g. in *StudentCourseGrid.cs* by overriding its *GetColumns* method:

        protected override List<SlickColumn> GetColumns()
        {
            var columns = base.GetColumns();
            columns.Single(x => x.Field == "CourseCompletion ").Formatter = 
                Type.GetType("Slick.Formatters.PercentCompleteBar").As<SlickColumnFormatter>();
            return columns;
        }

This is not reusable but saves you from defining a formatter class.
