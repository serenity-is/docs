# Serenity.Extensions assembly

## Serenity.Abstractions namespace

| signature | name | description |
| --: | --- | --- |
| interface  | [IElevationHandler](Serenity.Abstractions/IElevationHandler.md) | Interface for account elevation. |

## Serenity.ComponentModel namespace

| signature | name | description |
| --: | --- | --- |
| class  | [RowEditActionsColumnAttribute](Serenity.ComponentModel/RowEditActionsColumnAttribute.md) | Marks a property as the row edit actions column in a grid editor. |

## Serenity.Data namespace

| signature | name | description |
| --: | --- | --- |
| interface  | [IRolePermissionRow](Serenity.Data/IRolePermissionRow.md) | Role permission row interface |
| interface  | [IUserPermissionRow](Serenity.Data/IUserPermissionRow.md) | User permission row interface |
| interface  | [IUserRoleRow](Serenity.Data/IUserRoleRow.md) | User role row interface |

## Serenity.Extensions namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [AccountPasswordActionsPageBase&lt;TUserRow&gt;](Serenity.Extensions/AccountPasswordActionsPageBase-1.md) | Base class for account password action pages, such as change password, set password, forgot password, and reset password. |
| abstract class  | [BasePermissionKeyLister](Serenity.Extensions/BasePermissionKeyLister.md) | Base class for permission key listers that enumerate permission keys from a type source, including nested, assembly, and type-level permissions. |
| abstract class  | [BasePermissionService&lt;TUserPermissionRow,TUserRoleRow&gt;](Serenity.Extensions/BasePermissionService-2.md) | Base permission service that provides common functionality for permission services. |
| abstract class  | [BasePermissionService](Serenity.Extensions/BasePermissionService.md) | Base permission service that provides common functionality for permission services. |
| abstract class  | [BaseRolePermissionService&lt;TRolePermissionRow&gt;](Serenity.Extensions/BaseRolePermissionService-1.md) | Base permission service that provides common functionality for permission services. |
| class  | [BaseTranslationOptions](Serenity.Extensions/BaseTranslationOptions.md) | Options for the translation feature. |
| abstract class  | [BaseUserRetrieveService&lt;TRow&gt;](Serenity.Extensions/BaseUserRetrieveService-1.md) | Base user retrieve service that provides common functionality for user retrieve services. |
| abstract class  | [BaseUserRetrieveService](Serenity.Extensions/BaseUserRetrieveService.md) | Base user retrieve service that provides common functionality for user retrieve services. |
| static class  | [BasicProgressDialogTexts](Serenity.Extensions/BasicProgressDialogTexts.md) | Local text keys for the basic progress dialog. |
| static class  | [BulkServiceActionTexts](Serenity.Extensions/BulkServiceActionTexts.md) | Local text keys for bulk service actions. |
| static class  | [ChangePasswordFormTexts](Serenity.Extensions/ChangePasswordFormTexts.md) | Local text keys for the change password form. |
| class  | [ChangePasswordRequest](Serenity.Extensions/ChangePasswordRequest.md) | The request model for a change password service. |
| static class  | [ChangePasswordValidationTexts](Serenity.Extensions/ChangePasswordValidationTexts.md) | Local text keys for change password validation. |
| class  | [ClamAVSettings](Serenity.Extensions/ClamAVSettings.md) | Settings for ClamAV |
| class  | [ClamAVUploadScanner](Serenity.Extensions/ClamAVUploadScanner.md) | Implementation of IUploadAVScanner which connects to ClamAV service |
| class  | [DefaultDBAttribute](Serenity.Extensions/DefaultDBAttribute.md) | Marks a migration to run on the default database. |
| class  | [DefaultElevationHandler](Serenity.Extensions/DefaultElevationHandler.md) | Default implementation of [`IElevationHandler`](Serenity.Abstractions/IElevationHandler.md) |
| class  | [DeleteRowActionFormatterAttribute](Serenity.Extensions/DeleteRowActionFormatterAttribute.md) | An attribute that sets the formatter type to `Serenity.Extensions.DeleteRowActionFormatter` and its options. |
| static class  | [DialogUtilsTexts](Serenity.Extensions/DialogUtilsTexts.md) | Local text keys for dialog utilities. |
| class  | [EmailSender](Serenity.Extensions/EmailSender.md) | Default implementation of [`IEmailSender`](Serenity.Extensions/IEmailSender.md) that sends emails via SMTP, a pickup folder, or an email queue. |
| static class  | [EmailSenderExtensions](Serenity.Extensions/EmailSenderExtensions.md) | Extension methods for [`IEmailSender`](Serenity.Extensions/IEmailSender.md). |
| class  | [EnumSelectFormatterAttribute](Serenity.Extensions/EnumSelectFormatterAttribute.md) | An attribute that sets the formatter type to `Serenity.Extensions.EnumSelectFormatter` and its options. |
| class  | [EnvironmentSettings](Serenity.Extensions/EnvironmentSettings.md) | Settings related to the environment the application runs in, such as the externally and internally accessible URLs of the web site. |
| class  | [ExcelImportRequest](Serenity.Extensions/ExcelImportRequest.md) | The request model for an Excel import service. |
| class  | [ExcelImportResponse](Serenity.Extensions/ExcelImportResponse.md) | The response model for an Excel import service. |
| static class  | [ExtensionsTexts](Serenity.Extensions/ExtensionsTexts.md) |  |
| class  | [ExtensionsTypeSource](Serenity.Extensions/ExtensionsTypeSource.md) | Base type source for apps using Serenity.Extensions assembly and its reference chain |
| static class  | [ForgotPasswordFormTexts](Serenity.Extensions/ForgotPasswordFormTexts.md) | Local text keys for the forgot password form. |
| class  | [ForgotPasswordRequest](Serenity.Extensions/ForgotPasswordRequest.md) | The request model for a forgot password service. |
| static class  | [GetNextNumberHelper](Serenity.Extensions/GetNextNumberHelper.md) | Helper for generating the next number in a sequence with a prefix. |
| class  | [GetNextNumberRequest](Serenity.Extensions/GetNextNumberRequest.md) | The request model for a get next number service. |
| class  | [GetNextNumberResponse](Serenity.Extensions/GetNextNumberResponse.md) | The response model for a get next number service. |
| interface  | [IEmailQueue](Serenity.Extensions/IEmailQueue.md) | Abstraction for an email queue that stores messages to be sent later. |
| interface  | [IEmailSender](Serenity.Extensions/IEmailSender.md) | Abstraction for sending email messages. |
| interface  | [ITranslateTextHandler](Serenity.Extensions/ITranslateTextHandler.md) | Interface for handlers that translate texts. |
| abstract class  | [MembershipPageBase&lt;TUserRow&gt;](Serenity.Extensions/MembershipPageBase-1.md) | Base class for membership pages that provides common helpers for password hashing, salt generation, and user lookup. |
| class  | [MembershipSettings](Serenity.Extensions/MembershipSettings.md) | Settings for membership. |
| abstract class  | [MigrationAttributeBase](Serenity.Extensions/MigrationAttributeBase.md) | Base attribute for migration attributes that validates the migration version format. |
| class  | [MigrationKeyAttribute](Serenity.Extensions/MigrationKeyAttribute.md) | Marks a migration with a version key. |
| static class  | [MigrationUtils](Serenity.Extensions/MigrationUtils.md) | Helper methods for FluentMigrator migrations, including table creation with identity keys and database type detection. |
| class  | [PasswordStrengthRules](Serenity.Extensions/PasswordStrengthRules.md) | The password strength rules. |
| class  | [PasswordStrengthRulesDataScript](Serenity.Extensions/PasswordStrengthRulesDataScript.md) | This declares a dynamic script with key 'PasswordStrengthRules' that will be available from client side. |
| static class  | [PasswordStrengthValidationTexts](Serenity.Extensions/PasswordStrengthValidationTexts.md) | Local text keys for password strength validation. |
| class  | [PasswordStrengthValidator](Serenity.Extensions/PasswordStrengthValidator.md) | Validates passwords against the configured password strength rules. |
| class  | [ReportTree](Serenity.Extensions/ReportTree.md) | A tree of report categories and reports. |
| class  | [ResetPasswordEmailModel](Serenity.Extensions/ResetPasswordEmailModel.md) | The model for the reset password email. |
| static class  | [ResetPasswordFormTexts](Serenity.Extensions/ResetPasswordFormTexts.md) | Local text keys for the reset password form. |
| class  | [ResetPasswordOptions](Serenity.Extensions/ResetPasswordOptions.md) | A class that mirrors the `ResetPasswordOptions` script type. |
| class  | [ResetPasswordRequest](Serenity.Extensions/ResetPasswordRequest.md) | The request model for a reset password service. |
| class  | [ResetPasswordResponse](Serenity.Extensions/ResetPasswordResponse.md) | The response model for a reset password service. |
| class  | [SendResetPasswordResponse](Serenity.Extensions/SendResetPasswordResponse.md) | The response model for a send reset password service. |
| static class  | [SetPasswordFormTexts](Serenity.Extensions/SetPasswordFormTexts.md) | Local text keys for the set password form. |
| class  | [SingleLineTextFormatterAttribute](Serenity.Extensions/SingleLineTextFormatterAttribute.md) | An attribute that sets the formatter type to `Serenity.Extensions.SingleLineTextFormatter` and its options. |
| class  | [SiteAbsoluteUrl](Serenity.Extensions/SiteAbsoluteUrl.md) | Default implementation for ISiteAbsoluteUrl |
| class  | [SmtpSettings](Serenity.Extensions/SmtpSettings.md) | Settings for SMTP email sending. |
| class  | [StaticTextBlockAttribute](Serenity.Extensions/StaticTextBlockAttribute.md) | An attribute that sets the editor type to `Serenity.Extensions.StaticTextBlock` and its options. |
| class  | [TargetDBAttribute](Serenity.Extensions/TargetDBAttribute.md) | Marks a migration to run only on the specified database type. |
| class  | [TranslateTextInput](Serenity.Extensions/TranslateTextInput.md) | A single text to be translated. |
| class  | [TranslateTextOutput](Serenity.Extensions/TranslateTextOutput.md) | A single translated text. |
| class  | [TranslateTextRequest](Serenity.Extensions/TranslateTextRequest.md) | The request model for translating one or more texts. |
| class  | [TranslateTextResponse](Serenity.Extensions/TranslateTextResponse.md) | The response model for a text translation request. |
| class  | [TranslationItem](Serenity.Extensions/TranslationItem.md) | Represents a single translation entry in the translation grid. |
| class  | [TranslationListRequest](Serenity.Extensions/TranslationListRequest.md) | The request model for listing translations. |
| class  | [TranslationListResponse](Serenity.Extensions/TranslationListResponse.md) | The response model for a translation list request. |
| static class  | [TranslationTexts](Serenity.Extensions/TranslationTexts.md) | Local text keys for the translation module. |
| class  | [TranslationUpdateRequest](Serenity.Extensions/TranslationUpdateRequest.md) | The request model for updating user translations. |
| class  | [TranslationUpdateResponse](Serenity.Extensions/TranslationUpdateResponse.md) | The response model for a translation update request. |
| class  | [UserPreferenceRetrieveRequest](Serenity.Extensions/UserPreferenceRetrieveRequest.md) | The request model for retrieving a user preference. |
| class  | [UserPreferenceRetrieveResponse](Serenity.Extensions/UserPreferenceRetrieveResponse.md) | The response model for retrieving a user preference. |
| class  | [UserPreferenceUpdateRequest](Serenity.Extensions/UserPreferenceUpdateRequest.md) | The request model for updating a user preference. |

## Serenity.Extensions.DependencyInjection namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ClamAVUploadServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ClamAVUploadServiceCollectionExtensions.md) | DI extension methods related to ClamAVUploadScanner |
| static class  | [ElevationServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ElevationServiceCollectionExtensions.md) | Contains extensions to register elevation services in Extensions |
| static class  | [EmailServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/EmailServiceCollectionExtensions.md) | Contains extensions to register email services in Extensions |
| static class  | [PasswordStrengthServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/PasswordStrengthServiceCollectionExtensions.md) | Contains extensions to register password streng validator in Extensions |
| static class  | [ReportingServiceCollectionExtensions](Serenity.Extensions.DependencyInjection/ReportingServiceCollectionExtensions.md) | Contains extensions to register reporting services in Extensions |

## Serenity.Extensions.Endpoints namespace

| signature | name | description |
| --: | --- | --- |
| class  | [UserPreferenceEndpoint](Serenity.Extensions.Endpoints/UserPreferenceEndpoint.md) | Service endpoint for managing user preferences. |

## Serenity.Extensions.Entities namespace

| signature | name | description |
| --: | --- | --- |
| abstract class  | [LoggingRow&lt;TFields&gt;](Serenity.Extensions.Entities/LoggingRow-1.md) | This is a sample base class for rows that does insert/update date and user audit logging automatically. It is recommended to create your own base class, if your auditing field names are different than these. You should implement IInsertLogRow and/or IUpdateLogRow interfaces. ILoggingRow is a combination of these two. There is also an optional IDeleteLogRow interface that supports auditing on delete but for it to work you need to also implement IIsActiveDeletedRow so that your rows aren't actually deleted. |
| class  | [LoggingRowFields](Serenity.Extensions.Entities/LoggingRowFields.md) | Fields for a [`LoggingRow`](Serenity.Extensions.Entities/LoggingRow-1.md). |
| class  | [UserPreferenceRow](Serenity.Extensions.Entities/UserPreferenceRow.md) | Row for user preferences. |

## Serenity.Extensions.MVC namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ESM](Serenity.Extensions.MVC/ESM.md) | Provides paths to ECMAScript module entry points. |
| static class  | [Views](Serenity.Extensions.MVC/Views.md) | Provides paths to view files. |

## Serenity.Extensions.Pages namespace

| signature | name | description |
| --: | --- | --- |
| class  | [ReportController](Serenity.Extensions.Pages/ReportController.md) | Controller for rendering and downloading reports. |

## Serenity.Extensions.Repositories namespace

| signature | name | description |
| --: | --- | --- |
| class  | [UserPreferenceRepository](Serenity.Extensions.Repositories/UserPreferenceRepository.md) | Repository for managing user preferences. |

## Serenity.Reporting namespace

| signature | name | description |
| --: | --- | --- |
| class  | [DataReportExcelRenderer](Serenity.Reporting/DataReportExcelRenderer.md) | Default implementation of IDataReportExcelRenderer that renders a data report to an Excel package. |
| class  | [DefaultReportRetrieveHandler](Serenity.Reporting/DefaultReportRetrieveHandler.md) | Default implementation for report retrieve handler |
| class  | [DefaultReportTreeFactory](Serenity.Reporting/DefaultReportTreeFactory.md) | Default implementation of [`IReportTreeFactory`](Serenity.Reporting/IReportTreeFactory.md). |
| class  | [ExcelExporter](Serenity.Reporting/ExcelExporter.md) | Default implementation of IExcelExporter that exports data to Excel. |
| static class  | [ExcelReportGenerator](Serenity.Reporting/ExcelReportGenerator.md) | Helper for generating Excel packages from report columns and data. |
| class  | [HtmlReportCallbackUrlBuilder](Serenity.Reporting/HtmlReportCallbackUrlBuilder.md) | Default implementation for IHtmlReportRenderUrlBuilder |
| class  | [HtmlReportCallbackUrlInterceptor](Serenity.Reporting/HtmlReportCallbackUrlInterceptor.md) | Implementation for IReportCallbackInterceptor that uses callback report cookie to impersonate / transient grant permissions |
| class  | [HtmlReportPdfRenderer](Serenity.Reporting/HtmlReportPdfRenderer.md) | Default implementation for IHtmlReportPdfRenderer |
| interface  | [IReportTreeFactory](Serenity.Reporting/IReportTreeFactory.md) | Abstraction for a factory that builds report trees. |
| class  | [ReportRetrieveResult](Serenity.Reporting/ReportRetrieveResult.md) | Extending Serenity ReportRetrieveResponse class to add extra information |

## Serenity.Web namespace

| signature | name | description |
| --: | --- | --- |
| static class  | [ModulePageExtensions](Serenity.Web/ModulePageExtensions.md) | Extension methods for creating module and grid pages from controllers. |
| class  | [ModulePageModel](Serenity.Web/ModulePageModel.md) | The model for a module page. |
| class  | [ModulePageResult](Serenity.Web/ModulePageResult.md) | The result of a module page action, which renders a module page view. |
| class  | [RequiresElevationAttribute](Serenity.Web/RequiresElevationAttribute.md) | Used for critical methods that needs additional authentication. Like account link/unlinking. |