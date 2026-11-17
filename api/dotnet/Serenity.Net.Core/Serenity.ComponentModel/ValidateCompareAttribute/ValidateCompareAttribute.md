# ValidateCompareAttribute constructor

Requires a value to be the same as the one of another property, e.g. a password and its confirmation, which the forms also check, with the field of that property.

```csharp
public ValidateCompareAttribute(string otherProperty)
```

| parameter | description |
| --- | --- |
| otherProperty | The name of the other property, e.g. `nameof(Password)`. |

## See Also

* class [ValidateCompareAttribute](../ValidateCompareAttribute.md)