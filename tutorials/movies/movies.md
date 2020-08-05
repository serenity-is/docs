
# Tutorial: Movie Database

Let's create editing interface for some site similar to IMDB with Serenity.

> You can find source code for this tutorial at: 

> https://github.com/volkanceylan/MovieTutorial



### Create a new project named *MovieTutorial*

In Visual Studio click File -> New Project. Make sure you choose *Serene* template. Type *MovieTutorial* as name and click *OK*.

In Solution explorer, you should see one project with name *MovieTutorial.Web*.

MovieTutorial.Web project is an ASP.NET Core application that contains server side code plus static resources like css files, images etc. 

MovieTutorial.Web also has a tsconfig.json file at root, which specifies that it is also a TypeScript project. All *.ts* files under *Modules/* and *Scripts/* directories are compiled on save, and their outputs are combined into a script file under *wwwroot/scripts/site/* folder with name *MovieTutorial.Web.js*.

> Please make sure that you have TypeScript 3.9.5+ installed. Check your version from Visual Studio Extensions dialog.

> Download its latest version from http://www.typescriptlang.org/#download-links for your Visual Studio.
> 
> Also check prerequisites in Getting Started section.
