# FunctionCallCriteriaFactory class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Resolves function-call nodes read from criteria JSON.

```csharp
public static class FunctionCallCriteriaFactory
```

## Public Members

| name | description |
| --- | --- |
| static [Create](FunctionCallCriteriaFactory/Create.md)(…) | Creates a function-call criteria from its JSON name and parsed arguments. |
| static [SetFactories](FunctionCallCriteriaFactory/SetFactories.md)(…) | Sets the global factory registry, returning the previous snapshot. By default, supplied entries are merged over the existing factories; set *merge* to false to replace the registry. Pass null with *merge* false to clear all factories. The input is copied into an immutable, case-insensitive snapshot. The previous snapshot is returned and can be passed back to restore it. |
| static [SetLocalFactories](FunctionCallCriteriaFactory/SetLocalFactories.md)(…) | Sets the factory registry for the current async context. When set, it is exclusive of global factories. By default, the supplied factories are merged over the current global snapshot. Set *merge* to false to use only the supplied entries. Passing null clears the local registry and restores global lookup, regardless of *merge*. The supplied dictionary is copied into a read-only snapshot. |

## See Also

* **Source:** *[FunctionCallCriteriaFactory.cs](https://github.com/serenity-is/Serenity/blob/f3eca49ad489958e462afe254d2a02ea3b61aa6e/src/services/Data/Criteria/FunctionCallCriteriaFactory.cs)*