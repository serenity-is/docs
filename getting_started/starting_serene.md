# Starting Serene

After your first project is created in Visual Studio using Serene template, you will see a solution like this:

![Initial Solution Content](img/initial_solution_content.jpg)

It contains two projects, *Serene1.Script* and *Serene1.Web* (which is common for Serenity applications).

*Serene1.Web* includes the server side code of our application, while *Serene1.Script* contains the script code.

The script project looks like an ordinary .NET project but it actually generates Javascript code, using *Saltarelle Compiler* (https://github.com/erik-kallen/SaltarelleCompiler).

Web project is an ASP.NET MVC application.

Both projects have references to Serenity NuGet packages, so you can update them using package manager console anytime necessary.

Serene automatically creates its database in SQL local db at first run, so just press F5 and you are ready to go.

When application launches use `admin` user and `serenity` password to login. You can change password or create more users later, using *Administration / User Management* page.

![Login Screen](img/login_screen.jpg)

The sample application includes old and famous Northwind data along with services and user interface to edit it, which is mostly produced by Serenity Code Generator.



### Troubleshooting Connection Problems

If you are getting a connection error like the following while starting Serene for first time:

> A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: SQL Network Interfaces, error: 50 - Local Database Runtime error occurred. The specified LocalDB instance does not exist.
)



This error might mean that you don't have SQL Server Local DB 2012 installed. This server comes preinstalled with Visual Studio 2012 and 2013. 

In Serene.Web/web.config file there is a *Default* connection entry:

```xml
<connectionStrings>
    <add name="Default" connectionString="Data Source=(LocalDb)\v11.0; 
        Initial Catalog=Serene_Default_v1; Integrated Security=True" 
        providerName="System.Data.SqlClient" />
  </connectionStrings>
```

`(localdb)\v11.0` corresponds to default SQL Server 2012 LocalDB instance.

If you don't have SQL LocalDB 2012, you can install it from:

http://www.microsoft.com/en-us/download/details.aspx?id=29062

Visual Studio 2015 comes with SQL Server 2014 LocalDB. It's default instance name is renamed to MsSqlLocalDB by default. Thus, if you have VS2015, try changing connection string from `(localdb)\v11.0` to `(localdb)\MsSqlLocalDB`.

```xml
<connectionStrings>
    <add name="Default" connectionString="Data Source=(LocalDb)\MsSqlLocalDB; 
        Initial Catalog=Serene_Default_v1; Integrated Security=True" 
        providerName="System.Data.SqlClient" />
  </connectionStrings>
```

If you still have an error, open an administrative command prompt and type

```bat
> sqllocaldb info
```

This will list localdb instances like:

```
MSSqlLocalDB
test
```

If you don't have MsSqlLocalDB listed, you can create it:

```bat
> sqllocaldb create MsSqlLocalDB
```


If you have another SQL server instance, for example SQL Express, change data source to `.\SqlExpress`:


```xml
<connectionStrings>
    <add name="Default" connectionString="Data Source=.\SqlExpress; 
        Initial Catalog=Serene_Default_v1; Integrated Security=True" 
        providerName="System.Data.SqlClient" />
  </connectionStrings>
```


You can also use another SQL server. Just change the connection string.

