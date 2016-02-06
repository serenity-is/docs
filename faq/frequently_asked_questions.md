# Frequently Asked Questions

## Code Generator (Sergen)

** Should I regenerate code after adding fields to my table:**

It's recommended to only generate code once. You should add new fields to row, column and form classes manually, taking existing fields as a sample.

But if you made too many changes, and want to generate code again it is possible. Sergen will launch Kdiff3 to let you merge changes, so that it won't override the changes you might have made to the code generated before.

___

** I'm having an error in Sergen about KDiff3. Where to set its location: **

Sergen looks for KDiff3 at its default location under Program Files directory. Install it if you didn't yet.

If Kdiff3 is at another location, edit Serenity.CodeGenerator.config in your solution directory. This is a JSON file containing settings and preferences for Sergen.


## Permissions

** I want to separate INSERT permission from UPDATE permission **:

Instead of [ModifyPermission] attribute use [InsertPermission] and [UpdatePermission] attributes on rows.

By default, for INSERT, save handler looks for these permissions on row in this order on row:

- 1) InsertPermission
- 2) ModifyPermission 
- 3) ReadPermission

Only the first one that is found is checked.

Similarly for UPDATE, save handler looks for these permissions in order on row:

- 1) UpdatePermission
- 2) ModifyPermission
- 3) ReadPermission

For DELETE, delete handler looks for these permissions in order on row:

- 1) DeleteInsertPermission
- 2) ModifyPermission
- 3) ReadPermission


## Publishing and Deployment

** How can i publish Serenity applications: **

Serenity applications are x-copy deployable. You just need to setup connection strings after deployment. You might exclude source files from deployment.

Make sure you remove database migration safety check from *RunMigrations* method in *SiteInitialization.Migrations* file.

You can also use publish feature in Visual Studio. Make sure build action for all content files that you use are set to *Content*, and not *None*.

> You have to only publish MyApplication.Web, not script project.

Serenity uses a NuGet version of ASP.NET MVC, so there is no need to install MVC on server. If you get some DLL missing error, check that its *Copy Local* option of VS project references is set to *True*.

## Forms and Editors

** How to allow negative values in DecimalEditor: **

In *DecimalEditor* attribute set *MinValue* and *MaxValue* properties:

```cs
[DecimalEditor(MinValue = "-999999999.99", MaxValue = "999999999.99")]
public Decimal MyProperty { get; set; }
```
> Make sure you use same number of digits for min and max value.

___

** How to set current date in a date editor in new record mode: **

Add [DefaultValue("today")] for date, or [DefaultValue("now")] for date time editor in form declaration.

> Don't do this in row. It may cause errors.

Another option is to do this in dialog, overriding *AfterLoadEntity*:

```cs`
form.MyDateField.AsDate = JsDate.Today;
```