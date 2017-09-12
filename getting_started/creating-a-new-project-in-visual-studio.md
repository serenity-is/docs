# Creating a New Project in Visual Studio

Start Visual Studio (if it was already open, restart it). Click File => New Project. You should see Serene template under Templates => Visual C# section.

![VSIX New Project](img/newproject.png)


We have two versions of Serene template. One that uses classic ASP.NET MVC 4 (SERENE) and another one that works on ASP.NET CORE MVC 2.0 / .NET CORE 2.0.

ASP.NET Core is a recent technology and is platform independent (as long as you target .NET Core it also runs on Linux / OSX). 

ASP.NET MVC only runs on Windows and .NET framework but more mature (latest version is dated 2/9/2015).

We can say both versions of Serene is pretty stable.

Here is a document from Microsoft that might help you choose between two frameworks:

https://docs.microsoft.com/en-us/aspnet/core/choose-aspnet-framework

Name your application something like *MyCompany*, *MyProduct*, *HelloWorld* or leave the default *Serene1*.

> Please don't name it *Serenity*. It may conflict with other Serenity assemblies.

Click OK.

## Feature Selection

Serene will prompt you to choose features you would like to see.

![Feature Selection](img/featureselection.png)

All of these features / samples are optional. Initially we recommend you to leave them all checked so that you might have a look at how they are implemented.

After having some experience with Serene, you might create a new application and clear all these checkboxes to have a bare minimum project.

Choose features you like, click OK and take a break while Visual Studio creates the solution.