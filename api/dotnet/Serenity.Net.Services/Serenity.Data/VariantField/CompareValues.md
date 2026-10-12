# VariantField.CompareValues method

Compares two values of this field using the specified comparer.

```csharp
protected override int CompareValues(object value1, object value2, IComparer? comparer)
```

| parameter | description |
| --- | --- |
| value1 | The first value. |
| value2 | The second value. |
| comparer | The comparer, or null to use the default comparer for the value type. |

## Return Value

A value indicating the relative order of the two values.

## See Also

* class [VariantField](../VariantField.md)