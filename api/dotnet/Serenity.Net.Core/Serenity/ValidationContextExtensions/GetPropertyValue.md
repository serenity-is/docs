# ValidationContextExtensions.GetPropertyValue method

Gets the value of another property of the object being validated, e.g. a row, for a rule on more than one field.

```csharp
public static object? GetPropertyValue(this ValidationContext context, string propertyName)
```

| parameter | description |
| --- | --- |
| context | The context. |
| propertyName | The name of the property. |

## Return Value

The value, or null when the object has no such property.

## See Also

* class [ValidationContextExtensions](../ValidationContextExtensions.md)