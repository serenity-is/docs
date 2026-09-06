# ReportRenderOptions.ReportParams property

The set of report params usually a serialized JSON object to be passed to the URL callback. These params should already be applied to the passed report instance. Will be ignored if the report is rendered directly, e.g. without a callback.

```csharp
public string ReportParams { get; set; }
```

## See Also

* class [ReportRenderOptions](../ReportRenderOptions.md)