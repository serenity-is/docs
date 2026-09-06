# ServiceCollectionConfigureExtensions.ConfigureSections method

Calls `Configure<TOptionsType>` for all setting classes that have a DefaultSectionKeyAttribute.

```csharp
public static IServiceCollection ConfigureSections(this IServiceCollection services, 
    IConfiguration config, ITypeSource typeSource = null, Func<Type, bool> predicate = null)
```

| parameter | description |
| --- | --- |
| services | The IServiceCollection to add the services to. |
| config | The configuration being bound. |
| typeSource | The type source with setting classes. |
| predicate | Optional predicate for type filtering. |

## Return Value

The IServiceCollection so that additional calls can be chained.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *config* is `null`, or no *typeSource* is provided and none is registered. |

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [ServiceCollectionConfigureExtensions](../ServiceCollectionConfigureExtensions.md)