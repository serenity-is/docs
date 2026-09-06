# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.CustomValidate method

Calls custom validator.

```csharp
protected virtual string CustomValidate(RowValidationContext context, Field field, 
    ICustomValidator validator)
```

| parameter | description |
| --- | --- |
| context | Validation context |
| field | Field |
| validator | Custom validator |

## Return Value

The validation error message, or `null` if the value is valid.

## See Also

* class [RowValidationContext](../RowValidationContext.md)
* class [Field](../../Serenity.Data/Field.md)
* interface [ICustomValidator](../../Serenity/ICustomValidator.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)