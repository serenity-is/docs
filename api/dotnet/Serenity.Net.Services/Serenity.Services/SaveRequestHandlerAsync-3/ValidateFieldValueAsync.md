# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateFieldValueAsync method

Checks the value of a field by a validation rule asynchronously, see CancellationToken).

```csharp
protected virtual ValueTask<string?> ValidateFieldValueAsync(Field field, ValidationAttribute rule, 
    object? value, ValidationContext context, CancellationToken cancellationToken)
```

| parameter | description |
| --- | --- |
| field | The field. |
| rule | The rule. |
| value | The value of the field. |
| context | The context, of the row, for the field. |
| cancellationToken | The cancellation token. |

## Return Value

The validation error message, or `null` if the value is valid.

## See Also

* class [Field](../../Serenity.Data/Field.md)
* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerAsync-3.md)