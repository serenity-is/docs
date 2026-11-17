# SqlCollationSpec constructor

An engine independent description of the comparison a collation should perform.

```csharp
public SqlCollationSpec(string? Culture, bool IgnoreCase = false, bool IgnoreAccents = false)
```

| parameter | description |
| --- | --- |
| Culture | The culture name, an empty string for the invariant culture, or null for an ordinal comparison. |
| IgnoreCase | True to compare case insensitively. |
| IgnoreAccents | True to compare accent insensitively. |

## See Also

* struct [SqlCollationSpec](../SqlCollationSpec.md)