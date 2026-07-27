# DefaultTypeSource constructor
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Default implementation for a type source that accepts an assembly list

```csharp
public DefaultTypeSource(IEnumerable<Assembly> assemblies, IFeatureToggles featureToggles = null)
```

| parameter | description |
| --- | --- |
| assemblies | List of assemblies |
| featureToggles | Feature toggles service used to filter types |

## Remarks

Creates a new instance

## See Also

* interface [IFeatureToggles](../IFeatureToggles.md)
* class [DefaultTypeSource](../DefaultTypeSource.md)