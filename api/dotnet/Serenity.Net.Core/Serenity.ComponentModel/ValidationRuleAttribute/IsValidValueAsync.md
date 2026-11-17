# ValidationRuleAttribute.IsValidValueAsync method

Gets whether a value is valid asynchronously, by default by [`IsValidValue`](./IsValidValue.md). An empty value, i.e. null or an empty text, is valid without calling it. A rule that overrides it should still give [`IsValidValue`](./IsValidValue.md) a synchronous check, as the synchronous save handlers and other validators call that one.

```csharp
protected virtual ValueTask<bool> IsValidValueAsync(object? value, ValidationContext context, 
    CancellationToken cancellationToken)
```

| parameter | description |
| --- | --- |
| value | The value, which is not empty. |
| context | The context, e.g. for the other values of the object, or its services. |
| cancellationToken | The cancellation token. |

## See Also

* class [ValidationRuleAttribute](../ValidationRuleAttribute.md)