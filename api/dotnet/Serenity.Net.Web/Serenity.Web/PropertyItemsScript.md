# PropertyItemsScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstract base class for [`ColumnsScript`](ColumnsScript.md) and [`FormScript`](FormScript.md)

```csharp
public abstract class PropertyItemsScript : IGetScriptData, INamedDynamicScript
```

## Public Members

| name | description |
| --- | --- |
| [Expiration](PropertyItemsScript/Expiration.md) { get; set; } |  |
| [GroupKey](PropertyItemsScript/GroupKey.md) { get; set; } |  |
| [ScriptName](PropertyItemsScript/ScriptName.md) { get; } |  |
| event [ScriptChanged](PropertyItemsScript/ScriptChanged.md) |  |
| [Changed](PropertyItemsScript/Changed.md)() |  |
| [CheckRights](PropertyItemsScript/CheckRights.md)(…) |  |
| [GetScript](PropertyItemsScript/GetScript.md)() |  |
| [GetScriptData](PropertyItemsScript/GetScriptData.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| [PropertyItemsScript](PropertyItemsScript/PropertyItemsScript.md)(…) | Creates a new instance of the class |
| static [CheckName](PropertyItemsScript/CheckName.md)(…) | Checks the name if its empty or null |

## See Also

* interface [IGetScriptData](IGetScriptData.md)
* interface [INamedDynamicScript](INamedDynamicScript.md)
* **Source:** *[PropertyItemsScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/PropertyEditor/PropertyItemsScript.cs)*