# ExpectedRows enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Expected number of rows enumeration for SQL Update / Delete operation. This enumeration is used to avoid updating/deleting multiple records by mistake when forgot to add a WHERE statement.

```csharp
public enum ExpectedRows
```

## Values

| name | value | description |
| --- | --- | --- |
| One | `0` | Query should only affect One row, not zero or more |
| ZeroOrOne | `1` | Query may affect zero or one row, not more |
| Ignore | `2` | Ignore number of affected rows |

## See Also

* **Source:** *[ExpectedRows.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/SqlHelpers/ExpectedRows.cs)*