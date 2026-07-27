# ServiceCollectionConfigureExtensions.ConfigureSections method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Calls `Configure&lt;TOptionsType&gt;` for all setting classes with DefaultSectionKeyAttribute.

```csharp
public static IServiceCollection ConfigureSections(this IServiceCollection services, 
    IConfiguration config, ITypeSource typeSource = null, Func<Type, bool> predicate = null)
```

| parameter | description |
| --- | --- |
| services | The IServiceCollection to add the services to. |
| config | The configuration being bound. |
| typeSource | Type source with setting classes |
| predicate | Optional predicate for type filtering |

## Return Value

The IServiceCollection so that additional calls can be chained.

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [ServiceCollectionConfigureExtensions](../ServiceCollectionConfigureExtensions.md)