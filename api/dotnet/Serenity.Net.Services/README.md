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
| abstract class  | [BaseCellDecorator](Serenity.Reporting/BaseCellDecorator.md) |  |
| abstract class  | [BaseReport](Serenity.Reporting/BaseReport.md) |  |
| class  | [CellDecoratorAttribute](Serenity.Reporting/CellDecoratorAttribute.md) |  |
| class  | [EnumDecorator](Serenity.Reporting/EnumDecorator.md) |  |
| class  | [GenerateCsvRequest](Serenity.Reporting/GenerateCsvRequest.md) |  |
| class  | [GenerateExcelFileRequest](Serenity.Reporting/GenerateExcelFileRequest.md) |  |
| interface  | [ICellDecorator](Serenity.Reporting/ICellDecorator.md) |  |
| interface  | [ICustomFileName](Serenity.Reporting/ICustomFileName.md) |  |
| interface  | [ICustomizeHtmlToPdf](Serenity.Reporting/ICustomizeHtmlToPdf.md) |  |
| interface  | [IDataOnlyReport](Serenity.Reporting/IDataOnlyReport.md) |  |
| interface  | [IDataReportExcelRenderer](Serenity.Reporting/IDataReportExcelRenderer.md) |  |
| interface  | [IExcelExporter](Serenity.Reporting/IExcelExporter.md) |  |
| interface  | [IExternalReport](Serenity.Reporting/IExternalReport.md) | This interface marks a report class as a report that should open an external URL, e.g. an SSRS report url, or any arbitrary site The URL should be returned from GetData() method of report class. |
| interface  | [IHtmlToPdfOptions](Serenity.Reporting/IHtmlToPdfOptions.md) |  |
| interface  | [IReport](Serenity.Reporting/IReport.md) |  |
| interface  | [IReportRegistry](Serenity.Reporting/IReportRegistry.md) |  |
| interface  | [IReportWithAdditionalData](Serenity.Reporting/IReportWithAdditionalData.md) |  |
| class  | [ReportAttribute](Serenity.Reporting/ReportAttribute.md) |  |
| class  | [ReportColumn](Serenity.Reporting/ReportColumn.md) |  |
| static class  | [ReportColumnConverter](Serenity.Reporting/ReportColumnConverter.md) |  |
| class  | [ReportDesignAttribute](Serenity.Reporting/ReportDesignAttribute.md) |  |
| class  | [ReportRegistry](Serenity.Reporting/ReportRegistry.md) |  |
| class  | [ReportRetrieveRequest](Serenity.Reporting/ReportRetrieveRequest.md) |  |
| class  | [ReportRetrieveResponse](Serenity.Reporting/ReportRetrieveResponse.md) |  |
| class  | [TabularDataReport](Serenity.Reporting/TabularDataReport.md) |  |
| class  | [UseChromeHtmlToPdfAttribute](Serenity.Reporting/UseChromeHtmlToPdfAttribute.md) |  |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [BaseDeleteBehavior](Serenity.Services/BaseDeleteBehavior.md) |  |
| abstract class  | [BaseListBehavior](Serenity.Services/BaseListBehavior.md) |  |
| class  | [BaseRepository](Serenity.Services/BaseRepository.md) |  |
| abstract class  | [BaseRequestHandler](Serenity.Services/BaseRequestHandler.md) |  |
| abstract class  | [BaseRetrieveBehavior](Serenity.Services/BaseRetrieveBehavior.md) |  |
| abstract class  | [BaseSaveBehavior](Serenity.Services/BaseSaveBehavior.md) |  |
| abstract class  | [BaseSaveDeleteBehavior](Serenity.Services/BaseSaveDeleteBehavior.md) |  |
| static class  | [BehaviorProviderExtensions](Serenity.Services/BehaviorProviderExtensions.md) | Extension methods for behavior provider |
| class  | [CaptureLogBehavior](Serenity.Services/CaptureLogBehavior.md) |  |
| class  | [CaptureLogConsts](Serenity.Services/CaptureLogConsts.md) |  |
| static class  | [DataValidation](Serenity.Services/DataValidation.md) |  |
| class  | [DefaultBehaviorFactory](Serenity.Services/DefaultBehaviorFactory.md) |  |
| class  | [DefaultBehaviorProvider](Serenity.Services/DefaultBehaviorProvider.md) |  |
| class  | [DefaultHandlerActivator](Serenity.Services/DefaultHandlerActivator.md) |  |
| class  | [DefaultHandlerAttribute](Serenity.Services/DefaultHandlerAttribute.md) | Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler. |
| class  | [DefaultHandlerFactory](Serenity.Services/DefaultHandlerFactory.md) |  |
| static class  | [DefaultHandlerFactoryExtensions](Serenity.Services/DefaultHandlerFactoryExtensions.md) |  |
| class  | [DefaultHandlerRegistry](Serenity.Services/DefaultHandlerRegistry.md) |  |
| class  | [DefaultImplicitBehaviorRegistry](Serenity.Services/DefaultImplicitBehaviorRegistry.md) |  |
| class  | [DefaultRequestContext](Serenity.Services/DefaultRequestContext.md) |  |
| class  | [DeleteRequest](Serenity.Services/DeleteRequest.md) |  |
| class  | [DeleteRequestHandler&lt;TRow&gt;](Serenity.Services/DeleteRequestHandler-1.md) |  |
| class  | [DeleteRequestHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/DeleteRequestHandler-3.md) |  |
| class  | [DeleteResponse](Serenity.Services/DeleteResponse.md) |  |
| class  | [DisplayOrderFilterHelper](Serenity.Services/DisplayOrderFilterHelper.md) |  |
| class  | [GenericHandlerTypeAttribute](Serenity.Services/GenericHandlerTypeAttribute.md) |  |
| interface  | [IBehaviorFactory](Serenity.Services/IBehaviorFactory.md) |  |
| interface  | [IBehaviorProvider](Serenity.Services/IBehaviorProvider.md) | Interface abstraction for behavior provider |
| interface  | [ICreateHandler&lt;TRow&gt;](Serenity.Services/ICreateHandler-1.md) |  |
| interface  | [ICreateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ICreateHandler-3.md) |  |
| interface  | [IDefaultHandlerFactory](Serenity.Services/IDefaultHandlerFactory.md) |  |
| interface  | [IDefaultHandlerRegistry](Serenity.Services/IDefaultHandlerRegistry.md) |  |
| interface  | [IDeleteBehavior](Serenity.Services/IDeleteBehavior.md) | A delete behavior that can be used as a mixin within a DeleteRequestHandler lifecycle |
| interface  | [IDeleteExceptionBehavior](Serenity.Services/IDeleteExceptionBehavior.md) | This is an extension for delete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [IDeleteHandler&lt;TRow&gt;](Serenity.Services/IDeleteHandler-1.md) |  |
| interface  | [IDeleteHandler&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](Serenity.Services/IDeleteHandler-3.md) |  |
| interface  | [IDeleteRequestHandler](Serenity.Services/IDeleteRequestHandler.md) | Represents a DeleteRequestHandler. Is used with DeleteBehavior objects. |
| interface  | [IDeleteRequestProcessor](Serenity.Services/IDeleteRequestProcessor.md) |  |
| interface  | [IFieldBehavior](Serenity.Services/IFieldBehavior.md) | Represents a request handler behavior that is targeted to a field. |
| interface  | [IHandlerActivator](Serenity.Services/IHandlerActivator.md) |  |
| interface  | [IImplicitBehavior](Serenity.Services/IImplicitBehavior.md) | An implicit behavior is a request handler behavior (save/list/retrieve/delete etc.) which can be implicitly activated for a row type without explicitly attached to that row type. |
| interface  | [IImplicitBehaviorRegistry](Serenity.Services/IImplicitBehaviorRegistry.md) | An interface to query list of implicit behaviors registered through the dependency resolver |
| interface  | [IIncludeExcludeColumns](Serenity.Services/IIncludeExcludeColumns.md) |  |
| interface  | [IListBehavior](Serenity.Services/IListBehavior.md) | A list behavior that can be used as a mixin within a ListRequestHandler lifecycle |
| interface  | [IListHandler&lt;TRow&gt;](Serenity.Services/IListHandler-1.md) |  |
| interface  | [IListHandler&lt;TRow,TListRequest&gt;](Serenity.Services/IListHandler-2.md) |  |
| interface  | [IListHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/IListHandler-3.md) |  |
| interface  | [IListRequestHandler](Serenity.Services/IListRequestHandler.md) | Represents a ListRequestHandler. Is used with ListBehavior objects. |
| interface  | [IListRequestProcessor](Serenity.Services/IListRequestProcessor.md) |  |
| interface  | [IListResponse](Serenity.Services/IListResponse.md) |  |
| interface  | [IRequestContext](Serenity.Services/IRequestContext.md) |  |
| interface  | [IRequestHandler&lt;TRow&gt;](Serenity.Services/IRequestHandler-1.md) |  |
| interface  | [IRequestHandler&lt;TRow,TRequest,TResponse&gt;](Serenity.Services/IRequestHandler-3.md) |  |
| interface  | [IRequestHandler](Serenity.Services/IRequestHandler.md) |  |
| interface  | [IRequestType&lt;TRequestType&gt;](Serenity.Services/IRequestType-1.md) |  |
| interface  | [IResponseType&lt;TResponseType&gt;](Serenity.Services/IResponseType-1.md) |  |
| interface  | [IRetrieveBehavior](Serenity.Services/IRetrieveBehavior.md) | A retrieve behavior that can be used as a mixin within a RetrieveRequestHandler lifecycle |
| interface  | [IRetrieveHandler&lt;TRow&gt;](Serenity.Services/IRetrieveHandler-1.md) |  |
| interface  | [IRetrieveHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/IRetrieveHandler-3.md) |  |
| interface  | [IRetrieveRequestHandler](Serenity.Services/IRetrieveRequestHandler.md) | Represents a RetrieveRequestHandler. Is used with RetrieveBehavior objects. |
| interface  | [IRetrieveRequestProcessor](Serenity.Services/IRetrieveRequestProcessor.md) |  |
| interface  | [IRetrieveResponse](Serenity.Services/IRetrieveResponse.md) |  |
| interface  | [ISaveBehavior](Serenity.Services/ISaveBehavior.md) | A save behavior that can be used as a mixin within a SaveRequestHandler lifecycle |
| interface  | [ISaveExceptionBehavior](Serenity.Services/ISaveExceptionBehavior.md) | This is an extension for save behaviors that should be called for exceptions that occur during save. It could be useful to preview the exception and raise another exception for FK / PK database errors etc. |
| interface  | [ISaveHandler&lt;TRow&gt;](Serenity.Services/ISaveHandler-1.md) |  |
| interface  | [ISaveHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/ISaveHandler-3.md) |  |
| interface  | [ISaveRequest](Serenity.Services/ISaveRequest.md) |  |
| interface  | [ISaveRequestHandler](Serenity.Services/ISaveRequestHandler.md) | Represents a SaveRequestHandler. Is used with SaveBehavior objects. |
| interface  | [ISaveRequestProcessor](Serenity.Services/ISaveRequestProcessor.md) |  |
| interface  | [IUpdateHandler&lt;TRow&gt;](Serenity.Services/IUpdateHandler-1.md) |  |
| interface  | [IUpdateHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/IUpdateHandler-3.md) |  |
| class  | [JsonServiceClient](Serenity.Services/JsonServiceClient.md) |  |
| class  | [JsonSortByConverter](Serenity.Services/JsonSortByConverter.md) | Serialize/deserialize a SortBy object as string |
| class  | [LinkingSetRelationBehavior](Serenity.Services/LinkingSetRelationBehavior.md) |  |
| class  | [ListRequest](Serenity.Services/ListRequest.md) |  |
| class  | [ListRequestHandler&lt;TRow&gt;](Serenity.Services/ListRequestHandler-1.md) |  |
| class  | [ListRequestHandler&lt;TRow,TListRequest&gt;](Serenity.Services/ListRequestHandler-2.md) |  |
| class  | [ListRequestHandler&lt;TRow,TListRequest,TListResponse&gt;](Serenity.Services/ListRequestHandler-3.md) |  |
| class  | [ListResponse&lt;T&gt;](Serenity.Services/ListResponse-1.md) |  |
| class  | [LocalizationBehavior](Serenity.Services/LocalizationBehavior.md) |  |
| class  | [MasterDetailRelationBehavior](Serenity.Services/MasterDetailRelationBehavior.md) |  |
| static class  | [RequestHandlerExtensions](Serenity.Services/RequestHandlerExtensions.md) |  |
| enum  | [RetrieveColumnSelection](Serenity.Services/RetrieveColumnSelection.md) |  |
| class  | [RetrieveLocalizationRequest](Serenity.Services/RetrieveLocalizationRequest.md) |  |
| class  | [RetrieveLocalizationResponse&lt;TEntity&gt;](Serenity.Services/RetrieveLocalizationResponse-1.md) |  |
| class  | [RetrieveRequest](Serenity.Services/RetrieveRequest.md) |  |
| class  | [RetrieveRequestHandler&lt;TRow&gt;](Serenity.Services/RetrieveRequestHandler-1.md) |  |
| class  | [RetrieveRequestHandler&lt;TRow,TRetrieveRequest,TRetrieveResponse&gt;](Serenity.Services/RetrieveRequestHandler-3.md) |  |
| class  | [RetrieveResponse&lt;T&gt;](Serenity.Services/RetrieveResponse-1.md) |  |
| class  | [SaveRequest&lt;TEntity&gt;](Serenity.Services/SaveRequest-1.md) |  |
| class  | [SaveRequestHandler&lt;TRow&gt;](Serenity.Services/SaveRequestHandler-1.md) |  |
| class  | [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](Serenity.Services/SaveRequestHandler-3.md) |  |
| enum  | [SaveRequestType](Serenity.Services/SaveRequestType.md) |  |
| class  | [SaveResponse](Serenity.Services/SaveResponse.md) |  |
| class  | [SaveWithLocalizationRequest&lt;TEntity&gt;](Serenity.Services/SaveWithLocalizationRequest-1.md) |  |
| class  | [ServiceError](Serenity.Services/ServiceError.md) |  |
| static class  | [ServiceHelper](Serenity.Services/ServiceHelper.md) |  |
| static class  | [ServiceQueryHelper](Serenity.Services/ServiceQueryHelper.md) |  |
| class  | [ServiceRequest](Serenity.Services/ServiceRequest.md) |  |
| class  | [ServiceResponse](Serenity.Services/ServiceResponse.md) |  |
| class  | [SortBy](Serenity.Services/SortBy.md) |  |
| static class  | [TreeOrdering](Serenity.Services/TreeOrdering.md) |  |
| static class  | [TwoLevelCacheInvalidationExtensions](Serenity.Services/TwoLevelCacheInvalidationExtensions.md) |  |
| class  | [UndeleteRequest](Serenity.Services/UndeleteRequest.md) |  |
| class  | [UndeleteRequestHandler&lt;TRow&gt;](Serenity.Services/UndeleteRequestHandler-1.md) |  |
| class  | [UndeleteRequestHandler&lt;TRow,TUndeleteResponse&gt;](Serenity.Services/UndeleteRequestHandler-2.md) |  |
| class  | [UndeleteResponse](Serenity.Services/UndeleteResponse.md) |  |
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