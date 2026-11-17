# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetValidationForm method

Gets the form the row is also validated by, see FormValidationAttribute: the one of the handler, else the one of the row, or null for none. It can be overridden to choose one, e.g. by what is saved, when the entity has more than one form.

```csharp
protected virtual Type? GetValidationForm()
```

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)