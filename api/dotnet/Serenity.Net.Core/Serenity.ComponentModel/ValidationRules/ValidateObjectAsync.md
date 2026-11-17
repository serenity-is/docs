# ValidationRules.ValidateObjectAsync method

Validates the properties of an object like [`ValidateObject`](./ValidateObject.md), awaiting the rules that can be checked asynchronously, see [`IAsyncValidationRule`](../IAsyncValidationRule.md).

```csharp
public static ValueTask<ObjectValidationFailure?> ValidateObjectAsync(object instance, 
    ObjectValidationOptions? options = null, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| instance | The object. |
| options | How it is validated. |
| cancellationToken | The cancellation token. |

## Return Value

The first property whose value is not valid, or null when they all are.

## See Also

* class [ObjectValidationFailure](../ObjectValidationFailure.md)
* class [ObjectValidationOptions](../ObjectValidationOptions.md)
* class [ValidationRules](../ValidationRules.md)