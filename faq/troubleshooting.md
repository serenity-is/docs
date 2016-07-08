# 故障排除

## 初始设置

**在创建并启动新的 Serene 应用程序之后，不会显示登录页，而当你打开浏览器控制台，却得到一条错误消息：找不到 Template.LoginPanel：**

你可能使用了无效的解决方案名称，如 MyProject.Something （包含点'.'）。 

当项目以这种方式命名时，模板系统将不能定位模板。

请不要在解决方案名称中使用点符号（'.'），如果必须使用点符号，可在创建解决方案之后再重命名。

## 编译错误

**在 Script 项目添加文件后，得到几个引用不明确的错误：**

从 script 项目移除 *System.dll* 引用。Visual Studio 在你使用 *添加新文件* 对话框时添加该引用。Saltarelle 编译器不能与该程序集一起工作，因为它有完全不一样的运行时。 

在 Script 项目中，请使用复制/粘贴的方式创建代码文件。

**Error: System.ComponentModel.DisplayName attribute exists in both ...\Serenity.Script.UI.dll and ...\v2.0...\System.dll** 

与上面一样，从 Script 项目移除 *System.dll* 引用。 

## 运行时错误

**当上传文件或添加备注（notes）时，得到 *NotImplementException* 的异常：**

该功能需要表的标识列是整数。在最近版本的 Serenity 中，已添加对 String/Guid 主键的支持，但一些旧行为（old behaviors）不能与这种键一起工作。


## SQL 和连接字符串

**当我在网格列表切换页时，得到错误："'OFFSET' 附近语法错误，在 FETCH 声明中使用无效 NEXT 项 "：**

你的 SQL server 是 2008 或更旧的版本。默认情况下，SQL Server 连接使用 SQL2012 方言。在 SiteInitialization.cs 中把连接修改为  SqlServer2005 或 SqlServer2008 方言，如：

```cs
  SqlConnections.GetConnectionString("Default").Dialect =
    SqlServer2008Dialect.Instance;
```


## T4 模板问题

**在转换模板后，发现枚举不能被转换到脚本端：**

如果你在行（row）或者请求/响应服务中使用枚举类型，枚举会被转换，否则默认情况下，枚举不会被转换，如果此时你需要包含该枚举，请向其添加 [ScriptInclude] 特性。

## 编辑器和表单

**试图设置级联下拉列表，但第二个下拉列表始终为空：**

确保你正确地设置了 CascadeField，CascadeField 应该匹配第二检索的属性名称。例如，CountryID 在脚本端没有匹配 CountryId 。你可以使用 nameof() 操作确认，如 CascadeField = nameof(CityRow.CountryId) 。 

如果你错误地设置 CascadeFrom 项，也会发生类似的问题。它对应于你表单的第一个下拉列表 ID。例如，如果在表单中有 MyCountryId 和 CustomerCityId 属性，CascadeForm 应该是 *CustomerCountryId*。同样，你也可以使用 nameof(MyCountryId) 确认。  

> CascadeFrom 是表单的编辑器ID，而 CascadeField 是行中的字段属性名称。

另一种可能性是 CascadeField 没有包括在发送到脚本端的检索数据。例如，如果第二个下拉列表是城市，通过 CountryId 与国家下拉列表对应，请确保 CityRow 的 CountryId 属性有 [LookupInclude] 特性。默认情况下，只有 ID 和 Name 属性被发送到脚本端进行检索。

___

**试图使用对话框模板创建选项卡，但是选项卡不能显示或是空的:**

确保你没有把选项卡内容放到另一选项卡内容中，如 选项卡 DIV 包含其他选项卡的 DIV。

## 主/从 编辑 

**在内存中创建类似于 Movie 教程的演员编辑器的主从信息，但是更新记录时，我得到两条重复的实体：**

确保 EditDialog 类没有 [IdProperty] 。因为编辑对话框的记录是在内存中操作，此时该记录还没有实际的 ID，如果你对他们使用实际的 ID 属性，对话框会认为你在编辑时要添加新记录（由于它们的实际 ID 总为 null）。

正如你看到下面的代码，GridEditorDialog 基类使用伪造 ID：

```cs
[IdProperty("__id")]
public abstract class GridEditorDialog<TEntity> : EntityDialog<TEntity>
    where TEntity : class, new()
```

因此，当你在编辑对话框中设置 [IdProperty]，你是在重写该伪造 ID 并导致不可预料的行为。

___

**在成功地添加详细信息后，打开一个现有记录，发现某些可视字段（view fields）为空：**

请在 YourDetailRow.cs 的可视字段添加 [MinSelectLevel(SelectLevel.List)] 特性。默认情况下，List handlers 和 MasterDetailBehavior 只加载详细行的表字段（没有可视字段）。 


## 权限

**面不会显示在导航中**

Page 的访问权限是读取 XYZPage.cs 文件 *Index* 操作的 *PageAuthorize* 特性，这是一个 MVC 页面控制器。请确保你将此设置为用户权限。

___


**已经在 PermissionKeys.cs 添加了权限，但是不能在权限对话框显示它：**

PermissionKeys 类仅作为智能感智的目的。更多关于注册 keys 的信息请查看下面连接。

* [如何在 Serene 中注册权限？](howto/how_to_register_permissions_in_serene.md)

___

**在 row 中修改访问键（permission keys），但是当打开页面时得到错误且没有显示记录：**

XYZEndpoint.cs 也需要有 *[ServiceAuthorize("SomePermission")]* 特性。这是为了提供中等级别的安全（secondary level security）。在 Row 中替换访问键。  

## 本地化

**发布网站之后，本地化不能用：**

把翻译的文件保存到 ~/App_Data 目录下。将这些文件复制到服务器，或将相关文本文件移动到 ~/Scripts/site/texts 下。

___

**已经添加了自定义本地文本键，但是不能在脚本端访问它们：**

不是所有的翻译都会转换到脚本端。在 web.config 有一个控制着这些前缀的 *LocalTextPackages* 键设置。如果查看该配置，你可以看到只有以 *Db.*、*Dialogs.*、*Forms.* 等开头的文本键会被转换到客户端。这是为了限制大小的文本，因为不是所有的脚本代码都使用这些文本。 

请在该配置中添加你自己的前缀，或者把你的文本键更改为以其中的默认前缀开头。

___

## NuGet 程序包 和 升级


**更新 Select2 后，得到一些错误：**

请不要把 Select2 更新到  3.5.1+ 的版本，它最近的版本有一些已知的兼容性问题。

把 Select2 还原到 Select2 3.5.1，请在包管理器控制台输入下面指令：

> Update-Package Select2.js -Version 3.5.1


## 部署与发布

**发布项目之后，一些内容找不到或不能显示：**

如果你使用 Visual Studio 发布，确保 css、图片文件等被包含在 web 项目，并且把它们的 *生成操作* 属性设置为 *内容*。

另一种可能是  IIS_IUSRS 用户组不能访问文件。检查其是否有访问 web 文件夹（发布的文件夹）权限。

___

**发布之后，找不到表（如 User）：**

Serene 有一个避免在任意的数据库上运行迁移的检查。在 *SiteInitialization.Migrations* 文件的 *RunMigrations* 方法中可找到该检查，删除该检查。

___

**得到 “不能设置常量字段” 的 FieldAccessExceptions:**

托管服务提供商已将你的 web 应用程序池设置为中等信任安全等级。要求他们授予高度信任安全等级，或考虑更换供应商。

如果你的托管服务提供商没有锁住 web.config，也可以在 web.config 设置： 

```
<configuration> 
  <system.web> 
    <trust level="Full" />
  </system.web> 
</configuration> 

```

Serenity 使用反射初始化字段对象。在中等信任安全等级时，它不能初始化对象。你可以尝试把 *Row.cs* 所有的 *public readonly" 字段定义替换为 *public static*，但是不确定这样能解决所有问题。

> ASP.NET 的中等信任安全等级已经过时了，并且微软不会解决与此相关的任何问题。详见  http://stackoverflow.com/questions/16849801/is-trying-to-develop-for-medium-trust-a-lost-cause  
> 强烈建议你更换托管服务提供商。