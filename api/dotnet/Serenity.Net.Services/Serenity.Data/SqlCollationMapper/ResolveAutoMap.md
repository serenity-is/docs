# SqlCollationMapper.ResolveAutoMap method

Maps the specified comparer specification according to an automap keyword.

```csharp
public static string? ResolveAutoMap(string autoMap, string? comparer, string serverType, 
    SqlCollationTarget target, Func<string, bool>? exists = null)
```

| parameter | description |
| --- | --- |
| autoMap | One of the automap keywords. |
| comparer | The comparer specification of the connection. |
| serverType | The server type of the dialect. |
| target | What the collation is mapped for. |
| exists | Optional check for whether a collation exists on the server. |

## Return Value

The collation name, or null if it can't be mapped and the keyword is a try variant.

## Exceptions

| exception | condition |
| --- | --- |
| NotSupportedException | The comparer can't be mapped and the keyword is not a try variant. |

## See Also

* enum [SqlCollationTarget](../SqlCollationTarget.md)
* class [SqlCollationMapper](../SqlCollationMapper.md)