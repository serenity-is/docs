# LookupScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

```csharp
public abstract class LookupScript : DynamicScript, IGetScriptData, INamedDynamicScript
```

## Public Members

| name | description |
| --- | --- |
| [IdField](LookupScript/IdField.md) { get; set; } |  |
| [LookupKey](LookupScript/LookupKey.md) { get; set; } |  |
| [LookupParams](LookupScript/LookupParams.md) { get; } |  |
| [ParentIdField](LookupScript/ParentIdField.md) { get; set; } |  |
| [ScriptName](LookupScript/ScriptName.md) { get; } |  |
| [TextField](LookupScript/TextField.md) { get; set; } |  |
| override [GetScript](LookupScript/GetScript.md)() |  |
| [GetScriptData](LookupScript/GetScriptData.md)() |  |
| class [Data](LookupScript.Data.md) |  |

## Protected Members

| name | description |
| --- | --- |
| [LookupScript](LookupScript/LookupScript.md)() | The default constructor. |
| abstract [GetItems](LookupScript/GetItems.md)() |  |

## See Also

* class [DynamicScript](DynamicScript.md)
* interface [IGetScriptData](IGetScriptData.md)
* interface [INamedDynamicScript](INamedDynamicScript.md)
* **Source:** *[LookupScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/LookupScript.cs)*