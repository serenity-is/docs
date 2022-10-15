# ColumnSelection enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Column selection types for List services

```csharp
public enum ColumnSelection
```

## Values

| name | value | description |
| --- | --- | --- |
| List | `0` | List, e.g. only the table columns |
| KeyOnly | `1` | Key Only, e.g. the primary key(s) and ID of the table |
| Details | `2` | Details, e.g. all the fields |
| None | `3` | None, don't select any property by default |
| IdOnly | `4` | Only select Id property by default |
| Lookup | `5` | Lookup, e.g. ID, Name and fields with LookupInclude attribute |

## See Also

* **Source:** *[ColumnSelection.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/ColumnSelection.cs)*