# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.FieldValidationError method

Creates the error of a field whose value is not valid by one of its rules.

```csharp
protected static ValidationError FieldValidationError(Field field, string message)
```

| parameter | description |
| --- | --- |
| field | The field. |
| message | The message of the rule. |

## See Also

* class [ValidationError](../../../Serenity.Net.Core/Serenity.Services/ValidationError.md)
* class [Field](../../Serenity.Data/Field.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)