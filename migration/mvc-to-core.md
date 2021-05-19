# Migrating from ASP.NET MVC to ASP.NET Core

## Existing Project

* We assume your project name is **MyProject**, we'll refer to it as **existing project** from now on.

## Update Serenity/StartSharp/Serene to Latest Version for *existing project*

- Visit following document to update StartSharp/Serene and Serenity to latest versions.

* https://serenity.is/docs/startsharp/updating-startsharp

* This will reduce the potential of having migration problems.

* After updating and testing that there are no problems, close Visual Studio for **existing project**

## Backing up **existing project**

Take a full backup of your solution (ZIP etc) just in case something goes wrong.

## Creating Template Project

* Create a new project using StartSharp/Serene **ASPNET.CORE** version with the same name (**MyProject**) as your **existing project** in a different directory. 

* We'll use this project to transfer files / code to your **existing project**. Let's refer it to as **template project** from now on.

## Renaming Files and Folders

* Open your **existing project** folder and do following renames:
    - **MyProject.Web.csproj** to **Old.MyProject.Web.csproj.bak**
    - **MyProject.Web.csproj.user** to **Old.MyProject.Web.csproj.user.bak**
    - **Web.config** to **Old.Web.Debug.config.bak**
    - **Web.Debug.config** to **Old.Web.Debug.config.bak**
    - **Global.asax** to **Old.Global.asax.bak**
    - **Global.asax.cs** to **Old.Global.asax.cs.bak**
    - **tsconfig.json** to **Old.tsconfig.json**    
    - **package.json** to **Old.package.json**
    - **package-lock.json** to **Old.package-lock.json** (if exists)
    - **packages.config** to **Old.packages.config**
    - **Properties/AssemblyInfo.cs** to **Properties/Old.AssemblyInfo.cs.bak**
    - **Imports/CodeGenerationHelpers.ttinclude** to **Imports/Old.CodeGenerationHelpers.ttinclude.bak**
    - **Imports/MultipleOutputHelper.ttinclude** to **Imports/Old.MultipleOutputHelper.ttinclude.bak**
    - **Imports/Web.config** to **Imports/Old.Web.config.bak**
    - **Imports/ClientTypes/ClientTypes.tt** to **Imports/ClientTypes/Old.ClientTypes.tt.bak**
    - **Imports/ClientTypes/ClientTypes.log** to **Imports/ClientTypes/Old.ClientTypes.log.bak**
    - **Imports/ServerTypings/ServerTypings.tt** to **Imports/ServerTypings/Old.ServerTypings.tt.bak**
    - **Imports/ServerTypings/ServerTypings.log** to **Imports/ServerTypings/Old.ServerTypings.log.bak**
    - **Imports/MVC/MVC.tt** to **Imports/MVC/Old.MVC.tt.bak**
    - **Migrations/Web.config** to **Migrations/Old.Web.config.bak**
    - **Modules/Web.config** to **Modules/Old.Web.config.bak**
    - **Modules/Administration/User/Authentication/LdapDirectoryService.cs** to **Modules/Administration/User/Authentication/Old.LdapDirectoryService.cs.bak**
    - **Modules/Common/Helpers/RequireHttpsWithConfig.cs** to **Modules/Common/Helpers/Old.RequireHttpsWithConfig.cs.bak**
    - **Modules/Northwind/Order/OrderDetailSampleTask.cs** to **Modules/Northwind/Order/Old.OrderDetailSampleTask.cs.bak**
    - **Views/Web.config** to **Views/Old.Web.config.bak**
    - **App_Start/****.cs** to **App_Start/Old.****.cs.bak** (for all files there)
    - **App_Start/** to **Old.App_Start/**
    - **Scripts/** to **Old.Scripts/**
    - **Content/** to **Old.Content/**
    - **fonts/** to **Old.fonts/**
    - **tools/** to **Old.tools/**

  * Delete folder **Modules/AdvancedSamples/Grids/LongRunningAction/**
  * Delete folder **Modules/AdvancedSamples/Grids/VSGalleryQA/**

## Copying Files from Template Project

* Open **template project** folder and copy following files/folders to **existing project** directory to the same folder as the ones in source:

    - **appsettings.json**
    - **MyProject.Web.csproj**
    - **sergen.json**
    - **web.config**
    - **tsconfig.json** 
    - **package.json**
    - **package-lock.json** (if exists)
    - **.config** (might be hidden folder, check explorer settings)
    - **Initialization/** folder with all files and sub folders
    - **typings/** folder with all files and sub folders
    - **Views/_ViewImports.cshtml**
    - **Modules/_ViewImports.cshtml**
    - **Modules/Common/Helpers/XPagedList/** (only available in StartSharp)

* Copy following files from **template project** only if they are also available in your project (they are just samples)
    - **Modules/BasicSamples/BasicSamplesHelper.cs**
    - **Modules/Northwind/Reports/CustomerGrossSalesReport.cs**
    - **Modules/AdvancedSamples/Forms/AdvancedSamplesPage.Forms.cs** (only available in StartSharp)
    - **Modules/AdvancedSamples/Forms/BootstrapForm/BootstrapFormEdit.cshtml** (only available in StartSharp)
    - **Modules/AdvancedSamples/DataTables/DataTables.cs** (only available in StartSharp)
    - **Modules/AdvancedSamples/DataTables/BasicInit.cshtml** (only available in StartSharp)
    - **Modules/AdvancedSamples/DataTables/ServerSide.cshtml** (only available in StartSharp)
    - **Modules/AdvancedSamples/-MyProject-Helper.cs** (only available in StartSharp)
   
## Creating and Populating **wwwroot** folder

* Create a **wwwroot** folder under **existing project** folder.

* Create a **wwwroot/Scripts/**  folder under **existing project** folder

* Copy all files and folders under **Old.Scripts/** to **wwwroot/Scripts/**

* Copy all files and folders except **site/** subfolder under **wwwroot/Scripts/** of **template project** to **wwwroot/Scripts/** folder of **existing project** overwriting any files there. 

* If you copied **site/** subfolder by mistake, you may restore it from **Old.Scripts/** again. It's better to use **Scripts/site/** folder from your **existing project** just in case you made some modifications to **ScriptBundles.json** or local text files there.

* If you did modify any other script in your project under **Scripts/** directory or had a newer version of a script in **existing project**, you may again restore them from **Old.Scripts**.

* Create a **wwwroot/Content/** folder under **existing project** folder

* Copy all files and folders under **Old.Content/** to **wwwroot/Content/**

* Copy all files and folders except **site/** subfolder under **wwwroot/Content/** of **template project** to **wwwroot/Content/** folder of **existing project** overwriting any files there. 

* If you copied **site/** subfolder by mistake, you may restore it from **Old.Content/** again. It's better to use **Content/site/** folder from your **existing project** just in case you made some modifications to **CssBundles.json** or local text files there.

* If you did modify any other css/less file in your project under **Content/** directory or had a newer version of a css/less file in **existing project**, you may again restore them from **Old.Content**.

* Create a **wwwroot/fonts/** under **existing project** folder

* Copy all files and folders under **Old.fonts/** to **wwwroot/fonts/**

* Copy all files and folders under **wwwroot/fonts/** of **template project** to **wwwroot/fonts/** folder of **existing project** overwriting any files there. 

* If you did modify any other font file in your project under **fonts/** directory or had a newer version of a font file in **existing project**, you may again restore them from **Old.fonts**.

* Copy all files and folders under **Old.Scripts/typings/** to **typings/**

* Copy all files and folders under **typings/** of **template project** to **typings/** folder of **existing project** overwriting any files there. 

* Move **favicon.ico** under **existing project** folder to **wwwroot/**


## Open **existing project** in Visual Studio.

You may get lots of errors, we'll resolve them one by one.

## Replacing namespaces and routes

- Using Find and Replace dialog in Visual Studio (Ctrl+H) find and replace following (make sure to include double quotes and parens etc. for search/replace):

* `using System.Web.Mvc;` with `using Microsoft.AspNetCore.Mvc;` in `*.cs` files.
* `using System.Web.Security;` with `using Microsoft.AspNetCore.DataProtection;`
* `[RoutePrefix("` with `[Route("` in `*.cs` files.
* `"), Route("{action}")` with `/[action]")` in `*.cs` files
* `"), Route("{action=index}")` with `/[action]")` in `*.cs` files.
* Find all `public ActionResult Index()` in `*.cs` files, copy the `[Route(".../[action]")]` on top of their controller to the action removing the `/action]` part at the end, and inserting `/` at the start of all route attributes of any such actions that doesn't have `~/` or `/` at start, e.g.:

```cs
    [Route("MyModule/MyEntity/[action]")]
    public class MyEntityController : Controller
    {
        // currently this action is only accessible at address MyModule/MyEntity/Index
        // not MyModule/MyEntity unlike ASP.NET MVC, you can't set a default for action parameter
        public ActionResult Index() 
        {
          // ...
        }

        [Route("SomeOther")] // add slash to such route attributes
        // or its address will become MyModule/MyEntity/ActionWithRoute/SomeOther       
        // as route on controller is a prefix for routes on actions
        public ActionResult ActionWithRoute() 
        {
          // ...
        }

        [Route("/Test")] // no change needed for this action as it is rooted
        public ActionResult ActionWithRoute() 
        {
          // ...
        }

        // no change is needed for this action, as it can be accessed at MyModule/MyEntity/ActionNoRoute
        public ActionResult ActionNoRoute()
        {
        }
    }
```

should become:

```cs
    [Route("MyModule/MyEntity/[action]")]
    public class MyEntityController : Controller
    {
        [Route("/MyModule/MyEntity")]
        [Route("/MyModule/MyEntity/Index")] // add this only if you want it to be accessed as /MyModule/MyEntity/Index too
        public ActionResult Index()
        {
          // ..
        }

        [Route("/SomeOther")]
        public ActionResult AnotherAction() {
          // ...
        }

        [Route("/Test")] // no change needed for this action as it is rooted
        public ActionResult ActionWithRoute() 
        {
          // ...
        }

        // no change is needed for this action, as it can be accessed at MyModule/MyEntity/ActionNoRoute
        public ActionResult ActionNoRoute()
        {
        }
    }

```

> In ASP.NET Core there is nothing similar to RoutePrefix attribute, so its not possible to determine Index action as default for a controller route.

If this is too complex, you may also remove route attribute from the controller, and use explicit routes for all actions:

## Setting Connection Strings

Open **Old.Web.config** file and copy connection strings there to **appsettings.json** under Data.

```json
  "Data": {
    "YourConnectionKey1": {
      "ConnectionString": "YourConnectionString1",
      "ProviderName": "YourProviderName1"
    },
    "YourConnectionKey2": {
      "ConnectionString": "YourConnectionString2",
      "ProviderName": "YourProviderName2"
    }
  },
```

You may remove **Northwind** connection in appsettings.json if your **existing project** doesn't have **Northwind** connection.

## Copying AppSettings

Open **Old.Web.config** file and copy and extra settings or modified settings you have there to **AppSettings** section in **appsettings.json**:

```json
  "AppSettings": {
    "YourJsonSetting1": { 
      // json copied from source replacing single quote with double quote 
    },
    "YourStringSetting2": "value copied from source"
  }
```

## Applying your customizations to **tsconfig.json**

If you modified **tsconfig.json** file in your project before migration, make sure you apply similar changes to new **tsconfig.json** that we copied from **template project**.

Open **Old.tsconfig.json** file and **tsconfig.json** file in your **existing project** directory and compare them to see if you made any changes that should be transferred to the new one.

> If you don't remember doing any manual changes there (which is common for Serenity apps), you may skip this step.


## Applying your customizations to **package.json**

If you modified **package.json** file in your project before migration, e.g. for adding some packages, make sure you apply similar changes to new **package.json** that we copied from **template project**.

Open **Old.package.json** file and **package.json** file in your **existing project** directory and compare them, especially **dependencies** and **devDependencies** sections to see if you made any changes that should be transferred to the new one.

> If you don't remember doing any manual changes there (which is common for Serenity apps), you may skip this step.

## Adding third party package references

If you have any third party package references, other than ones that comes default with StartSharp/Serene, you will need to manually add references to them in your project.

Open **Old.packages.config** file and identify and extra packages that you might have added to your **existing project**.

For example if you have a package like below:


```xml
<package id="Markdig" version="0.17.0" targetFramework="net461" />
```

You'll need to first search **nuget.org** for **MarkDig** package, determine its latest version (also check if it is compatible with .NET Core/Standard)

Then, edit your project file and add a package reference like following:

```xml
<PackageReference Include="Markdig" Version="0.18.1" />
```

You may also use NuGet package manager to add package references but it might be slower sometimes.

## Adding System.DirectoryServices for Active Directory Authentication

If you are planning to use Active Directory Authentication in .NET Core you may have to add following packages:

```
    <PackageReference Include="System.DirectoryServices" Version="4.7.0" />
    <PackageReference Include="System.DirectoryServices.AccountManagement" Version="4.7.0" />
    <PackageReference Include="System.DirectoryServices.Protocols" Version="4.7.0" />
```

If you are not going to use AD authentication, you may simply delete User/Authentication/ActiveDirectoryService.cs.

# Applying Changes for Code Files with Errors

After doing changes so far, you may still have some errors in a few files like AccountPage.cs, UserRepository.cs etc. These are due to API compatibility problems between .NET Core/Framework and ASP.NET MVC/Core. 

You may resolve most of these problems just by copying newer code from **template project** into **existing project** for files with compile errors. But if you made manual changes to these files, applying fixes manually could be useful.

Here we list some of manual changes that should be applied to such files if you don't want to copy them from **existing project**. Please note that these fixes are only valid for current version of Serene/StartSharp and future versions might require applying different changes. So, its a good idea to check most recent code in **template project**.

## Changes in Modules/Membership/Account/AccountPage.cs

If you didn't make any modifications in AccountPage.cs you may directly copy it from **template project**, otherwise do following changes in AccountPage.cs:

* Replace\
  `(object)(FormsAuthentication.LoginUrl + "?returnUrl=" + Uri.EscapeDataString(returnUrl)));`\
  with\
  `(object)("~/Account/Login?returnUrl=" + Uri.EscapeDataString(returnUrl)));`

* Replace\
  `var bytes = MachineKey.Unprotect(Convert.FromBase64String(token), "ImpersonateAs");`\
  with\
  `var bytes = HttpContext.RequestServices.GetDataProtector("ImpersonateAs")`\
    `.Unprotect(Convert.FromBase64String(token));`

* Replace\
  `var Request.UserAgent + "|" + Request.UserHostAddress;`\
  with\
  `var currentClientId = Request.Headers["User-Agent"] + "|" + HttpContext.Connection.RemoteIpAddress;`

* Replace\
  `Session.Abandon();`\
  `FormsAuthentication.SignOut();`\
  with\
  `WebSecurityHelper.LogOut();`

## Changes in Modules/Membership/Account/ChangePassword/AccountPage.ChangePassword.cs

If you didn't make any modifications in AccountPage.ChangePassword.cs you may directly copy it from **template project**, otherwise do following changes in AccountPage.ChangePassword.cs:

* Replace\
  `HttpGet, Authorize]`\
  with\
  `HttpGet, PageAuthorize]`

* Replace\
  `var salt = Membership.GeneratePassword(5, 1);`\
  `var hash = SiteMembershipProvider.ComputeSHA512(request.NewPassword + salt);`\
  with\
  `string salt = null;`\
  `var hash = UserRepository.GenerateHash(request.NewPassword, ref salt);`

## Changes in Modules/Membership/Account/ForgotPassword/AccountPage.ForgotPassword.cs

If you didn't make any modifications in AccountPage.ForgotPassword.cs you may directly copy it from **template project**, otherwise do following changes in AccountPage.ForgotPassword.cs:

* Replace\
  `var token = Convert.ToBase64String(MachineKey.Protect(bytes, "ResetPassword"));`\
  with\
  `var token = Convert.ToBase64String(HttpContext.RequestServices`\
  `.GetDataProtector("ResetPassword").Protect(bytes));`

* Replace\
  `var emailBody = TemplateHelper.RenderTemplate(`\
  with\
  `var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,`

  Replace\
  `Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");`\
  with\
  `Request.GetBaseUri().ToString();`

## Changes in Modules/Membership/Account/ResetPassword/AccountPage.ResetPassword.cs

If you didn't make any modifications in AccountPage.ResetPassword.cs you may directly copy it from **template project**, otherwise do following changes in AccountPage.ResetPassword.cs:

* Replace\
  `using (var ms = new MemoryStream(MachineKey.Unprotect(Convert.FromBase64String(t), "ResetPassword")))`\
  with\
  `var bytes = HttpContext.RequestServices`\
  `.GetDataProtector("ResetPassword").Unprotect(Convert.FromBase64String(t));`\
  `using (var ms = new MemoryStream(bytes))`

* Replace\
  `using (var ms = new MemoryStream(MachineKey.Unprotect(`\
  `Convert.FromBase64String(request.Token), "ResetPassword")))`\
  with\
  `using (var ms = new MemoryStream(bytes))`

* Replace\
  `var salt = Membership.GeneratePassword(5, 1);`\
  `var hash = SiteMembershipProvider.ComputeSHA512(request.NewPassword + salt);`\
  with\
  `string salt = null;`\
  `var hash = UserRepository.GenerateHash(request.NewPassword, ref salt);`


## Changes in Modules/Membership/Account/SignUp/AccountPage.Signup.cs

If you didn't make any modifications in AccountPage.Signup.cs you may directly copy it from **template project**, otherwise do following changes in AccountPage.Signup.cs:

* Replace\
  `var token = Convert.ToBase64String(MachineKey.Protect(bytes, "Activate"));`\
  with\
  `var token = Convert.ToBase64String(HttpContext.RequestServices`\
  `.GetDataProtector("Activate").Protect(bytes));`

* Replace\
  `var emailBody = TemplateHelper.RenderTemplate(`\
  with\
  `var emailBody = TemplateHelper.RenderViewToString(HttpContext.RequestServices,`

* Replace\
  `var bytes = MachineKey.Unprotect(Convert.FromBase64String(t), "Activate");`\
  with\
  `var bytes = HttpContext.RequestServices`\
  `.GetDataProtector("Activate").Unprotect(Convert.FromBase64String(t));`

* Replace\
  `Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");`\
  with\
  `Request.GetBaseUri().ToString();`


## Changes in Modules/Administration/User/UserListRequest.cs


Copy this file from **template project** or modify it to add DataProtector property:

```cs
    public class UserListRequest : ListRequest
    {
        [JsonIgnore]
        internal IDataProtector DataProtector;
        [JsonIgnore]
        internal byte[] ClientHash;
    }
```

* Add\
  `using Microsoft.AspNetCore.DataProtection;`

## Changes in Modules/Administration/User/UserEndpoint.cs


Copy this file from **template project** or apply changes below:

* Add\
  `using Microsoft.AspNetCore.DataProtection;`

* Replace\
  `var clientId = Request.UserAgent + "|" + Request.UserHostAddress;`\
  with\
  `request.DataProtector = HttpContext.RequestServices.GetDataProtector("ImpersonateAs");`\
  `var clientId = Request.Headers["User-Agent"] + "|" + HttpContext.Connection.RemoteIpAddress;`

> Some of these changes might only be valid for StartSharp

## Changes in Modules/Administration/User/UserRepository.cs


Copy this file from **template project** or apply changes below:

* Add\ `using Serenity.Abstractions;`

* Replace\
  `isPublicDemo = ConfigurationManager.AppSettings["IsPublicDemo"] == "1"`\
  with\
  `isPublicDemo = Dependency.Resolve<IConfigurationManager>()`\
  `.AppSetting("IsPublicDemo", typeof(string)) as string == "1";`

  > You may also remove isPublicDemo and any code that uses it. It is only meaningful for Serenity.is Demo


* Replace\
  `salt = salt ?? Membership.GeneratePassword(5, 1);`\
  with\
  `salt = salt ?? Serenity.IO.TemporaryFileHelper.RandomFileCode().Substring(0, 5);`
  
* Replace\
  `if (Request.ClientHash != null &&`\
  with\
  `if (Request.DataProtector != null && Request.ClientHash != null &&`


* Replace\
  `entity.ImpersonationToken = GetImpersonationToken(`\
  with\
  `entity.ImpersonationToken = GetImpersonationToken(Request.DataProtector,`

* Replace\
  `private static string GetImpersonationToken(byte[] clientHash, string username)`\
  with\
  `private static string GetImpersonationToken(IDataProtector dataProtector, byte[] clientHash, string username)`

* Replace\
  `var token = Convert.ToBase64String(MachineKey.Protect(bytes, "ImpersonateAs"));`\
  with\
  `var token = Convert.ToBase64String(dataProtector.Protect(bytes));`

  
> Some of these changes might only be valid for StartSharp

## Changes in Modules/Common/Reporting/ReportController.cs


Copy this file from **template project** or apply changes below:

* Add `using Serenity.Abstractions;`
* Add `using Microsoft.AspNetCore.Mvc.ViewFeatures;`

* Replace\
  `var viewData = download ? new ViewDataDictionary(data) : ViewData;`\
  with\
  `var viewData = download ? new ViewDataDictionary(this.ViewData) { Model = data } : ViewData;`

* Replace\
  `var formsCookie = Request.Cookies[FormsAuthentication.FormsCookieName];`\
  with\
  `var formsCookieName = ".AspNetAuth";`\
  `var formsCookie = Request.Cookies[formsCookieName];`

* Replace\
  `converter.Cookies[formsCookieName] = formsCookie;`\
  with\
  `converter.Cookies[FormsAuthentication.FormsCookieName] = formsCookie.Value;`

* Replace\
  `var languageCookie = Request.Cookies["LanguagePreference"];`\
  `if (languageCookie != null)`\
  `   converter.Cookies["LanguagePreference"] = languageCookie.Value;`\
  with\
  `var languageCookieName = "LanguagePreference";`\
  `var languageCookie = Request.Cookies[languageCookieName];`\
  `if (languageCookie != null)`\
  `   converter.Cookies[languageCookieName] = languageCookie.Value;`\

* Replace\
  `Response.AddHeader("Content-Disposition", cd.ToString());`\
  with\
  `Response.Headers["Content-Disposition"] = "inline;filename=" + System.Net.WebUtility.UrlEncode(fileDownloadName);`\

* Replace\
  `Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");`\
  with\
  `Request.GetBaseUri().ToString();`

* Replace\
  `var html = TemplateHelper.RenderViewToString(designAttr.Design, viewData);`\
  with\
  `var html = TemplateHelper.RenderViewToString(HttpContext.RequestServices, designAttr.Design, viewData);`

## Changes in Modules/Common/File/FilePage.cs


Copy this file from **template project** or apply changes below:

* Add `using HttpContextBase = Microsoft.AspNetCore.Http.HttpContext;`

* Add `using Microsoft.AspNetCore.Mvc;`

* Replace\
  `return new FilePathResult(filePath, mimeType);`\
  with\
  `if (!((string)Request.Headers["Accept"] ?? "").Contains("json"))`

* Replace\
  `if (context.Request.Files.Count != 1)`\
  with\
  `if (context.Request.Form.Files.Count != 1)`

* Replace\
  `HttpPostedFileBase file = context.Request.Files[0];`\
  with\
  `var file = context.Request.Form.Files[0];`

* Replace\
  `if (processor.ProcessStream(file.InputStream, Path.GetExtension(file.FileName)))`\
  with\
  `if (processor.ProcessStream(file.OpenReadStream(), Path.GetExtension(file.FileName)))`

* Replace\
  `using (var sw = new StreamWriter(Path.ChangeExtension(`\
  `UploadHelper.DbFilePath(temporaryFile), ".orig")))`\
  with\
  `using (var sw = new StreamWriter(System.IO.File.OpenWrite(`\
  `Path.ChangeExtension(UploadHelper.DbFilePath(temporaryFile), ".orig"))))`

* Replace\
  `if (!(Request.Headers["Accept"] ?? "").Contains("json"))`\
  with\
  `if (!((string)Request.Headers["Accept"] ?? "").Contains("json"))`

## Changes in Modules/Common/EmailClient/EmailPage.cs

Copy this file from **template project** if it exists.

## Changes in Modules/Common/EmailClient/EmailEndpoint.cs

Copy this file from **template project** if it exists.

## Changes in Administration/Translation/TranslationRepository.cs


Copy this file from **template project** or apply changes below:

* Replace\
  `return HostingEnvironment.MapPath("~/App_Data/texts/") + "user.texts." + (languageID.TrimToNull() ?? "invariant") + ".json";`\
  with\
  `return Path.Combine(Path.GetDirectoryName(HostingEnvironment.MapPath("~/")),`\
  `"App_Data/texts/".Replace('/', Path.DirectorySeparatorChar)) + "user.texts." + (languageID.TrimToNull() ?? "invariant") + ".json";`

* Remove or comment two lines below:
  `Dependency.Resolve<IDependencyRegistrar>().RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());`\
  `CommonInitialization.InitializeLocalTexts();`

## Changes in Modules/Common/Navigation/NavigationModel.cs


Copy this file from **template project** or apply changes below:

* Add\
  `using Microsoft.AspNetCore.Http;`\
  `using Microsoft.AspNetCore.Http.Extensions;`

* Replace\
  `if (HttpContext.Current != null)`\
  with\
  `var httpContext = Dependency.Resolve<IHttpContextAccessor>().HttpContext;`\
  `if (httpContext != null)`

* Replace\
  `var requestUrl = HttpContext.Current.Request.Url;`\
  with\
  `var requestUrl = httpContext.Request.GetDisplayUrl();`

* Replace\
  `String.Compare(requestUrl.AbsolutePath, HostingEnvironment.ApplicationVirtualPath,`\
  `, StringComparison.OrdinalIgnoreCase) == 0)`\
  with\
  `String.Compare(httpContext.Request.Path,`\
  `HostingEnvironment.ApplicationVirtualPath, StringComparison.OrdinalIgnoreCase) == 0)`

## Changes in Modules/Common/Reporting/ExcelReportGenerator.cs


Copy this file from **template project** then manually apply your changes if any.

## Changes in Modules/Common/Reporting/ReportPage.cshtml


Copy this file from **template project** then manually apply your changes if any.

## Changes in Views/Shared/LeftNavigation.cshtml


Copy this file from **template project** then manually apply your changes if any.

## Changes in Views/Shared/_Layout.cshtml

* Replace all occurences of\
`@UICulture`\
with\
`@System.Globalization.CultureInfo.CurrentUICulture.Name`

* Replace\
  `VirtualPathUtility.ToAbsolute("~/upload/") + user.UserImage`\
  with\
  `System.Web.VirtualPathUtility.ToAbsolute("~/upload/") + user.UserImage`

* Replace\
`Func<string, IHtmlString> json = x => new HtmlString(Serenity.JSON.Stringify(x));`\
with\
`Func<string, HtmlString> json = x => new HtmlString(Serenity.JSON.Stringify(x));`

* Replace\
`themeCookie = Request.Cookies["...Theme"]...`\
`var theme = ...`\
with\
`var themeCookie = Context.Request.Cookies["...Theme"];`\
`var theme = themeCookie != null && !themeCookie.IsEmptyOrNull() ? themeCookie : "azure-light";`

* Replace 
`var hideNav = Request["hideNav"] == "1";`
with\
`var hideNav = (string)Context.Request.Query["hideNav"] == "1";`

* Replace\
`@{Html.RenderPartial(MVC.Views.Shared._LayoutHead);}`\
with\
`<partial name="@MVC.Views.Shared._LayoutHead" />`

* Replace\
`@{Html.RenderPartial(MVC.Views.Shared.LeftNavigation, new MyProject.Navigation.NavigationModel()); }`
with\
`<partial name="@MVC.Views.Shared.LeftNavigation" model="new MyProject.Navigation.NavigationModel()" />`

## Changes in Views/Shared/_LayoutNoNavigation.cshtml

* Replace all occurences of 
`@UICulture`\
with\
`@System.Globalization.CultureInfo.CurrentUICulture.Name`

## Changes in Modules/Membership/Account/AccountLogin.cshtml

* Replace\
`@if (SiteInitialization.SkippedMigrations)`\
with\
`@if (DataMigrations.SkippedMigrations)`

* Replace\
  `@{Html.RenderPartial(MVC.Views.Shared._LayoutHead);}`\
  with\
  `<partial name="@MVC.Views.Shared._LayoutHead" />`

## Applying Your Manual Changes to Startup.cs from SiteInitialization.cs

* If you made any changes in SiteInitialization.cs, you will have to apply them to Startup.cs.

* This might include registering background tasks, setting authorization services like permission service etc.

* This part is a bit tedious work as there are lots of differences between .NET Core and MVC registration process. 

* Please take existing code in Startup.cs as a sample, and try to identify how you can apply your manual changes there.

* If stuck, please ask in Serenity GitHub repository for community help and we'll add useful solutions to this document.