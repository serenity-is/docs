# Troubleshooting

## Initial Setup

**After you create a new Serene application and launch it, login screen doesn't show and you see an error message in console that says *Template.LoginPanel is not found*:**

You probably used an invalid solution name, like MyProject.Something that contains dot (.) 

Template system might not be able to locate templates when projects are named this way.

Please don't use dot in solution name. You may rename solution after creation if required.

## Compilation Errors

**I'm getting several *ambiguous reference* errors after adding a file to Script project :**

Remove *System.dll* reference from script project. Visual Studio adds this reference when you use *Add New File* dialog. Saltarelle Compiler doesn't work with such references, as it has a completely different runtime.

Please use copy/paste to create code files in Script project.

**Error: System.ComponentModel.DisplayName attribute exists in both ...\Serenity.Script.UI.dll and ...\v2.0...\System.dll** 

Same as above, remove *System.dll* reference from script project.

## Runtime Errors

**I'm getting *NotImplementException* when uploading files, or adding notes:**

Such features requires a table with integer identity column. String/Guid primary key support is added in recent Serenity versions, and some old behaviors doesn't work with such keys.


### SQL and Connections

**When i change page in grid, i'm getting error, "Incorrect syntax near 'OFFSET'. Invalid usage of the option NEXT in the FETCH statement:**

Your SQL server version is 2008 or older. By default, SQL Server connections use SQL2012 dialect. Do something like below for your connections in SiteInitialization.cs and your dialect for all to SqlServer2005 or SqlServer2008:

```cs
  SqlConnections.GetConnectionString("Default").Dialect =
    SqlServer2008Dialect.Instance;
```


## T4 Template Problems

**My enum is not transferred to script side, after transforming templates:**

If you use an enum type in a row or service request / response it will be transferred, otherwise it won't by default. If you still want to include this enum, add [ScriptInclude] attribute on top of it.

## Editors and Forms

**Tried to setup cascaded dropdowns but my second dropdown is always empty:**

Make sure your CascadeField is correct and it matches property name in secondary lookup properly. For example CountryID doesn't match CountryId at script side. You may use nameof() operator like CascadeField = nameof(CityRow.CountryId) to be sure.

A similar problem might occur if you fail to correctly set CascadeFrom option. This corresponds to first dropdown ID in your form. For example, if there are MyCountryId and CustomerCityId properties in the form, CascadeForm should be *CustomerCountryId*. Again, you can use nameof(MyCountryId) to be certain.

> CascadeFrom is an editor ID in form, while CascadeField is a field property name in row.

Another possibility is that CascadeField is not included in lookup data that is sent to script side. For example, if second dropdown is city selection, which is connected to a country dropdown through CountryId, make sure that CountryId property in CityRow has a [LookupInclude] attribute on it. By default, only ID and Name properties are sent to script side for lookups.

___

** Tried to create tabs using a dialog template, but my tab is not shown or empty: **

Make sure you don't put a tab content, inside another one, like DIV inside another tab DIV.

## Master/Detail Editing

**I created a in memory master detail editing similar to one in Movie Tutorial cast editor, but when i update a record, i'm getting duplicate entries:**

Make sure you don't have a [IdProperty] on your EditDialog class. As edit dialogs work in memory with records that doesn't yet have actual IDs, if you use your actual ID property with them, dialog will think that you are adding new records on update (as their actual ID value is always null).

As you see in code below, GridEditorDialog base class uses a fake ID:

```cs
[IdProperty("__id")]
public abstract class GridEditorDialog<TEntity> : EntityDialog<TEntity>
    where TEntity : class, new()
```

So when you put [IdProperty] to your edit dialog, you're overwriting this fake ID and causing unexpected behavior.

___

**I'm succesfully adding details but later when open an existing record, some view fields are empty:**

Please put [MinSelectLevel(SelectLevel.List)] on your view fields in YourDetailRow.cs. By default, List handlers and MasterDetailBehavior only loads table fields (not view fields) of detail rows.


## Permissions

** My page is not shown in navigation: **

Page access permissions are read from *PageAuthorize* attribute on *Index* action of *XYZPage.cs* file, which is your MVC page controller. Make sure you set this to a permission user has.

___


** I have added a permission to PermissionKeys.cs but it doesn't show in user permissions dialog:**

PermissionKeys class is just for intellisense purposes. See below for information about registering keys.

* [How To Register Permissions in Serene](howto/how_to_register_permissions_in_serene.md)

___

** Changed permission keys on row, but i'm getting an error when i open the page, and no records displayed:**

Your XYZEndpoint.cs also has a *[ServiceAuthorize("SomePermission")]* on it. This is to provide a secondary level security. Replace permission key with the one on Row. 

## Localization

** My localizations lost on live site after publishing: **

The translations you made using translation interface are saved to files under ~/App_Data directory. Either copy these files to live server, or move texts in them to relevant files under ~/Scripts/site/texts.

___

**I have added some custom local text keys but can't access them from script side:**

Not all translations are transferred to script side. There is a setting in web.config with *LocalTextPackages* key, that controls these prefixes. If you look there, you can see that only text keys that are starting with *Db.*, *Dialogs.*, *Forms.* etc are transferred to client side. This is to limit size of texts as not all of them are used in script code.

Either add your own prefix there, or change your keys to start with one of default prefixes.

___

## NuGet Packages and Updates


** I have some errors after updating Select2: **

Please don't update Select2 to a version later than 3.5.1. Recent versions has some known compability problems.

To revert to Select2 3.5.1, type following in package manager console:

> Update-Package Select2.js -Version 3.5.1


## Deployment and Publishing

** After publishing project some content is not found, or not displayed: **

If you are using Visual Studio publish, make sure that css, image files etc are included in web project and their build action is set to content.

Another possibility is that IIS_IUSRS user group can't access files. Check that it has permissions to files in published web folder.

___

** Table not found (e.g. User) errors after publish: **

Serene has a check to avoid running migrations on an arbitrary database. Find this check under *RunMigrations* method of *SiteInitialization.Migrations* file and remove it.

___

** *FieldAccessExceptions* with message "Cannot set a constant field" **:

Your hosting provider has set your web application pool to medium trust. Ask them to grant high trust, or if possible change provider.

It might be possible to change trust level in web.config if your hosting provider didn't lock it:

```
<configuration> 
  <system.web> 
    <trust level="Full" />
  </system.web> 
</configuration> 

```

Serenity initializes field objects with reflection. Under medium trust, it can't do that. You may try replacing all **public  readonly*" field declarations with "*public static"* in *Row.cs, but not sure if this will resolve all problems. 

> ASP.NET has made Medium trust obsolete, and they won't fix any problems related to this anymore. See http://stackoverflow.com/questions/16849801/is-trying-to-develop-for-medium-trust-a-lost-cause
> It is strongly recommended to change your hosting provider