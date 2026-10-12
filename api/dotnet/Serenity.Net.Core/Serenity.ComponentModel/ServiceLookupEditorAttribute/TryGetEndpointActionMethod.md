# ServiceLookupEditorAttribute.TryGetEndpointActionMethod method

Tries to get an endpoint action method using the same action selection rules used when resolving a service URL.

```csharp
public static MethodInfo? TryGetEndpointActionMethod(Type endpoint, string? actionName)
```

| parameter | description |
| --- | --- |
| endpoint | The endpoint type. |
| actionName | The action name, or null to select ListLookup or List. |

## Return Value

The action method if found; otherwise, null.

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)