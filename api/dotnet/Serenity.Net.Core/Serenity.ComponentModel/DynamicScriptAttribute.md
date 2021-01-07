# DynamicScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for dynamic script attributes. Dynamic scripts contain dynamic data, but they are not parameterized.

```csharp
[AttributeUsage(AttributeTargets.Method)]
public abstract class DynamicScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [DynamicScriptAttribute](DynamicScriptAttribute/DynamicScriptAttribute.md)(…) | Initializes a new instance of the [`DynamicScriptAttribute`](DynamicScriptAttribute.md) class. |
| [CacheDuration](DynamicScriptAttribute/CacheDuration.md) { get; set; } | Gets or sets the duration of the caching. |
| [CacheGroupKey](DynamicScriptAttribute/CacheGroupKey.md) { get; set; } | Gets or sets the cache group key. Group keys are used to invalidate a group of items. |
| [Key](DynamicScriptAttribute/Key.md) { get; } | Gets the key. |

## See Also

* **Source:** *[DynamicScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/DynamicScriptAttribute.cs)*