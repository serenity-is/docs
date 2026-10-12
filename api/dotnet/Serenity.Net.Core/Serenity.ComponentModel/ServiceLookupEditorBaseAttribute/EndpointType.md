# ServiceLookupEditorBaseAttribute.EndpointType property

Gets or sets the endpoint type. If this is set, the service URL will be determined from the endpoint's route using [`ActionName`](./ActionName.md) method, or List or ListLookup actions if ActionName is not set.

```csharp
public Type? EndpointType { get; set; }
```

## See Also

* class [ServiceLookupEditorBaseAttribute](../ServiceLookupEditorBaseAttribute.md)