# 多租户

在本教程中，我们把 Norhwind 改为多租户应用程序。

这是多租户软件在维基百科中的定义：

> 多租户技术（multi-tenancy technology）或称多重租赁技术，是一种软件架构技术，它是在探讨与实现如何于多用户的环境下共用相同的系统或程序组件，并且仍可确保各用户间数据的隔离性。---维基百科

我们在每张表中添加一个 TenantId 字段，包含用户（Users）表，并只让用户对看到/修改只属于自己的租户记录。因此，如果租户使用自己的数据库工作，租户间是相互独立的。

多租户应用程序有一些优势，如可以减少管理的花销。但是它们也有一些劣势，例如，由于所有租户的数据都保存在一个数据库中，单个租户不能简单地独自获取或者备份自己的数据。当有更多的记录需要处理时通常会降低性能。

随着云应用的趋势，虚拟化的成本逐渐降低，并包含迁移之类的功能，现在很容易在云上安装多实例应用程序。

我个人是避免使用多租户应用程序的。在我看来每个客户最好有一个数据库。

但是，有一些用户询问如何实现多租户的功能，于是便有了该教程，但作为奖励，随着多租户教程，我们将介绍一些高级的 Serenity 主题。

> 你可以在下面的连接中找到本教程的源代码：

> https://github.com/volkanceylan/Serenity-Tutorials/tree/master/MultiTenancy



### 创建一个名为 *MultiTenancy* 的教程

在 Visual Studio 中，点击 文件 -> 新项目。确保你选择了 *Serene template*，输入 *MultiTenancy* 作为名称并点击 *OK*。

在解决方案资源管理器中，你应该看到两个项目，分别是 *MultiTenancy.Web* 和 *MultiTenancy.Script* 。

> 确保 *MultiTenancy.Web* 是启动项目（它应该加粗显示），如果它还不是启动项目，你可以在该项目名称中右键并点击 *设为启动项目*。


### 添加项目依赖

默认情况下， 当你按 F5 运行程序时，Visual Studio 只生成 MultiTenancy.Web 项目。

> 这是由 Visual Studio 的 Options -> Projects and Solutions -> Build And Run -> "Only build startup projects and dependencies on Run" 设置控制的，但并不建议你修改该设置。

为了在 Web 项目运行时，也让 Script 项目生成，右键 *MultiTenancy.Web* 项目，点击 *Build Dependencies* -> *Project Dependencies* 并勾选 *Dependencies* 选项卡下的 *MultiTenancy.Script*。

> 不幸的是，我们没办法在 Serene 的模板设置该依赖关系。
