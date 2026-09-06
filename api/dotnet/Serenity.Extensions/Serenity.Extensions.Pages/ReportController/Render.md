# ReportController.Render method

Renders a report with the specified key and options.

```csharp
public ActionResult Render(string key, string opt, string ext, int? print = 0)
```

| parameter | description |
| --- | --- |
| key | The report key. |
| opt | The report parameters. |
| ext | The export format extension. |
| print | Whether to render in print mode. |

## Return Value

The report render result.

## See Also

* class [ReportController](../ReportController.md)