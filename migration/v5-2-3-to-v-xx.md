# Upgrading from v5.2.3 to v _NEW_VERSION_

## Who should apply these changes?
If you created your project from a StartSharp / Serene 5.2.3+ template you don't need to apply changes in this document.

If the project was created from 5.2.3 or an earlier version, then please first apply migrations earlier migrations listed on left.

StartSharp customers should use [stargen](stargen.md) to automate most of the changes listed here.
Stargen also works on Serene template for this update.

If you are not sure which version of a template your project was created from, you may check your *sergen.json* file. Since version 5.0.19, StartSharp/Serene projects contain information about the initial version of the template under the *UpgradeInfo* section:
 
 ```json
"UpgradeInfo": {
    "InitialType": "Premium",
    "InitialVersion": "5.2.3"
}
```

> If *InitialVersion* is not shown there, it means your initial template version is less than 5.0.19.

## Serenity Package Versions
You should first [update your Serenity package versions](README.md) to `_NEW_VERSION_` minimum.

Your package versions should look like this at the minimum:

```xml
<PackageReference Include="Serenity.Assets" Version="_NEW_VERSION_" />
<PackageReference Include="Serenity.Scripts" Version="_NEW_VERSION_" />
<PackageReference Include="Serenity.Net.Web" Version="_NEW_VERSION_" />
```

Don't forget to update pro packages to `_NEW_VERSION_` as well.

<!-- ## Adding New Packages
You should install the new `Serenity.Pro.Coder` package to your project.

With newly added and updated packages there should be a section that looks like this:
```xml
<PackageReference Include="Serenity.Pro.Coder" Version="_NEW_VERSION_" />
``` -->

## Updating CsProj File

### Updating AssemblyName
Find the `AssemblyName` tag in your `.csproj` file and replace the `.Core` to `.Web`:

```diff
- <AssemblyName>YourProject.Core</AssemblyName>
+ <AssemblyName>YourProject.Web</AssemblyName>
```

### Adding TypeScriptNoEmitOnError
If there is no `<TypeScriptNoEmitOnError` tag with `false` inside in your `.csproj` file, add the following inside any `PropertyGroup` element without any condition:

```xml
<TypeScriptNoEmitOnError>false</TypeScriptNoEmitOnError>
```

If there is any `TypeScriptNoEmitOnError` with `true` inside, remove it.

### Removing TypeScriptToolsVersion Tags
If there is any `TypeScriptToolsVersion` tag in your `.csproj` file, remove it.

### Ignoring node_modules on TypeScriptCompile 
If there is no `TypeScriptCompile` tag with `Remove` attribute with the value of `node_modules`, add the following inside any `ItemGroup` element without any condition:

```xml
<TypeScriptCompile Remove="node_modules\**" />
```

### Adding Content Files
Add the following inside any `ItemGroup` element without any condition:

```xml
<Content Include="libman.json;sergen.json;tsconfig.json;tslint.json">
    <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    <CopyToOutputDirectory>Never</CopyToOutputDirectory>
</Content>

<Content Include="Namespaces/tsconfig.json">
    <CopyToPublishDirectory>Never</CopyToPublishDirectory>
    <CopyToOutputDirectory>Never</CopyToOutputDirectory>
    <ExcludeFromSingleFile>true</ExcludeFromSingleFile>
</Content>
```

### Updating Target CompileTSC  
Add `wwwroot\esm\**\*.js` to the `Outputs` attribute of the `CompileTSC` target.

```diff
-  <Target Name="CompileTSC" AfterTargets="AfterBuild" Inputs="@(CompileTSCInputs)" Outputs="wwwroot\Scripts\site\StartSharp.Web.js">
+  <Target Name="CompileTSC" AfterTargets="AfterBuild" Inputs="@(CompileTSCInputs)" Outputs="wwwroot\Scripts\site\StartSharp.Web.js;wwwroot\esm\**\*.js">
```

### Adding SergenRestore Target

### Adding Condition to x and y Target
