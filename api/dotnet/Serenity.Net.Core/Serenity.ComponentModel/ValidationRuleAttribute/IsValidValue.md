# ValidationRuleAttribute.IsValidValue method

Gets whether a value is valid. An empty value, i.e. null or an empty text, is valid without calling it, as being required is [`RequiredAttribute`](../RequiredAttribute.md)'s concern.

```csharp
protected abstract bool IsValidValue(object? value, ValidationContext context)
```

| parameter | description |
| --- | --- |
| value | The value, which is not empty. |
| context | The context, e.g. for the other values of the object, or its services. |

## See Also

* class [ValidationRuleAttribute](../ValidationRuleAttribute.md)