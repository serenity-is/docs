# Stargen

Stargen is a tool we provide for StartSharp customers, which automates updates / migrations listed under Migrations section (starting from 3.14.x to 5.0.12 migration).

Please note that **Stargen** is a *simple regex based* search / replace tool, not an intelligent system. Even though we try to handle many edge cases and the tool has an extensive suit of tests, there is still a possibility for the tool to break your code and result in losing some of your customizations. The risk increases with the amount of customizations made to the StartSharp code, and how old a template your project was initially created from.

It is strongly recommended to take a full backup of your project and/or use a version control system like GIT to minimize the risks. It is also a good idea to check the applied changes manually before committing them.

The tool takes a backup of files it overrides under **%USERPROFILE%\Documents\stargen\upgrades** folder matching the original directory structure. You may also try to revert to original versions of files from there if something goes wrong (by copy pasting contents back to your project directory).

**By downloading and running the tool you acknowledge that you read the terms outlined in this document and understand the possible risks**

## DISCLAIMER 

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE

## Downloading Stargen

Start by downloading *Stargen* from the relases section in StartSharp repository:

https://github.com/volkanceylan/StartSharp/releases/

Save it to an empty folder anywhere, open a command prompt, CD to that directory containing the nuget package you downloaded:

```ps
C:\>cd C:\NewDir
C:\NewDir>
```

## Installing / Updating Stargen

Run following to update/install *stargen* as a global tool:

```
C:\NewDir> dotnet tool update stargen --global --add-source .\
```

> `tool update` command should be able to install it first time as well, but if you get an error try following:
>
> dotnet tool install stargen --global --add-source .\

## Running Stargen Upgrade

* Please first commit your changes or take a full backup of your project.

* Make sure Visual Studio is closed and IIS express is not running, so that your project files are not locked

* Open a command prompt in your project directory where your sergen.json and appsettings.json resides and execute following command:

```ps
C:\MyProject\MyProject\MyProject.Web> stargen upgrade
```
You'll get an output like following:

```ps
Running Upgrade: From Serenity v3 to Serenity.Net v5
Overwritten files can be restored from: C:\Users\yourusername\Documents\stargen\upgrades\YourProject.Web\20210101-2046
```

If everything went good, you may now open your project and try clean / rebuild.

There may be some errors left if you have customizations in your code, in that case, please follow the notes in *Migration* section on Serenity docs:

https://serenity/docs/migration

## Checking Applied Migrations

Stargen display the applied migrations during execution and it also records them in *sergen.json* file:

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

Using this information, stargen avoids running a migration when it runs a second time if it was already applied to the project.