# 如何升级到 Serenity 2.0 并启用 TypeScript ？

Serenity 从 2.0 版本开始支持 TypeScript。

这是一个为使用旧版本 Serene 模板且想使用 TypeScript 功能的用户提供的迁移指南。 

如果你不需要 TypeScript，只需要更新你的 Serenity 程序包，它应该能正常工作。

> 即使你不需要 TypeScript，还是建议你执行此处列出的步骤来更新你的项目，因为 Serene 已经发生了许多变化以支持 TypeScript，升级可能会帮助你避免未来的问题。


## 我应该切换到 TypeScript 吗？

 Serenity 已经稳定支持使用 TypeScript 并强烈推荐你也使用它编写代码。因为 TypeScript 有更强的后盾（微软和大量用户），TypeScript 将是 Serenity 应用程序的未来。  

此外 TypeScript 感觉像原生 Javascript 拥有特赞的智能感知、重构和编译时类型检查 。 

自 Serenity 一开始，我们一直使用 Saltaralle，但由于它于去年 6 月（2015 年） 被 Bridge.NET 收购，此后没有得到任何更新，它的未来有点模糊。

使用 Saltaralle 写的旧代码将继续工作，Serenity 尽可能的向前兼容。 

如果 Bridge.NET v2.0 （下一个 Saltaralle）出来后，我们可能尝试切换回去，除非它涉及的改变大多而不能处理。 

## 迁移你的 Serene 应用程序到 v2.0  


### 请检查你的解决方案正确生成 


首先确保你的解决方案能成功生成。

> 如果可能的话，以 ZIP 备份解决方案，因为我们执行的一些步骤可能难以恢复。


### 安装 TypeScript 


从 

https://www.typescriptlang.org/#download-links

为你的 Visual Studio 版本安装 TypeScript 1.8+。 


### 更新 NuGet 程序包 

像平常那样更新到 Serenity 2.0 的程序包：

```
Update-Package Serenity.Web
Update-Package Serenity.CodeGenerator
Update-Package Serenity.Script
```

当更新 Serenity.Web 时，VS 可能会显示 "你的项目已经配置为支持 TypeScript " 的对话框，点击确定即可。


### 确保更新程序包没有导致问题

再次重新生成你的解决方案并运行它。打开一些页面、对话框等，以确保在 2.0 程序包下正确地工作。


### 在 Web 项目中配置 TypeScript 

卸载 MyProject.Web 并编辑它：

在 TypeScriptToolsVersion 后面添加下面的配置：

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

*用项目名称替代 **Serene.Web.js** 。* 

在同一文件的末尾，你将看到像下面的内容：

```xml
  <Import Project="...Microsoft.CSharp.targets" />
  <Import Project="...Microsoft.WebApplication.targets" />
  <Import Project="...Microsoft.TypeScript.targets" />
```

确保含 TypeScript.targets 的行在所有其他目标（targets）下面。如果不在该位置，则把它移到 WebAplpication.targets 下面。若把它放在 Microsoft.WebApplication.targets 之前，VS 将不能正常工作。   

同样地，在文件底部，你可以找到 *编译网站 Less (CompileSiteLess)* 的步骤，在这里添加 TSC ： 

```xml
  <Target Name="CompileSiteLess" AfterTargets="AfterBuild">
    <Exec Command="&quot;$(ProjectDir)tools\node\lessc.cmd&quot; 
        &quot;$(ProjectDir)Content\site\site.less&quot; &gt; 
        &quot;$(ProjectDir)Content\site\site.css&quot;">
    </Exec>
    <Exec Command="&quot;$(TscToolPath)\$(TypeScriptToolsVersion)\
        $(TscToolExe)&quot; -project &quot;
        $(ProjectDir)tsconfig.json&quot;" ContinueOnError="true" />
  </Target>
```

保存修改，重新加载项目并继续下面的步骤。

### 添加 tsconfig.json 文件 

在你的 Web 项目的根目录下（web.conifg 和 Global.asax 文件所在的位置）添加 **tsconfig.json** 文件，其内容如下：

```json
{
    "compileOnSave": true,
    "compilerOptions": {
        "preserveConstEnums": true,
        "experimentalDecorators": true,
        "declaration": true,
        "emitBOM": true,
        "sourceMap": true,
        "target": "ES5",
        "outFile": "Scripts/site/Serene.Web.js"
    },
    "exclude": [
        "Scripts/site/Serene.Web.d.ts"
    ]
}
```

*用项目名称替代 **Serene.Web** 。



### 添加一个测试的 TypeScript 文件 

在 YourProject.Web/scripts/site/ 中添加一个文件 **dummy.ts**。打开该文件并输入如下内容：

```ts
namespace MyProject {
    export class Dummy {
    }
}
```

当你保存该文件后，应该有一个含如下内容的 MyProject.Web.js 文件。如果你没有看到该文件，点击 显示所有文件 并刷新文件夹。

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

右键并包含该文件到项目。现在你可以删除 dummy.ts。

> 如果你使用 VS2015 之前的版本，可能保存后不能编译 TS 文件，将在生成项目时被编译。

### 在 _LayoutHead.cshtml 包含 MyProject.Web.js 文件 

编辑 MyProject.Web/Views/Shared/_LayoutHead.cshtml，并在 MyProject.Script.js 之后包含 MyProject.Web.js 引用。

```cshtml
// ...
@Html.Script("~/Scripts/Site/MyProject.Script.js")
@Html.Script("~/Scripts/Site/MyProject.Web.js")
// ...
```

你项目的 TypeScript 已经配置好了。


### 修改 T4 模板的位置

Serene v2.0 已经合并了一些 .TT 模板并为 TypeScript 创建了一个新的代码生成器。 

请确保你的项目成功生成，并且在执行生成时，不要取消生成，否则你将得到残缺的项目。

定位到 YourProject.Web\Modules\Common\Imports\ MultipleOutputHelper.ttinclude 文件。 

在同一文件夹中复制一份该文件，并重命名为 *CodeGenerationHelpers.ttinclude*。 

复制下面连接中最新 CodeGenerationHelpers.ttinclude 代码，并把它粘贴到新建的文件中： 

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/CodeGenerationHelpers.ttinclude

在该文件中 * 查找 **Serene** 并替换为 **YourProjectName** *，该文件中不应该含任何  **Serene** 。 

> 你可以用最新版本的模板创建 Serene 项目来获得这些文件。

### ClientTypes.tt

创建文件夹 *YourProject.Web\Modules\Common\Imports\ClientTypes* 并把 *ScriptEditorTypes.tt* 移到该文件夹，然后把 *ScriptEditorTypes.tt* 重命名为 *ClientTypes.tt*。 

从下面连接复制粘贴得到 *ClientTypes.tt* 内容：

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/ClientTypes/ClientTypes.tt

在该文件中 * 查找 **Serene** 并替换为 **YourProjectName** * 


### ServerTypings.tt

创建文件夹 *YourProject.Web\Modules\Common\Imports\ServerTypings* 并把 *ScriptFormatterTypes.tt* 移到该文件夹，然后把 *ScriptFormatterTypes.tt* 重命名为 *ServerTypings.tt* 。

从下面连接复制粘贴得到 *ServerTypings.tt* 内容：

https://raw.githubusercontent.com/volkanceylan/Serene/master/Serene/Serene.Web/Modules/Common/Imports/ServerTypings/ServerTypings.tt


在该文件中 * 查找 **Serene** 并替换为 **YourProjectName** * 

### 生成代码 

当保存打开的 ClientTypes.tt 和 ServerTypings.tt 文件时，模板文件将生成代码。 While they are open save ClientTypes.tt and ServerTypings.tt files, and wait for them to generate codes.

保存并重新生成项目。Save project and rebuild.

### 修改 T4 模板的 FormContexts 和 ServiceContracts 的位置 

这两个模板已经合并成一个。

我们将在 Web 项目重复类似的步骤。

定位到 YourProject.Script\Imports\ MultipleOutputHelper.ttinclude 文件。 

在同一文件夹中复制一份该文件，并重命名为 CodeGenerationHelpers.ttinclude。

复制下面连接（连接已经不一样了）中最新 CodeGenerationHelpers.ttinclude 代码，并把它粘贴到新建的文件中：

[https://raw.githubusercontent.com/volkanceylan/Serene/ b900c67b4c820284379b9c613b16379bb8c530f3/Serene/Serene.Script/ Imports/CodeGenerationHelpers.ttinclude](https://raw.githubusercontent.com/volkanceylan/Serene/b900c67b4c820284379b9c613b16379bb8c530f3/Serene/Serene.Script/Imports/CodeGenerationHelpers.ttinclude)

*在该文件中 查找 **Serene** 并替换为 **YourProjectName**。* 

### ServiceContracts.tt

把文件夹 *YourProject.Script\Imports\ServiceContracts* 重命名为 **ServerImports**，并把 *ServiceContracts.tt* 重命名为 *ServerImports.tt*。

从下面连接复制粘贴得到 *ServerImports.tt* 内容：

[https://raw.githubusercontent.com/volkanceylan/Serene/ b900c67b4c820284379b9c613b16379bb8c530f3/Serene/Serene.Script/ Imports/ServerImports/ServerImports.tt](https://raw.githubusercontent.com/volkanceylan/Serene/b900c67b4c820284379b9c613b16379bb8c530f3/Serene/Serene.Script/Imports/ServerImports/ServerImports.tt)

*在该文件中 查找 **Serene** 并替换为 **YourProjectName**。

删除 *FormContexts* 文件夹及其 *FormContext.tt* 文件。 Delete folder *FormContexts* with file *FormContext.tt* in it.

保存 **ServerImports.tt** 并等待其生成代码。这可能得花点时间，由于包含一些 Saltaralle 代码导致其生成速度慢下来。

重新生成解决方案并确保没有生成错误。

** 恭喜！ 你的项目已经为 TypeScript 和其他功能做好准备了 **


### 这些新的 .tt 文件有什么作用？

- **ServerTypings.tt**: 为 TypeScript 生成代码，包括 行（Row）、表单（Form）、列（Column）、从服务器 (Web) 代码导入服务声明引用。此外，如果有 YourProject.Script 文件，将导入该类的引用。

- **ServerTypes.tt**: 为 Saltaralle 生成代码，包括  行（Row）、表单（Form）、列（Column）、从服务器 (Web) 代码导入服务声明引用。这里还没有从 TypeScript 导入类引用，因此如果你想在 Saltaralle 代码中使用一些 TypeScript 类，你需要手工导入（import）类引用。

- **ClientTypes.tt**: 为 Web 项目生成代码，包含从 TypeScript 和 Saltaralle 导入的编辑器和格式化器。 


### 怎样生成 TypeScript 网格/对话框代码

 Serenity 代码生成器（Sergen）现在有一个选项，只需勾选 *Generate Grid/Dialog Code in TypeScript (instead of Saltaralle)* 就可在 YourProject.Web/Modules/YourEntity 目录下生成 YourDialog.ts 和 YourGrid.ts 文件，以替代 YourProject.Script 项目的  YourGrid.cs 和 YourDialog.cs。

** 请不要使用 Sergen 为已存在的 Saltaralle 对话框或网格生成代码。否则，你将有两个 YourGrid 和 YourDialog 类，很可能导致始料不及的错误。 **






