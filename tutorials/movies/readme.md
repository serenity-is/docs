
# Tutorial: Movie Database

Let's create editing interface for some site similar to IMDB with Serenity.


### Create a new project named *MovieTutorial*

In Visual Studio click File -> New Project. Make sure you choose *Serene* template. Type *MovieTutorial* as name and click *OK*.

In Solution explorer, you should see two projects with names *MovieTutorial.Web* and *MovieTutorial.Script*.

> Make sure *MovieTutorial.Web* is the startup project (it should be bold), if not right click on project name and click *Set As Startup Project*.



### What Are These Project Files?

Serenity applications usually has at least two projects. One for server side code plus static resources like css files, images etc. (MovieTutorial.Web) and one for client side code (MovieTutorial.Script).

MovieTutorial.Script looks like an ordinary C# class library but the code it contains is actualy compiled to Javascript using Saltarelle. 

> Its output (MovieTutorial.Script.js) will be copied to folder *Scripts/site/* under *MovieTutorial.Web*. So at runtime, only MovieTutorial.Web project is used.



### Creating *Movie* Table

To store list of movies we need a Movie table. We could create this table using old-school techniques like SQL Management Studio but we prefer creating it as a *migration* using *Fluent Migrator*:

> Fluent Migrator is a migration framework for .NET much like Ruby on Rails Migrations. Migrations are a structured way to alter your database schema and are an alternative to creating lots of sql scripts that have to be run manually by every developer involved. Migrations solve the problem of evolving a database schema for multiple databases (for example, the developer’s local database, the test database and the production database). Database schema changes are described in classes written in C# that can be checked into a version control system.

> See https://github.com/schambers/fluentmigrator for more information on FluentMigrator.

Using *Solution Explorer* navigate to *MovieTutorial.Web / Modules / Common / Migrations / DefaultDB*.

