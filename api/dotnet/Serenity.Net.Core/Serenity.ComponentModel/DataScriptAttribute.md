# DataScriptAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this method / type should generate a remote data script. Data contained by remote data scripts can be accessed client side using Q.getRemoteData("Key") function.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class DataScriptAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [DataScriptAttribute](DataScriptAttribute/DataScriptAttribute.md)() | Initializes a new instance of the [`DataScriptAttribute`](DataScriptAttribute.md) class. |
| [DataScriptAttribute](DataScriptAttribute/DataScriptAttribute.md)(…) | Initializes a new instance of the [`DataScriptAttribute`](DataScriptAttribute.md) class. |
| [CacheDuration](DataScriptAttribute/CacheDuration.md) { get; set; } | Cache duration in seconds |
| [CacheGroupKey](DataScriptAttribute/CacheGroupKey.md) { get; set; } | Gets or sets the cache group key. Group keys are used to invalidate a group of items. |
| [Key](DataScriptAttribute/Key.md) { get; } | Gets the key. |
| [Permission](DataScriptAttribute/Permission.md) { get; set; } | Permission key required to access this data script. Use special value "?" for all logged-in users. Use special value "*" for anyone including not logged-in users. |
| static [AutoKeyFor](DataScriptAttribute/AutoKeyFor.md)(…) | Gets the automatically generated key for given type. |

## See Also

* class [DynamicScriptAttribute](DynamicScriptAttribute.md)
* **Source:** *[DataScriptAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/DataScriptAttribute.cs)*