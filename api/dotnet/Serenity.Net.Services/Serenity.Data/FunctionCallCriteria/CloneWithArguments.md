# FunctionCallCriteria.CloneWithArguments method

Creates a copy of this function criteria with the specified arguments.

```csharp
protected internal virtual FunctionCallCriteria CloneWithArguments(BaseCriteria[] arguments)
```

| parameter | description |
| --- | --- |
| arguments | The arguments for the copy. |

## Return Value

A copy of this function criteria.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | arguments is null. |

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [FunctionCallCriteria](../FunctionCallCriteria.md)