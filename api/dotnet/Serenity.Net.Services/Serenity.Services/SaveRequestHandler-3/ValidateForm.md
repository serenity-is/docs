# SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateForm method

Validates the row by a form, i.e. by what the form checks in the browser that the row doesn't, see FormValidationAttribute. It is called for the form of [`GetValidationForm`](../SaveRequestHandlerBase-3/GetValidationForm.md), and can be called for others.

```csharp
protected virtual void ValidateForm(Type formType)
```

| parameter | description |
| --- | --- |
| formType | The type of the form. |

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A field is not valid by the form. |

## See Also

* class [SaveRequestHandler&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandler-3.md)