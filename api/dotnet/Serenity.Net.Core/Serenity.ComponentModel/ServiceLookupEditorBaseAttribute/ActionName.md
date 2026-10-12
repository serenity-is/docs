# ServiceLookupEditorBaseAttribute.ActionName property

Gets / sets the action name, e.g. List / ListLookup etc. to use. If this is null, the service will be determined from the endpoint's ListLookup or List actions, or defaults to "List" method if no endpoint is available.

```csharp
public string? ActionName { get; set; }
```

## See Also

* class [ServiceLookupEditorBaseAttribute](../ServiceLookupEditorBaseAttribute.md)