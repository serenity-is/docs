# 创建检索表

让我们从创建系统所要用到的检索表开始。

这是所需的表：

* 会议类型表（董事会会议、每周分析、SCRUM 会议、年会等）；
* 地点表（举行会议的地址、房间号码等）；
* 议程类型表（会议的主题，一个可能有多个主题）；
* 单位表（此次会议的组织单位）；
* 联系人表（参会人员、记者、管理层等）。

我们使用 *met* 作为数据库表的 schema 。

在 *Modules/Common/Migrations/DefaultDB* 创建一个名为 *DefaultDB_20160709_232400_MeetingLookups* 的迁移类：

```cs
using FluentMigrator;

namespace MeetingManagement.Migrations.DefaultDB
{
    [Migration(20160709232400)]
    public class DefaultDB_20160709_232400_MeetingLookups 
        : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Schema("met");
            
            Create.Table("AgendaTypes").InSchema("met")
                .WithColumn("AgendaTypeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Contacts").InSchema("met")
                .WithColumn("ContactId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Title").AsString(30).Nullable()
                .WithColumn("FirstName").AsString(50).NotNullable()
                .WithColumn("LastName").AsString(50).NotNullable()
                .WithColumn("Email").AsString(100).NotNullable();

            Create.Table("Locations").InSchema("met")
                .WithColumn("LocationId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable()
                .WithColumn("Address").AsString(300).Nullable()
                .WithColumn("Latitude").AsDouble()
                .WithColumn("Longitude").AsDouble();

            Create.Table("MeetingTypes").InSchema("met")
                .WithColumn("MeetingTypeId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();

            Create.Table("Units").InSchema("met")
                .WithColumn("UnitId").AsInt32()
                    .Identity().PrimaryKey().NotNullable()
                .WithColumn("Name").AsString(100).NotNullable();
        }
    }
}
```


### 为检索表生成代码

我们的模块名称为 *Meetings*。在生成代码时，我们应该使用非复数的实体标识符：

* AgendaTypes => AgendaType
* Contacts => Contact
* Locations => Location
* MeetingTypes => MeetingType
* Units => Unit

为这 5 张表使用上面给出的实体标识符生成代码：

![Sergen Lookups](img/met_sergen_lookups.png)

对这些表生成的界面并不是很美观，需要做一些美化。

![Initial Lookups](img/met_initial_lookups.png)

### 把导航连接移到 NavigationItems.cs

打开 *AgendaTypePage.cs*、*ContactPage.cs*、*LocationPage.cs*、*MeetingTypePage.cs* 和 *UnitPage.cs* 文件，并把文件顶部的导航连接移至 *NavigationItems.cs*：

```cs
using Serenity.Navigation;
using Administration = MeetingManagement.Administration.Pages;
using Meeting = MeetingManagement.Meeting.Pages;

[assembly: NavigationLink(1000, "Dashboard", 
    url: "~/", permission: "", icon: "icon-speedometer")]

[assembly: NavigationMenu(2000, "Meeting")]
[assembly: NavigationLink(2500, "Meeting/Agenda Types", 
    typeof(Meeting.AgendaTypeController))]
[assembly: NavigationLink(2600, "Meeting/Contacts", 
    typeof(Meeting.ContactController))]
[assembly: NavigationLink(2700, "Meeting/Locations", 
    typeof(Meeting.LocationController))]
[assembly: NavigationLink(2800, "Meeting/Meeting Types", 
    typeof(Meeting.MeetingTypeController))]
[assembly: NavigationLink(2900, "Meeting/Units", 
    typeof(Meeting.UnitController))]
```


### 为检索表设置 DisplayName 和 InstanceName 特性

打开 *AgendaTypeRow.cs*、*ContactRow.cs*、*LocationRow.cs*、*MeetingTypeRow.cs* 和 *UnitRow.cs* 文件，并像下面那样修改 *DisplayName* 和 *InstanceName* 特性：

* AgendaTypeRow => "Agenda Types", "Agenda Type"
* ContactRow => "Contacts", "Contact"
* LocationRow => "Locations", "Location"
* MeetingTypeRow => "Meeting Types", "Meeting Type"
* UnitRow => "Units", "Unit"

```cs
[ConnectionKey("Default"), TwoLevelCached,
 DisplayName("Agenda Types"), InstanceName("Agenda Type")]
[ReadPermission("Meeting")]
[ModifyPermission("Meeting")]
public sealed class AgendaTypeRow : Row, IIdRow, INameRow
{
```


 