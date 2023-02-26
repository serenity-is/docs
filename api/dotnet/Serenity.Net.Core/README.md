# Serenity.Net.Core assembly

## Serenity namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [AuthorizationExtensions](Serenity/AuthorizationExtensions.md) | Authorization extension methods |
| static class  | [CollectionExtensions](Serenity/CollectionExtensions.md) | Basic collection extensions |
| enum  | [DateElementOrder](Serenity/DateElementOrder.md) | Date element orders |
| static class  | [DateHelper](Serenity/DateHelper.md) | Static class with common date utilities and constants |
| static class  | [DistributedCacheExtensions](Serenity/DistributedCacheExtensions.md) | Contains extensions methods to work with IDistributedCache provider. |
| static class  | [EnumMapper](Serenity/EnumMapper.md) | Contains Enum mapping and other helper functions |
| static class  | [ExceptionExtensions](Serenity/ExceptionExtensions.md) | Exception data extensions |
| static class  | [FileSystemExtensions](Serenity/FileSystemExtensions.md) | IFileSystem extensions to reduce dependency on System.IO, in case these methods are also added to IFileSystem in the future |
| interface  | [IFileSystem](Serenity/IFileSystem.md) | Base file system for abstracting physical disk access |
| interface  | [INotLoggedException](Serenity/INotLoggedException.md) | An exception that should not be logged. |
| static class  | [Invariants](Serenity/Invariants.md) | Invariant culture related constants and formats. |
| interface  | [IServiceResolver&lt;TService&gt;](Serenity/IServiceResolver-1.md) | A generic version of IServiceProvider which resolves a service on demand. |
| interface  | [ITextLocalizer](Serenity/ITextLocalizer.md) | Text localizer for current context language / pending state. |
| interface  | [IUserDefinition](Serenity/IUserDefinition.md) | User definition abstraction. |
| static class  | [JSON](Serenity/JSON.md) | Contains shortcuts to Newtonsoft.Json serialization / deserialization methods, and default Serenity settings. |
| static class  | [JsonSettings](Serenity/JsonSettings.md) | Contains default Serenity JSON serialization settings. |
| class  | [LocalText](Serenity/LocalText.md) | Defines a localizable text resource. Contains a local text key and has implicit conversions to and from String. |
| static class  | [MemoryCacheExtensions](Serenity/MemoryCacheExtensions.md) | Contains extensions methods to work with IMemoryCache provider. |
| class  | [NullExceptionLogger](Serenity/NullExceptionLogger.md) | Null exception logger that logs nothing |
| class  | [NullTextLocalizer](Serenity/NullTextLocalizer.md) | Null text localizer which returns null for all keys |
| static class  | [PathHelper](Serenity/PathHelper.md) | Contains Path related helper functions. |
| class  | [PhysicalFileSystem](Serenity/PhysicalFileSystem.md) | Physical file sytem |
| static class  | [ReflectionExtensions](Serenity/ReflectionExtensions.md) | Reflection extensions |
| static class  | [StringHelper](Serenity/StringHelper.md) | This static class contains some helper functions that operate on String objects. |
| enum  | [SummaryType](Serenity/SummaryType.md) | Enumeration of aggregate function types for a column |
| static class  | [TextLocalizerExtensions](Serenity/TextLocalizerExtensions.md) | Extensions for local text context |
| class  | [Throttler](Serenity/Throttler.md) | Provides throttling checks for operations. E.g. allow 10 login attempts per minute. |
| class  | [TwoLevelCache](Serenity/TwoLevelCache.md) | Contains helper functions to use local and distributed cache in sync with optional cache invalidation. |
| static class  | [TwoLevelCacheExtensions](Serenity/TwoLevelCacheExtensions.md) | Contains extension functions to use local and distributed cache in sync with optional cache invalidation. |
| static class  | [UriHelper](Serenity/UriHelper.md) | Contains URI related helper functions. |
| struct  | [ValueStopwatch](Serenity/ValueStopwatch.md) | A value stopwatch |

## Serenity.Abstractions namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DefaultTypeSource](Serenity.Abstractions/DefaultTypeSource.md) | Default implementation for a type source |
| interface  | [IExceptionLogger](Serenity.Abstractions/IExceptionLogger.md) | Exception logger abstraction |
| interface  | [IHttpContextItemsAccessor](Serenity.Abstractions/IHttpContextItemsAccessor.md) | Interface for abstraction that should return HttpContext.Current.Items for web requests, and null for normal threads. |
| interface  | [IImpersonator](Serenity.Abstractions/IImpersonator.md) | Interface for authorization services that supports temporary impersonating |
| interface  | [ILocalTextRegistry](Serenity.Abstractions/ILocalTextRegistry.md) | Abstraction for local text registry which stores translations for local text keys. |
| interface  | [IPermissionService](Serenity.Abstractions/IPermissionService.md) | Permission service abstraction |
| interface  | [IRemoveAll](Serenity.Abstractions/IRemoveAll.md) | Abstraction for objects that supports clearing all items, like a cache or local text registry. |
| interface  | [ISiteAbsoluteUrl](Serenity.Abstractions/ISiteAbsoluteUrl.md) | Interface to access absolute base URL for current site, including the PathBase. Useful for reporting callbacks, or e-mails etc. |
| interface  | [ITransientGrantor](Serenity.Abstractions/ITransientGrantor.md) | Interface for permission services that supports granting permissions temporarily |
| interface  | [ITwoLevelCache](Serenity.Abstractions/ITwoLevelCache.md) | An abstraction for a combination of in memory and distributed cache. |
| interface  | [ITypeSource](Serenity.Abstractions/ITypeSource.md) | Abstraction for type source which is used as an extensibility point for Serenity applications |
| interface  | [IUserAccessor](Serenity.Abstractions/IUserAccessor.md) | Abstraction to access the current user |
| interface  | [IUserRetrieveService](Serenity.Abstractions/IUserRetrieveService.md) | Abstraction to retrieve a user definition by its id or username |
| static class  | [TypeSourceExtensions](Serenity.Abstractions/TypeSourceExtensions.md) | Type source extension methods |

## Serenity.ComponentModel namespace

| signature | name | description |
| --: | --- | --- |
| class  | [AlignCenterAttribute](Serenity.ComponentModel/AlignCenterAttribute.md) | Centers text horizontally (usually in a grid column). |
| abstract class  | [AlignmentAttribute](Serenity.ComponentModel/AlignmentAttribute.md) | Controls horizontal alignment of text (usually in grid columns). |
| class  | [AlignRightAttribute](Serenity.ComponentModel/AlignRightAttribute.md) | Right aligns text horizontally (usually in a grid column) |
| class  | [AllowHideAttribute](Serenity.ComponentModel/AllowHideAttribute.md) | Controls users ability to hide a column, e.g. using column picker. |
| class  | [AnnotationTypeAttribute](Serenity.ComponentModel/AnnotationTypeAttribute.md) | Declares that the type with this attribute is an annotation type for another type, e.g. it contains attributes for the other type and its properties. This is mainly used to separate dependencies between rows and UI related properties like editor types etc. |
| class  | [AsyncLookupEditorAttribute](Serenity.ComponentModel/AsyncLookupEditorAttribute.md) | Indicates that the target property should use a "Lookup" editor with "async" set to true. |
| class  | [BasedOnRowAttribute](Serenity.ComponentModel/BasedOnRowAttribute.md) | An attribute that indicates this type is based on another row type. Used with form, columns etc. types to map their properties to corresponding property in a row, so that they inherit attributes. |
| abstract class  | [BaseUploadEditorAttribute](Serenity.ComponentModel/BaseUploadEditorAttribute.md) | Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory. |
| class  | [BooleanEditorAttribute](Serenity.ComponentModel/BooleanEditorAttribute.md) | Indicates that the target property should use a "Boolean" editor. |
| class  | [BooleanFilteringAttribute](Serenity.ComponentModel/BooleanFilteringAttribute.md) | Sets filtering type to "Boolean" |
| class  | [BooleanFormatterAttribute](Serenity.ComponentModel/BooleanFormatterAttribute.md) | Sets formatting type to "Boolean" |
| class  | [CheckboxFormatterAttribute](Serenity.ComponentModel/CheckboxFormatterAttribute.md) | Sets formatting type to "Checkbox" |
| class  | [CheckLookupEditorAttribute](Serenity.ComponentModel/CheckLookupEditorAttribute.md) | Indicates that the target property should use a "CheckLookup" editor. |
| class  | [CollapsibleAttribute](Serenity.ComponentModel/CollapsibleAttribute.md) | Used to specify a target is collapsible. Commonly used with form categories to make them collapsible. |
| class  | [ColumnsScriptAttribute](Serenity.ComponentModel/ColumnsScriptAttribute.md) | Indicates that this type should generate a columns script, which contains information about properties in this type and is an array of PropertyItem objects. Column scripts can be accessed from client side using Q.getColumns("Key") |
| class  | [CssClassAttribute](Serenity.ComponentModel/CssClassAttribute.md) | Sets the CSS class for columns and form fields. In forms, class is added to container div with .field class that contains both label and editor. For columns, it sets cssClass property of SlickColumn, which adds this class to slick cells for all rows. Slick column headers are not affected by this attribute, use HeaderCssClass for that. |
| abstract class  | [CustomEditorAttribute](Serenity.ComponentModel/CustomEditorAttribute.md) | Base attribute class that all other custom editor types derives from. |
| abstract class  | [CustomFilteringAttribute](Serenity.ComponentModel/CustomFilteringAttribute.md) | Base class which other custom filtering types derive from. |
| abstract class  | [CustomFormatterAttribute](Serenity.ComponentModel/CustomFormatterAttribute.md) | Base class for custom formatter type attributes |
| class  | [DataScriptAttribute](Serenity.ComponentModel/DataScriptAttribute.md) | Indicates that this method / type should generate a remote data script. Data contained by remote data scripts can be accessed client side using Q.getRemoteData("Key") function. |
| class  | [DateEditorAttribute](Serenity.ComponentModel/DateEditorAttribute.md) | Indicates that the target property should use a "Date" editor. |
| class  | [DateFilteringAttribute](Serenity.ComponentModel/DateFilteringAttribute.md) | Sets filtering type as "Date" |
| class  | [DateFormatterAttribute](Serenity.ComponentModel/DateFormatterAttribute.md) | Sets formatting type to "Date" |
| class  | [DateTimeEditorAttribute](Serenity.ComponentModel/DateTimeEditorAttribute.md) | Indicates that the target property should use a "DateTime" editor. |
| class  | [DateTimeFilteringAttribute](Serenity.ComponentModel/DateTimeFilteringAttribute.md) | Indicates that this field should have date/time type of filtering |
| class  | [DateTimeFormatterAttribute](Serenity.ComponentModel/DateTimeFormatterAttribute.md) | Sets formatting type to "DateTime". |
| class  | [DateYearEditorAttribute](Serenity.ComponentModel/DateYearEditorAttribute.md) | Indicates that the target property should use a "DateYear" editor. |
| class  | [DecimalEditorAttribute](Serenity.ComponentModel/DecimalEditorAttribute.md) | Indicates that the target property should use a "Decimal" editor. |
| class  | [DecimalFilteringAttribute](Serenity.ComponentModel/DecimalFilteringAttribute.md) | Indicates that this field should have decimal type of filtering |
| class  | [DefaultFilenameFormatSanitizer](Serenity.ComponentModel/DefaultFilenameFormatSanitizer.md) | Default implementation for IFilenameFormatSanitizer |
| class  | [DisplayFormatAttribute](Serenity.ComponentModel/DisplayFormatAttribute.md) | Sets the display format for a column. This has no effect on editors! It is only for Display, "NOT Editing". For editing, you have to change UI culture. |
| class  | [DistinctValuesEditorAttribute](Serenity.ComponentModel/DistinctValuesEditorAttribute.md) | Indicates that the target property should use a "DistinctValues" editor and also defines an automatic lookup script for row fields. |
| abstract class  | [DynamicScriptAttribute](Serenity.ComponentModel/DynamicScriptAttribute.md) | Base class for dynamic script attributes. Dynamic scripts contain dynamic data, but they are not parameterized. |
| class  | [EditLinkAttribute](Serenity.ComponentModel/EditLinkAttribute.md) | Indicates that the property this attribute placed on should have an edit link |
| class  | [EditorFilteringAttribute](Serenity.ComponentModel/EditorFilteringAttribute.md) | Indicates that property should a custom editor for filtering, which is usually determined by form editor type of the property. |
| class  | [EditorOptionAttribute](Serenity.ComponentModel/EditorOptionAttribute.md) | Sets an editor option for target property editor. Avoid using this where possible as option keys and values are not checked. |
| class  | [EditorTypeAttribute](Serenity.ComponentModel/EditorTypeAttribute.md) | Sets editor type of the target property. |
| class  | [EmailAddressEditorAttribute](Serenity.ComponentModel/EmailAddressEditorAttribute.md) | Indicates that the target property should use a "EmailAddress" editor. |
| class  | [EnumEditorAttribute](Serenity.ComponentModel/EnumEditorAttribute.md) | Indicates that the target property should use a "Enum" editor. |
| class  | [EnumFilteringAttribute](Serenity.ComponentModel/EnumFilteringAttribute.md) | Indicates that property should use enum type of filtering |
| class  | [EnumFormatterAttribute](Serenity.ComponentModel/EnumFormatterAttribute.md) | Sets formatting type to "Enum". |
| class  | [EnumKeyAttribute](Serenity.ComponentModel/EnumKeyAttribute.md) | Sets the enumeration key of an enum |
| class  | [FileDownloadFormatterAttribute](Serenity.ComponentModel/FileDownloadFormatterAttribute.md) | Sets formatting type to "FileDownload". |
| class  | [FileUploadEditorAttribute](Serenity.ComponentModel/FileUploadEditorAttribute.md) | Sets editor type as "ImageUpload" (single), while allowing non-image files. |
| class  | [FilteringIdFieldAttribute](Serenity.ComponentModel/FilteringIdFieldAttribute.md) | Specifies ID field to filter on a field. For example, if this attribute is placed on EmployeeName field, EmployeeId can be the filtering field, so that values are filtered on ID not text value. |
| class  | [FilteringOptionAttribute](Serenity.ComponentModel/FilteringOptionAttribute.md) | Declares a new filtering option |
| class  | [FilteringTypeAttribute](Serenity.ComponentModel/FilteringTypeAttribute.md) | Sets filtering type for the field |
| class  | [FilterOnlyAttribute](Serenity.ComponentModel/FilterOnlyAttribute.md) | Indicates that this field should not be shown, and could not be made visible in column selection dialog, but only used for advanced filtering. |
| class  | [FormatterOptionAttribute](Serenity.ComponentModel/FormatterOptionAttribute.md) | Adds a formatter option |
| class  | [FormatterTypeAttribute](Serenity.ComponentModel/FormatterTypeAttribute.md) | Sets formatter type. |
| class  | [FormCssClassAttribute](Serenity.ComponentModel/FormCssClassAttribute.md) | Sets CSS class for field on forms only. |
| class  | [FormScriptAttribute](Serenity.ComponentModel/FormScriptAttribute.md) | Indicates that this type should generate a form script, which contains information about properties in this type and is an array of PropertyItem objects. Form scripts can be accessed from client side using Q.getForm("Key") |
| class  | [FormWidthAttribute](Serenity.ComponentModel/FormWidthAttribute.md) | Sets CSS class for field on forms only. Useful for Bootstrap grid, e.g. col-md-4 etc. |
| class  | [FullWidthAttribute](Serenity.ComponentModel/FullWidthAttribute.md) | Set form field width class to null, e.g. full width |
| class  | [GroupOrderAttribute](Serenity.ComponentModel/GroupOrderAttribute.md) | Sets in which order this property should be grouped by. This is only meaningful when a grid has grouping, and it sets the default grouped columns. The properties with this attribute are the default ones grouped by and their groupOrder determines in which order they are grouped by. |
| class  | [HalfWidthAttribute](Serenity.ComponentModel/HalfWidthAttribute.md) | Marks form field with "col-sm-6" css class, which makes it allocate half of form row on device widths &gt;= 768px (e.g. iPad) |
| class  | [HeaderCssClassAttribute](Serenity.ComponentModel/HeaderCssClassAttribute.md) | Sets the CSS class for grid column headers. It sets headerCssClass property of SlickColumn. This has no effect for forms. |
| class  | [HiddenAttribute](Serenity.ComponentModel/HiddenAttribute.md) | Sets a column as initially hidden |
| class  | [HideOnInsertAttribute](Serenity.ComponentModel/HideOnInsertAttribute.md) | Controls whether this field is visible on new record mode |
| class  | [HideOnUpdateAttribute](Serenity.ComponentModel/HideOnUpdateAttribute.md) | Controls whether this field is visible on edit record mode |
| class  | [HintAttribute](Serenity.ComponentModel/HintAttribute.md) | Sets a hint for a form field. Hint is shown when field label is hovered. This has no effect on columns. |
| class  | [HtmlContentEditorAttribute](Serenity.ComponentModel/HtmlContentEditorAttribute.md) | Indicates that the target property should use a "HtmlContent" editor. This is generally a CK editor that contains more functionalities compared to other ones. |
| class  | [HtmlNoteContentEditorAttribute](Serenity.ComponentModel/HtmlNoteContentEditorAttribute.md) | Indicates that the target property should use a "HtmlNoteContent" editor. This is generally a CK editor with only basic functionality for notes enabled. |
| class  | [HtmlReportContentEditorAttribute](Serenity.ComponentModel/HtmlReportContentEditorAttribute.md) | Indicates that the target property should use a "HtmlReportContent" editor. This is generally a CK editor with only functionality compatible with common reporting tools like SSRS, Telerik, DevExpress etc. enabled. |
| interface  | [ICustomizePropertyItems](Serenity.ComponentModel/ICustomizePropertyItems.md) | Represents a customized column / form script |
| interface  | [IFilenameFormatSanitizer](Serenity.ComponentModel/IFilenameFormatSanitizer.md) | Abstraction for sanitizing values of replacement placeholders in a file name format string like &#x7C;X&#x7C;/&#x7C;Y&#x7C;. Sanitizer is called for each of the placeholders and for the result. Can be implemented by custom subclasses of upload editor attributes or registered in DI. |
| class  | [IgnoreAttribute](Serenity.ComponentModel/IgnoreAttribute.md) | Skips a property while generating grid column or form field list. Use this to ignore a property for UI, but still use it for other purposes like JSON serialization. This might be useful when a type is used as a Service Request and Form Declaration at the same time. |
| class  | [IgnoreNameAttribute](Serenity.ComponentModel/IgnoreNameAttribute.md) | Skips checking a property name. This is usually used along with BasedOnRow attribute CheckNames = true to skip checking property name if it matches a field property name in the row. |
| class  | [ImageUploadEditorAttribute](Serenity.ComponentModel/ImageUploadEditorAttribute.md) | Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory. |
| class  | [ImplicitPermissionAttribute](Serenity.ComponentModel/ImplicitPermissionAttribute.md) | Placed on permission keys to define an implicitly assigned permissions when a user / role has the permission. Currently only implemented in premium app. |
| class  | [InsertableAttribute](Serenity.ComponentModel/InsertableAttribute.md) | Controls if this field is editable in new record mode. When used with fields, turns on or off the insertable flag. |
| class  | [IntegerEditorAttribute](Serenity.ComponentModel/IntegerEditorAttribute.md) | Indicates that the target property should use a "Integer" editor. |
| class  | [IntegerFilteringAttribute](Serenity.ComponentModel/IntegerFilteringAttribute.md) | Indicates that property should use integer type of filtering |
| interface  | [IUploadEditor](Serenity.ComponentModel/IUploadEditor.md) | Runs FileUploadBehavior or MultipleFileUploadBehavior behaviors. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory. |
| interface  | [IUploadFileConstraints](Serenity.ComponentModel/IUploadFileConstraints.md) | Constraints of the uploaded file size. |
| interface  | [IUploadFileOptions](Serenity.ComponentModel/IUploadFileOptions.md) | Upload options related to the file name and encoding |
| interface  | [IUploadImageContrains](Serenity.ComponentModel/IUploadImageContrains.md) | Contstraints for the uploaded image. |
| interface  | [IUploadImageOptions](Serenity.ComponentModel/IUploadImageOptions.md) | Options for the uploaded image and thumbnails |
| interface  | [IUploadOptions](Serenity.ComponentModel/IUploadOptions.md) | Marker interface for all upload options |
| class  | [JsonLocalTextAssetsAttribute](Serenity.ComponentModel/JsonLocalTextAssetsAttribute.md) | Registers a folder with json local text files packed as static web assets for the assembly |
| class  | [LabelWidthAttribute](Serenity.ComponentModel/LabelWidthAttribute.md) | Determines label with of target property, and optionally the properties following it until another of this attribute is used. |
| class  | [LocalTextPrefixAttribute](Serenity.ComponentModel/LocalTextPrefixAttribute.md) | Sets local text prefix for the row. |
| class  | [LookupEditorAttribute](Serenity.ComponentModel/LookupEditorAttribute.md) | Indicates that the target property should use a "Lookup" editor. |
| abstract class  | [LookupEditorBaseAttribute](Serenity.ComponentModel/LookupEditorBaseAttribute.md) | Base class for lookup based editor types |
| class  | [LookupFilteringAttribute](Serenity.ComponentModel/LookupFilteringAttribute.md) | Indicates that property should use lookup editor type of filtering |
| class  | [LookupScriptAttribute](Serenity.ComponentModel/LookupScriptAttribute.md) | Placed on rows / or custom lookup classes to denote it has a lookup script. When placed on a row class, lookup scripts only transfer ID and Name fields by default to client side for security / performance reasons. Make sure you add [LookupInclude] attribute to properties you'll need to access from script. |
| class  | [MaskedEditorAttribute](Serenity.ComponentModel/MaskedEditorAttribute.md) | Indicates that the target property should use a "Masked" editor and also defines an automatic lookup script for row fields. |
| class  | [MaxLengthAttribute](Serenity.ComponentModel/MaxLengthAttribute.md) | Sets the maximum length of an editor attached to the target property. |
| class  | [MediumHalfLargeQuarterWidthAttribute](Serenity.ComponentModel/MediumHalfLargeQuarterWidthAttribute.md) | Marks form field with "col-md-6 col-lg-3" css class, which makes it allocate half of form row on device widths &gt;= 992px (some desktop), and quarter on device widths &gt;= 1200px |
| class  | [MediumHalfLargeThirdWidthAttribute](Serenity.ComponentModel/MediumHalfLargeThirdWidthAttribute.md) | Marks form field with "col-md-6 col-lg-4" css class, which makes it allocate half of form row on device widths &gt;= 992px (some desktop), and third on device widths &gt;= 1200px |
| class  | [MediumHalfWidthAttribute](Serenity.ComponentModel/MediumHalfWidthAttribute.md) | Marks form field with "col-md-6" css class, which makes it allocate half of form row on device widths &gt;= 992px (some desktops) |
| class  | [MediumQuarterWidthAttribute](Serenity.ComponentModel/MediumQuarterWidthAttribute.md) | Marks form field with "col-md-3" css class, which makes it allocate quarter on device widths &gt;= 992px (some desktops) |
| class  | [MediumThirdLargeQuarterWidthAttribute](Serenity.ComponentModel/MediumThirdLargeQuarterWidthAttribute.md) | Marks form field with "col-md-4 col-lg-3" css class, which makes it allocate third of form row on device widths &gt;= 992px (some desktop), and quarter on device widths &gt;= 1200px |
| class  | [MinuteFormatterAttribute](Serenity.ComponentModel/MinuteFormatterAttribute.md) | Sets formatting type to "Minute" which formats an integer value in HH:mm format. |
| class  | [ModuleAttribute](Serenity.ComponentModel/ModuleAttribute.md) | Sets the module name for the row. Module name is usually the folder name under ~/Modules folder entity resides in. |
| class  | [MultipleFileUploadEditorAttribute](Serenity.ComponentModel/MultipleFileUploadEditorAttribute.md) | Sets editor type to "MultipleImageUpload" while allowing non-image files. |
| class  | [MultipleImageUploadEditorAttribute](Serenity.ComponentModel/MultipleImageUploadEditorAttribute.md) | Sets editor type to "MultipleImageUpload" which doesn't allow non-image file types by default. |
| class  | [NestedLocalTextsAttribute](Serenity.ComponentModel/NestedLocalTextsAttribute.md) | Indicates that this class contains local texts with optionally subclasses that also contains local texts with keys joined by "." between each class name. The topmost class has no local text prefix by default and its name doesn't take role in local text key generation. |
| class  | [NestedPermissionKeysAttribute](Serenity.ComponentModel/NestedPermissionKeysAttribute.md) | Indicates that this class contains permission keys with optional subclasses that also contains permission keys. |
| class  | [NotFilterableAttribute](Serenity.ComponentModel/NotFilterableAttribute.md) | Indicates that the field this attribute is placed on is not filterable. |
| class  | [NumberFormatterAttribute](Serenity.ComponentModel/NumberFormatterAttribute.md) | Sets formatting type to "Number" |
| class  | [OneThirdWidthAttribute](Serenity.ComponentModel/OneThirdWidthAttribute.md) | Marks form field with "col-md-4" css class, which makes it allocate a third of form row on device widths &gt;= 992px (e.g. medium desktop) |
| class  | [OneWayAttribute](Serenity.ComponentModel/OneWayAttribute.md) | Indicates that the target property should not get serialized when a property grid is saved. This means, the editor of the property reads the value from the entity, but it doesn't get written back to save entity. |
| class  | [PasswordEditorAttribute](Serenity.ComponentModel/PasswordEditorAttribute.md) | Indicates that the target property should use a "Password" editor. |
| class  | [PlaceholderAttribute](Serenity.ComponentModel/PlaceholderAttribute.md) | Sets a placeholder for a form field. Placeholder text is shown inside the editor when its value is empty. Only editors using basic inputs and Select2 editor supports this. |
| class  | [PropertyItem](Serenity.ComponentModel/PropertyItem.md) | Corresponds to a property item (e.g. a field in property grid with a label and editor, or a column specification in a grid) |
| class  | [PropertyItemsData](Serenity.ComponentModel/PropertyItemsData.md) | The data format of a property items script (form or columns) |
| class  | [QuarterWidthAttribute](Serenity.ComponentModel/QuarterWidthAttribute.md) | Marks form field with "col-lg-3 col-sm-6" css class, which makes it allocate half of form row on device widths &gt;= 768 (e.g. ipad), and quarter on device widths &gt;= 1200px (desktop) |
| class  | [QuickFilterAttribute](Serenity.ComponentModel/QuickFilterAttribute.md) | Indicates that this property should have a quick filter on grid. |
| class  | [QuickFilterOptionAttribute](Serenity.ComponentModel/QuickFilterOptionAttribute.md) | Add an option to the quick filtering. |
| class  | [RadioButtonEditorAttribute](Serenity.ComponentModel/RadioButtonEditorAttribute.md) | Indicates that the target property should use a "RadioButton" editor. |
| class  | [RecaptchaAttribute](Serenity.ComponentModel/RecaptchaAttribute.md) | Indicates that the target property should use a "Recaptcha" (Google). |
| class  | [RecaptchaSettings](Serenity.ComponentModel/RecaptchaSettings.md) | Settings for Recaptcha integration |
| class  | [RegisterPermissionKeyAttribute](Serenity.ComponentModel/RegisterPermissionKeyAttribute.md) | Registers a permission key. |
| class  | [RequiredAttribute](Serenity.ComponentModel/RequiredAttribute.md) | Determines if field is required in form. |
| class  | [RequiredPermissionAttribute](Serenity.ComponentModel/RequiredPermissionAttribute.md) | Specifies required permission to access an object, e.g. a report |
| class  | [ResetFormWidthAttribute](Serenity.ComponentModel/ResetFormWidthAttribute.md) | Resets form field width to null. It maybe used to cancel UntilNext flag of a prior width attribute. |
| class  | [ResetLabelWidthAttribute](Serenity.ComponentModel/ResetLabelWidthAttribute.md) | Resets form css class to null, it maybe used to cancel a prior LabelWidth attribute with UntilNext = true |
| class  | [ResizableAttribute](Serenity.ComponentModel/ResizableAttribute.md) | Determines resizability of a target column. |
| class  | [ScriptIncludeAttribute](Serenity.ComponentModel/ScriptIncludeAttribute.md) | Enables script code generation for the type this attribute is placed on. By default, types which are used in an endpoint / row is automatically enabled for code generation. Use this only for non-referenced types. |
| class  | [ScriptSkipAttribute](Serenity.ComponentModel/ScriptSkipAttribute.md) | Disables script code generation for the type this attribute is placed on. Currently only useful for LocalText/Permission generation. |
| class  | [ServiceLookupEditorAttribute](Serenity.ComponentModel/ServiceLookupEditorAttribute.md) | Indicates that the target property should use a "ServiceLookup" editor. |
| abstract class  | [ServiceLookupEditorBaseAttribute](Serenity.ComponentModel/ServiceLookupEditorBaseAttribute.md) | Base class for service lookup based editor types |
| class  | [SortableAttribute](Serenity.ComponentModel/SortableAttribute.md) | Indicates if sorting is enabled for this property |
| class  | [SortOrderAttribute](Serenity.ComponentModel/SortOrderAttribute.md) | Sets the column as sorted by default, and its index among sorted columns. Negative values means descending sort. Applies only to columns. |
| class  | [StringEditorAttribute](Serenity.ComponentModel/StringEditorAttribute.md) | Indicates that the target property should use a "String" editor. |
| class  | [SummaryTypeAttribute](Serenity.ComponentModel/SummaryTypeAttribute.md) | Determines type of aggregate function for a column to use |
| class  | [TabAttribute](Serenity.ComponentModel/TabAttribute.md) | Sets a tab for a form field. |
| class  | [TextAreaEditorAttribute](Serenity.ComponentModel/TextAreaEditorAttribute.md) | Indicates that the target property should use a "TextArea" editor. |
| class  | [ThreeQuarterWidthAttribute](Serenity.ComponentModel/ThreeQuarterWidthAttribute.md) | Marks form field with "col-lg-9" css class, which makes it allocate three quarter on device widths &gt;= 1200px |
| class  | [TimeEditorAttribute](Serenity.ComponentModel/TimeEditorAttribute.md) | Indicates that the target property should use a "Time" editor. |
| class  | [TwoThirdWidthAttribute](Serenity.ComponentModel/TwoThirdWidthAttribute.md) | Marks form field with "col-md-8" css class, which makes it allocate two third of form row on device widths &gt;= 992px (e.g. medium desktop) |
| class  | [UpdatableAttribute](Serenity.ComponentModel/UpdatableAttribute.md) | Controls if this field is editable in update record mode. When used with fields, turns on or off the updatable flag. |
| class  | [UploadOptions](Serenity.ComponentModel/UploadOptions.md) | Set of default upload options |
| class  | [URLEditorAttribute](Serenity.ComponentModel/URLEditorAttribute.md) | Indicates that the target property should use a "Url" editor. |
| class  | [UrlFormatterAttribute](Serenity.ComponentModel/UrlFormatterAttribute.md) | Sets formatting type to "Url" |
| class  | [VisibleAttribute](Serenity.ComponentModel/VisibleAttribute.md) | Controls initial visibility of a column / form field. |
| class  | [WidthAttribute](Serenity.ComponentModel/WidthAttribute.md) | Sets column width |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| class  | [Base32](Serenity.Data/Base32.md) | This class is based on the Base32 class from DC# 0.31 All credits to Jonathan Bindel. |
| static class  | [BinarySerialization](Serenity.Data/BinarySerialization.md) | Contains helper functions for serialization and deserialization of data items (e.g.cached items) |
| class  | [DeletePermissionAttribute](Serenity.Data/DeletePermissionAttribute.md) | Sets delete permission for the row. |
| class  | [FieldInsertPermissionAttribute](Serenity.Data/FieldInsertPermissionAttribute.md) | Sets default read permission for fields of a row which doesn't have a InsertPermission themselves. |
| class  | [FieldModifyPermissionAttribute](Serenity.Data/FieldModifyPermissionAttribute.md) | Sets default read permission for fields of a row which doesn't have a ModifyPermission themselves. |
| class  | [FieldReadPermissionAttribute](Serenity.Data/FieldReadPermissionAttribute.md) | Sets default read permission for fields of a row which doesn't have a ReadPermission themselves. |
| class  | [FieldUpdatePermissionAttribute](Serenity.Data/FieldUpdatePermissionAttribute.md) | Sets default read permission for fields of a row which doesn't have a UpdatePermission themselves. |
| class  | [InsertPermissionAttribute](Serenity.Data/InsertPermissionAttribute.md) | Sets delete permission for the row. |
| class  | [JsonSafeInt64Converter](Serenity.Data/JsonSafeInt64Converter.md) | Serialize/deserialize a row |
| class  | [ModifyPermissionAttribute](Serenity.Data/ModifyPermissionAttribute.md) | Sets modify permission for the row. Modify permission is used for Insert/Update/Delete if they are not explicitly specified. |
| class  | [NavigationPermissionAttribute](Serenity.Data/NavigationPermissionAttribute.md) | Sets navigation permission for the row, which if exists takes precedence over ReadPermissionAttribute to determine permission for row's page and navigation item. |
| abstract class  | [PermissionAttributeBase](Serenity.Data/PermissionAttributeBase.md) | An abstract base attribute that all permission related attributes derive from. |
| class  | [ReadPermissionAttribute](Serenity.Data/ReadPermissionAttribute.md) | Sets read permission for the row. |
| class  | [ServiceLookupPermissionAttribute](Serenity.Data/ServiceLookupPermissionAttribute.md) | Sets a permission to read only lookup fields in a row via List service Lookup field means ID, Name, and [LookupInclude] properties in a row. You must use [AuthorizeList(typeof(XRow))] instead of ServiceAuthorize in service endpoint. |
| class  | [UpdatePermissionAttribute](Serenity.Data/UpdatePermissionAttribute.md) | Sets update permission for the row. |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [CoreServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/CoreServiceCollectionExtensions.md) | Contains extensions to register core services |
| class  | [ServiceResolver&lt;TService&gt;](Serenity.Extensions.DependencyInjection/ServiceResolver-1.md) | A generic version of IServiceProvider which resolves a service on demand. |

## Serenity.IO namespace

| signature | name | description |
| --: | --- | --- |
| enum  | [DeleteType](Serenity.IO/DeleteType.md) | File deletion type. |
| class  | [GlobFilter](Serenity.IO/GlobFilter.md) | A fast glob implementation, compatible with .gitignore patterns of GIT |
| class  | [TemporaryFileHelper](Serenity.IO/TemporaryFileHelper.md) | Contains helper functions for temporary files and folders |

## Serenity.Localization namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DefaultTextLocalizer](Serenity.Localization/DefaultTextLocalizer.md) | Implementation of text localizer for current ui culture name and text registry |
| static class  | [EnumLocalTextRegistration](Serenity.Localization/EnumLocalTextRegistration.md) | Contains initialization method for adding local text translations defined by Description attributes in enumeration classes. |
| class  | [FallbackLocalTextSource](Serenity.Localization/FallbackLocalTextSource.md) | Adds key fallback to any ILocalTextSource implementation |
| class  | [InitializedLocalText](Serenity.Localization/InitializedLocalText.md) | A subclass of LocalText class that contains a initial translation value. Some classes like NestedLocalTextRegistration uses this type to avoid re-registering a initialized local text object, when their Initialization method called more than once. |
| static class  | [JsonLocalTextRegistration](Serenity.Localization/JsonLocalTextRegistration.md) | Contains helper methods for registration of local texts in hierarchical/dictionary formatted JSON files. |
| class  | [LocalTextRegistry](Serenity.Localization/LocalTextRegistry.md) | Default ILocalTextRegistry implementation. |
| static class  | [NestedLocalTextRegistration](Serenity.Localization/NestedLocalTextRegistration.md) | Contains helper methods for registration of local texts in nested static classes. Nested static contains LocalText objects with actual translations as keys. This class locates them (with NestedLocalTextsAttribute at outermost class), determines keys by path from outermost to nested class name, replaces existing LocalText instance with a InitializedLocalText instance containing this generated key and initial translation, and registers this translation in ILocalTextRegistry provider. |
| static class  | [NestedPermissionKeyRegistration](Serenity.Localization/NestedPermissionKeyRegistration.md) | Contains helper methods for registration of permission keys in nested static classes. These classes contains string constants containing permission keys. Display name for permission keys can be set by [DisplayName] attribute. Display name for groups can be set by [Description] attribute on classes themselves. For group display name to work, all constants in a class must start with same group prefix. |

## Serenity.Plugins namespace

| signature | name | description |
| --: | --- | --- |
| class  | [CssFile](Serenity.Plugins/CssFile.md) | CSS file dependency for plugins |
| interface  | [IBackgroundJobs](Serenity.Plugins/IBackgroundJobs.md) | Interface for plugins that has a list of background jobs |
| interface  | [IConfigureServices](Serenity.Plugins/IConfigureServices.md) | Interface for plugins that requires to configure their own services / options |
| interface  | [ICssFiles](Serenity.Plugins/ICssFiles.md) | CSS file dependencies for plugins. |
| interface  | [INavigationItems](Serenity.Plugins/INavigationItems.md) | Abstraction for plugins with navigation entries |
| interface  | [IPlugin](Serenity.Plugins/IPlugin.md) | Abstraction for plugins |
| interface  | [IScriptFiles](Serenity.Plugins/IScriptFiles.md) | Abstraction for plugins with script file dependencies |
| class  | [NavigationEntry](Serenity.Plugins/NavigationEntry.md) | Plugin navigation entry abstraction. |
| class  | [PrecompiledViewsAttribute](Serenity.Plugins/PrecompiledViewsAttribute.md) | Indicates that this plugin assembly contains precompiled views (by RazorGenerator) |
| class  | [ScriptFile](Serenity.Plugins/ScriptFile.md) | Plugin script file registration |

## Serenity.Reflection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [AnnotationTypeExtensions](Serenity.Reflection/AnnotationTypeExtensions.md) | Extension methods for annotation types |
| class  | [AnnotationTypeRegistry](Serenity.Reflection/AnnotationTypeRegistry.md) | Default annotation type registry |
| class  | [AssemblySorter](Serenity.Reflection/AssemblySorter.md) | Sorts assemblies based on their dependencies |
| class  | [CodeWriter](Serenity.Reflection/CodeWriter.md) | Used to write formatted code to a string builder. |
| interface  | [IAnnotatedType](Serenity.Reflection/IAnnotatedType.md) | Annotated type information |
| interface  | [IAnnotationTypeRegistry](Serenity.Reflection/IAnnotationTypeRegistry.md) | An interface to query list of annotation types for a given type |
| interface  | [IPropertyInfo](Serenity.Reflection/IPropertyInfo.md) | An interface to virtualize property attribute access |
| class  | [WrappedProperty](Serenity.Reflection/WrappedProperty.md) | A class that basically implements IPropertyInfo for PropertyInfo objects |

## Serenity.Services namespace

| signature | name | description |
| --: | --- | --- |
| enum  | [ColumnSelection](Serenity.Services/ColumnSelection.md) | Column selection types for List services |
| interface  | [IIsSensitiveMessage](Serenity.Services/IIsSensitiveMessage.md) | An interface to determine if the message of an exception might contain sensitive information that should not be shown to the end user. Currently only ValidationError implements this and returns false by default unless set explicitly. |
| class  | [JsonStringHashSetConverter](Serenity.Services/JsonStringHashSetConverter.md) | Serialize/deserialize a IdentifierSet object as string |
| static class  | [PermissionExpressionParser](Serenity.Services/PermissionExpressionParser.md) | A simple parser / evaluator for logic permission expressions |
| class  | [ValidationError](Serenity.Services/ValidationError.md) | Generic validation error mostly used by services. |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| enum  | [ImageScaleMode](Serenity.Web/ImageScaleMode.md) | Thumbnail scaling modes |
| class  | [ImpersonatingUserAccessor](Serenity.Web/ImpersonatingUserAccessor.md) | Adds impersonation support to any IUserContext implementation |
| class  | [LogicOperatorPermissionService](Serenity.Web/LogicOperatorPermissionService.md) | Adds AND OR operator support to any IPermissionService implementation |
| class  | [TransientGrantingPermissionService](Serenity.Web/TransientGrantingPermissionService.md) | Adds temporary granting support to any IPermissionService implementation |