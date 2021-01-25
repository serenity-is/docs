# EntityServiceCollectionExtensions class
**namespace:** *[Serenity.Extensions.DependencyInjection](../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Contains extensions to register entity services

```csharp
public static class EntityServiceCollectionExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AddEntities](EntityServiceCollectionExtensions/AddEntities.md)(…) | Adds the annotation types, sql connections, default row type registry and row fields provider. Warning: This method sets the singleton row fields provider as the default by calling RowFieldsProvider.SetDefault on creation. |

## See Also

* **Source:** *[EntityServiceCollectionExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Extensions/EntityServiceCollectionExtensions.cs)*