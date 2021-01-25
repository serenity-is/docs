# EntityServiceCollectionExtensions.AddEntities method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Adds the annotation types, sql connections, default row type registry and row fields provider. Warning: This method sets the singleton row fields provider as the default by calling RowFieldsProvider.SetDefault on creation.

```csharp
public static void AddEntities(this IServiceCollection services)
```

| parameter | description |
| --- | --- |
| services | The services. |

## See Also

* class [EntityServiceCollectionExtensions](../EntityServiceCollectionExtensions.md)