# GenericClassField&lt;TValue&gt;.CompareValues method

Compares two values of this field using the specified comparer.

```csharp
protected virtual int CompareValues(TValue value1, TValue value2, IComparer? comparer)
```

| parameter | description |
| --- | --- |
| value1 | The first value. |
| value2 | The second value. |
| comparer | The comparer, or null to use [`Comparer`](../Field/Comparer.md). |

## Return Value

A value indicating the relative order of the two values.

## See Also

* class [GenericClassField&lt;TValue&gt;](../GenericClassField-1.md)