# 如何在 Serene 中注册权限？

Serene 在用户和角色权限对话框中显示权限列表，若要在这里显示你自己的权限，需要在你自己的权限中使用下面的特性：

- 继承自 PermissionAttributeBase 的特性：
    - *ReadPermission*
    - *ModifyPermission*
    - *InsertPermission* 
    - *UpdatePermission*
    - *DeletePermission*


- Page 和 Endpoint 访问控制特性：
    - *PageAuthorize*
    - *ServiceAuthorize*

这些特性可以在下面类型中使用：

- *XYZRow*（可设置 Read, Write, Insert, Update, Delete 权限）
- *XYZPage* 及操作方法（PageAuthorize）
- *XYZEndpoint* 及服务操作（ServiceAuthorize）

当你在这些属性中使用许可键（permission key），Serene 将在应用程序启动时使用反射自动检测它们。

> PermissionKeys 是 Serene 的一个类。一些用户希望在该类中写自己的许可键也会被检测。 

> 但是，PermissionKeys 类只是为了智能提示，它被 Serene 忽略。

如果你不使用其中任何的许可键，但仍然想在权限对话框中显示它，你可以在程序集中使用 RegisterPermission 特性（可在 YourProject.Web 任何地方使用）︰

```cs
[assembly: Serenity.ComponentModel.RegisterPermissionKey("MySpecialPermissionKey")]
```

## 组织权限树

若要在树层次结构中创建权限，在你的许可键中使用冒号（:）作为分隔符：

- MyModule:SubModule:General
- MyModule:SubModule:Permission1
- MyModule:SubModule:Permission2

这些键会在  MyModule / SubModule 类别下显示。因此它们的类别是： 

- MyModule:SubModule:

> 类别键(Category keys) 以冒号结束，不要使用以冒号结尾的许可键。 

请不要使用匹配类别键的许可键。如果你使用这样的键，如 *MyModule:SubModule*，它不会在  MyModule / SubModule 类别下显示而会在同一级别中显示。 

如果你需要类别使用一个通用权限（generic permission），可以使用 *MyModule:SubModule:General*。

> *General* 没有特殊的含义，若你喜欢，也可以使用 Common， Module， View。 

## 处理类别的显示文本 

因为类别由许可键自动决定，可能没有友好的显示文本。

你需要使用本地化系统为它们添加显示文本。

> 如果你不需要本地化，只需要在 site.texts.invariant.json 添加文本。

例如，在 site.texts.invariant.json 文件中有这样的键值对：

```json
    "Permission.Administration:": "Administration",
    "Permission.Administration:Security": "User, Role Management and Permissions",
    "Permission.Administration:Translation": "Languages and Translations",
    "Permission.Northwind:Customer:": "Customers",
    "Permission.Northwind:Customer:View": "View",
    "Permission.Northwind:Customer:Delete": "Delete",
    "Permission.Northwind:Customer:Modify": "Create/Update",
    "Permission.Northwind:General": "[General]"
```

以冒号结尾的键，如*Administration:* 和 *Customer:* 对应类别显示的文本。

你需要将类别文本添加到固定的语言。如果你想要本地化，也可以添加其他语言。