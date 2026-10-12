# BaseCriteria LogicalNot operator

Implements the operator !.

```csharp
public static BaseCriteria operator !(BaseCriteria criteria)
```

| parameter | description |
| --- | --- |
| criteria | The criteria. |

## Return Value

The result of the operator.

## Remarks

Builds SQL NOT criteria; it does not evaluate the criteria as a Boolean value.

## See Also

* class [BaseCriteria](../BaseCriteria.md)