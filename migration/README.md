# Introduction

## Update vs Upgrade (Migration)

To avoid confusion, let's start by defining `Update` and `Upgrade (Migration)` which have completely different meanings. 

When we say `Update` it generally means `Updating Serenity NuGet Packages` to their `latest versions`. This is just about fetching latest versions of binary NuGet packages and most of the time that does not require any manual code modification.

Meanwhile, `upgrade (or migration)` involves breaking changes and there will be some modifications that needs to be applied to your code manually. 

> Migration is sometimes confused with *Database Migration* so we refer to it as a *upgrade*.

If you *update* Serenity packages and see that something does not work as it should, you should visit *Migrations* section on this site to understand what to do. It is also a good idea to visit this site before *trying a update* to see if there are any breaking changes.

Premium StartSharp customers can use [`stargen`](stargen.md) tool to automate *updates* and *upgrades* if any.

* [Updating/Upgrading Using Stargen](stargen.md)

## Identifying Packages to Update

To see which `Serenity` packages you need to update, first have a look at your csproj file:

```xml
<PackageReference Include="Serenity.Pro.Scripts" Version="5.0.12" />
<PackageReference Include="Serenity.Net.Web" Version="5.0.20" />
<PackageReference Include="Serenity.Assets" Version="5.0.19" />
<PackageReference Include="Serenity.Scripts" Version="5.0.20" />
<PackageReference Include="Serenity.Demo.ThemeSamples" Version="5.0.20.1" />
```

Take a note of any `PackageReference` include that starts with `Serenity.`

## Updating Serenity Packages

Updating `Serenity` packages only updates `Serenity NuGet Packages` to their `most recent versions`.

Open a command prompt at your project directory and execute following commands in order:

### Base Package Updates

```cmd
dotnet restore
dotnet add package Serenity.Net.Web
dotnet add package Serenity.Assets
dotnet add package Serenity.Scripts
```

> If you use `Package Manager Console` in Visual Studio you may also try `Update-Package` command instead of `dotnet add package`.

### Pro Package Updates

If you are a StartSharp customer, download latest version of `pro-packages.zip` from StartSharp repository, extract it to `pro-packages` folder under your solution folder and execute following:

```cmd
dotnet add package Serenity.Pro.Scripts
```

> This is the only pro package as of writing. It contains all pro feature scripts. We'll be splitting them into separate packages and introducing new ones, so please prefer [`stargen`](stargen.md) to automate all updates

### Updating Feature Packages

If you have common / premium feature packages like `Serenity.Demo.ThemeSamples` etc in your project, you need to also update them (otherwise you shouldn't):

```cmd
dotnet add package Serenity.Demo.ThemeSamples
```


## Applying Upgrades (Migration)

If you tried to update and had some issues, you should check the migration notes that are listed on the left navigation. 

> It is also a good idea to check them even when no errors occur during the update. There might be some critical security issues etc. that should be handled.

You should start from the version you created your project from, and apply all of the migrations in order (from bottom to top).

For example, if you created your project from a v3.14.x template, and the latest version is 5.0.20, you should apply upgrade notes in following order:

* 3.14.x to 5.0.12
* 5.0.12 to 5.0.20

StartSharp customers should see the following document and use *Stargen* tool to automate upgrade process:

* [Upgrading / Updating using Stargen](stargen.md)

