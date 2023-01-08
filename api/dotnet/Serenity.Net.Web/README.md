# Serenity.Net.Web assembly

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| class  | [ScriptCulture](Serenity/ScriptCulture.md) | Culture options that are passed to the client side |

## Serenity.ComponentModel namespace

| signature | name | description |
| --: | --- | --- |
| class  | [EmailEditorAttribute](Serenity.ComponentModel/EmailEditorAttribute.md) | Email editor type with two inputs. Please prefer EmailAddressEditorAttribute which uses a single input. |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ForXmlHelper](Serenity.Data/ForXmlHelper.md) | Helper to generate T-SQL FOR XML RAW statements |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [DynamicScriptServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md) | Contains DI extension methods related to dynamic script services |
| static class  | [NodeScriptRunnerExtensions](Serenity.Extensions.DependencyInjection/NodeScriptRunnerExtensions.md) | Contains extensions for [`NodeScriptRunner`](Serenity.Web/NodeScriptRunner.md) |

## Serenity.Navigation namespace

| signature | name | description |
| --: | --- | --- |
| interface  | [INavigationItemSource](Serenity.Navigation/INavigationItemSource.md) | Navigation item source abstraction |
| interface  | [INavigationModel](Serenity.Navigation/INavigationModel.md) | Navigation model abstraction |
| interface  | [INavigationModelFactory](Serenity.Navigation/INavigationModelFactory.md) | Factory abstraction for navigation models |
| class  | [NavigationGroupAttribute](Serenity.Navigation/NavigationGroupAttribute.md) | Defines a navigation group, which are usually the icons on the sidebar band |
| class  | [NavigationHelper](Serenity.Navigation/NavigationHelper.md) | Contains helper methods for navigation models and items |
| class  | [NavigationItem](Serenity.Navigation/NavigationItem.md) | A node in a navigation tree model |
| abstract class  | [NavigationItemAttribute](Serenity.Navigation/NavigationItemAttribute.md) | Navigation item attribute |
| class  | [NavigationLinkAttribute](Serenity.Navigation/NavigationLinkAttribute.md) | A navigation item with a link |
| class  | [NavigationMenuAttribute](Serenity.Navigation/NavigationMenuAttribute.md) | Navigation menu without a link |
| class  | [NavigationSectionAttribute](Serenity.Navigation/NavigationSectionAttribute.md) | Navigation section attribute |

## Serenity.Reporting namespace

| signature | name | description |
| --: | --- | --- |
| class  | [HtmlToPdfConverter](Serenity.Reporting/HtmlToPdfConverter.md) | HTML to PDF converter class using WKHTMLToPdf |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AntiforgeryCookieResultFilterAttribute](Serenity.Services/AntiforgeryCookieResultFilterAttribute.md) | Append the anti forgery token as CSRF-TOKEN cookie to the response, so that AJAX calls can read it client side and send as a header. |
| class  | [AuthorizeCreateAttribute](Serenity.Services/AuthorizeCreateAttribute.md) | Authorizes access to a service method by reading one of InsertPermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| class  | [AuthorizeDeleteAttribute](Serenity.Services/AuthorizeDeleteAttribute.md) | Authorizes access to a service method by reading one of DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| class  | [AuthorizeListAttribute](Serenity.Services/AuthorizeListAttribute.md) | Authorizes access to a service method by reading ReadPermissionAttribute. It also allows lookup mode access (as OrPermission) if the source type has ServiceLookupPermissionAttribute |
| class  | [AuthorizeUpdateAttribute](Serenity.Services/AuthorizeUpdateAttribute.md) | Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| static class  | [EndpointExtensions](Serenity.Services/EndpointExtensions.md) | Contains some extensions for service endpoints |
| class  | [FileUploadBehavior](Serenity.Services/FileUploadBehavior.md) | Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute. |
| class  | [HandleServiceExceptionAttribute](Serenity.Services/HandleServiceExceptionAttribute.md) | An exception filter attribute to handle service exceptions and return them to ServiceResponse objects |
| class  | [JsonRequestAttribute](Serenity.Services/JsonRequestAttribute.md) | An action filter for methods that accept JSON content via their "request" arguments. |
| class  | [MultipleFileUploadBehavior](Serenity.Services/MultipleFileUploadBehavior.md) | Behavior class that handles MultipleFileUploadEditorAttribute and MultipleImageUploadEditorAttribute. |
| class  | [Result&lt;TResponse&gt;](Serenity.Services/Result-1.md) | An action result type containing a object |
| class  | [ResultWithStatus&lt;TResponse&gt;](Serenity.Services/ResultWithStatus-1.md) | An action result type containing a object with status code |
| class  | [ServiceAuthorizeAttribute](Serenity.Services/ServiceAuthorizeAttribute.md) | Authorizes access to a service action. Optionally checks the permission provided as the first argument. Use special permission key "?" to check for logged-in users, and "*" to allow anyone including anonymous access. This returns a service error instead of raising an exception like PageAuthorize attribute. |
| abstract class  | [ServiceEndpoint](Serenity.Services/ServiceEndpoint.md) | Subclass of controller for service endpoints |
| class  | [ServiceEndpointActionModelConvention](Serenity.Services/ServiceEndpointActionModelConvention.md) | Action model convention for [`ServiceEndpoint`](Serenity.Services/ServiceEndpoint.md) actions |
| class  | [ServiceEndpointModelBinderProvider](Serenity.Services/ServiceEndpointModelBinderProvider.md) | Provides model binding for service endpoints |
| class  | [ServiceEndpointNullModelBinder](Serenity.Services/ServiceEndpointNullModelBinder.md) | Null model binder for interface arguments |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AutoValidateAntiforgeryIgnoreBearerAttribute](Serenity.Web/AutoValidateAntiforgeryIgnoreBearerAttribute.md) | An attribute that causes validation of antiforgery tokens for all unsafe HTTP methods. An antiforgery token is required for HTTP methods other than GET, HEAD, OPTIONS, and TRACE, and when there is no cookie header and authorization is Bearer, e.g. JWT etc. |
| class  | [ColumnsScript](Serenity.Web/ColumnsScript.md) | Dynamic script type for columns (ColumnsScriptAttribute) |
| class  | [ColumnsScriptRegistration](Serenity.Web/ColumnsScriptRegistration.md) | Contains registration methods for [`ColumnsScript`](Serenity.Web/ColumnsScript.md) types |
| class  | [ConcatenatedScript](Serenity.Web/ConcatenatedScript.md) | A dynamic script that is formed from concentanation of other scripts |
| class  | [ContentHashCache](Serenity.Web/ContentHashCache.md) | Default [`IContentHashCache`](Serenity.Web/IContentHashCache.md) implementation |
| class  | [CssBundleManager](Serenity.Web/CssBundleManager.md) | Default implementation for [`ICssBundleManager`](Serenity.Web/ICssBundleManager.md) |
| class  | [CssBundlingOptions](Serenity.Web/CssBundlingOptions.md) | Options for css bundling |
| abstract class  | [DataScript&lt;TData&gt;](Serenity.Web/DataScript-1.md) | Generic subclass of the [`DataScript`](Serenity.Web/DataScript.md) |
| class  | [DataScript](Serenity.Web/DataScript.md) | Dynamic script that contains remote data |
| class  | [DataScriptRegistration](Serenity.Web/DataScriptRegistration.md) | Contains helper methods for data script registration |
| class  | [DefaultFileWatcherFactory](Serenity.Web/DefaultFileWatcherFactory.md) | Default implementation for [`IFileWatcherFactory`](Serenity.Web/IFileWatcherFactory.md) |
| class  | [DefaultUploadStorage](Serenity.Web/DefaultUploadStorage.md) | Default IUploadStorage implementation which uses a combined upload storage of two DiskUploadStorage instances. |
| class  | [DistinctValuesRegistration](Serenity.Web/DistinctValuesRegistration.md) | Contains helper methods for distinct values scripts |
| class  | [DistinctValuesScript&lt;TRow&gt;](Serenity.Web/DistinctValuesScript-1.md) | A dynamic script type for distinct values of a field |
| abstract class  | [DynamicScript](Serenity.Web/DynamicScript.md) | Base abstract implementation for [`IDynamicScript`](Serenity.Web/IDynamicScript.md) |
| class  | [DynamicScriptManager](Serenity.Web/DynamicScriptManager.md) | Default implementation for [`IDynamicScriptManager`](Serenity.Web/IDynamicScriptManager.md) |
| static class  | [ExcelContentResult](Serenity.Web/ExcelContentResult.md) | Excel content result helper methods |
| class  | [FileWatcher](Serenity.Web/FileWatcher.md) | Default file watcher implementation for physical file system |
| class  | [FormScript](Serenity.Web/FormScript.md) | Dynamic script type for forms (FormScriptAttribute) |
| class  | [FormScriptRegistration](Serenity.Web/FormScriptRegistration.md) | Contains registration methods for [`FormScript`](Serenity.Web/FormScript.md) types |
| static class  | [HtmlScriptExtensions](Serenity.Web/HtmlScriptExtensions.md) | Contains Serenity related helper methods that can be used in Razor CSHTML files |
| class  | [HttpContextItemsAccessor](Serenity.Web/HttpContextItemsAccessor.md) | Default implementation for IHttpContextItemsAccessor using IHttpContextAccessor and its Items property. |
| class  | [HttpContextUserAccessor](Serenity.Web/HttpContextUserAccessor.md) | Default implementation of IUserAccessor for HTTP context |
| static class  | [HttpRequestExtensions](Serenity.Web/HttpRequestExtensions.md) | Contains HTTP request related extensions |
| interface  | [ICacheSuffix](Serenity.Web/ICacheSuffix.md) | Abstraction to get cache suffix used while generating key for a cached dynamic script |
| interface  | [IContentHashCache](Serenity.Web/IContentHashCache.md) | An abstraction for content hash cache, which contains hashes of web servable files. |
| interface  | [ICssBundleManager](Serenity.Web/ICssBundleManager.md) | Abstraction for css bundling manager |
| interface  | [IDynamicScript](Serenity.Web/IDynamicScript.md) | Dynamic script abstraction |
| interface  | [IDynamicScriptManager](Serenity.Web/IDynamicScriptManager.md) | Dynamic script manager abstraction |
| interface  | [IFileWatcher](Serenity.Web/IFileWatcher.md) | File system watcher abstraction |
| interface  | [IFileWatcherFactory](Serenity.Web/IFileWatcherFactory.md) | An abstract factory to create file system watchers |
| interface  | [IGetScriptData](Serenity.Web/IGetScriptData.md) | Provides access to the data object of a dynamic script |
| interface  | [INamedDynamicScript](Serenity.Web/INamedDynamicScript.md) | A dynamic script with default registration name |
| interface  | [IScriptBundleManager](Serenity.Web/IScriptBundleManager.md) | Abstraction for script bundling manager |
| interface  | [IScriptContent](Serenity.Web/IScriptContent.md) | Cached dynamic script content |
| interface  | [IScriptName](Serenity.Web/IScriptName.md) | Provides access to the registration name for a dynamic script |
| class  | [LocalTextPackages](Serenity.Web/LocalTextPackages.md) | Corresponds to LocalTextPackages section of the appsettings.json file |
| class  | [LocalTextScript](Serenity.Web/LocalTextScript.md) | Local text dynamic script |
| abstract class  | [LookupScript](Serenity.Web/LookupScript.md) | Dynamic script type for lookup scripts |
| class  | [LookupScriptRegistration](Serenity.Web/LookupScriptRegistration.md) | Contains helper methods for lookup script registration |
| class  | [NodeScriptRunner](Serenity.Web/NodeScriptRunner.md) | Executes the `script` entries defined in a `package.json` file, capturing any output written to stdio. |
| class  | [PageAuthorizeAttribute](Serenity.Web/PageAuthorizeAttribute.md) | Authorizes access to a controller action. Optionally checks the permission provided as the first argument. Use special permission key "?" to check for logged-in users, and "*" to allow anyone including anonymous access. |
| abstract class  | [PropertyItemsScript](Serenity.Web/PropertyItemsScript.md) | Abstract base class for [`ColumnsScript`](Serenity.Web/ColumnsScript.md) and [`FormScript`](Serenity.Web/FormScript.md) |
| static class  | [RecaptchaValidation](Serenity.Web/RecaptchaValidation.md) | Recaptcha validation extensions. This was written for a very old version of Google Recaptcha and might not be working properly. |
| class  | [RegisteredScripts](Serenity.Web/RegisteredScripts.md) | A dynamic script type for registered scripts |
| class  | [RowLookupScript&lt;TRow&gt;](Serenity.Web/RowLookupScript-1.md) | Generic lookup script type for rows |
| class  | [ScriptBundleManager](Serenity.Web/ScriptBundleManager.md) | Default implementation for [`IScriptBundleManager`](Serenity.Web/IScriptBundleManager.md) |
| class  | [ScriptBundlingOptions](Serenity.Web/ScriptBundlingOptions.md) | Options for script bundling |
| class  | [ScriptContent](Serenity.Web/ScriptContent.md) | Default implementation for [`IScriptContent`](Serenity.Web/IScriptContent.md) |
| static class  | [TemplateHelper](Serenity.Web/TemplateHelper.md) | Helper methods for CSHTML templating |
| class  | [TemplateScript](Serenity.Web/TemplateScript.md) | Dynamic script type for HTML templates |
| class  | [TemplateScriptRegistrar](Serenity.Web/TemplateScriptRegistrar.md) | Registrar for HTML templates (obsolete, please avoid such templates and specify templates directly in the Widget's getTemplate() method |
| static class  | [UploadServiceCollectionExtensions](Serenity.Web/UploadServiceCollectionExtensions.md) | DI extension methods related to upload services |
| static class  | [VirtualPathUtility](Serenity.Web/VirtualPathUtility.md) | Extension methods providing partial compatibility with legacy VirtualPathUtility. |

## Serenity.Web.Middleware namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DynamicScriptMiddleware](Serenity.Web.Middleware/DynamicScriptMiddleware.md) | Dynamic script middleware that handles "/DynJS.axd/" and "/DynamicData/" paths. |

## Serenity.Web.Providers namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [SiteMembershipProvider](Serenity.Web.Providers/SiteMembershipProvider.md) | Used to be a membership provider but now only contains a SHA512 helper |

## SerenityIs.Administration namespace

| signature | name | description |
| --: | --- | --- |
| class  | [LocalTextDataScript](SerenityIs.Administration/LocalTextDataScript.md) | Local text data script to access local texts from an external app like mobile |