# Installing Serene From Visual Studio Marketplace

## Downloading Template

Open URL below in your browser:

https://marketplace.visualstudio.com/items?itemName=VolkanCeylan.SereneSerenityApplicationTemplate

![Visual Studio Marketplace Download](img/vsgalleryserene.png)

Click *Download* to transfer VSIX file to your computer.

## Install Template into Visual Studio

After download is finished, double click the downloaded VSIX file to start Visual Studio extension installation dialog 

> If you have both Visual Studio 2017 and 2015 installed, sometimes Visual Studio 2015 installer might pick up VSIX file so it only installs in Visual Studio 2015. If you experience this issue, right click the file, click *Open With* and choose *Visual Studio Version Selector*.

> ![VSIX Installation](img/vsixopenwith.png)


Click Install when prompted.

![VSIX Installation](img/vsixinstall.png)

> Note that this application template requires Visual Studio 2012 or higher. Make you sure you have the latest Visual Studio updates installed. ASP.NET MVC Core version requires Visual Studio 2017 with Update 3

## Creating a New Project in Visual Studio

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

Please use Pascal casing, e.g. a name that starts with a Capital Letter. Don't name your project something like `myProject`.

Click OK.

## Feature Selection

Serene will prompt you to choose features you would like to see.

![Feature Selection](img/featureselection.png)

All of these features / samples are optional. Initially we recommend you to leave them all checked so that you might have a look at how they are implemented.

After having some experience with Serene, you might create a new application and clear all these checkboxes to have a bare minimum project.

Choose features you like, click OK and take a break while Visual Studio creates the solution.