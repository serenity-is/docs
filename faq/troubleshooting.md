# Troubleshooting

## Initial Setup

** After you create a new Serene application and launch it, login screen doesn't show and you see an error message in console that says *Template.LoginPanel is not found*: **

You probably used an invalid solution name, like MyProject.Something that contains dot (.) 

Template system might not be able to locate templates when projects are named this way.

Please don't use dot in solution name. You may rename solution after creation if required.

## NuGet Packages and Updates

___

** I have some errors after updating Select2: **

Please don't update Select2 to a version later than 3.5.1. Recent versions has some known compability problems.

To revert to Select2 3.5.1, type following in package manager console:

> Update-Package Select2.js -Version 3.5.1


## Deployment and Publishing

___

** After publishing project some content is not found, or not displayed: **

If you are using Visual Studio publish, make sure that css, image files etc are included in web project and their build action is set to content.

Another possibility is that IIS_IUSRS user group can't access files. Check that it has permissions to files in published web folder.

___

** Table not found (e.g. User) errors after publish: **

Serene has a check to avoid running migrations on an arbitrary database. Find this check under *RunMigrations* method of *SiteInitialization.Migrations* file and remove it.

** I'm getting *FieldAccessExceptions* with message "Cannot set a constant field" **

Your hosting provider has set your web application pool to medium trust. Ask them to grant high trust, or if possible change provider.

Serenity initializes field objects with reflection. Under medium trust, it can't do that. You may try replacing all **public static readonly*" field declarations with "*public static"*, but not sure if this will resolve all problems. 