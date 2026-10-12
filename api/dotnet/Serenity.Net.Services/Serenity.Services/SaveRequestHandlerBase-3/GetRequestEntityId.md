# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.GetRequestEntityId method

Gets the id of the entity targeted by the current request, converted to the value type of the row's id field. Falls back to the row's own id when the request does not carry one. Used both for loading the previous entity and for building the error returned when it cannot be loaded, so that a caller cannot distinguish a missing record from one they are not allowed to touch.

```csharp
protected virtual object? GetRequestEntityId()
```

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)