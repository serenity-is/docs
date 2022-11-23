# Serenity.Net.Services assembly

## global namespace

| signature | name | description |
| --: | --- | --- |
| interface  | [IImageProcessor](global/IImageProcessor.md) |  |

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| enum  | [CaptureOperationType](Serenity/CaptureOperationType.md) |  |
| static class  | [PrefixHelper](Serenity/PrefixHelper.md) |  |

## Serenity.ComponentModel namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AddBehaviorAttribute](Serenity.ComponentModel/AddBehaviorAttribute.md) | Attaches an explicit behavior |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CaptureLogAttribute](Serenity.Data/CaptureLogAttribute.md) |  |
| class  | [CriteriaFieldExpressionReplacer](Serenity.Data/CriteriaFieldExpressionReplacer.md) |  |
| static class  | [DisplayOrderHelper](Serenity.Data/DisplayOrderHelper.md) | A static class with helper functions to update display orders of all records or groups of records in a table. |
| interface  | [ICaptureLogHandler](Serenity.Data/ICaptureLogHandler.md) |  |
| interface  | [ICaptureLogRow](Serenity.Data/ICaptureLogRow.md) |  |
| interface  | [ILocalizationRow](Serenity.Data/ILocalizationRow.md) |  |
| class  | [LocalizationRowAttribute](Serenity.Data/LocalizationRowAttribute.md) |  |
| static class  | [ServiceRequestExtensions](Serenity.Data/ServiceRequestExtensions.md) | Contains static extension methods for DbField and Meta objects. |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ServiceCollectionExtensions.md) |  |

## Serenity.IO namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CommandLineTools](Serenity.IO/CommandLineTools.md) |  |

## Serenity.PropertyGrid namespace

| signature | name | description |
| --: | --- | --- |
| class  | [LocalizablePropertyProcessor](Serenity.PropertyGrid/LocalizablePropertyProcessor.md) |  |

## Serenity.Reporting namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [BaseCellDecorator](Serenity.Reporting/BaseCellDecorator.md) | Base class for cell decorators, implementing all [`ICellDecorator`](Serenity.Reporting/ICellDecorator.md) members. |
| abstract class  | [BaseReport](Serenity.Reporting/BaseReport.md) | Base class for reports that implement [`IReport`](Serenity.Reporting/IReport.md) and optionally [`IReportWithAdditionalData`](Serenity.Reporting/IReportWithAdditionalData.md) |
| class  | [CellDecoratorAttribute](Serenity.Reporting/CellDecoratorAttribute.md) | Attribute used to set the [`ICellDecorator`](Serenity.Reporting/ICellDecorator.md) type for a property. |
| class  | [EnumDecorator](Serenity.Reporting/EnumDecorator.md) | A decorator used to export enum name instead of the enum integer value. |
| class  | [GenerateCsvRequest](Serenity.Reporting/GenerateCsvRequest.md) | Request model for a CSV exporter. |
| class  | [GenerateExcelFileRequest](Serenity.Reporting/GenerateExcelFileRequest.md) | Request model for an Excel exporter. |
| interface  | [ICellDecorator](Serenity.Reporting/ICellDecorator.md) | Cell decorator interface mainly used for Excel export styling. |
| interface  | [ICustomFileName](Serenity.Reporting/ICustomFileName.md) | Interface to customize the output file name, e.g. name of the XLSX or PDF file outputted by reports. By default, reports has output file name of format "{ReportKey}_yyyyMMdd_HHmmss.ext". |
| interface  | [ICustomizeHtmlToPdf](Serenity.Reporting/ICustomizeHtmlToPdf.md) |  |
| interface  | [IDataOnlyReport](Serenity.Reporting/IDataOnlyReport.md) | Interface for reports that only contain data, e.g. no design. These are usually Excel/CSV etc. export type of reports. |
| interface  | [IDataReportExcelRenderer](Serenity.Reporting/IDataReportExcelRenderer.md) | Excel exporter interface for data only reports. This is usually implemented by EPPlus based exporter. The interface abstracts that dependency. |
| interface  | [IExcelExporter](Serenity.Reporting/IExcelExporter.md) |  |
| interface  | [IExternalReport](Serenity.Reporting/IExternalReport.md) | This interface marks a report class as a report that should open an external URL, e.g. an SSRS report url, or any arbitrary site The URL should be returned from GetData() method of report class. |
| interface  | [IHtmlToPdfOptions](Serenity.Reporting/IHtmlToPdfOptions.md) | Set of options for HTML to PDF converter (WKHTMLToPdf) |
| interface  | [IReport](Serenity.Reporting/IReport.md) | The basic interface for all reports |
| interface  | [IReportRegistry](Serenity.Reporting/IReportRegistry.md) | Abstraction for the registry which holds and allows querying list of available reports by their keys and categories. |
| interface  | [IReportWithAdditionalData](Serenity.Reporting/IReportWithAdditionalData.md) | The interface for reports that return some type of additional data. For example, the system settings. This can be considered as additional datasets. |
| class  | [ReportAttribute](Serenity.Reporting/ReportAttribute.md) | Marks a class as Report |
| class  | [ReportColumn](Serenity.Reporting/ReportColumn.md) | Information about a report column |
| static class  | [ReportColumnConverter](Serenity.Reporting/ReportColumnConverter.md) | Contains methods to extract ReportColumns from other types. |
| class  | [ReportDesignAttribute](Serenity.Reporting/ReportDesignAttribute.md) | The attribute used to determine the location of the report design which is usually a CSHTML file. |
| class  | [ReportRegistry](Serenity.Reporting/ReportRegistry.md) | Default report registry implementation |
| class  | [ReportRetrieveRequest](Serenity.Reporting/ReportRetrieveRequest.md) | Request model to retrieve a report by its key. This only returns the metadata, e.g. parameters of report etc. |
| class  | [ReportRetrieveResponse](Serenity.Reporting/ReportRetrieveResponse.md) | Response model for a report retrieve request. |
| class  | [TabularDataReport](Serenity.Reporting/TabularDataReport.md) | An implementation of a data only report which is used mainly for Excel export. |
| class  | [UseChromeHtmlToPdfAttribute](Serenity.Reporting/UseChromeHtmlToPdfAttribute.md) | Marks a report so that it should use Chrome instead of WKHTML |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [BaseDeleteBehavior](Serenity.Services/BaseDeleteBehavior.md) | Base class for types implementing [`IDeleteBehavior`](Serenity.Services/IDeleteBehavior.md) |
| abstract class  | [BaseListBehavior](Serenity.Services/BaseListBehavior.md) |  |
| class  | [BaseRepository](Serenity.Services/BaseRepository.md) |  |
| abstract class  | [BaseRequestHandler](Serenity.Services/BaseRequestHandler.md) | An abstract class that can be used as base for request handlers that accept a [`IRequestContext`](Serenity.Services/IRequestContext.md) instance. |
| abstract class  | [BaseRetrieveBehavior](Serenity.Services/BaseRetrieveBehavior.md) |  |
| abstract class  | [BaseSaveBehavior](Serenity.Services/BaseSaveBehavior.md) |  |
| abstract class  | [BaseSaveDeleteBehavior](Serenity.Services/BaseSaveDeleteBehavior.md) | Base class for behaviors implementing save and delete behavior interfaces |
| abstract class  | [BaseUndeleteBehavior](Serenity.Services/BaseUndeleteBehavior.md) | Base class for types implementing [`IUndeleteBehavior`](Serenity.Services/IUndeleteBehavior.md) |
| static class  | [BehaviorProviderExtensions](Serenity.Services/BehaviorProviderExtensions.md) | Extension methods for behavior provider |
| class  | [CaptureLogBehavior](Serenity.Services/CaptureLogBehavior.md) | Capture log behavior |
| class  | [CaptureLogConsts](Serenity.Services/CaptureLogConsts.md) |  |
| static class  | [DataValidation](Serenity.Services/DataValidation.md) |  |
| class  | [DefaultBehaviorFactory](Serenity.Services/DefaultBehaviorFactory.md) | Default [`IBehaviorFactory`](Serenity.Services/IBehaviorFactory.md) implementation |
| class  | [DefaultBehaviorProvider](Serenity.Services/DefaultBehaviorProvider.md) | Default implementation for [`IBehaviorProvider`](Serenity.Services/IBehaviorProvider.md) |
| class  | [DefaultHandlerActivator](Serenity.Services/DefaultHandlerActivator.md) |  |
| class  | [DefaultHandlerAttribute](Serenity.Services/DefaultHandlerAttribute.md) | Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler. |
| class  | [DefaultHandlerFactory](Serenity.Services/DefaultHandlerFactory.md) |  |
| static class  | [DefaultHandlerFactoryExtensions](Serenity.Services/DefaultHandlerFactoryExtensions.md) |  |
| class  | [DefaultHandlerRegistry](Serenity.Services/DefaultHandlerRegistry.md) |  |
| class  | [DefaultImplicitBehaviorRegistry](Serenity.Services/DefaultImplicitBehaviorRegistry.md) | Default implementation for the [`IImplicitBehaviorRegistry`](Serenity.Services/IImplicitBehaviorRegistry.md) |
| class  | [DefaultRequestContext](Serenity.Services/DefaultRequestContext.md) |  |
| class  | [DeleteRequest](Serenity.Services/DeleteRequest.md) | Service object for delete requests |
| class  | [DeleteRequestHandler&lt;TRow&gt;](Serenity.Services/DeleteRequestHandler-1.md) | Base generic class for delete request handlers that use [`DeleteRequest`](Serenity.Services/DeleteRequest.md) as the request type, and [`DeleteResponse`](Serenity.Services/DeleteResponse.md) as the response type. |
| class  | [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/DeleteRequestHandler-3.md) | Generic base class for delete request handlers |
| class  | [DeleteResponse](Serenity.Services/DeleteResponse.md) | The response object returned from a delete service |
| class  | [DisplayOrderFilterHelper](Serenity.Services/DisplayOrderFilterHelper.md) |  |
| class  | [GenericHandlerTypeAttribute](Serenity.Services/GenericHandlerTypeAttribute.md) |  |
| interface  | [IBehaviorFactory](Serenity.Services/IBehaviorFactory.md) | Behavior factory abstraction |
| interface  | [IBehaviorProvider](Serenity.Services/IBehaviorProvider.md) | Interface abstraction for behavior provider which resolves list of behavior instances of a specified type, like [`ISaveBehavior`](Serenity.Services/ISaveBehavior.md) etc. |
| interface  | [ICreateHandler&lt;TRow&gt;](Serenity.Services/ICreateHandler-1.md) |  |
| interface  | [ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ICreateHandler-3.md) |  |
| interface  | [IDefaultHandlerFactory](Serenity.Services/IDefaultHandlerFactory.md) |  |
| interface  | [IDefaultHandlerRegistry](Serenity.Services/IDefaultHandlerRegistry.md) |  |
| interface  | [IDeleteBehavior](Serenity.Services/IDeleteBehavior.md) | A delete behavior that can be used as a mixin within a DeleteRequestHandler lifecycle |
| interface  | [IDeleteExceptionBehavior](Serenity.Services/IDeleteExceptionBehavior.md) | This is an extension for delete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [IDeleteHandler&lt;TRow&gt;](Serenity.Services/IDeleteHandler-1.md) | Interface for delete request handlers that use [`DeleteRequest`](Serenity.Services/DeleteRequest.md) as request, and [`DeleteResponse`](Serenity.Services/DeleteResponse.md) as response types. |
| interface  | [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/IDeleteHandler-3.md) | Interface for delete request handlers with custom delete request / response types. |
| interface  | [IDeleteRequestHandler](Serenity.Services/IDeleteRequestHandler.md) | Represents a DeleteRequestHandler. Is used with DeleteBehavior objects. |
| interface  | [IDeleteRequestProcessor](Serenity.Services/IDeleteRequestProcessor.md) | Abstraction for delete request handlers with a Process method. |
| interface  | [IFieldBehavior](Serenity.Services/IFieldBehavior.md) | Represents a request handler behavior that is targeted to a field. |
| interface  | [IHandlerActivator](Serenity.Services/IHandlerActivator.md) |  |
| interface  | [IImplicitBehavior](Serenity.Services/IImplicitBehavior.md) | An implicit behavior is a request handler behavior (save/list/retrieve/delete etc.) which can be implicitly activated for a row type without explicitly attached to that row type. |
| interface  | [IImplicitBehaviorRegistry](Serenity.Services/IImplicitBehaviorRegistry.md) | An interface to query list of implicit behaviors registered through the dependency resolver. Implicit behaviors are automatically activated behaviors by querying via their ActivateFor method. See [`IImplicitBehavior`](Serenity.Services/IImplicitBehavior.md) |
| interface  | [IIncludeExcludeColumns](Serenity.Services/IIncludeExcludeColumns.md) | Abstraction for service objects containing include / exclude column sets. See [`ListRequest`](Serenity.Services/ListRequest.md) and [`RetrieveRequest`](Serenity.Services/RetrieveRequest.md). |
| interface  | [IListBehavior](Serenity.Services/IListBehavior.md) | A list behavior that can be used as a mixin within a ListRequestHandler lifecycle |
| interface  | [IListHandler&lt;TRow&gt;](Serenity.Services/IListHandler-1.md) |  |
| interface  | [IListHandler&lt;TRow,TListRequest&gt;](Serenity.Services/IListHandler-2.md) |  |
| interface  | [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/IListHandler-3.md) |  |
| interface  | [IListRequestHandler](Serenity.Services/IListRequestHandler.md) | Represents a ListRequestHandler. Is used with ListBehavior objects. |
| interface  | [IListRequestProcessor](Serenity.Services/IListRequestProcessor.md) |  |
| interface  | [IListResponse](Serenity.Services/IListResponse.md) | The interface for list response. This is used to easily access list response members as the [`ListResponse`](Serenity.Services/ListResponse-1.md) class itself is generic. |
| interface  | [IRequestContext](Serenity.Services/IRequestContext.md) | A service request context abstraction containing services that are mostly used by all service handler types. This is a type similar to the HttpContext but is specialized for service handlers. |
| interface  | [IRequestHandler&lt;TRow&gt;](Serenity.Services/IRequestHandler-1.md) | Marker interface for request handlers that operate on a specific entity type. |
| interface  | [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](Serenity.Services/IRequestHandler-3.md) | Marker interface for request handlers that operate on a specific entity type, request type and a response type. |
| interface  | [IRequestHandler](Serenity.Services/IRequestHandler.md) | Marker interface for standard and custom request handlers |
| interface  | [IRequestType&lt;TRequestType&gt;](Serenity.Services/IRequestType-1.md) |  |
| interface  | [IResponseType&lt;TResponseType&gt;](Serenity.Services/IResponseType-1.md) |  |
| interface  | [IRetrieveBehavior](Serenity.Services/IRetrieveBehavior.md) | A retrieve behavior that can be used as a mixin within a RetrieveRequestHandler lifecycle |
| interface  | [IRetrieveHandler&lt;TRow&gt;](Serenity.Services/IRetrieveHandler-1.md) |  |
| interface  | [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/IRetrieveHandler-3.md) |  |
| interface  | [IRetrieveRequestHandler](Serenity.Services/IRetrieveRequestHandler.md) | Represents a RetrieveRequestHandler. Is used with RetrieveBehavior objects. |
| interface  | [IRetrieveRequestProcessor](Serenity.Services/IRetrieveRequestProcessor.md) |  |
| interface  | [IRetrieveResponse](Serenity.Services/IRetrieveResponse.md) | Interface for a [`RetrieveResponse`](Serenity.Services/RetrieveResponse-1.md). As the RetrieveResponse itself is generic, this allows easier access to its members. |
| interface  | [ISaveBehavior](Serenity.Services/ISaveBehavior.md) | A save behavior that can be used as a mixin within a SaveRequestHandler lifecycle |
| interface  | [ISaveExceptionBehavior](Serenity.Services/ISaveExceptionBehavior.md) | This is an extension for save behaviors that should be called for exceptions that occur during save. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [ISaveHandler&lt;TRow&gt;](Serenity.Services/ISaveHandler-1.md) |  |
| interface  | [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ISaveHandler-3.md) |  |
| interface  | [ISaveRequest](Serenity.Services/ISaveRequest.md) | Interface for a [`SaveRequest`](Serenity.Services/SaveRequest-1.md). As the SaveRequest itself is generic, this allows easier access to its members. |
| interface  | [ISaveRequestHandler](Serenity.Services/ISaveRequestHandler.md) | Represents a SaveRequestHandler. Is used with SaveBehavior objects. |
| interface  | [ISaveRequestProcessor](Serenity.Services/ISaveRequestProcessor.md) |  |
| interface  | [IUndeleteBehavior](Serenity.Services/IUndeleteBehavior.md) | A undelete behavior that can be used as a mixin within a UndeleteRequestHandler lifecycle |
| interface  | [IUndeleteExceptionBehavior](Serenity.Services/IUndeleteExceptionBehavior.md) | This is an extension for undelete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [IUndeleteHandler&lt;TRow&gt;](Serenity.Services/IUndeleteHandler-1.md) | Interface for undelete request handlers that use [`UndeleteRequest`](Serenity.Services/UndeleteRequest.md) as request, and [`UndeleteResponse`](Serenity.Services/UndeleteResponse.md) as response types. |
| interface  | [IUndeleteHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](Serenity.Services/IUndeleteHandler-3.md) | Interface for undelete request handlers with custom undelete request / response types. |
| interface  | [IUndeleteRequestHandler](Serenity.Services/IUndeleteRequestHandler.md) | Represents a UndeleteRequestHandler. Is used with UndeleteBehavior objects. |
| interface  | [IUndeleteRequestProcessor](Serenity.Services/IUndeleteRequestProcessor.md) | Abstraction for undelete request handlers with a Process method. |
| interface  | [IUpdateHandler&lt;TRow&gt;](Serenity.Services/IUpdateHandler-1.md) |  |
| interface  | [IUpdateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/IUpdateHandler-3.md) |  |
| class  | [JsonServiceClient](Serenity.Services/JsonServiceClient.md) | A JSON service client implementation |
| class  | [JsonSortByConverter](Serenity.Services/JsonSortByConverter.md) | Serialize/deserialize a SortBy object as string |
| class  | [LinkingSetRelationBehavior](Serenity.Services/LinkingSetRelationBehavior.md) |  |
| class  | [ListRequest](Serenity.Services/ListRequest.md) | The request model for a List service. |
| class  | [ListRequestHandler&lt;TRow&gt;](Serenity.Services/ListRequestHandler-1.md) |  |
| class  | [ListRequestHandler&lt;TRow,TListRequest&gt;](Serenity.Services/ListRequestHandler-2.md) |  |
| class  | [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/ListRequestHandler-3.md) |  |
| class  | [ListResponse&lt;T&gt;](Serenity.Services/ListResponse-1.md) | The response model for a list service. |
| class  | [LocalizationBehavior](Serenity.Services/LocalizationBehavior.md) |  |
| class  | [MasterDetailRelationBehavior](Serenity.Services/MasterDetailRelationBehavior.md) |  |
| static class  | [RequestHandlerExtensions](Serenity.Services/RequestHandlerExtensions.md) |  |
| enum  | [RetrieveColumnSelection](Serenity.Services/RetrieveColumnSelection.md) | The group of columns to retrieve |
| class  | [RetrieveLocalizationRequest](Serenity.Services/RetrieveLocalizationRequest.md) | A retrieve request with localization. Don't use. Provided only for compatibility. |
| class  | [RetrieveLocalizationResponse&lt;TEntity&gt;](Serenity.Services/RetrieveLocalizationResponse-1.md) | The service model for a localization retrieve response |
| class  | [RetrieveRequest](Serenity.Services/RetrieveRequest.md) | The request model for a Retrieve service |
| class  | [RetrieveRequestHandler&lt;TRow&gt;](Serenity.Services/RetrieveRequestHandler-1.md) |  |
| class  | [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/RetrieveRequestHandler-3.md) |  |
| class  | [RetrieveResponse&lt;T&gt;](Serenity.Services/RetrieveResponse-1.md) | The service response model for a Retrieve service |
| class  | [SaveRequest&lt;TEntity&gt;](Serenity.Services/SaveRequest-1.md) | The service model for a Save (Create / Update) service. |
| class  | [SaveRequestHandler&lt;TRow&gt;](Serenity.Services/SaveRequestHandler-1.md) |  |
| class  | [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/SaveRequestHandler-3.md) |  |
| enum  | [SaveRequestType](Serenity.Services/SaveRequestType.md) |  |
| class  | [SaveResponse](Serenity.Services/SaveResponse.md) | The response model for a Save service |
| class  | [SaveWithLocalizationRequest&lt;TEntity&gt;](Serenity.Services/SaveWithLocalizationRequest-1.md) | A save request with localization. Don't use. Provided only for compatibility. |
| class  | [ServiceError](Serenity.Services/ServiceError.md) | The error object model returned from a service |
| static class  | [ServiceHelper](Serenity.Services/ServiceHelper.md) |  |
| static class  | [ServiceQueryHelper](Serenity.Services/ServiceQueryHelper.md) |  |
| class  | [ServiceRequest](Serenity.Services/ServiceRequest.md) | The base request object model for all service requests. Your custom request objects should all derive from this type. |
| class  | [ServiceResponse](Serenity.Services/ServiceResponse.md) | The base service response object model for all service response types. Your custom response objects should derive from this class. |
| class  | [SortBy](Serenity.Services/SortBy.md) | A sort column. In JSON this is deserialized from strings in the format "field" or "field desc" |
| static class  | [TreeOrdering](Serenity.Services/TreeOrdering.md) |  |
| static class  | [TwoLevelCacheInvalidationExtensions](Serenity.Services/TwoLevelCacheInvalidationExtensions.md) |  |
| class  | [UndeleteRequest](Serenity.Services/UndeleteRequest.md) | The request model for an undelete service |
| class  | [UndeleteRequestHandler&lt;TRow&gt;](Serenity.Services/UndeleteRequestHandler-1.md) | Base generic class for undelete request handlers that use [`UndeleteRequest`](Serenity.Services/UndeleteRequest.md) as the request type, and [`UndeleteResponse`](Serenity.Services/UndeleteResponse.md) as the response type. |
| class  | [UndeleteRequestHandler&lt;TRow,TUndeleteRequest,TUndeleteResponse&gt;](Serenity.Services/UndeleteRequestHandler-3.md) | Generic base class for undelete request handlers |
| class  | [UndeleteResponse](Serenity.Services/UndeleteResponse.md) | The response model for an undelete service |
| class  | [UniqueConstraintSaveBehavior](Serenity.Services/UniqueConstraintSaveBehavior.md) |  |
| class  | [UniqueFieldSaveBehavior](Serenity.Services/UniqueFieldSaveBehavior.md) |  |
| class  | [UpdatableExtensionBehavior](Serenity.Services/UpdatableExtensionBehavior.md) |  |
| class  | [UpdateInsertLogBehavior](Serenity.Services/UpdateInsertLogBehavior.md) |  |
| class  | [UploadedFile](Serenity.Services/UploadedFile.md) |  |
| class  | [ValidateParentBehavior](Serenity.Services/ValidateParentBehavior.md) |  |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CombinedUploadStorage](Serenity.Web/CombinedUploadStorage.md) |  |
| class  | [CopyTemporaryFileOptions](Serenity.Web/CopyTemporaryFileOptions.md) |  |
| class  | [CopyTemporaryFileResult](Serenity.Web/CopyTemporaryFileResult.md) |  |
| class  | [DefaultImageProcessor](Serenity.Web/DefaultImageProcessor.md) |  |
| class  | [DefaultUploadProcessor](Serenity.Web/DefaultUploadProcessor.md) |  |
| class  | [DefaultUploadValidator](Serenity.Web/DefaultUploadValidator.md) |  |
| class  | [DiskUploadStorage](Serenity.Web/DiskUploadStorage.md) |  |
| class  | [DiskUploadStorageOptions](Serenity.Web/DiskUploadStorageOptions.md) |  |
| static class  | [FileMetadataKeys](Serenity.Web/FileMetadataKeys.md) |  |
| class  | [FilesToDelete](Serenity.Web/FilesToDelete.md) |  |
| static class  | [FilesToDeleteExtensions](Serenity.Web/FilesToDeleteExtensions.md) |  |
| class  | [FormatFilenameOptions](Serenity.Web/FormatFilenameOptions.md) |  |
| interface  | [IDiskUploadFileSystem](Serenity.Web/IDiskUploadFileSystem.md) |  |
| interface  | [IFilesToDelete](Serenity.Web/IFilesToDelete.md) |  |
| class  | [ImageChecker](Serenity.Web/ImageChecker.md) | checks stream data if valid image file and validate required conditions. |
| enum  | [ImageCheckResult](Serenity.Web/ImageCheckResult.md) | [`ImageChecker`](Serenity.Web/ImageChecker.md)'s result codes. |
| class  | [ImageEncoderParams](Serenity.Web/ImageEncoderParams.md) |  |
| class  | [ImageFormatInfo](Serenity.Web/ImageFormatInfo.md) |  |
| interface  | [IUploadProcessor](Serenity.Web/IUploadProcessor.md) |  |
| interface  | [IUploadStorage](Serenity.Web/IUploadStorage.md) |  |
| interface  | [IUploadValidator](Serenity.Web/IUploadValidator.md) |  |
| static class  | [KnownMimeTypes](Serenity.Web/KnownMimeTypes.md) |  |
| class  | [PhysicalDiskUploadFileSystem](Serenity.Web/PhysicalDiskUploadFileSystem.md) |  |
| class  | [ProcessedUploadInfo](Serenity.Web/ProcessedUploadInfo.md) |  |
| class  | [TempUploadStorage](Serenity.Web/TempUploadStorage.md) |  |
| static class  | [ThumbnailGenerator](Serenity.Web/ThumbnailGenerator.md) | Static class that contains thumbnail generator methods |
| static class  | [UploadFormatting](Serenity.Web/UploadFormatting.md) |  |
| static class  | [UploadPathHelper](Serenity.Web/UploadPathHelper.md) |  |
| class  | [UploadSettings](Serenity.Web/UploadSettings.md) |  |
| static class  | [UploadStorageExtensions](Serenity.Web/UploadStorageExtensions.md) |  |