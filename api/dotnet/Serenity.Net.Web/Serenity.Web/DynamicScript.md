# DynamicScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Base abstract implementation for [`IDynamicScript`](IDynamicScript.md)

```csharp
public abstract class DynamicScript : IDynamicScript
```

## Public Members

| name | description |
| --- | --- |
| [Expiration](DynamicScript/Expiration.md) { get; set; } |  |
| [GroupKey](DynamicScript/GroupKey.md) { get; set; } |  |
| [Permission](DynamicScript/Permission.md) { get; set; } |  |
| virtual [CheckRights](DynamicScript/CheckRights.md)(…) |  |
| abstract [GetScript](DynamicScript/GetScript.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| [DynamicScript](DynamicScript/DynamicScript.md)() | Creates a new instance of the class |

## See Also

* interface [IDynamicScript](IDynamicScript.md)
* **Source:** *[DynamicScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/DynamicScript.cs)*