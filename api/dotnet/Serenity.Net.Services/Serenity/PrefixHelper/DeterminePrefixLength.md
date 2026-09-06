# PrefixHelper.DeterminePrefixLength&lt;T&gt; method

Determines the prefix length.

```csharp
public static int DeterminePrefixLength<T>(IEnumerable<T> list, Func<T, string> getName)
```

| parameter | description |
| --- | --- |
| T | The item type |
| list | List of objects |
| getName | Gets the field name from a list element |

## Return Value

The length of the common prefix, or `0` if there is none.

## See Also

* class [PrefixHelper](../PrefixHelper.md)