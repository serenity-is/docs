# CoreServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains extensions to register core services

```csharp
public static class CoreServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddAnnotationTypes](CoreServiceCollectionExtensions/AddAnnotationTypes.md)(…) | Adds the annotation type registry. |
| static [AddAutoRegisteredServices](CoreServiceCollectionExtensions/AddAutoRegisteredServices.md)(…) | Registers all the types with an RegisterService attribute (RegisterSingleton, RegisterScoped, RegisterTransient etc.) from the type source in the service collection if available, or using the provided typeSource, optionally filtering implementation types via a provided predicate. Use this at the end of InitializeServices in Startup.cs so that services can be overridden before others. |
| static [AddCaching](CoreServiceCollectionExtensions/AddCaching.md)(…) | Adds memory caching as ILocalCache implementation and a distributed cache emulator as IDistributed cache implementation. |
| static [AddFeatureToggles](CoreServiceCollectionExtensions/AddFeatureToggles.md)(…) | Adds IFeatureToggles service to the registry. |
| static [AddServiceResolver](CoreServiceCollectionExtensions/AddServiceResolver.md)(…) | Adds on demand service resolver to the registry. |
| static [AddSingletonWrapped&lt;TService,TWrapper,TImplementation&gt;](CoreServiceCollectionExtensions/AddSingletonWrapped.md)(…) | Adds a singleton service of the type *TService* with the implementation type *TWrapper* that wraps the *TImplementation* to the IServiceCollection. |
| static [AddSingletonWrapped&lt;TService,TWrapper1,TWrapper2,TImplementation&gt;](CoreServiceCollectionExtensions/AddSingletonWrapped.md)(…) | Adds a singleton service of the type *TService* with the implementation type *TWrapper1* that wraps the *TWrapper2* which itself wraps the *TImplementation* to the IServiceCollection. |
| static [AddTextRegistry](CoreServiceCollectionExtensions/AddTextRegistry.md)(…) | Adds the local text registry. |
| static [AddTypeSource](CoreServiceCollectionExtensions/AddTypeSource.md)(…) | Adds a type source to the registry. |
| static [AddUserProvider](CoreServiceCollectionExtensions/AddUserProvider.md)(…) | Adds the [`DefaultUserProvider`](../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Note that it requires IUserRetrieveService, IUserAcessor to be registered in the service collection. It also tries to register the DefaultUserClaimCreator. |
| static [AddUserProvider&lt;TUserAccessor,TUserRetrieveService&gt;](CoreServiceCollectionExtensions/AddUserProvider.md)(…) | Adds the [`DefaultUserProvider`](../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Also registers the given IUserAccessor and IUserRetrieveService implementations and tries to register the DefaultUserClaimCreator implementation. |
| static [AddUserProvider&lt;TUserAccessor,TUserRetrieveService,TUserClaimCreator&gt;](CoreServiceCollectionExtensions/AddUserProvider.md)(…) | Adds the [`DefaultUserProvider`](../Serenity.Services/DefaultUserProvider.md) as [`IUserProvider`](../Serenity.Abstractions/IUserProvider.md) implementation to the service collection. Also registers the given IUserAccessor, IUserRetrieveService and IUserClaimCreator implementations. |

## See Also

* **Source:** *[CoreServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Helpers/CoreServiceCollectionExtensions.cs)*