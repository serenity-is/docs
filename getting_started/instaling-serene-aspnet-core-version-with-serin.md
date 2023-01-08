# Installing Serene Asp.Net Core Version with SERIN

This section is for users who doesn't or can't use Visual Studio (in Linux / OSX). 

Serene Asp.Net Core version supports Linux and Mac OSX in addition to Windows.

> We recommend Visual Studio Code for all platforms, but it is also possible to work with a basic text editor like Notepad / VIM. There are also other nice options e.g. Atom.

## Install .NET SDK 

Please go to the address below and follow the instructions for your specific platform:

https://www.microsoft.com/net/download/core

> Serenity usually depends on latest stable version of .NET SDK, if you get an error on project creation about .NET SDK, please check the error message, and install appropriate version of .NET SDK as this document might be updated yet.

## Install NodeJS

As TypeScript (and our SERene project INitializer - SERIN) runs on NodeJS you need to install Node/NPM from:

https://nodejs.org/en/download/

or using your favorite package manager:

https://nodejs.org/en/download/package-manager/

### Install SERIN as a Global Tool

Install our project initializer, *SERIN* as a global tool using NPM:

**Linux / OSX:**

```sh
> sudo npm install -g serin
```

**Windows:**
```
> npm install -g serin
```

![NPM Install Serin](img/linux-npm-install-serin.png)

> Thanks to Victor (@vctor) for Linux screenshots

### Create a Folder for New Project

Create an empty *MySerene* (or a name you like) folder.

**Linux / OSX:**

```sh
> cd ~
> mkdir MySerene
> cd MySerene
```

**Windows:**

```cmd
> cd c:\Projects
> mkdir MySerene
> cd MySerene
```

> Serin has to be run from a completely empty directory

### Run Serin to Create a New Project

While inside an empty directory, run *serin*:

```cmd
> serin
```

> If you are trying to create a StartSharp project, or directly from an existing Serene VSIX file downloaded from the marketplace, you may type the full path to the VSIX file:
> `serin /path/to/StartSharp.Template.vsix

![Windows Serin MyApp](img/linux-serin-myserene.png)

Type an application name, e.g. `MySerene`, and press `ENTER`. Take a break while Serin creates 
your project, initializes static content, and restores packages.

After Serin creates your project, you will have a *MySerene.Web* folder under the current directory. 
Enter that directory:

```cmd
> cd MySerene.Web
```

## Running Serene

For OSX / Linux, first, restore packages:

```cmd
> dotnet restore
```

Make sure you run this command under *MySerene.AspNetCore* folder.

Then type:

```cmd
> dotnet run
```

Now open a browser and navigate to `http://localhost:5000`.

> Actual port may vary. You'll see it on console after executing *dotnet run*.
