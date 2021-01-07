# SqlHelper.FixCommandText method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Fixes the command text for target dialect by replacing brackets ([]), and parameter prefixes (@).

```csharp
public static string FixCommandText(string commandText, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| commandText | The command text. |
| dialect | The dialect. |

## Return Value

Fixed query.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlHelper](../SqlHelper.md)