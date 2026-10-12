# Parameter.CheckName method

Validates a parameter name, so that null, empty, "@"-only and whitespace-only names are rejected in one place. Used by this constructor and other parameter-name entry points (AddParam / SetParam / ParamCriteria).

```csharp
public static string CheckName(string? name)
```

| parameter | description |
| --- | --- |
| name | The name to validate. |

## Return Value

The validated name.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null or empty. |
| ArgumentOutOfRangeException | name doesn't start with "@", or has nothing but whitespace after it. |

## See Also

* struct [Parameter](../Parameter.md)