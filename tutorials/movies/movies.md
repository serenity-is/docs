
# Tutorial: Movie Database

Let's create editing interface for some site similar to IMDB with Serenity.

> You can find source code for this tutorial at: 

> https://github.com/volkanceylan/MovieTutorial



### Create a new project named *MovieTutorial*

In Visual Studio click File -> New Project. Make sure you choose *Serene* template. Type *MovieTutorial* as name and click *OK*.

> You might also choose Serene (AspNetCore) version. A few things will be different. We'll try to list those differences.

In Solution explorer, you should see one project with name *MovieTutorial.Web*.

MovieTutorial.Web project is an ASP.NET MVC (or Core) application that contains server side code plus static resources like css files, images etc. 

MovieTutorial.Web also has a tsconfig.json file at root, which specifies that it is also a TypeScript project. All *.ts* files under *Modules/* and *Scripts/* directories are compiled on save, and their outputs are combined into a script file under *scripts/site/* folder with name *MovieTutorial.Web.js*.

> Please make sure that you have TypeScript 2.5.2+ installed. Check your version from Visual Studio Extensions dialog.

> To install TypeScript 2.5.2+ in Visual Studio, you'll need to install Visual Studio 2015 Update 3.
> 
> Download its latest version from http://www.typescriptlang.org/#download-links for your Visual Studio.
> 
> Also check prerequisites in Getting Started section.
