# InstanceNameAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines non-plural name for an entity.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class InstanceNameAttribute : Attribute, IHasTextKey
```

| parameter | description |
| --- | --- |
| instanceName | Name of the instance. |

## Public Members

| name | description |
| --- | --- |
| [InstanceNameAttribute](InstanceNameAttribute/InstanceNameAttribute.md)(…) | Determines non-plural name for an entity. |
| [InstanceName](InstanceNameAttribute/InstanceName.md) { get; } | Gets the name of the instance. |
| [TextKey](InstanceNameAttribute/TextKey.md) { get; set; } | Gets or sets the local text key for the instance name. |

## Remarks

Initializes a new instance of the [`InstanceNameAttribute`](./InstanceNameAttribute.md) class.

## See Also

* interface [IHasTextKey](../../Serenity.Net.Core/Serenity.Services/IHasTextKey.md)
* **Source:** *[InstanceNameAttribute.cs](https://github.com/serenity-is/Serenity/blob/0c34357a17d56458ca5b7a3be25f42666b9eb050/src/services/Data/Mapping/InstanceNameAttribute.cs)*