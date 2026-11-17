# SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateFormAsync method

Validates the row by a form, i.e. by what the form checks in the browser that the row doesn't, see FormValidationAttribute, awaiting the rules that can be checked asynchronously. It is called for the form of [`GetValidationForm`](../SaveRequestHandlerBase-3/GetValidationForm.md), and can be called for others.

```csharp
protected virtual Task ValidateFormAsync(Type formType, 
    CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| formType | The type of the form. |
| cancellationToken | The cancellation token. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A field is not valid by the form. |

## See Also

* class [SaveRequestHandlerAsync&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerAsync-3.md)