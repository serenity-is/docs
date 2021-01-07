# SqlHelper.AddParamWithValue method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Adds the parameter with value to the target command.

```csharp
public static DbParameter AddParamWithValue(this DbCommand command, string name, object value, 
    ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| command | The command. |
| name | The name. |
| value | The value. |
| dialect | The dialect. |

## Return Value

New parameter

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlHelper](../SqlHelper.md)