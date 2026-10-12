# FunctionCallCriteriaFactory.Create method

Creates a function-call criteria from its JSON name and parsed arguments.

```csharp
public static FunctionCallCriteria? Create(string functionName, BaseCriteria[] arguments)
```

| parameter | description |
| --- | --- |
| functionName | The serialized function name. |
| arguments | The parsed arguments. |

## Return Value

The function criteria, or null when this function isn't supported.

## See Also

* class [FunctionCallCriteria](../FunctionCallCriteria.md)
* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteriaFactory](../FunctionCallCriteriaFactory.md)