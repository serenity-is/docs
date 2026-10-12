# FunctionCallCriteria constructor

Criteria object that identifies a function call.

```csharp
protected FunctionCallCriteria(params BaseCriteria[] arguments)
```

| parameter | description |
| --- | --- |
| arguments | The arguments. |

## Remarks

Function-call criteria can be rendered to SQL and represented in criteria JSON. JSON deserialization resolves calls through [`FunctionCallCriteriaFactory`](../FunctionCallCriteriaFactory.md). The default factory supports only `UPPER`; safe request validators can impose stricter per-function argument rules.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteria](../FunctionCallCriteria.md)