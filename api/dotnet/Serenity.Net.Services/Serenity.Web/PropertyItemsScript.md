# PropertyItemsScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstract base class for [`ColumnsScript`](ColumnsScript.md) and [`FormScript`](FormScript.md)

```csharp
public abstract class PropertyItemsScript : IGetScriptData, INamedDynamicScript
```

| parameter | description |
| --- | --- |
| scriptName | Script name |
| type | Columns or form type |
| propertyProvider | Property item provider |
| serviceProvider | Service provider |

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
| static [Compact](PropertyItemsScript/Compact.md)(…) | Generates a compact version of the scripts |

## Protected Members

| name | description |
| --- | --- |
| [PropertyItemsScript](PropertyItemsScript/PropertyItemsScript.md)(…) | Abstract base class for [`ColumnsScript`](ColumnsScript.md) and [`FormScript`](FormScript.md) |
| static [CheckName](PropertyItemsScript/CheckName.md)(…) | Checks the name if its empty or null |

## Remarks

Creates a new instance of the class

## See Also

* interface [IGetScriptData](../Serenity.Net.Core/IGetScriptData.md)
* interface [INamedDynamicScript](../Serenity.Net.Core/INamedDynamicScript.md)
* **Source:** *[PropertyItemsScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/DynamicScript/PropertyItemsScript.cs)*