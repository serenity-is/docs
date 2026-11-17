# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateFieldValuesAsync method

Validates the values of the assigned fields by the validation rules of their properties, like [`ValidateFieldValues`](../SaveRequestHandler-3/ValidateFieldValues.md), awaiting the rules that can be checked asynchronously, see IAsyncValidationRule.

```csharp
protected virtual Task ValidateFieldValuesAsync(CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| cancellationToken | The cancellation token. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | One of the fields has an invalid value |

## See Also

* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerAsync-3.md)