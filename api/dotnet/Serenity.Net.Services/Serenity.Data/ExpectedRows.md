# ExpectedRows enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Expected number of rows enumeration for SQL Update / Delete operations. This enumeration is used to avoid updating/deleting multiple records by mistake when one forgets to add a WHERE statement.

```csharp
public enum ExpectedRows
```

## Values

| name | value | description |
| --- | --- | --- |
| One | `0` | Query should only affect one row, not zero or more. |
| ZeroOrOne | `1` | Query may affect zero or one row, not more. |
| Ignore | `2` | Ignore the number of affected rows. |

## See Also

* **Source:** *[ExpectedRows.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/SqlHelpers/ExpectedRows.cs)*