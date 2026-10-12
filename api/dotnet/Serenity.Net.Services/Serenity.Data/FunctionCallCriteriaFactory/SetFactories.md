# FunctionCallCriteriaFactory.SetFactories method

Sets the global factory registry, returning the previous snapshot. By default, supplied entries are merged over the existing factories; set *merge* to false to replace the registry. Pass null with *merge* false to clear all factories. The input is copied into an immutable, case-insensitive snapshot. The previous snapshot is returned and can be passed back to restore it.

```csharp
public static IReadOnlyDictionary<string, Func<BaseCriteria[], FunctionCallCriteria?>> SetFactories(
    IReadOnlyDictionary<string, Func<BaseCriteria[], FunctionCallCriteria?>>? factories, 
    bool merge = true)
```

| parameter | description |
| --- | --- |
| factories | New factories, or null when replacing with an empty registry. |
| merge | True to merge over the current factories; false to replace them. |

## Return Value

The previous factory snapshot.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteria](../FunctionCallCriteria.md)
* class [FunctionCallCriteriaFactory](../FunctionCallCriteriaFactory.md)