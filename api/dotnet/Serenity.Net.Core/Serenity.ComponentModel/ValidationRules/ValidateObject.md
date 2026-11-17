# ValidationRules.ValidateObject method

Validates the properties of an object by what the properties of its type, or of the [`RulesType`](../ObjectValidationOptions/RulesType.md), e.g. a form, declare: [`RequiredAttribute`](../RequiredAttribute.md), [`RequiredWhenAttribute`](../RequiredWhenAttribute.md) and the validation rules, like [`ValidateRangeAttribute`](../ValidateRangeAttribute.md). As in the browser, a property that is hidden, by [`VisibleAttribute`](../VisibleAttribute.md), on insert or update, or by its [`VisibleWhenAttribute`](../VisibleWhenAttribute.md)s, or is read only, by ReadOnlyAttribute or its [`ReadOnlyWhenAttribute`](../ReadOnlyWhenAttribute.md)s, is not checked, and neither is a rule only checked by the forms.

```csharp
public static ObjectValidationFailure? ValidateObject(object instance, 
    ObjectValidationOptions? options = null)
```

| parameter | description |
| --- | --- |
| instance | The object, e.g. a row, whose properties are read by the names of the ones of the rules type. |
| options | How it is validated. |

## Return Value

The first property whose value is not valid, or null when they all are.

## See Also

* class [ObjectValidationFailure](../ObjectValidationFailure.md)
* class [ObjectValidationOptions](../ObjectValidationOptions.md)
* class [ValidationRules](../ValidationRules.md)