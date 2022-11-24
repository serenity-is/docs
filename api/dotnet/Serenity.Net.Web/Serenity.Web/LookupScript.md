# LookupScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Dynamic script type for lookup scripts

```csharp
public abstract class LookupScript : DynamicScript, IGetScriptData, INamedDynamicScript
```

## Public Members

| name | description |
| --- | --- |
| [IdField](LookupScript/IdField.md) { get; set; } | Gets / sets lookup ID field |
| [LookupKey](LookupScript/LookupKey.md) { get; set; } | Gets / sets lookup key |
| [LookupParams](LookupScript/LookupParams.md) { get; } | Gets lookup parameters dictionary |
| [ParentIdField](LookupScript/ParentIdField.md) { get; set; } | Gets / sets lookup parent ID field |
| [ScriptName](LookupScript/ScriptName.md) { get; } |  |
| [TextField](LookupScript/TextField.md) { get; set; } | Gets / sets lookup text field |
| override [GetScript](LookupScript/GetScript.md)() |  |
| [GetScriptData](LookupScript/GetScriptData.md)() |  |
| class [Data](LookupScript.Data.md) | Data format for a lookup script |

## Protected Members

| name | description |
| --- | --- |
| [LookupScript](LookupScript/LookupScript.md)() | Creates a new instance of the class |
| abstract [GetItems](LookupScript/GetItems.md)() |  |

## See Also

* class [DynamicScript](DynamicScript.md)
* interface [IGetScriptData](IGetScriptData.md)
* interface [INamedDynamicScript](INamedDynamicScript.md)
* **Source:** *[LookupScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/LookupScript.cs)*