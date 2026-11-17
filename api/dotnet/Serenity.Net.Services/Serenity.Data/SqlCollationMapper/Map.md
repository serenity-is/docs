# SqlCollationMapper.Map method

Maps the specified comparison to a collation name.

```csharp
public static string Map(string serverType, SqlCollationSpec spec, SqlCollationTarget target, 
    bool tolerant = false, Func<string, bool>? exists = null)
```

| parameter | description |
| --- | --- |
| serverType | The server type of the dialect. |
| spec | The comparison. |
| target | What the collation is mapped for. |
| tolerant | True to allow a collation that only differs in case or accent sensitivity. |
| exists | Optional check for whether a collation exists on the server. |

## Return Value

The collation name.

## Exceptions

| exception | condition |
| --- | --- |
| NotSupportedException | There is no such collation. |

## See Also

* struct [SqlCollationSpec](../SqlCollationSpec.md)
* enum [SqlCollationTarget](../SqlCollationTarget.md)
* class [SqlCollationMapper](../SqlCollationMapper.md)