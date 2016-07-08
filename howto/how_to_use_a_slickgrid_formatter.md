# 如何使用 SlickGrid 格式化器（Formatter）？


** 本节的 TypeScript 版本有待更新 **



使用 SlickGrid 格式化器功能，如在 SlickGrid 列中显示完成程度的百分比进度条示例：

http://mleibman.github.io/SlickGrid/examples/example2-formatters.html


### 包含必须的资源

首先在 *_LayoutHead.cshtml* (MyProject.Web/Views/Shared/_LayoutHead.cshtml)文件中包含这些格式化程序引用：

```cshtml
//...
@Html.Script("~/Scripts/jquery.slimscroll.js")
@Html.Script("~/Scripts/SlickGrid/slick.formatters.js")
@Html.Script("~/Scripts/Site/MovieTutorial.Script.js")
//...
```

同样需要包含下面的 CSS（来自 example.css，可以插入到 site.less）。

```css
.percent-complete-bar {
  display: inline-block;
  height: 6px;
  -moz-border-radius: 3px;
  -webkit-border-radius: 3px;
}
```

### 定义 Serenity 的 DataGrid 格式化器


假设我们想在 *StudentCourseGrid* 的 *CourseCompletion* 列使用 *Slick.Formatters.PercentCompleteBar* 格式化。 

```cs
public class StudentCourseColumns
{
    //...
    [Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```

要在服务器端引用 SlickGrid 格式化器，需要为 Serenity 网格定义一个格式化器类型。

以在 MyApplication.Script 项目的 StudentCourseGrid.cs 旁定义一个文件（PercentCompleteBarFormatter.cs）为例，该文件内容如下：

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

> 使用你的根命名空间（解决方案名称）替换 MyApplication 。

现在你可以在服务端引用它：

```cs
public class StudentCourseColumns
{
    //...
    [FormatterType("PercentCompleteBar"), Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```

重新生成你的项目，你将看到 CourseCompletion 列有一个像 SlickGrid 示例的百分比栏。 


### 获得智能感知和编译时检查 

要在 PercentCompleteBarFormatter 服务端获得智能感知（可避免使用魔术字符串），你应该转换 T4 模板（在转换之前请确保成功生成解决方案）。 

在此之后，你可以在服务器端像下面这样引用它：


```cs
public class StudentCourseColumns
{
    //...
    [PercentCompleteBarFormatter, Width(200)]
    public Decimal CourseCompletion { get; set; }
}
```


### 替代方案（不建议）


也可以不用定义 Serenity 格式化器类，例如在 *StudentCourseGrid.cs* 通过重写其 *GetColumns* 方法，直接在脚本代码中设置 SlickGrid 列格式化器功能：

        protected override List<SlickColumn> GetColumns()
        {
            var columns = base.GetColumns();
            columns.Single(x => x.Field == "CourseCompletion ").Formatter = 
                Type.GetType("Slick.Formatters.PercentCompleteBar").As<SlickColumnFormatter>();
            return columns;
        }

该方式是不可重用的，但可省去定义格式化器类。
