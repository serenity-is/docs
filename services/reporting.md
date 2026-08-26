# Reporting

Serenity has a server-side reporting system for generating HTML, PDF, Excel, and CSV output from your data. A report is a plain class that implements `IReport`; the framework provides a registry, factory, renderer, and HTML-to-PDF converters to turn it into a downloadable file.

## Defining a Report

A report is any class implementing [`IReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReport.md), which has a single `GetData()` method. Mark it with [`[Report]`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportAttribute.md) so the registry discovers it, and optionally `[Category]`, `[DisplayName]`, and `[RequiredPermission]`:

```cs
[Report, RequiredPermission(PermissionKeys.General)]
[Category("Northwind/Orders"), DisplayName("Customer Gross Sales")]
public class CustomerGrossSalesReport(ISqlConnections sqlConnections, ITextLocalizer localizer, IServiceProvider serviceProvider) : IReport, IDataOnlyReport
{
    [DisplayName("Start Date")]
    public DateTime? StartDate { get; set; }

    [DisplayName("End Date")]
    public DateTime? EndDate { get; set; }

    public object GetData()
    {
        using var connection = SqlConnections.NewFor<SalesByCategoryRow>();
        return connection.Query<Item>("CustomerGrossSales",
            param: new { startDate = StartDate, endDate = EndDate },
            commandType: System.Data.CommandType.StoredProcedure);
    }

    public List<ReportColumn> GetColumnList()
    {
        return ReportColumnConverter.ObjectTypeToList(typeof(Item), ServiceProvider, Localizer);
    }

    [BasedOnRow(typeof(CustomerGrossSalesRow), CheckNames = true)]
    public class Item
    {
        public string CustomerId { get; set; }
        public string ContactName { get; set; }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        [CellDecorator(typeof(AmountDecorator))]
        public decimal GrossAmount { get; set; }
    }

    public class AmountDecorator : BaseCellDecorator
    {
        public override void Decorate()
        {
            var item = Item as Item;
            if (item.GrossAmount > 1000)
                Foreground = "#ff0000";
            else if (item.GrossAmount > 500)
                Foreground = "#ffa500";
        }
    }
}
```

This is the Northwind `CustomerGrossSalesReport` — a data-only report (Excel/CSV). Public properties like `StartDate`/`EndDate` are the report parameters, shown in the report dialog and populated by the factory.

[`BaseReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/BaseReport.md) is a convenient base class that also implements [`IReportWithAdditionalData`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportWithAdditionalData.md) (for reports that return extra datasets).

## Report Factory

[`IReportFactory`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportFactory.md) creates a report instance by its key and populates it from JSON parameters. [`ReportFactoryExtensions.Create<TReport>()`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportFactoryExtensions.md) is the typed helper:

```cs
var report = reportFactory.Create<CustomerGrossSalesReport>(r => {
    r.StartDate = new DateTime(2024, 1, 1);
    r.EndDate = new DateTime(2024, 12, 31);
});
```

## Report Registry

[`IReportRegistry`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportRegistry.md) (implemented by [`ReportRegistry`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportRegistry.md)) discovers all `[Report]`-marked types from the type source and groups them by `[Category]`. It also enforces the report's `[RequiredPermission]` — `GetAvailableReportsInCategory` only returns reports the current user can access.

## Data-Only Reports (Excel / CSV)

[`IDataOnlyReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IDataOnlyReport.md) marks a report that has no design — just data and columns, used for Excel/CSV export. [`TabularDataReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/TabularDataReport.md) is a ready-made implementation that takes an `IEnumerable` of data plus either a list of [`ReportColumn`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportColumn.md)s or a columns type.

[`IExcelExporter`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IExcelExporter.md) exports data to an Excel file, deriving columns from a columns type via [`ReportColumnConverter`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportColumnConverter.md). The [`GenerateCsvRequest`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/GenerateCsvRequest.md) and [`GenerateExcelFileRequest`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/GenerateExcelFileRequest.md) models are the request shapes for the CSV/Excel export endpoints.

## Cell Decorators

[`ICellDecorator`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ICellDecorator.md) lets you style individual cells during Excel export (background, foreground, format). Derive from [`BaseCellDecorator`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/BaseCellDecorator.md) and attach it to a column with [`[CellDecorator]`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/CellDecoratorAttribute.md) — see the `AmountDecorator` example above. [`EnumDecorator`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/EnumDecorator.md) is a built-in decorator that displays enum values by their description.

## Report Rendering

[`IReportRenderer`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportRenderer.md) renders a report to a file. It takes the report and [`ReportRenderOptions`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportRenderOptions.md) (preview mode, report key/params, export format) and returns a [`ReportRenderResult`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportRenderResult.md) with the content bytes, file name, extension, and MIME type.

- [`[ReportDesign]`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ReportDesignAttribute.md) — points an HTML report at its CSHTML design file.
- [`ICustomFileName`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ICustomFileName.md) / [`ICustomTitle`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ICustomTitle.md) — customize the output file name / report title.
- [`IReportCallbackInterceptor`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportCallbackInterceptor.md) — intercepts render callbacks (used for impersonation during report rendering).

## HTML → PDF

[`IHtmlToPdfConverter`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IHtmlToPdfConverter.md) converts HTML to PDF using an [`IHtmlToPdfOptions`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IHtmlToPdfOptions.md) (URL, cookies, page size, margins, etc.). An HTML report implements [`ICustomizeHtmlToPdf`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/ICustomizeHtmlToPdf.md) to tweak those options:

```cs
[Report("Northwind.OrderDetail")]
[ReportDesign(MVC.Views.Order.OrderDetailReport)]
[RequiredPermission(PermissionKeys.General)]
public class OrderDetailReport(ISqlConnections sqlConnections) : IReport, ICustomizeHtmlToPdf
{
    public int OrderID { get; set; }

    public object GetData() { /* ... */ }

    public void Customize(IHtmlToPdfOptions options)
    {
        options.MarginsAll = "2cm";
    }
}
```

The open-source framework ships a WKHTML-to-PDF converter (`WKHtmlToPdfConverter`), registered by `AddHtmlToPdf()` (part of `AddReporting()`). The [`[UseWKHtmlToPdf]`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/UseWKHtmlToPdfAttribute.md) attribute (and the obsolete `[UseChromeHtmlToPdf]`) lets a report opt into a specific converter.

## The Report Callback Mechanism

HTML reports are rendered to PDF by a headless browser (WKHTML or Puppeteer) that runs on the server. The converter doesn't render the report directly — it **calls back into the web site** to fetch the report's HTML, then prints that page to PDF. The callback URL points at the report render action (`Serenity.Extensions/Report/Render`) with the report key and parameters.

The callback URL is built by [HtmlReportCallbackUrlBuilder](../api/dotnet/Serenity.Extensions/Serenity.Reporting/HtmlReportCallbackUrlBuilder.md) (the default [IHtmlReportRenderUrlBuilder](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IHtmlReportRenderUrlBuilder.md)), which resolves the site's **internal** URL through `ISiteAbsoluteUrl.GetInternalUrl()`. It also forwards the current user's authentication and language cookies (plus a short-lived report auth cookie) so the callback renders the report with the same permissions.

### `ISiteAbsoluteUrl` and `SiteAbsoluteUrl`

[`ISiteAbsoluteUrl`](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/ISiteAbsoluteUrl.md) provides the absolute base URL of the site (including the path base). It has two methods:

- `GetInternalUrl()` — the internal/local URL used for report callbacks (and similar server-to-self requests).
- `GetExternalUrl()` — the external/public URL used for links in emails etc.

The default implementation, [`SiteAbsoluteUrl`](../api/dotnet/Serenity.Extensions/Serenity.Extensions/SiteAbsoluteUrl.md), resolves them as follows:

| Method | Resolution order |
| --- | --- |
| `GetInternalUrl()` | 1. `EnvironmentSettings:SiteInternalUrl` → 2. current HTTP request base URL → 3. `EnvironmentSettings:SiteExternalUrl` |
| `GetExternalUrl()` | 1. current HTTP request base URL → 2. `EnvironmentSettings:SiteExternalUrl` |

If neither setting is available and there's no HTTP request, both methods throw with a message telling you to configure `EnvironmentSettings`.

### `EnvironmentSettings`

[`EnvironmentSettings`](../api/dotnet/Serenity.Extensions/Serenity.Extensions/EnvironmentSettings.md) is read from the `EnvironmentSettings` section of `appsettings.json`:

```json
{
  "EnvironmentSettings": {
    "SiteExternalUrl": "https://myapp.example.com/",
    "SiteInternalUrl": "http://localhost:5050/"
  }
}
```

- `SiteExternalUrl` — the publicly accessible URL, used for link generation in emails etc. `GetExternalUrl()` uses it only when no HTTP request is available.
- `SiteInternalUrl` — the internally accessible, local-network URL, used for report tools to call back into the site. `GetInternalUrl()` prefers it over the current request's base URI and the external URL.

> **Why `SiteInternalUrl` matters:** when the site is behind a reverse proxy or load balancer, the public URL may not be reachable from the server itself. The headless browser used for PDF rendering runs on the server, so it must call back through a URL the server can reach — that's what `SiteInternalUrl` provides. If it's not set, the callback falls back to the current request's base URL (which is usually fine in development).

`ISiteAbsoluteUrl` is registered by `AddHtmlToPdf()` (part of `AddReporting()`):

```cs
services.TryAddSingleton<ISiteAbsoluteUrl, SiteAbsoluteUrl>();
```

## PuppeteerHtmlToPdf (StartSharp)

StartSharp replaces the WKHTML converter with **PuppeteerHtmlToPdf**, which renders PDFs with a headless Chrome (or Firefox) browser via PuppeteerSharp. It's part of **Serenity.Pro.Extensions** (premium, StartSharp only).

`PuppeteerHtmlToPdfConverter` implements `IHtmlToPdfConverter`. It launches a headless browser, navigates to the report URL, and prints it to PDF. Like the WKHTML converter, it fetches the report HTML through the [callback mechanism](#the-report-callback-mechanism) described above, so the `EnvironmentSettings` internal/external URL configuration applies to it too. On first use it downloads the browser (Chrome by default) into `App_Data/chrome` (or `App_Data/firefox`) unless an executable path is configured.

### Initialization in Startup.cs

In StartSharp's `Startup.cs`, `AddPuppeteerHtmlToPdf()` is called right before `AddReporting()`:

```cs
services.AddPuppeteerHtmlToPdf()
    .AddReporting();
```

`AddPuppeteerHtmlToPdf()` registers `PuppeteerHtmlToPdfConverter` as the `IHtmlToPdfConverter` implementation:

```cs
public static IServiceCollection AddPuppeteerHtmlToPdf(this IServiceCollection collection)
{
    collection.TryAddSingleton<IHtmlToPdfConverter, PuppeteerHtmlToPdfConverter>();
    return collection;
}
```

Because it's registered before `AddReporting()` (which would otherwise register the WKHTML converter), the Puppeteer converter is the active `IHtmlToPdfConverter` in StartSharp.

### Configuration

`PuppeteerHtmlToPdfSettings` is read from the `PuppeteerHtmlToPdf` section of `appsettings.json`:

```json
{
  "PuppeteerHtmlToPdf": {
    "Product": "Chrome",
    "DownloadPath": "App_Data/chrome",
    "ExecutablePath": "",
    "CustomArgs": ["--no-sandbox"]
  }
}
```

- `Product` — `Chrome` (default) or `Firefox`.
- `DownloadPath` — where the browser is downloaded via PuppeteerSharp's `BrowserFetcher` (defaults to `App_Data/chrome` or `App_Data/firefox` under the content root).
- `ExecutablePath` — use an already-installed browser executable instead of downloading one.
- `CustomArgs` — extra command-line arguments passed to the browser.

## See Also

- [Service Endpoints](service_endpoints.md)
- [Service Models](service-models.md)
- [Uploads](upload.md)
- API reference: [`IReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReport.md),
  [`IReportFactory`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportFactory.md),
  [`IReportRegistry`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportRegistry.md),
  [`IDataOnlyReport`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IDataOnlyReport.md),
  [`IReportRenderer`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IReportRenderer.md),
  [`IHtmlToPdfConverter`](../api/dotnet/Serenity.Net.Services/Serenity.Reporting/IHtmlToPdfConverter.md)