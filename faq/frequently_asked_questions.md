# Frequently Asked Questions

** How To Publish Serenity Applications: **

Serenity applications are x-copy deployable. You just need to setup connection strings after deployment. You might exclude source files from deployment.

Make sure you remove database migration safety check from *RunMigrations* method in *SiteInitialization.Migrations* file.

You can also use publish feature in Visual Studio. Make sure build action for all content files that you use are set to *Content*, and not *None*.

> You have to only publish MyApplication.Web, not script project.

Serenity uses a NuGet version of ASP.NET MVC, so there is no need to install MVC on server. If you get some DLL missing error, check that its *Copy Local* option of VS project references is set to *True*.

** How To Allow Negative Values in DecimalEditor: **

In *DecimalEditor* attribute set *MinValue* and *MaxValue* properties:

```
[DecimalEditor(MinValue = "-999999999.99", MaxValue = "999999999.99")]
public Decimal MyProperty { get; set; }
```

## I'm having an error in Sergen for KDiff3. Where to set its location:

Sergen looks for KDiff3 at its default location under Program Files directory. Install it if you didn't yet.

If Kdiff3 is at another location, edit Serenity.CodeGenerator.config in your solution directory. This is a JSON file containing settings and preferences for Sergen.

## Should I regenerate code after adding fields to my table

It's recommended to only generate code once. You should add new fields to row, column and form classes manually, taking existing fields as a sample.

But if you made too many changes, and want to generate code again it is possible. Sergen will launch Kdiff3 to let you merge changes, so that it won't override the changes you might have made to the code generated before.

> Make sure you use same number of digits for min and max value.

# Troubleshooting


** After you create a new Serene application and launch it, login screen doesn't show and you see an error message in console that says *Template.LoginPanel is not found*: **

You probably used an invalid solution name, like MyProject.Something that contains dot (.) 

Template system might not be able to locate templates when projects are named this way.

Please don't use dot in solution name. You may rename solution after creation if required.

___

** After publishing project some content is not found, or not displayed: **

If you are using Visual Studio publish, make sure that css, image files etc are included in web project and their build action is set to content.

Another possibility is that IIS_IUSRS user group can't access files. Check that it has permissions to files in published web folder.

___

** Table not found (e.g. User) errors after publish: **

Serene has a check to avoid running migrations on an arbitrary database. Find this check under *RunMigrations* method of *SiteInitialization.Migrations* file and remove it.

___

** I have some errors after updating Select2: **

Please don't update Select2 to a version later than 3.5.1. Recent versions has some known compability problems.

To revert to Select2 3.5.1, type following in package manager console:

> Update-Package Select2.js -Version 3.5.1

___

** I'm trying to use LookupEditor but
