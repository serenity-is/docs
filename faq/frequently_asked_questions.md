# 常见问题

## 代码生成器 (Sergen)

** 在表中添加新字段之后，我应该重新生成代码吗？**

建议只生成一次代码，你应该以现有字段为例，在行（row）、 列（column）和表单（form）类手动添加新字段。

但是如果你做了太多的更改，并且再次生成代码。Sergen 将启动 Kdiff3 让你合并更改，以便不会覆盖你之前对生成代码所做的更改。

___

** 在 Sergen 中，我有关于 KDiff3 的错误，如何定位该错误呢？ **

Sergen 在其默认程序文件目录下查找 KDiff3。如果你还没有该程序，请安装它。

如果 Kdiff3 在另一位置，编辑你的解决方案目录下的 Serenity.CodeGenerator.config。这是一个包含 Sergen 设置和首选项的 JSON 文件。 


## Permissions

** 如何从 UPDATE 权限中分离出 INSERT 权限？ **:

在行（rows）中使用 [InsertPermission] 和 [UpdatePermission] 替代 [ModifyPermission] 特性。

默认情况下，插入、保存处理程序（INSERT, save handler）按如下顺序检索行中的这些权限：

- 1) InsertPermission
- 2) ModifyPermission 
- 3) ReadPermission

只有第一个被选中的权限才会被找到。

类似的，更新、保存处理程序（UPDATE, save handler）按如下顺序检索行中的这些权限：

- 1) UpdatePermission
- 2) ModifyPermission
- 3) ReadPermission

删除处理程序（delete handler）按如下顺序检索行中的这些权限：

- 1) DeleteInsertPermission
- 2) ModifyPermission
- 3) ReadPermission
 
列表/检索处理程序（LIST / RETRIEVE handler）只有一个权限被选中：

- 1) ReadPermission


## 发布和部署

** 怎样发布 Serenity 应用程序？ **

Serenity 应用程序使用 x-copy 部署。在部署之后，你只需要设置安装程序的连接字符串。你可以从部署中排除源文件。

确保你在 *SiteInitialization.Migrations* 文件 *RunMigrations* 方法中删除了数据库迁移安全检查。 

你也可以使用 Visual Studio 的发布功能。但需确保所有内容文件（content files）的生成操作设置为 *Content*（而不 *None*）。 

> 你只需要发布 MyApplication.Web 项目，不需要发布 script 项目。

Serenity 使用 ASP.NET MVC 的 NuGet 版本。因此无需在服务器安装 MVC。如果你得到一些缺少 DLL 的错误，请检查 VS 项目引用的 *复制到本地* 选项是否设置为 *True*。 

## 表单 和 编辑器（Editors）

** 如何在 DecimalEditor 中允许负值？ **

在 *DecimalEditor* 特性设置 *MinValue* 和 *MaxValue* 属性：

```cs
[DecimalEditor(MinValue = "-999999999.99", MaxValue = "999999999.99")]
public Decimal MyProperty { get; set; }
```
> 请确保最大值和最小值使用相同的位数。


** 如何重新加载/刷新检索编辑器数据？ **

使用 *Q.ReloadLookup("MyModule.MyLookupKey")* 重新加载检索其 key 的结果。

** 如何为枚举创建过滤编辑器？ **

```cs
AddEqualityFilter<EnumEditor>(SomeRow.Fields.TheEnumField,
    options: new EnumEditor { EnumKey = "MyModule.MyEnumType" });
```

___

** 如何在新记录模式下把日期编辑器设置为当前日期？ **

在表单定义中为日期时间编辑器的日期添加 [DefaultValue("today")] 或者 [DefaultValue("now")]。

> 请不要在行（row）中添加这些特性，否则将导致错误。

另一做法是在对话框中处理，重写 *AfterLoadEntity*：

```cs`
form.MyDateField.AsDate = JsDate.Today;
```