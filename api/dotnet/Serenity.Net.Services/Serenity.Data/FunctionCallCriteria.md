# FunctionCallCriteria class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Criteria object that identifies a function call

```csharp
public abstract class FunctionCallCriteria : BaseCriteria
```

| parameter | description |
| --- | --- |
| arguments | The arguments. |

## Public Members

| name | description |
| --- | --- |
| [Arguments](FunctionCallCriteria/Arguments.md) { get; } | Gets the arguments. |
| abstract [GetFunctionName](FunctionCallCriteria/GetFunctionName.md)(…) | Gets the function name |
| override [ToString](FunctionCallCriteria/ToString.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [FunctionCallCriteria](FunctionCallCriteria/FunctionCallCriteria.md)(…) | Criteria object that identifies a function call |
| virtual [AppendArguments](FunctionCallCriteria/AppendArguments.md)(…) | Appends the arguments |
| virtual [AppendCloseParenthesis](FunctionCallCriteria/AppendCloseParenthesis.md)(…) | Appends the closing parenthesis |
| virtual [AppendFunctionName](FunctionCallCriteria/AppendFunctionName.md)(…) | Appends the function name |
| virtual [AppendOpenParenthesis](FunctionCallCriteria/AppendOpenParenthesis.md)(…) | Appends the opening parenthesis |

## See Also

* class [BaseCriteria](BaseCriteria.md)
* **Source:** *[FunctionCallCriteria.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Criteria/FunctionCallCriteria.cs)*