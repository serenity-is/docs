# SqlHelper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Contains static SQL related helper functions and extensions.

```csharp
public static class SqlHelper
```

## Public Members

| name | description |
| --- | --- |
| static [AddParamWithValue](SqlHelper/AddParamWithValue.md)(…) | Adds the parameter with value to the target command. |
| static [Execute](SqlHelper/Execute.md)(…) | Executes the specified query on connection. (5 methods) |
| static [ExecuteAndGetID](SqlHelper/ExecuteAndGetID.md)(…) | Executes the query and returns the generated identity value. Only works for auto incremented fields, not GUIDs. |
| static [ExecuteNonQuery](SqlHelper/ExecuteNonQuery.md)(…) | Executes the SQL statement, and returns affected rows. (3 methods) |
| static [ExecuteReader](SqlHelper/ExecuteReader.md)(…) | Executes the command returning a data reader. (6 methods) |
| static [ExecuteScalar](SqlHelper/ExecuteScalar.md)(…) | Executes the statement returning a scalar value. (4 methods) |
| static [Exists](SqlHelper/Exists.md)(…) | Executes the query returning true if it has at least one result. |
| static [FixCommandText](SqlHelper/FixCommandText.md)(…) | Fixes the command text for target dialect by replacing brackets ([]), and parameter prefixes (@). |
| static [FixParamType](SqlHelper/FixParamType.md)(…) | Fixes the type of the parameter to something suitable as SQL parameter. |
| static [LogCommand](SqlHelper/LogCommand.md)(…) | Logs the command. |
| static [NewCommand](SqlHelper/NewCommand.md)(…) | Creates new command. (2 methods) |

## See Also

* **Source:** *[SqlHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/SqlHelpers/SqlHelper.cs)*