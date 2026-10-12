# Parameter constructor

Parameter struct.

```csharp
public Parameter(string name)
```

| parameter | description |
| --- | --- |
| name | The name. Must start with "@": parameter names are always "@"-prefixed, and dialect translation happens later when the command is built (see SqlHelper.AddParamWithValue). |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty. |
| ArgumentOutOfRangeException | name doesn't start with "@", or has nothing but whitespace after it. |

## Remarks

Initializes a new instance of the [`Parameter`](../Parameter.md) struct.

## See Also

* struct [Parameter](../Parameter.md)