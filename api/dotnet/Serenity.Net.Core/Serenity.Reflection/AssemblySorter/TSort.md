# AssemblySorter.TSort&lt;T&gt; method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

A generic dependency sort function

```csharp
public static IEnumerable<T> TSort<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> dependencies, 
    bool throwOnCycle = false)
```

| parameter | description |
| --- | --- |
| T | Type of items |
| source | The source. |
| dependencies | The dependencies. |
| throwOnCycle | if set to `true` throw on circular link. |

## See Also

* class [T](../Serenity.Net.Core/../AssemblySorter.T.md)
* class [AssemblySorter](../AssemblySorter.md)