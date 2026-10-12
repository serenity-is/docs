# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.concurrencyVersion field

Gets the concurrency version used for the update operation, when the row implements [`IConcurrencyVersionRow`](../../Serenity.Data/IConcurrencyVersionRow.md). It is the value sent by the client when present, otherwise the value loaded from the database.

```csharp
protected object? concurrencyVersion;
```

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)