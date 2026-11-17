# ObjectValidationFailure constructor

Why an object is not valid, see [`ValidateObject`](../ValidationRules/ValidateObject.md): the first property whose value is not.

```csharp
public ObjectValidationFailure(string propertyName, string? message)
```

| parameter | description |
| --- | --- |
| propertyName | The name of the property. |
| message | The message of the rule the value is not valid by, or null for a required value that is missing. |

## See Also

* class [ObjectValidationFailure](../ObjectValidationFailure.md)