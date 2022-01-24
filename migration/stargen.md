# Stargen

Stargen is a tool we provide for StartSharp customers, which automates updates / upgrades (migrations) listed under Migrations section (starting from 3.14.x to 5.0.12 migration).

> When it runs, Stargen automatically updates *Serenity* packages and *dotnet sergen* tool to their latest versions. This works even when there are no pending upgrades.

Please note that **Stargen** is a *simple regex based* search / replace tool, not an intelligent system. Even though we try to handle many edge cases and the tool has an extensive suit of tests, there is still a possibility for the tool to break your code and result in losing some of your customizations. The risk increases with the amount of customizations made to the StartSharp code, and how old a template your project was initially created from.

It is strongly recommended to take a full backup of your project and/or use a version control system like GIT to minimize the risks. It is also a good idea to check the applied changes manually before committing them.

The tool takes a backup of files it overrides under **%USERPROFILE%\Documents\stargen\upgrades** folder matching the original directory structure. You may also try to revert to original versions of files from there if something goes wrong (by copy pasting contents back to your project directory).

**By downloading and running the tool you acknowledge that you read the terms outlined in this document and understand the possible risks**

## DISCLAIMER 

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE

## Installing / Updating Stargen

If you haven't already, you should start by registering **serenity.is** package source.

Please open following Serenity.is members page which contains information about the premium package source, your private access token, and how to register it:

https://serenity.is/Dashboard

The command you should find there is something like following:

```cmd
dotnet nuget add source -n serenity.is 
       https://packages.serenity.is/your-customerid/your-apikey/v3/index.json
```

or this one below if you prefer not to have your access token in the URL (e.g. to keep it safe from prying eyes):

```cmd
dotnet nuget add source -n serenity.is https://packages.serenity.is/v3/index.json 
       -u "your-username" -p "your-customer-identifier/your-api-key"
```

> You may also use Nuget Package Sources option under Visual Studio settings dialog.

Once you configured the premium package source, run following to update/install *stargen* as a global tool:

```
dotnet tool update -g stargen
```

> `tool update` command should be able to install it first time as well, but if you get an error try following:
>
> dotnet tool install -g stargen

## Running Stargen Upgrade

* Please first commit your changes or take a full backup of your project.

* Make sure Visual Studio is closed and IIS express is not running, so that your project files are not locked

* Open a command prompt in your project directory where your sergen.json and appsettings.json resides and execute following commands:

```ps
C:\MyProject\MyProject\MyProject.Web> dotnet tool update -g stargen
C:\MyProject\MyProject\MyProject.Web> stargen upgrade
```
You'll get an output like following:

```ps
Running Upgrade: From Serenity v3 to Serenity.Net v5
Overwritten files can be restored from: C:\Users\yourusername\Documents\stargen\upgrades\YourProject.Web\20210101-2046
```

If everything went good, you may now open your project and try clean / rebuild.

There may be some errors left if you have customizations in your code, in that case, please follow the upgrade notes in *Migration* section on left navigation.

## Checking Applied Upgrades

Stargen display the applied upgrades during execution and it also records them in *sergen.json* file:

```json
{
  "RootNamespace": "MyProject",
  "UpgradeInfo": {
    "AppliedUpgrades": [
      "UP_20201206_1720_Serenity_v3_to_v5"
    ]
  }
}
```

Using this information, stargen avoids running an upgrade when it runs a second time if it was already applied to the project.