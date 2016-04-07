# How To: Upgrade to Serenity 2.0 and Enable TypeScript

Serenity has TypeScript support starting with version 2.0.

This is a migration guide for users that started with an older Serene template, and wants to use TypeScript features.

If you don't need TypeScript, just update your Serenity packages and it should work as normal.

> Even if you won't need TypeScript, it's recommended to perform steps listed here to keep your project up to date. This might also help you avoid future problems as there has been many changes in Serene for TypeScript support.


## Should I Switch To TypeScript?

TypeScript support in Serenity is rather new and you might experience a few issues. 

TypeScript compiler itself is also still in development and has some glitches like Compile on Save support is only working with VS2015, or having build ordering problems with MSBUILD projects.

There are also some usability problems. For example there is no intellisense for method overriding in TypeScript.

Anyway, TypeScript is probably the future for Serenity applications, as it has a stronger backing at the moment (Microsoft and average number of users). Also TypeScript feels like native Javascript with proper intellisense, refactoring and compile time type checking. 

We've been using Saltaralle with Serenity since start but its future is a bit blurry. It didn't get any updates since it is acquired by Bridge.NET, last June (2015).

Saltaralle with Serenity is more stable than TypeScript for now. Your old code will continue to work. Saltaralle will be supported as long as possible with Serenity for backward compability. 

If Bridge.NET v2.0 (next Saltaralle) comes out, we may also try to switch, unless it involves with too many changes to handle.

## Migrating Your Serene Application to v2.0


### Check that your solution is building properly


First make sure your solution is properly building.

> If possible, take a ZIP backup of solution, as some steps we'll perform might be hard to revert.


### Install TypeScript


Install TypeScript 1.8+ from

https://www.typescriptlang.org/#download-links

for your Visual Studio version.


### Update NuGet Packages

Update to 2.0 packages as you'd normally do:

```
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Script
```

While updating Serenity.Web, VS might show a dialog with text "Your Project has been configured to support TypeScript". Click YES.


### Ensuring Package Updates Caused No Problems

Rebuild your solution again and run it. Open some pages, dialogs etc. and make sure that it is working properly with 2.0 packages.


### Configuring Web Project for TypeScript

Unload MyProject.Web and edit it.

Add lines below after TypeScriptToolsVersion line:

```xml
    // ...
    <TypeScriptToolsVersion>1.8</TypeScriptToolsVersion>
    <TypeScriptCompileBlocked>True</TypeScriptCompileBlocked>
  </PropertyGroup>
  <PropertyGroup>
    <TypeScriptCharset>utf-8</TypeScriptCharset>
    <TypeScriptEmitBOM>True</TypeScriptEmitBOM>
    <TypeScriptGeneratesDeclarations>False</TypeScriptGeneratesDeclarations>
    <TypeScriptExperimentalDecorators>True</TypeScriptExperimentalDecorators>
    <TypeScriptOutFile>Scripts\site\Serene.Web.js</TypeScriptOutFile>
    <TypeScriptCompileOnSaveEnabled>False</TypeScriptCompileOnSaveEnabled>
  </PropertyGroup>
```

*Replace **Serene.Web.js** with your project name.*

In the end of same file, you'll see lines like below:

```xml
  <Import Project="...Microsoft.CSharp.targets" />
  <Import Project="...Microsoft.WebApplication.targets" />
  <Import Project="...Microsoft.TypeScript.targets" />
```

Make sure the line with TypeScript.targets with is under all other targets. Move it under WebAplpication.targets if not. VS puts them before Microsoft.WebApplication.targets and somehow it doesn't work that way. 

Save changes, reload the project and follow to next step.

### Adding tsconfig.json File

Add a **tsconfig.json** file to the root of your Web project (where web.config and Global.asax files are) with content like below:

```json
{
    "compileOnSave": true,
    "compilerOptions": {
        "preserveConstEnums": true,
        "experimentalDecorators": true,
        "declaration": false,
        "emitBOM": true,
        "sourceMap": true,
        "outFile": "Scripts/site/Serene.Web.js"
    }
}
```

*Replace **Serene.Web.js** with your project name.*



### Add a Test TypeScript File

Add a **dummy.ts** file under YourProject.Web/scripts/site/dummy.ts. Open it and type something like below:

```ts
namespace MyProject {
    export class Dummy {
    }
}
```

When you save it, there should be a MyProject.Web.js file there with content below. If you can't see it, click Show All Files and refresh folder.

```js
var MyProject;
(function (MyProject) {
    var Dummy = (function () {
        function Dummy() {
        }
        return Dummy;
    }());
    MyProject.Dummy = Dummy;
})(MyProject || (MyProject = {}));
//# sourceMappingURL=SereneUpgrading.Web.js.map
```

Right click and include that file to your project. Now you can delete dummy.ts.

Your project is configured for TypeScript.

> If you are using a version before VS2015 and compile on save is not working, you might try removing TypeScriptCompileBlocked property from Web.csproj file and use compile on build.


### Changing Location for T4 Templates

Serene v2.0 has merged some .TT templates and created new one for TypeScript code generation.

Please make sure your project is building successfully and DON'T CLEAN it while performing these steps, otherwise you may end up with a broken project.

Locate file YourProject.Web\Modules\Common\Imports\ MultipleOutputHelper.ttinclude

Make a copy of it in same folder with name *CodeGenerationHelpers.ttinclude*

Get latest source of CodeGenerationHelpers.ttinclude from address below and copy paste it to *CodeGenerationHelpers.ttinclude* file you just created:

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/CodeGenerationHelpers.ttinclude

*Search and Replace **Serene** with **YourProjectName** * in this file if any. There shouldn't be any **Serene** word in this file as of writing.

> You may also create a new Serene project with latest version of template to get these files.

### ClientTypes.tt

Create folder *YourProject.Web\Modules\Common\Imports\ClientTypes* and move *ScriptEditorTypes.tt* to there, then rename *ScriptEditorTypes.tt* to *ClientTypes.tt*.

Grab latest source of ClientTypes.tt file from address below and copy paste it to *ClientTypes.tt* file you just moved:

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/ClientTypes/ClientTypes.tt

*Search and Replace **Serene** with **YourProjectName** * in this file if any.


### ServerTypings.tt

Create folder *YourProject.Web\Modules\Common\Imports\ServerTypings* and move *ScriptFormatterTypes.tt* to there, then rename *ScriptFormatterTypes.tt* to *ServerTypings.tt*.

Grab latest source of ServerTypings.tt file from address below and copy paste it to *ServerTypings.tt* file you just moved:

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/ServerTypings/ServerTypings.tt


*Search and Replace **Serene** with **YourProjectName** * in this file if any.

### Generate Code

While they are open save ClientTypes.tt and ServerTypings.tt files, and wait for them to generate codes.








