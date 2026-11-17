# EntityQueryAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies how an entity is read when it is used as a source of another query, e.g. by an entity query of a data source, or that it can't be used so. See [`EntityQueryMode`](./EntityQueryMode.md).

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class EntityQueryAttribute : Attribute
```

| parameter | description |
| --- | --- |
| mode | The mode. |

## Public Members

| name | description |
| --- | --- |
| [EntityQueryAttribute](EntityQueryAttribute/EntityQueryAttribute.md)(…) | Specifies how an entity is read when it is used as a source of another query, e.g. by an entity query of a data source, or that it can't be used so. See [`EntityQueryMode`](./EntityQueryMode.md). |
| [Mode](EntityQueryAttribute/Mode.md) { get; } | Gets the mode. |

## See Also

* **Source:** *[EntityQueryAttribute.cs](https://github.com/serenity-is/Serenity/blob/c9de1423e8c163e87ed25856ef3b74517aea2c6c/src/services/RequestHandlers/List/EntityQueryAttribute.cs)*