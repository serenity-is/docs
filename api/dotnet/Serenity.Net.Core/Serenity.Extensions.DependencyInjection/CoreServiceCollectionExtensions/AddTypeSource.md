# CoreServiceCollectionExtensions.AddTypeSource method

Adds a type source to the registry.

```csharp
public static void AddTypeSource(this IServiceCollection services, Assembly[] assemblies, 
    IFeatureToggles? featureToggles = null)
```

| parameter | description |
| --- | --- |
| services | The services. |
| assemblies | List of assemblies. |
| featureToggles | Feature toggles. |

## See Also

* interface [IFeatureToggles](../../Serenity.Abstractions/IFeatureToggles.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)