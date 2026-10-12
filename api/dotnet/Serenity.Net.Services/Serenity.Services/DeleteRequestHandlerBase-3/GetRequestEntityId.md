# DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;.GetRequestEntityId method

Gets the id of the entity targeted by the current request, converted to the value type of the row's id field. Used both for loading the entity and for building the error returned when it cannot be loaded, so that a caller cannot distinguish a missing record from one they are not allowed to touch.

```csharp
protected virtual object? GetRequestEntityId()
```

## See Also

* class [DeleteRequestHandlerBase&lt;TRow,TDeleteRequest,TDeleteResponse&gt;](../DeleteRequestHandlerBase-3.md)