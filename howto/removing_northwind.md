
# How To: Remove Northwind From Serene

After you take Northwind as a sample, and develop your own project, you would want to remove Northwind module artifacts from your project. 

Here is how to get rid of it.

We assume your solution name is *MyProject*, so you have *MyProject.Web* and *MyProject.Script* projects in your solution.

Perform steps below in Visual Studio:


### Removing Project Folders

* Remove *MyProject.Web/Modules/Northwind* folder. This will remove all server side code related to Northwind.

* Remove *MyProject.Script/Northwind* folder to remove all script code related to Northwind.


### Removing Navigation Items

* Open *MyProject.Web/Modules/Common/Navigation/NavigationItems.cs*, remove following lines:

```cs
using Northwind = MyProject.Northwind.Pages;

[assembly: NavigationMenu(8000, "Northwind", icon: "icon-anchor")]
[assembly: NavigationLink(8200, "Northwind/Customers", 
    typeof(Northwind.CustomerController), icon: "icon-wallet")]
[assembly: NavigationLink(8300, "Northwind/Products", 
    typeof(Northwind.ProductController), icon: "icon-present")]
[assembly: NavigationLink(8400, "Northwind/Suppliers", 
    typeof(Northwind.SupplierController), icon: "icon-magic-wand")]
[assembly: NavigationLink(8500, "Northwind/Shippers", 
    typeof(Northwind.ShipperController), icon: "icon-plane")]
[assembly: NavigationLink(8600, "Northwind/Categories", 
    typeof(Northwind.CategoryController), icon: "icon-folder-alt")]
[assembly: NavigationLink(8700, "Northwind/Regions", 
    typeof(Northwind.RegionController), icon: "icon-map")]
[assembly: NavigationLink(8800, "Northwind/Territories", 
    typeof(Northwind.TerritoryController), icon: "icon-puzzle")]
```

### Removing LESS Entries 

* Open *MyProject.Web/Content/site/site.less* file, remove following line:
    
```less
@import "site.northwind.less";
```

* Remove *MyProject.Web/Content/site/site.northwind.less* file.


### Removing Migration Scripts

* Open *MyProject.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20141103_140000_Initial.cs* file, remove following line:

```cs
    Execute.EmbeddedScript("MyProject.Modules.Common.Migrations.DefaultDB.NorthwindDBScript.sql");

```

* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/DefaultDB_20141123_155100_ProductImage.cs* file.

* Remove *MyProject.Web/Modules/Common/Migrations/DefaultDB/NorthwindDBScript.sql* file.


### Removing Localization Texts

* Open *MyProject.Web/Modules.Texts.cs* and remove following lines:

```cs
            public static LocalText NorthwindPhone = "...";
            public static LocalText NorthwindPhoneMultiple = "...";
```

