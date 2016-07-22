# 如何在 Serenity 中使用第三方插件？

在 Serenity 应用程序使用第三方/自定义插件没有涉及特别的步骤。你可以在 _LayoutHead.cshtml 包括第三方脚本和 CSS 并遵照官方文档的步骤。

尤其是如果你使用 TypeScript，更没有涉及特别的步骤。

如果使用 Saltaralle（已经被弃用），则可能必须编写一些导入类（import classes）或动态使用这些类。

但是，如果你希望该组件与 Serenity 编辑对话框更好地工作，你可以尝试把它封装成 Serenity 部件。

在这里，我们将以 Bootstrap 的多选插件作为示例，将其集成到 Serenity，使其类似于 LookupEditor。

这是 Bootstrap 多选组件的文档和示例：

http://davidstutz.github.io/bootstrap-multiselect/


### 获取脚本和 CSS 文件

首先，我们应该下载组件的脚本和 CSS 文件，并把它们分别放在 MyProject.Web/scripts/ 和 MyProject.Web/content 文件夹下。

该组件有 NuGet 程序包，但是不幸的是它并不是按我们项目标准的形式安装（它不会将文件放到项目文件夹），所以我们要手动下载文件。

下载脚本文件，并把它放到 MyProject.Web/Scripts 下:

https://raw.githubusercontent.com/davidstutz/bootstrap-multiselect/master/dist/js/bootstrap-multiselect.js

下载 CSS 文件，并把它放到 MyProject.Web/Content 下：

https://raw.githubusercontent.com/davidstutz/bootstrap-multiselect/master/dist/css/bootstrap-multiselect.css

### 在 _LayoutHead.cshtml 包含脚本/样式文件

根据该插件的文档，我们应该包含这些文件：

```html
<!-- Include the plugin's CSS and JS: -->
<script type="text/javascript" 
  src="js/bootstrap-multiselect.js">
</script>
<link rel="stylesheet" type="text/css"/
      href="css/bootstrap-multiselect.css" />
```

打开 MyProject.Web/Views/Shared 下的 _LayoutHead.cshtml，并包含这些文件：

```html
// ...
@Html.Stylesheet("~/Content/bootstrap-multiselect.css")
@Html.Stylesheet("~/Content/serenity/serenity.css")
@Html.Stylesheet("~/Content/site/site.css")
// ...
@Html.Script("~/Scripts/bootstrap-multiselect.js")
@Html.Script("~/Scripts/Site/Serene.Script.js")
@Html.Script("~/Scripts/Site/Serene.Web.js")
```


### 创建 BSMultiSelectEditor.ts

现在，我们需要一个 TypeScript 源文件来放置组件。我们可以把它放在  MyProject.Web/Scripts 或者 MyProject.Web/Modules 目录下面。

我将在 MyProject.Web/Modules/Common/Widgets（你需要先创建 Widgets 文件夹）下创建该文件。

创建 BSMultiSelectEditor.ts 文件：

```ts
namespace MyProject {
    @Serenity.Decorators.element("<select/>")
    @Serenity.Decorators.registerClass(
        [Serenity.IGetEditValue, Serenity.ISetEditValue])
    export class BSMultiSelectEditor
        extends Serenity.Widget<BSMultiSelectOptions>
        implements Serenity.IGetEditValue, Serenity.ISetEditValue {

        constructor(element: JQuery, opt: BSMultiSelectOptions) {
            super(element, opt);
        }

        public setEditValue(source: any, 
            property: Serenity.PropertyItem): void {
        }

        public getEditValue(property: Serenity.PropertyItem, 
            target: any): void {
        }
    }

    export interface BSMultiSelectOptions {
        lookupKey: string;
    }
}
```

这里，我们定义了一个新的继承自 Widget 的编辑器类型。我们的小部件使用 BSMultiSelectOptions 类型选项，且类似于 LookupEditor ，包含 lookupKey 选项。它还实现了 IGetEditValue 和 ISetEditValue 的 TypeScript 接口 （这不同于 C# 接口）。

`@Serenity.Decorators.element("<select/>")`

在上面这行代码，我们指定小部件与 SELECT 元素一起工作，因为该 bootstrap 多选插件也要求一个 select 元素。

```
@Serenity.Decorators.registerClass(
    [Serenity.IGetEditValue, Serenity.ISetEditValue])
```

上面，我们采用 Saltaralle 类型系统注册 TypeScript 类，并指定小部件实现自定义值的 getter 和 setter 方法，这些方法对应于 getEditValue 和 setEditValue 。

> 这里的语法有点简洁，因为我们必须处理 Saltaralle 和 TypeScript 之间的互操作。

我们的 constructor、getEditValue 和 setEditValue 方法还是空的，我们待会将填充它们。


### 使用我们的新编辑器

现在，生成你的项目并转换模板。

打开 CustomerRow.cs 并定位到 Representatives 属性：

```cs
[LookupEditor(typeof(EmployeeRow), Multiple = true), ClientSide]
[LinkingSetRelation(typeof(CustomerRepresentativesRow), 
    "CustomerId", "EmployeeId")]
public List<Int32> Representatives
{
    get { return Fields.Representatives[this]; }
    set { Fields.Representatives[this] = value; }
}
```

我们在这里可以看到 Representatives 使用 Multiple 值为 true 的 LookupEditor。我们把它替换成新的编辑器：

```cs
[BSMultiSelectEditor(LookupKey = "Northwind.Employee"), ClientSide]
[LinkingSetRelation(typeof(CustomerRepresentativesRow), 
    "CustomerId", "EmployeeId")]
public List<Int32> Representatives
{
    get { return Fields.Representatives[this]; }
    set { Fields.Representatives[this] = value; }
}
```


### 使用检索项目填充编辑器

如果你现在生成项目，并打开客户对话框，你将看到 Customer representatives 字段的选项为为空。

让我们先用数据填充它：

```ts
export class BSMultiSelectEditor {
    constructor(element: JQuery, opt: BSMultiSelectOptions) {
        super(element, opt);
        
        let lookup = Q.getLookup(this.options.lookupKey) as Q.Lookup<any>;
        for (let item of lookup.get_items()) {
            let key = item[lookup.get_idField()];
            let text = item[lookup.get_textField()] || '';
            Q.addOption(element, key, text);
        }        
    }
```

我们首先获得由 *lookupKey* 选项指定检索的对象。

检索（Lookups）有 idField 和 textField 属性，通常对应的字段由检索行（lookup row）上的 IIdRow 和 INameRow 接口决定。

我们在 lookup 枚举所有的项目并使用 idField 和 textField 属性确定这些项的 key 和 text 属性。

现在保存文件，并再次打开客户对话框，这次你将看到选项被填充了。


### Bootstrap Multi Select Typings


根据文档，现在应该在我们的元素中调用 jQuery 的扩展方法 ".multiselect()" 。

我会把 SELECT 元素转换为 `<any>` 并在其上调用 .multiselect。但是我想使用 TypeScript 写一个定义文件 .d.ts 以重用含智能感知的多选。

因此，在 MyProject.Web/Scripts/typings/bsmultiselect 文件夹下，创建文件 *bsmultiselect.d.ts*：

```ts
interface JQuery {
    multiselect(options?: BSMultiSelectOptions | string): JQuery;
}

interface BSMultiSelectOptions {
    multiple?: boolean;
    includeSelectAllOption?: boolean;
    selectAllText?: string;
    selectAllValue?: string | number;
}
```

在这里，我扩展了原属于 jQuery 自身且被定义在 jquery.d.ts 的 jQuery 接口。在 TypeScript 中，你可以用新的方法扩展任何接口、属性等。

我使用插件文档的方法定义 BSMultiSelectOptions。该插件其实有更多的选项，但为了演示，我尽量保持简单。


### 在我们的编辑器中创建 Bootstrap 多选

现在，我将回到我们的构造函数并使用多选插件初始化它：

```ts
export class BSMultiSelectEditor {
    constructor(element: JQuery, opt: BSMultiSelectOptions) {
        super(element, opt);
        
        element.attr('multiple', 'multiple')
        
        let lookup = Q.getLookup(this.options.lookupKey) as Q.Lookup<any>;
        for (let item of lookup.get_items()) {
            let key = item[lookup.get_idField()];
            let text = item[lookup.get_textField()] || '';
            Q.addOption(element, key, text);
        }        
        
        element
            .attr('name', this.uniqueName + "[]")
            .multiselect();     
    }
```

打开客户对话框，你将看到 Representatives 已经有 Bootstrap 多选编辑器。

### 处理 GetEditValue 和 SetEditValue 方法

如果我们没有处理这些方法，Serenity 不会知道如何读取或设置编辑器的值，因此即使你选择了一些代表（representatives），下一次你再打开对话框，也会得到空的选项。


```ts
export class BSMultiSelectEditor {
//...

public setEditValue(source: any, property: Serenity.PropertyItem): void {
    this.element.val(source[property.name] || []).multiselect('refresh');
}

public getEditValue(property: Serenity.PropertyItem, target: any): void {
    target[property.name] = this.element.val() || [];
}
```

setEditValue 在编辑器值需要被设置时调用。它接受一个 *源（source）* 对象，该对象通常是对话框中加载的实体。

Property 参数是包含有关正在处理字段详细信息的属性项目对象，如 Representatives 属性。它的 *name* 字段包含字段名称，如 *Representatives*。

这里，我们在设置所选值后调用 multiselect('refresh')，因为多选插件不知道选项什么时候会被更改。

getEditValue 正好相反。它会读取编辑值并将其设置到目标实体。

Ok，现在我们的客户编辑器可以很好地工作了。