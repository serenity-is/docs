# HtmlReportCallbackUrlInterceptor constructor
**namespace:** *[Serenity.Reporting](../../README.md#serenity.reporting-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Implementation for IReportCallbackInterceptor that uses callback report cookie to impersonate / transient grant permissions

```csharp
public HtmlReportCallbackUrlInterceptor(ILogger<HtmlReportCallbackUrlBuilder> logger, 
    IPermissionService permissionService = null, IUserAccessor userAccessor = null, 
    IUserClaimCreator userClaimCreator = null, IHttpContextAccessor httpContextAccessor = null, 
    IDataProtectionProvider dataProtectionProvider = null)
```

## See Also

* class [HtmlReportCallbackUrlBuilder](../HtmlReportCallbackUrlBuilder.md)
* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [IUserAccessor](../Serenity.Net.Core/../../Serenity.Abstractions/IUserAccessor.md)
* interface [IUserClaimCreator](../Serenity.Net.Core/../../Serenity.Abstractions/IUserClaimCreator.md)
* class [HtmlReportCallbackUrlInterceptor](../HtmlReportCallbackUrlInterceptor.md)