
# How To: Remove Northwind & Other Samples From Serene/StartSharp

If you forgot to uncheck certain features during project creation, or if you just wanted to keep sample modules as a reference initially, you may want to remove the modules and their artifacts from your application before deploying it to production. Here's how to do that:

> Please note that, as Serenity and Serene/StartSharp are updated frequently, some of these instructions may become out of date. If you notice any changes that need to be made, you can edit this document at https://github.com/serenity-is/docs/blob/master/howto/how_to_remove_sample_modules.md and send a pull request.

## Removing Northwind, Basic Samples, and Advanced Samples Modules

`Advanced Samples` and `Basic Samples` depend on the `Northwind` module, so you can't remove `Northwind` without also removing the others.

### Removing the Assembly Registrations in Startup.cs:

Edit the `Startup.cs` file to remove the assembly registration for these modules:
```cs
//<if:Northwind>
typeof(Serenity.Demo.Northwind.CustomerController).Assembly,
//</if:Northwind>
//<if:BasicSamples>
typeof(Serenity.Demo.BasicSamples.BasicSamplesController).Assembly,
//</if:BasicSamples>
//<if:AdvancedSamples>
typeof(Serenity.Demo.AdvancedSamples.AdvancedSamplesController).Assembly,
//</if:AdvancedSamples>
//<if:DataAuditLog>
```

The lines that start with `typeof` are there so that the feature modules can register their navigation items, and other stuff.

You may not see the `<if:Northwind>` style of comments there unless you used `serin` to create the project.

### Removing the Connection String for Northwind:

Edit the `appsettings.json` file and remove the `Northwind` connection string:

```json
"Northwind": {
    "ConnectionString": "Server=(localdb)\\MsSqlLocalDB;Database=MyProject_Northwind_v1;...",
    "ProviderName": "System.Data.SqlClient"
}
```

> You may also want to delete the YourProjectName_Northwind_Default_v1 database from (localdb)\MsSqlLocalDB.

### Removing the Northwind Bundle from `appsettings.bundles.json`:

Remove the following lines from `appsettings.bundles.json` file:

```json
"NorthwindLookups": [
    "dynamic://Lookup.Northwind.Category",
    "dynamic://Lookup.Northwind.Customer",
    "dynamic://Lookup.Northwind.CustomerCountry",
    "dynamic://Lookup.Northwind.CustomerCity",
    "dynamic://Lookup.Northwind.Employee",
    "dynamic://Lookup.Northwind.Shipper",
    "dynamic://Lookup.Northwind.OrderShipCountry",
    "dynamic://Lookup.Northwind.OrderShipCity",
    "dynamic://Lookup.Northwind.Product",
    "dynamic://Lookup.Northwind.Region",
    "dynamic://Lookup.Northwind.Supplier",
    "dynamic://Lookup.Northwind.Territory"
]
```

This is a bundle definition for Northwind-related lookups.

### Remove Northwind Aggregates from the Dashboard

If you did not modify `DashboardPage.cs` file, you may have something like the following there:

```cs
public ActionResult Index(
    //<if:Northwind>
    [FromServices] ITwoLevelCache cache,
    [FromServices] ISqlConnections sqlConnections
    //</if:Northwind>
    )
{
    //<if:Northwind>
    if (cache is null)
        throw new ArgumentNullException(nameof(cache));

    if (sqlConnections is null)
        throw new ArgumentNullException(nameof(sqlConnections));

    var o = Serenity.Demo.Northwind.OrderRow.Fields;
    //...
```

To remove the Northwind aggregates from the dashboard, replace the entire block with the following:

```cs
[PageAuthorize, HttpGet, Route("~/")]
public ActionResult Index()
{
    return View(MVC.Views.Common.Dashboard.DashboardIndex, 
        new DashboardPageModel());
}
```

Just make sure not to delete any of your code!

Also, edit `DashboardIndex.cshtml` and replace the lines that look like the following:

```xml
<!--<if:Northwind>-->
<a href="~/Northwind/Order?shippingState=0" 
    class="card-footer">More info 
    <i class="fa fa-arrow-circle-right"></i></a>
<!--</if:Northwind>-->
```

with:

```xml
<a href="" class="card-footer">More info 
    <i class="fa fa-arrow-circle-right"></i></a>
```

### Removing Sample Navigation Items

Edit `NavigationItems.cs` file to remove the following:

```cs
[assembly: NavigationSection("MyProject/Demo Modules",
    Include = new[] { "Northwind", "Basic Samples", "Advanced Samples", "Theme Samples" })]
```

### Removing Northwind Migration-Related Code

Edit the `DataMigrations.cs` file and remove the lines that reference Northwind:

```cs
private static readonly string[] databaseKeys = new[] { // dont remove this!
    "Default" // don't remove this!
    //<if:Northwind> // remove this
    , "Northwind" // remove this
    //</if:Northwind> // remove this
};

//<if:Northwind> // remove all these
if (databaseKey.Equals("Northwind", StringComparison.OrdinalIgnoreCase))
{
    migrationNamespace = typeof(Serenity.Demo.Northwind.Migrations.MigrationAttribute).Namespace;
    migrationAssemblies = new[] { typeof(Serenity.Demo.Northwind.Migrations.MigrationAttribute).Assembly };
}
//</if:Northwind>
```

### Removing the Package References

Edit the project file (`YourProjectName.Web.csproj`) and remove the following package references:

```xml
    <!--<if:Northwind>-->
    <PackageReference Include="Serenity.Demo.Northwind" 
        Version="6.4.3.1" />
    <!--</if:Northwind>-->
    <!--<if:BasicSamples>-->
    <PackageReference Include="Serenity.Demo.BasicSamples" 
        Version="6.4.3.1" />
    <!--</if:BasicSamples>-->
    <PackageReference Include="Serenity.Pro.UI" 
        Version="6.4.3.2" />
    <!--<if:AdvancedSamples>-->
    <PackageReference Include="Serenity.Demo.AdvancedSamples" 
        Version="6.4.3.2" />
    <!--</if:AdvancedSamples>-->
```

Again, the lines that look like `<!--if:Northwind>-->` won't be there if you did not use `serin`.

### Removing Typings

If you have any of the following folders, delete them:

```txt
typings/serenity.demo.advancedsamples
typings/serenity.demo.basicsamples
typings/serenity.demo.northwind
```

Please note that if you are using ES-modules, e.g. any project that is created from 6.4.3+, you don't need the `typings` folder at all as it is only used for the old `Namespaces` style code. You can safely remove the whole folder.

### Rebuild the Project

As of this point, there should be no artifacts related to Northwind and sample modules in your project. Rebuild, and run your project to see if it works properly.

## Removing Other Pro Features

### Removing DataAuditLog

Please make sure you are not using Data Audit Logging functionality, and don't have any [AuditLog] attributes on your entities before removing it.

Delete the following lines from `Startup.cs` file:

```cs
//<if:DataAuditLog>
typeof(Serenity.Pro.DataAuditLog.DataAuditLogController).Assembly,
//</if:DataAuditLog>
```

Delete the `Migrations/DefaultDB/DefaultDB_20180513_2014_DataAuditLog.cs` file.


Delete the following lines from `AdministrationNavigation.cs` file:

```cs
//<if:DataAuditLog>
[assembly: NavigationLink(9100, "Administration/Data Audit Log", 
    typeof(Serenity.Pro.DataAuditLog.DataAuditLogController), 
    icon: "fa-history premium-feature")]
//</if:DataAuditLog>
```

Remove the following package reference from the project file:

```xml
<!--<if:DataAuditLog>-->
<PackageReference Include="Serenity.Pro.DataAuditLog" 
    Version="6.4.3.2" />
<!--</if:DataAuditLog>-->
```

### Removing DataExplorer

The `DataExplorer` should only be removed if you don't use the dynamic data explorer page or any of its components.

Remove the following lines from the `Startup.cs` file:

```cs
//<if:DataExplorer>
typeof(Serenity.Pro.DataExplorer.DataExplorerController).Assembly,
//</if:DataExplorer>

//<if:DataExplorer>
services.Configure<Serenity.Pro.DataExplorer.DataExplorerConfig>(
    Configuration.GetSection(
        Serenity.Pro.DataExplorer.DataExplorerConfig.SectionKey));
//</if:DataExplorer>
```

Delete the following lines from `AdministrationNavigation.cs` file:

```cs
//<if:DataExplorer>
[assembly: NavigationLink(9200, "Administration/Data Explorer", 
    typeof(Serenity.Pro.DataExplorer.DataExplorerController), 
    icon: "fa-database premium-feature")]
//</if:DataExplorer>
```

Remove the following package reference from the project file:

```xml
<!--<if:DataExplorer>-->
<PackageReference Include="Serenity.Pro.DataExplorer" Version="6.4.3.2" />
<!--</if:DataExplorer>-->
```

### Removing `EmailClient`

The `EmailClient` should be removed if you don't use the IMAP email client sample.

Remove the following lines from the `Startup.cs` file:

```cs
//<if:EmailClient>
typeof(Serenity.Pro.EmailClient.MailboxController).Assembly,
//</if:EmailClient>
```

Delete the following lines from `AdministrationNavigation.cs` file:

```cs
//<if:DataExplorer>
[assembly: NavigationLink(9200, "Administration/Data Explorer", 
    typeof(Serenity.Pro.DataExplorer.DataExplorerController), 
    icon: "fa-database premium-feature")]
//</if:DataExplorer>
```

Remove the following package reference from the project file:

```xml
<!--<if:EmailClient>-->
<PackageReference Include="Serenity.Pro.EmailClient" Version="6.4.3.2" />
<!--</if:EmailClient>-->
```


### Removing `Serenity.Pro.UI` Package Reference

If you removed the `EmailClient`, you may also remove this package reference as it is only used by that:

```xml
<PackageReference Include="Serenity.Pro.UI" Version="6.4.3.2" />
```

### Removing `EmailQueue`

If you are not using the email queueing functionality, e.g. putting the emails into a mail queue before getting sent, and retrying sending them if they fail the first time, you may remove the `EmailQueue`.

Delete the following lines from `Startup.cs` file:

```cs
//<if:EmailQueue>
typeof(Serenity.Pro.EmailQueue.EmailQueueController).Assembly,
//</if:EmailQueue>

//<if:EmailQueue>
backgroundJobManager.Register(ActivatorUtilities
    .CreateInstance<Serenity.Pro.EmailQueue.EmailQueueJob>(app.ApplicationServices));
//</if:EmailQueue>
```

Delete the `Migrations/DefaultDB/DefaultDB_20170211_1527_Mailing.cs`, and the `DefaultDB_20210522_1623_MailSerializedMessage.cs` files.


Delete the following lines from `AdministrationNavigation.cs` file:

```cs
//<if:EmailQueue>
[assembly: NavigationLink(9300, "Administration/Email Queue", 
    typeof(Serenity.Pro.EmailQueue.EmailQueueController), 
    icon: "fa-envelope-o premium-feature")]
//</if:EmailQueue>
```

Remove the following lines from the `appsettings.json` file:

```json
  "MailingService": {
    "Enabled": true,
    "AutoUse": true,
    //...
  }
```

Remove the following package reference from the project file:

```xml
<!--<if:EmailQueue>-->
<PackageReference Include="Serenity.Pro.EmailQueue" 
    Version="6.4.3.2" />
<!--</if:EmailQueue>-->
```

## Removing `OpenIdDict`

If you are not using JWT / Open ID connect authentication, e.g. connecting to your services via mobile applications, you may remove the OpenIddict integration.

Delete the following lines from `Startup.cs` file:

```cs
//<if:OpenIddict>
var openIdSection = Configuration.GetSection(...)
services.Configure<Serenity.Pro.OpenIddict.OpenIdSettings>(...);
var openIdSettings = openIdSection.Get<...>();
if (openIdSettings.Enabled)
    services.AddOpenIddictLocalServerWithDefaults(...);
//</if:OpenIddict>

//<if:OpenIddict>
var openIdSettings = app.ApplicationServices.GetService<...>>().Value;
if (openIdSettings.Enabled)
    app.UseOpenIddictSchemeFor(...);
//</if:OpenIddict>
```

Delete the `Migrations/DefaultDB/DefaultDB_20220629_1515_OpenIddict.cs` file.

Delete the `Modules/Administration/OpenId` folder.

Remove the following lines from the `appsettings.json` file:

```json
  "OpenIdSettings": {
    "Enabled": false,
    "Applications": [
      //...
    ]
  },
```

Remove the following package reference from the project file:

```xml
<!--<if:OpenIddict>-->
<PackageReference Include="Serenity.Pro.OpenIddict" 
    Version="6.4.3.2" />
<!--</if:OpenIddict>-->
```

### Removing `Meeting`

The `Meeting` module should be removed if you don't use any of the meeting pages under `Pro Features/Meeting`.

Remove the following lines from the `Startup.cs` file:

```cs
//<if:Meeting>
typeof(Serenity.Pro.Meeting.MeetingController).Assembly,
//</if:Meeting>
```

Delete the `Migrations/DefaultDB/DefaultDB_20161126_2100_Meeting.cs` file.

Delete the `"Meeting"` from the following lines in `NavigationItems.cs` file:

```cs
[assembly: NavigationSection("MyProject/Pro Features",
    Include = new[] { "Meeting", "Organization", "Work Log" })]
```

Remove the following package reference from the project file:

```xml
<!--<if:Meeting>-->
<PackageReference Include="Serenity.Pro.Meeting" Version="6.4.3.2" />
<!--</if:Meeting>-->
```

### Removing `Organization`

As the `Meeting` module depends on the `Organization` module, it should only be removed if you removed the `Meeting` module and don't use any of the organization pages under `Pro Features/Organization`.

Remove the following lines from the `Startup.cs` file:

```cs
//<if:Organization>
typeof(Serenity.Pro.Organization.BusinessUnitController).Assembly,
//</if:Organization>
```

Delete the `Migrations/DefaultDB/DefaultDB_20161126_2000_Organization.cs` file.

Delete the `"Organization"` from the following lines in `NavigationItems.cs` file:

```cs
[assembly: NavigationSection("MyProject/Pro Features",
    Include = new[] { "Organization", "Work Log" })]
```

Remove the following package reference from the project file:

```xml
<!--<if:Organization>-->
<PackageReference Include="Serenity.Pro.Organization" Version="6.4.3.2" />
<!--</if:Organization>-->
```

## Removing WorkLog

The `WorkLog` module can be removed If you are not using the time tracking / work log pages.

Remove the following lines from the `Startup.cs` file:

```cs
//<if:WorkLog>
typeof(Serenity.Pro.WorkLog.WorkLogController).Assembly,
//</if:WorkLog>
```

Delete the `Migrations/DefaultDB/DefaultDB_20210824_1546_WorkLog.cs` file.

Delete the `"Work Log"` from the following lines in `NavigationItems.cs` file:

```cs
[assembly: NavigationSection("MyProject/Pro Features",
    Include = new[] { "Work Log" })]
```

Remove the following package reference from the project file:

```xml
<!--<if:WorkLog>-->
<PackageReference Include="Serenity.Pro.WorkLog" Version="6.4.3.2" />
<!--</if:WorkLog>-->
```

