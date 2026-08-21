# AssemblySorter.Sort method
**namespace:** *[Serenity.Reflection](../../README.md#serenity.reflection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Sorts the specified assemblies based on their dependencies.

```csharp
public static IEnumerable<Assembly> Sort(IEnumerable<Assembly> assemblies)
```

| parameter | description |
| --- | --- |
| assemblies | The assemblies. |

## Return Value

The assemblies sorted so that dependencies come before dependents.

## See Also

* class [AssemblySorter](../AssemblySorter.md)