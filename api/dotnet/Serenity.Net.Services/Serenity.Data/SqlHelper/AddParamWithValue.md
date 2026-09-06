# SqlHelper.AddParamWithValue method

Adds the parameter with value to the target command.

```csharp
public static IDbDataParameter AddParamWithValue(this IDbCommand command, string name, 
    object value, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| command | The command. |
| name | The name. |
| value | The value. |
| dialect | The dialect. |

## Return Value

The new parameter.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlHelper](../SqlHelper.md)