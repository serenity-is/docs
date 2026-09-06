# AssemblySorter.TSort&lt;T&gt; method

A generic dependency sort function

```csharp
public static IEnumerable<T> TSort<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> dependencies)
```

| parameter | description |
| --- | --- |
| T | Type of items |
| source | The source. |
| dependencies | The dependencies. |

## Return Value

The items sorted so that dependencies come before dependents.

## See Also

* class [AssemblySorter](../AssemblySorter.md)