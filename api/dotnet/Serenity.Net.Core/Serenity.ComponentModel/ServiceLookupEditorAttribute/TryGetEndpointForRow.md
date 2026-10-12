# ServiceLookupEditorAttribute.TryGetEndpointForRow method

Tries to find the endpoint associated with a row type.

```csharp
public static Type? TryGetEndpointForRow(Type rowType, string? actionName, out string? service)
```

| parameter | description |
| --- | --- |
| rowType | The row type. |
| actionName | The optional action name. |
| service | The discovered service URL, if any. |

## Return Value

The endpoint type if a matching endpoint is found; otherwise, null.

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)