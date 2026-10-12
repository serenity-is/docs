# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.CaptureConcurrencyVersion method

Captures the concurrency version used for the update, if the row implements [`IConcurrencyVersionRow`](../../Serenity.Data/IConcurrencyVersionRow.md), before editable field validation clears non editable assignments. The value sent by the client is used when present, otherwise the value loaded from the database. The captured value is later used to append the version to the update's WHERE clause.

```csharp
protected virtual void CaptureConcurrencyVersion()
```

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)