# ServiceLookupEditorAttribute.AutoServiceFor method

When service is null, this method first tries to determine the service URL from a matching endpoint for row types, then falls back to the module identifier and type name convention.

```csharp
public static string AutoServiceFor(Type itemType, string? actionName = null)
```

| parameter | description |
| --- | --- |
| itemType | Type to generate a service for. |
| actionName | Optional action name. |

## Return Value

Auto generated service.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown when *itemType* is null. |

## See Also

* class [ServiceLookupEditorAttribute](../ServiceLookupEditorAttribute.md)