# FunctionCallCriteriaFactory.SetLocalFactories method

Sets the factory registry for the current async context. When set, it is exclusive of global factories. By default, the supplied factories are merged over the current global snapshot. Set *merge* to false to use only the supplied entries. Passing null clears the local registry and restores global lookup, regardless of *merge*. The supplied dictionary is copied into a read-only snapshot.

```csharp
public static IReadOnlyDictionary<string, Func<BaseCriteria[], FunctionCallCriteria?>>? 
    SetLocalFactories(
    IReadOnlyDictionary<string, Func<BaseCriteria[], FunctionCallCriteria?>>? factories, 
    bool merge = true)
```

| parameter | description |
| --- | --- |
| factories | Local factories, or null to return to global factories. |
| merge | True to merge with global factories; false to replace them locally. |

## Return Value

The previous local registry, if any.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteria](../FunctionCallCriteria.md)
* class [FunctionCallCriteriaFactory](../FunctionCallCriteriaFactory.md)