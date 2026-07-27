# CoreServiceCollectionExtensions.AddSingletonWrapped&lt;TService,TWrapper,TImplementation&gt; method (1 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds a singleton service of the type *TService* with the implementation type *TWrapper* that wraps the *TImplementation* to the IServiceCollection.

```csharp
public static IServiceCollection AddSingletonWrapped<TService, TWrapper, TImplementation>(
    this IServiceCollection services)
    where TService : class
    where TWrapper : TService
    where TImplementation : TService
```

| parameter | description |
| --- | --- |
| TService | The type of the service to add. |
| TWrapper | The type of the wrapper to use. |
| TImplementation | The type of the implementation to use. |
| services | The IServiceCollection to add the service to. |

## Return Value

A reference to this instance after the operation has completed.

## See Also

* class [TService](../Serenity.Net.Core/../CoreServiceCollectionExtensions.TService.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)

---

# CoreServiceCollectionExtensions.AddSingletonWrapped&lt;TService,TWrapper1,TWrapper2,TImplementation&gt; method (2 of 2)
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Adds a singleton service of the type *TService* with the implementation type *TWrapper1* that wraps the *TWrapper2* which itself wraps the *TImplementation* to the IServiceCollection.

```csharp
public static IServiceCollection 
    AddSingletonWrapped<TService, TWrapper1, TWrapper2, TImplementation>(
    this IServiceCollection services)
    where TService : class
    where TWrapper1 : TService
    where TWrapper2 : TService
    where TImplementation : TService
```

| parameter | description |
| --- | --- |
| TService | The type of the service to add. |
| TWrapper1 | The type of the wrapper 1 to use. |
| TWrapper2 | The type of the wrapper 2 to use. |
| TImplementation | The type of the implementation to use. |
| services | The IServiceCollection to add the service to. |

## Return Value

A reference to this instance after the operation has completed.

## See Also

* class [TService](../Serenity.Net.Core/../CoreServiceCollectionExtensions.TService.md)
* class [CoreServiceCollectionExtensions](../CoreServiceCollectionExtensions.md)