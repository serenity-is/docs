
# How To: Remove Northwind & Other Samples From Serene

After you take Northwind as a sample, and develop your own project, you would want to remove Northwind module, and other sample artifacts from your project. 

Here is how to get rid of them.

We assume your solution name is *MyProject*, so you have *MyProject.Web* project in your solution.

Perform steps below in Visual Studio:


### Removing Project Folders

* Remove *MyProject.Web/Modules/AdminLTE* folder. This will remove all server side code related to theme samples.

* Remove *MyProject.Web/Modules/BasicSamples* folder. This will remove all server side code related to basic samples.

* Remove *MyProject.Web/Modules/Northwind* folder. This will remove all server side code related to Northwind.

### Removing Navigation Items

* Open *MyProject.Web/Modules/Common/Navigation/NavigationItems.cs*, remove all lines with *Northwind*, *Basic Samples* and *Theme Samples* and remove these two lines:

```
using Northwind = MovieTutorial.Northwind.Pages;
using Basic = MovieTutorial.BasicSamples.Pages;
```

### Removing Migration Scripts

Remove folder *MyProject.Web/Modules/Common/Migrations/NorthwindDB/* with all files under it.

Remove "Northwind" from following line in *MyProject.Web/App_Start/ SiteInitialization.Migrations.cs*:

```cs
private static string[] databaseKeys = new[] { "Default", "Northwind" };
```

Also remove *Northwind* connection string from *web.config*.

```xml
<add name="Northwind" connectionString="Data Source=(LocalDb)\v11.0; 
    Initial Catalog=MovieTutorial_Northwind_v1; 
    Integrated Security=True" 
    providerName="System.Data.SqlClient" />
```

### Removing LESS Entries 

* Open *MyProject.Web/Content/site/site.less* file, remove following lines:
    
```less
@import "site.basicsamples.less";
@import "site.northwind.less";
```

* Remove *MyProject.Web/Content/site/site.basicsamples.less* file.
* Remove *MyProject.Web/Content/site/site.northwind.less* file.

### Removing Localization Texts

* Open *MyProject.Web/Modules/Texts.cs* and remove following lines:

```cs
            public static LocalText NorthwindPhone = "...";
            public static LocalText NorthwindPhoneMultiple = "...";
```

* Open all localization json files under *MyProject.Web/Scripts/site/*, e.g. *site.texts.es.json* and remove all lines with *Northwind*, *Theme Samples* and *Basic Samples*.

### Removing Northwind / Samples Generated Code

* Expand *MyProject.Web/Modules/Common/Imports/ ServerTypings/ServerTypings.tt*. Select files starting with *Northwind.*, *BasicSamples.* and delete them.
 
### Removing Northwind Numbers From Dashboard 

Open *DashboardPage.cs*, remove these using lines:

```cs
using Northwind;
using Northwind.Entities;
```

As Dashboard gets numbers from Northwind tables, you should modify *Index()* action like this:

```cs
[Authorize, HttpGet, Route("~/")]
public ActionResult Index()
{
    var cachedModel = new DashboardPageModel()
    {
    };

    return View(MVC.Views.Common.Dashboard.DashboardIndex, cachedModel);
}
```

> You should replace this model with something specific to your site, and modify DashboardIndex accordingly.


### Building Project and Running T4 (.tt) Templates

* Now rebuild your solution.

* Make sure it is built *successfully* before executing next step.

* Click *Build* menu and click *Transform All Templates*.

* Rebuild your solution again.

* Search for *Northwind* in all solution items. It should find no results.

* Run your project, now Northwind menu is gone.


### Removing Northwind Tables

If you are using Serene 1.6.4.3+ Northwind tables are in a separate database, so you can just drop it. Following steps are unnecessary.


> ### If using a version below Serene 1.6.3, follow these steps:

> * Open *MyProject.Web/Modules/Common/Migrations/DefaultDB/ DefaultDB_20141103_140000_Initial.cs* file, remove following line:


>```cs
> Execute.EmbeddedScript(
>   "MyProject.Modules.Common.Migrations.DefaultDB.NorthwindDBScript.sql");
>```

>* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/ DefaultDB_20141123_155100_ProductImage.cs* file.

>* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/ DefaultDB_20151014_030700_OrderDetailID.cs* file.

>* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/ NorthwindDBScript.sql* file.


> * You would drop your existing database, and let migrations recreate your tables.

> * If you have some data that you don't want to lose in other tables, execute the script below to remove Northwind tables:

>```sql
>DROP TABLE [dbo].[Order Details]
>DROP TABLE [dbo].[Orders]
>DROP TABLE [dbo].[Products]
>DROP TABLE [dbo].[Suppliers]
>DROP TABLE [dbo].[Shippers]
>DROP TABLE [dbo].[EmployeeTerritories]
>DROP TABLE [dbo].[Employees]
>DROP TABLE [dbo].[CustomerCustomerDemo]
>DROP TABLE [dbo].[Customers]
>DROP TABLE [dbo].[Categories]
>DROP TABLE [dbo].[Territories]
>DROP TABLE [dbo].[Region]
>DROP TABLE [dbo].[CustomerDemographics]
>DELETE FROM [dbo].[VersionInfo] WHERE Version = 20141123155100
>```

> Please make sure the database you are running this script on is a Serene one.
