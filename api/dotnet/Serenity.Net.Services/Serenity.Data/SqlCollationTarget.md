# SqlCollationTarget enumeration
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

What a collation is mapped for, as the available collations can differ between them.

```csharp
public enum SqlCollationTarget
```

## Values

| name | value | description |
| --- | --- | --- |
| Database | `0` | The default collation of a database, e.g. in a CREATE DATABASE statement. |
| Column | `1` | The collation of a string column, e.g. in a migration. |

## See Also

* **Source:** *[SqlCollationTarget.cs](https://github.com/serenity-is/Serenity/blob/64f4d46040be54ec435d5a0cabde26e1c69fe085/src/services/Data/Collations/SqlCollationTarget.cs)*