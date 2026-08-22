# SqlCommandDumper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Generates a debug version of a SQL command, including DECLARE statements for its parameters, so that it can be executed or inspected outside of the original connection. Based on the answer by Mitch at http://stackoverflow.com/questions/265192/get-the-generated-sql-statement-from-a-sqlcommand-object.

```csharp
public class SqlCommandDumper
```

## Public Members

| name | description |
| --- | --- |
| [SqlCommandDumper](SqlCommandDumper/SqlCommandDumper.md)() | The default constructor. |
| static [GetCommandText](SqlCommandDumper/GetCommandText.md)(…) | Gets the command text for the specified command, including parameter declarations. |

## See Also

* **Source:** *[SqlCommandDumper.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/SqlHelpers/SqlCommandDumper.cs)*