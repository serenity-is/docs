# StreamField.CompareValues method

Compares two values of this field using the specified comparer.

```csharp
protected override int CompareValues(Stream value1, Stream value2, IComparer? comparer)
```

| parameter | description |
| --- | --- |
| value1 | The first value. |
| value2 | The second value. |
| comparer | The comparer, or null to use the default comparer for the value type. |

## Return Value

A value indicating the relative order of the two values.

## Exceptions

| exception | condition |
| --- | --- |
| NotImplementedException | This method is not implemented. |

## See Also

* class [StreamField](../StreamField.md)