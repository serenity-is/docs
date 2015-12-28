
# Tutorial: Movie Database

Let's create editing interface for some site similar to IMDB with Serenity.

> You can find source code for this tutorial at: 

> https://github.com/volkanceylan/Serenity-Tutorials/tree/master/MovieTutorial



### Create a new project named *MovieTutorial*

In Visual Studio click File -> New Project. Make sure you choose *Serene* template. Type *MovieTutorial* as name and click *OK*.

In Solution explorer, you should see two projects with names *MovieTutorial.Web* and *MovieTutorial.Script*.

> Make sure *MovieTutorial.Web* is the startup project (it should be bold), if not right click on project name and click *Set As Startup Project*.



### What Are These Project Files?

Serenity applications usually has at least two projects. One for server side code plus static resources like css files, images etc. (MovieTutorial.Web) and one for client side code (MovieTutorial.Script).

MovieTutorial.Script looks like an ordinary C# class library but the code it contains is actualy compiled to Javascript using Saltarelle. 

> Its output (MovieTutorial.Script.js) will be copied to folder *Scripts/site/* under *MovieTutorial.Web*. So at runtime, only MovieTutorial.Web project is used.

### Adding Project Dependency

By default, Visual Studio only builds MovieTutorial.Web project when you press F5 to run. 

> This is controlled by a setting under Visual Studio Options -> Projects and Solutions -> Build And Run -> "Only build startup projects and dependencies on Run". It is not recommended to change it.

To make Script project also build when Web project is run, right click MovieTutorial.Web project, click *Build Dependencies -> Project Dependencies* and check *MovieTutorial.Script* under *Dependencies* tab.

> Unfortunately, there is no way, we can set this dependency in Serene template.
