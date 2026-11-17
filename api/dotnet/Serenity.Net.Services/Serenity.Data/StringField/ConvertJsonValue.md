# StringField.ConvertJsonValue method

Converts or validates a non-null string value read from JSON before it is set on the row. It is not called for a JSON null. Derived fields can override it to reject a value by throwing, in which case the row is left unassigned for this field.

```csharp
protected virtual string? ConvertJsonValue(string? value)
```

| parameter | description |
| --- | --- |
| value | The value read from JSON. |

## Return Value

The value to set, which is the value itself by default.

## See Also

* class [StringField](../StringField.md)