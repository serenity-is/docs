# Serenity.Net.Web assembly

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ArgumentExceptions](Serenity/ArgumentExceptions.md) | This class contains methods for creating ArgumentException and subclasses while avoiding analyzer warnings regarding mismatched argument names. |
| static class  | [DataProtectorBinaryTokenExtensions](Serenity/DataProtectorBinaryTokenExtensions.md) | Extension methods for data protector to support tokens created via BinaryWriter |
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
| static class  | [ApplicationPartsServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ApplicationPartsServiceCollectionExtensions.md) | DI extension methods related to application part and type source |
| static class  | [DynamicScriptServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/DynamicScriptServiceCollectionExtensions.md) | Contains DI extension methods related to dynamic script services |
| static class  | [EsBuildMinifierExtensions](Serenity.Extensions.DependencyInjection/EsBuildMinifierExtensions.md) | Extensions for adding EsBuild minifiers to IServiceCollection. |
| static class  | [NodeScriptRunnerExtensions](Serenity.Extensions.DependencyInjection/NodeScriptRunnerExtensions.md) | Contains extensions for [`NodeScriptRunner`](Serenity.Web/NodeScriptRunner.md) |
| static class  | [ServiceCollectionConfigureExtensions](Serenity.Extensions.DependencyInjection/ServiceCollectionConfigureExtensions.md) | DI extension methods related to configuration and options |
| static class  | [ServiceEndpointServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ServiceEndpointServiceCollectionExtensions.md) | DI extension methods related to service endpoints |
| static class  | [UploadServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/UploadServiceCollectionExtensions.md) | DI extension methods related to upload services |

## Serenity.Navigation namespace

| signature | name | description |
| --: | --- | --- |
| class  | [NavigationHelper](Serenity.Navigation/NavigationHelper.md) | Contains helper methods for navigation models and items |
| class  | [NavigationLinkAttribute](Serenity.Navigation/NavigationLinkAttribute.md) | A navigation item with a link |

## Serenity.Reporting namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DefaultReportFactory](Serenity.Reporting/DefaultReportFactory.md) | Default implementation for IReportFactory |
| class  | [DefaultReportRenderer](Serenity.Reporting/DefaultReportRenderer.md) | Default implementation for IReportRenderer |
| class  | [WKHtmlToPdf](Serenity.Reporting/WKHtmlToPdf.md) | HTML to PDF converter class using WKHTMLToPdf |
| class  | [WKHtmlToPdfConverter](Serenity.Reporting/WKHtmlToPdfConverter.md) | Implementation for IWKHtmlToPdfConverter |
| class  | [WKHtmlToPdfSettings](Serenity.Reporting/WKHtmlToPdfSettings.md) | Set of WKHTMLToPdf settings |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AntiforgeryCookieResultFilterAttribute](Serenity.Services/AntiforgeryCookieResultFilterAttribute.md) | Append the anti forgery token as CSRF-TOKEN cookie to the response, so that AJAX calls can read it client side and send as a header. |
| class  | [AuthorizeCreateAttribute](Serenity.Services/AuthorizeCreateAttribute.md) | Authorizes access to a service method by reading one of InsertPermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| class  | [AuthorizeDeleteAttribute](Serenity.Services/AuthorizeDeleteAttribute.md) | Authorizes access to a service method by reading one of DeletePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| class  | [AuthorizeListAttribute](Serenity.Services/AuthorizeListAttribute.md) | Authorizes access to a service method by reading ReadPermissionAttribute. It also allows lookup mode access (as OrPermission) if the source type has ServiceLookupPermissionAttribute |
| class  | [AuthorizeRetrieveAttribute](Serenity.Services/AuthorizeRetrieveAttribute.md) | Authorizes retrieve access to a service method by reading ReadPermissionAttribute. ServiceLookupPermissionAttribute |
| class  | [AuthorizeUpdateAttribute](Serenity.Services/AuthorizeUpdateAttribute.md) | Authorizes access to a service method by reading one of UpdatePermissionAttribute, ModifyPermissionAttribute or ReadPermissionAttribute from the target type, which is usually a Row class. |
| static class  | [EndpointExtensions](Serenity.Services/EndpointExtensions.md) | Contains some extensions for service endpoints |
| class  | [FileUploadBehavior](Serenity.Services/FileUploadBehavior.md) | Behavior class that handles FileUploadEditorAttribute and ImageUploadEditorAttribute. |
| class  | [HandleControllerExceptionAttribute](Serenity.Services/HandleControllerExceptionAttribute.md) | An exception filter attribute to handle controller exceptions and return as view. |
| class  | [HandleServiceExceptionAttribute](Serenity.Services/HandleServiceExceptionAttribute.md) | An exception filter attribute to handle service exceptions and return them to ServiceResponse objects |
| class  | [JsonRequestAttribute](Serenity.Services/JsonRequestAttribute.md) | An action filter for methods that accept JSON content via their "request" arguments. |
| class  | [Result&lt;TResponse&gt;](Serenity.Services/Result-1.md) | An action result type containing a object |
| class  | [ResultWithStatus&lt;TResponse&gt;](Serenity.Services/ResultWithStatus-1.md) | An action result type containing a object with status code |
| class  | [ServiceAuthorizeAttribute](Serenity.Services/ServiceAuthorizeAttribute.md) | Authorizes access to a service action. Optionally checks the permission provided as the first argument. Use special permission key "?" to check for logged-in users, and "*" to allow anyone including anonymous access. This returns a service error instead of raising an exception like PageAuthorize attribute. |
| abstract class  | [ServiceEndpoint](Serenity.Services/ServiceEndpoint.md) | Subclass of controller for service endpoints |
| class  | [ServiceEndpointActionModelConvention](Serenity.Services/ServiceEndpointActionModelConvention.md) | Action model convention for [`ServiceEndpoint`](Serenity.Services/ServiceEndpoint.md) actions |
| class  | [ServiceEndpointApplicationModelProvider](Serenity.Services/ServiceEndpointApplicationModelProvider.md) | Applies action model conventions for [`ServiceEndpoint`](Serenity.Services/ServiceEndpoint.md) controllers |
| class  | [ServiceEndpointBindingMetadataProvider](Serenity.Services/ServiceEndpointBindingMetadataProvider.md) | An IBindingMetadataProvider which configures `ModelMetadata.IsBindingAllowed` to `false` for IDbConnection and IUnitOfWork types. |
| class  | [ServiceEndpointModelBinderProvider](Serenity.Services/ServiceEndpointModelBinderProvider.md) | Provides model binding for service endpoints |
| class  | [ServiceEndpointNullModelBinder](Serenity.Services/ServiceEndpointNullModelBinder.md) | Null model binder for interface arguments |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AntiforgeryFilterOptions](Serenity.Web/AntiforgeryFilterOptions.md) | Options for AutoValidateAntiforgeryIgnoreBearerFilter. |
| class  | [ApplicationPartsTypeSource](Serenity.Web/ApplicationPartsTypeSource.md) | Implementation for a type source that uses ApplicationPartManager to get assemblies. Note that it only includes assemblies that are marked with TypeSourceAssemblyAttribute which is automatically added to assemblies that reference Serenity.Net.Web NuGet package (or Serenity.Net.Web.targets). |
| class  | [AutoValidateAntiforgeryIgnoreBearerAttribute](Serenity.Web/AutoValidateAntiforgeryIgnoreBearerAttribute.md) | An attribute that causes validation of antiforgery tokens for all unsafe HTTP methods. An antiforgery token is required for HTTP methods other than GET, HEAD, OPTIONS, and TRACE, and when there is no cookie header and authorization is Bearer, e.g. JWT etc. |
| abstract class  | [BaseDynamicDataGenerator](Serenity.Web/BaseDynamicDataGenerator.md) | Base class for generating .json files under dynamic-data folder for script testing purposes |
| static class  | [CheckTreeEditorTexts](Serenity.Web/CheckTreeEditorTexts.md) |  |
| static class  | [ColumnPickerDialogTexts](Serenity.Web/ColumnPickerDialogTexts.md) |  |
| class  | [ColumnsScriptRegistration](Serenity.Web/ColumnsScriptRegistration.md) | Contains registration methods for ColumnsScript types |
| class  | [ContentHashCache](Serenity.Web/ContentHashCache.md) | Default [`IContentHashCache`](Serenity.Web/IContentHashCache.md) implementation |
| class  | [CssBundleManager](Serenity.Web/CssBundleManager.md) | Default implementation for [`ICssBundleManager`](Serenity.Web/ICssBundleManager.md) |
| class  | [CssBundlingOptions](Serenity.Web/CssBundlingOptions.md) | Options for css bundling |
| class  | [CssMinifyOptions](Serenity.Web/CssMinifyOptions.md) | Set of options for CSS minifying |
| class  | [CssMinifyResult](Serenity.Web/CssMinifyResult.md) | Result returned from a CSS minifier |
| static class  | [DataGridTexts](Serenity.Web/DataGridTexts.md) |  |
| class  | [DataScriptRegistration](Serenity.Web/DataScriptRegistration.md) | Contains helper methods for data script registration |
| static class  | [DateTimeEditorTexts](Serenity.Web/DateTimeEditorTexts.md) |  |
| class  | [DefaultFileWatcherFactory](Serenity.Web/DefaultFileWatcherFactory.md) | Default implementation for [`IFileWatcherFactory`](Serenity.Web/IFileWatcherFactory.md) |
| class  | [DefaultLocalTextInitializer](Serenity.Web/DefaultLocalTextInitializer.md) | Default local text initializer |
| class  | [DefaultUploadFileResponder](Serenity.Web/DefaultUploadFileResponder.md) | Default implementation for upload file responder |
| class  | [DefaultUploadStorage](Serenity.Web/DefaultUploadStorage.md) | Default IUploadStorage implementation which uses a combined upload storage of two DiskUploadStorage instances. |
| static class  | [DialogTexts](Serenity.Web/DialogTexts.md) |  |
| class  | [DistinctValuesRegistration](Serenity.Web/DistinctValuesRegistration.md) | Contains helper methods for distinct values scripts |
| class  | [DistinctValuesScript&lt;TRow&gt;](Serenity.Web/DistinctValuesScript-1.md) | A dynamic script type for distinct values of a field |
| class  | [DynamicScriptManager](Serenity.Web/DynamicScriptManager.md) | Default implementation for [`IDynamicScriptManager`](Serenity.Web/IDynamicScriptManager.md) |
| static class  | [EntityDialogTexts](Serenity.Web/EntityDialogTexts.md) |  |
| static class  | [EntityGridTexts](Serenity.Web/EntityGridTexts.md) |  |
| static class  | [ExcelContentResult](Serenity.Web/ExcelContentResult.md) | Excel content result helper methods |
| class  | [FeatureBarrierAttribute](Serenity.Web/FeatureBarrierAttribute.md) | An attribute that can be placed on MVC controllers, controller actions, or Razor pages to require all or any of a set of features to be enabled. Note that if no IFeatureToggles service is registered, the feature barrier will always pass. |
| class  | [FileWatcher](Serenity.Web/FileWatcher.md) | Default file watcher implementation for physical file system |
| static class  | [FilterPanelTexts](Serenity.Web/FilterPanelTexts.md) |  |
| class  | [FormScriptRegistration](Serenity.Web/FormScriptRegistration.md) | Contains registration methods for FormScript types |
| static class  | [FormValidationTexts](Serenity.Web/FormValidationTexts.md) |  |
| static class  | [HtmlContentEditorTexts](Serenity.Web/HtmlContentEditorTexts.md) |  |
| static class  | [HtmlCspExtensions](Serenity.Web/HtmlCspExtensions.md) | Contains CSP related extension methods for HTML helpers and HTTP contexts. |
| static class  | [HtmlImportMapExtensions](Serenity.Web/HtmlImportMapExtensions.md) | Contains import map related extension methods for HTML helpers and HTTP contexts. |
| static class  | [HtmlScriptExtensions](Serenity.Web/HtmlScriptExtensions.md) | Contains Serenity related helper methods that can be used in Razor CSHTML files |
| class  | [HttpContextItemsAccessor](Serenity.Web/HttpContextItemsAccessor.md) | Default implementation for IHttpContextItemsAccessor using IHttpContextAccessor and its Items property. |
| class  | [HttpContextUserAccessor](Serenity.Web/HttpContextUserAccessor.md) | Default implementation of IUserAccessor for HTTP context |
| static class  | [HttpRequestExtensions](Serenity.Web/HttpRequestExtensions.md) | Contains HTTP request related extensions |
| interface  | [ICacheSuffix](Serenity.Web/ICacheSuffix.md) | Abstraction to get cache suffix used while generating key for a cached dynamic script |
| interface  | [IContentHashCache](Serenity.Web/IContentHashCache.md) | An abstraction for content hash cache, which contains hashes of web servable files. |
| interface  | [ICssBundleManager](Serenity.Web/ICssBundleManager.md) | Abstraction for css bundling manager |
| interface  | [ICssMinifier](Serenity.Web/ICssMinifier.md) | Abstraction for Css minifier |
| interface  | [IDynamicScriptManager](Serenity.Web/IDynamicScriptManager.md) | Dynamic script manager abstraction |
| interface  | [IFileWatcher](Serenity.Web/IFileWatcher.md) | File system watcher abstraction |
| interface  | [IFileWatcherFactory](Serenity.Web/IFileWatcherFactory.md) | An abstract factory to create file system watchers |
| interface  | [IScriptBundleManager](Serenity.Web/IScriptBundleManager.md) | Abstraction for script bundling manager |
| interface  | [IScriptMinifier](Serenity.Web/IScriptMinifier.md) | Abstraction for script minifier |
| interface  | [IUploadFileResponder](Serenity.Web/IUploadFileResponder.md) | Abstraction for reading a file via /upload/path, e.g. the Read action in the FilePage |
| static class  | [KnownMimeTypes](Serenity.Web/KnownMimeTypes.md) | Contains set of known popular mime types |
| class  | [LocalTextDataScript](Serenity.Web/LocalTextDataScript.md) | Local text data script to access local texts from an external app like mobile |
| class  | [LocalTextScript](Serenity.Web/LocalTextScript.md) | Local text dynamic script |
| abstract class  | [LookupScript](Serenity.Web/LookupScript.md) | Dynamic script type for lookup scripts |
| class  | [LookupScriptRegistration](Serenity.Web/LookupScriptRegistration.md) | Contains helper methods for lookup script registration |
| class  | [NodeScriptRunner](Serenity.Web/NodeScriptRunner.md) | Executes the `script` entries defined in a `package.json` file, capturing any output written to stdio. |
| class  | [NuglifyMinifier](Serenity.Web/NuglifyMinifier.md) | Default implementation of IScriptMinifier and ICssMinifer interfaces with Nuglify library |
| class  | [PageAuthorizeAttribute](Serenity.Web/PageAuthorizeAttribute.md) | Authorizes access to a controller action. Optionally checks the permission provided as the first argument. Use special permission key "?" to check for logged-in users, and "*" to allow anyone including anonymous access. |
| static class  | [PagerTexts](Serenity.Web/PagerTexts.md) |  |
| static class  | [PropertyGridTexts](Serenity.Web/PropertyGridTexts.md) |  |
| static class  | [QuickSearchTexts](Serenity.Web/QuickSearchTexts.md) |  |
| class  | [RecaptchaPropertyProcessor](Serenity.Web/RecaptchaPropertyProcessor.md) | Property processor to pass recaptcha site key to client side |
| static class  | [RecaptchaValidation](Serenity.Web/RecaptchaValidation.md) | Recaptcha validation extensions. This was written for a very old version of Google Recaptcha and might not be working properly. |
| class  | [RegisteredScripts](Serenity.Web/RegisteredScripts.md) | A dynamic script type for registered scripts |
| class  | [RowLookupScript&lt;TRow&gt;](Serenity.Web/RowLookupScript-1.md) | Generic lookup script type for rows |
| class  | [ScriptBundleManager](Serenity.Web/ScriptBundleManager.md) | Default implementation for [`IScriptBundleManager`](Serenity.Web/IScriptBundleManager.md) |
| class  | [ScriptBundlingOptions](Serenity.Web/ScriptBundlingOptions.md) | Options for script bundling |
| class  | [ScriptContent](Serenity.Web/ScriptContent.md) | Default implementation for IScriptContent |
| class  | [ScriptMinifyOptions](Serenity.Web/ScriptMinifyOptions.md) | Set of options for script minifying |
| class  | [ScriptMinifyResult](Serenity.Web/ScriptMinifyResult.md) | Result returned from a script minifier |
| static class  | [SelectEditorTexts](Serenity.Web/SelectEditorTexts.md) |  |
| static class  | [TemplateHelper](Serenity.Web/TemplateHelper.md) | Helper methods for CSHTML templating |
| static class  | [VirtualPathUtility](Serenity.Web/VirtualPathUtility.md) | Extension methods providing partial compatibility with legacy VirtualPathUtility. |
| static class  | [WebTexts](Serenity.Web/WebTexts.md) |  |
| class  | [WebTypeSource](Serenity.Web/WebTypeSource.md) | Base type source for apps using Serenity.Web assembly and its reference chain |

## Serenity.Web.Middleware namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DynamicScriptMiddleware](Serenity.Web.Middleware/DynamicScriptMiddleware.md) | Dynamic script middleware that handles "/DynJS.axd/" and "/DynamicData/" paths. |

## Serenity.Web.Providers namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [SiteMembershipProvider](Serenity.Web.Providers/SiteMembershipProvider.md) | Used to be a membership provider but now only contains a SHA512 helper |