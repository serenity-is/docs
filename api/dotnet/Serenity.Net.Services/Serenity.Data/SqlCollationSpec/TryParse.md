# SqlCollationSpec.TryParse method

Tries to parse a comparer specification as accepted by [`ComparerResolver`](../ComparerResolver.md), e.g. "Ordinal", "OrdinalIgnoreCase", "InvariantCulture" or "tr-TR:IgnoreCase:IgnoreAccents".

```csharp
public static bool TryParse(string? value, out SqlCollationSpec spec)
```

| parameter | description |
| --- | --- |
| value | The comparer specification. |
| spec | The parsed value, if successful. |

## Return Value

True if the specification can be mapped to a collation.

## Remarks

CurrentCulture and CurrentCultureIgnoreCase are not accepted. A collation is stored in the database, so it can't depend on the culture of the process that creates it.

## See Also

* struct [SqlCollationSpec](../SqlCollationSpec.md)