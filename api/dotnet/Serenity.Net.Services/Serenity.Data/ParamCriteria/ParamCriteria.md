# ParamCriteria constructor

Initializes a new instance of the [`ParamCriteria`](../ParamCriteria.md) class.

```csharp
public ParamCriteria(string name)
```

| parameter | description |
| --- | --- |
| name | The parameter name. Should not start with @. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty |
| ArgumentOutOfRangeException | name starts with @. |

## See Also

* class [ParamCriteria](../ParamCriteria.md)