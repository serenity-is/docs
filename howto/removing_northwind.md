
# How To: Remove Northwind From Serene

After you take Northwind as a sample, and develop your own project, you would want to remove Northwind module artifacts from your project. 

Here is how to get rid of it.

We assume your solution name is *MyProject*, so you have *MyProject.Web* and *MyProject.Script* projects in your solution.

Perform steps below in Visual Studio:


### Removing Project Folders

* Remove *MyProject.Web/Modules/Northwind* folder. This will remove all server side code related to Northwind.

* Remove *MyProject.Script/Northwind* folder to remove all script code related to Northwind.


### Removing Navigation Items

* Open *MyProject.Web/Modules/Common/Navigation/NavigationItems.cs*, remove all lines with *Northwind*.

### Removing Migration Scripts

* Open *MyProject.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20141103_140000_Initial.cs* file, remove following line:

```cs
    Execute.EmbeddedScript("MyProject.Modules.Common.Migrations.DefaultDB.NorthwindDBScript.sql");

```

* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20141123_155100_ProductImage.cs* file.

* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/NorthwindDBScript.sql* file.


### Removing LESS Entries 

* Open *MyProject.Web/Content/site/site.less* file, remove following line:
    
```less
@import "site.northwind.less";
```

* Remove *MyProject.Web/Content/site/site.northwind.less* file.


### Removing Localization Texts

* Open *MyProject.Web/Modules.Texts.cs* and remove following lines:

```cs
            public static LocalText NorthwindPhone = "...";
            public static LocalText NorthwindPhoneMultiple = "...";
```

* Open *MyProject.Web/Scripts/site/site.texts.es.json* and remove all lines with *Northwind*.

* Open *MyProject.Web/Scripts/site/site.texts.tr.json* and remove all lines with *Northwind*.

* Open *MyProject.Web/Scripts/site/site.texts.invariant.json* and remove all lines with *Northwind*.


### Building Project and Running T4 (.tt) Templates

* Now rebuild your solution.

* Make sure it is built *successfully* before executing next step.

* Click *Build* menu and click *Transform All Templates*.

* Rebuild your solution again.

* Search for *Northwind* in all solution items. It should find no results.

* Run your project, now Northwind menu is gone.


### Removing Northwind Tables

* You would drop your existing database, and let migrations recreate your tables.

* If you have some data that you don't want to lose in other tables, execute the script below to remove Northwind tables:

```sql
DROP TABLE [dbo].[Order Details]
DROP TABLE [dbo].[Orders]
DROP TABLE [dbo].[Products]
DROP TABLE [dbo].[Suppliers]
DROP TABLE [dbo].[Shippers]
DROP TABLE [dbo].[EmployeeTerritories]
DROP TABLE [dbo].[Employees]
DROP TABLE [dbo].[CustomerCustomerDemo]
DROP TABLE [dbo].[Customers]
DROP TABLE [dbo].[Categories]
DROP TABLE [dbo].[Territories]
DROP TABLE [dbo].[Region]
DROP TABLE [dbo].[CustomerDemographics]
DELETE FROM [dbo].[VersionInfo] WHERE Version = 20141123155100
```

> Please make sure the database you are running this script on is a Serene one.


* Now Northwind is no more... 