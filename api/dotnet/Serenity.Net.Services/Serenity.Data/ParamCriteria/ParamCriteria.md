# ParamCriteria constructor

A criteria object containing a parameter name

```csharp
public ParamCriteria(string name)
```

| parameter | description |
| --- | --- |
| name | The parameter name. Should start with @. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty |
| ArgumentOutOfRangeException | name doesn't start with "@", or has nothing but whitespace after it. |

## Remarks

Initializes a new instance of the [`ParamCriteria`](../ParamCriteria.md) class.

## See Also

* class [BaseCriteria](../BaseCriteria.md)
* class [ParamCriteria](../ParamCriteria.md)