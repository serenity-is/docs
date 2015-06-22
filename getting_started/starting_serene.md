# Starting Serene

After your first project is created in Visual Studio using Serene template, you will see a solution like this:

![Initial Solution Content](img/initial_solution_content.jpg)

It contains two projects, *Serene1.Script* and *Serene1.Web* (which is common for Serenity applications).

*Serene1.Web* includes the server side code of our application while *Serene1.Script* contains the script code.

The script project looks like a normal .NET project but it actually generates Javascript code, using *Saltarelle Compiler* (https://github.com/erik-kallen/SaltarelleCompiler).

Web project is an MVC application.

Both projects have references to Serenity NuGet packages, so you can update them using package manager console anytime needed.

Serene automatically creates its database in SQL local db at first run, so just press F5 and you are ready to go.

When application launches use `admin` user and `serenity` password to login. You can later change password or create more users from *Administration / User Management* section.

![Login Screen](img/login_screen.jpg)

The sample application includes old and famous Nortwind data along with services and user interface for editing it that is mostly produced by Serenity Code Generator.





