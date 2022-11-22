# RetrieveColumnSelection enumeration
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

The group of columns to retrieve

```csharp
public enum RetrieveColumnSelection
```

## Values

| name | value | description |
| --- | --- | --- |
| Details | `0` | Details, e.g. all the fields |
| KeyOnly | `1` | Key Only, e.g. the primary key(s) and ID of the table |
| List | `2` | List, e.g. only the table columns |
| None | `3` | None, don't select any property by default |
| IdOnly | `4` | Only select Id property by default |
| Lookup | `5` | Lookup, e.g. ID, Name and fields with LookupInclude attribute |

## See Also

* **Source:** *[RetrieveColumnSelection.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Models/RetrieveColumnSelection.cs)*