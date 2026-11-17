# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.CreateFormValidationOptions method

Creates the options the row is validated by a form with: the values of its fields by the names of the properties of the form, of the request or else of the old row, for the conditions of the form, only checking the fields of the request on an update, like the required fields are.

```csharp
protected virtual ObjectValidationOptions CreateFormValidationOptions(Type formType)
```

| parameter | description |
| --- | --- |
| formType | The type of the form. |

## See Also

* class [ObjectValidationOptions](../../../Serenity.Net.Core/Serenity.ComponentModel/ObjectValidationOptions.md)
* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)