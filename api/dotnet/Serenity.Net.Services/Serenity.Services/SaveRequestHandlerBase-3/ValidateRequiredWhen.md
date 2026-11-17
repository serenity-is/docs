# SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;.ValidateRequiredWhen method

Validates the fields of the row that are required by their RequiredWhenAttributes, which, unlike a RequiredAttribute of a row, are checked on the server too, as the conditions are not something the database can tell. Like the required fields and the validation by a form, an update only checks the fields it has, with the conditions reading the old values of the ones it doesn't, and a field the form hides or makes read only by the attributes of the row is not checked.

```csharp
protected virtual void ValidateRequiredWhen()
```

## Exceptions

| exception | condition |
| --- | --- |
| ValidationError | A field required by its conditions has no value. |

## See Also

* class [SaveRequestHandlerBase&lt;TRow,TSaveRequest,TSaveResponse&gt;](../SaveRequestHandlerBase-3.md)