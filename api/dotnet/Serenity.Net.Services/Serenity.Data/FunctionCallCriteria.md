# FunctionCallCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Criteria object that identifies a function call.

```csharp
public abstract class FunctionCallCriteria : BaseCriteria
```

| parameter | description |
| --- | --- |
| arguments | The arguments. |

## Public Members

| name | description |
| --- | --- |
| [Arguments](FunctionCallCriteria/Arguments.md) { get; } | Gets a copy of the arguments. Mutating the returned array does not affect this instance. |
| abstract [GetFunctionName](FunctionCallCriteria/GetFunctionName.md)(…) | Gets the function name |
| override [ToString](FunctionCallCriteria/ToString.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [FunctionCallCriteria](FunctionCallCriteria/FunctionCallCriteria.md)(…) | Criteria object that identifies a function call. |
| virtual [AppendArguments](FunctionCallCriteria/AppendArguments.md)(…) | Appends the arguments |
| virtual [AppendCloseParenthesis](FunctionCallCriteria/AppendCloseParenthesis.md)(…) | Appends the closing parenthesis |
| virtual [AppendFunctionName](FunctionCallCriteria/AppendFunctionName.md)(…) | Appends the function name. |
| virtual [AppendOpenParenthesis](FunctionCallCriteria/AppendOpenParenthesis.md)(…) | Appends the opening parenthesis |
| virtual [CloneWithArguments](FunctionCallCriteria/CloneWithArguments.md)(…) | Creates a copy of this function criteria with the specified arguments. |

## Remarks

Function-call criteria can be rendered to SQL and represented in criteria JSON. JSON deserialization resolves calls through [`FunctionCallCriteriaFactory`](./FunctionCallCriteriaFactory.md). The default factory supports only `UPPER`; safe request validators can impose stricter per-function argument rules.

## See Also

* class [BaseCriteria](./BaseCriteria.md)
* **Source:** *[FunctionCallCriteria.cs](https://github.com/serenity-is/Serenity/blob/f3eca49ad489958e462afe254d2a02ea3b61aa6e/src/services/Data/Criteria/FunctionCallCriteria.cs)*