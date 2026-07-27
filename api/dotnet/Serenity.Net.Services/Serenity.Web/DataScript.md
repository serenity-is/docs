# DataScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Dynamic script that contains remote data

```csharp
public class DataScript : DynamicScript, IGetScriptData, INamedDynamicScript
```

## Public Members

| name | description |
| --- | --- |
| [DataScript](DataScript/DataScript.md)(…) | Creates a new instance of the class |
| [ScriptName](DataScript/ScriptName.md) { get; } |  |
| override [GetScript](DataScript/GetScript.md)() |  |
| [GetScriptData](DataScript/GetScriptData.md)() |  |
| const [SetScriptDataFormat](DataScript/SetScriptDataFormat.md) | Format string for Serenity.setScriptData({0}, {1}) |

## Protected Members

| name | description |
| --- | --- |
| [DataScript](DataScript/DataScript.md)() | Creates a new instance of the class |
| [getData-](DataScript/getData-.md) | Callback to get data |
| [key-](DataScript/key-.md) | Key for the data script |

## See Also

* class [DynamicScript](DynamicScript.md)
* interface [IGetScriptData](../Serenity.Net.Core/IGetScriptData.md)
* interface [INamedDynamicScript](../Serenity.Net.Core/INamedDynamicScript.md)
* **Source:** *[DataScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/DynamicScript/DataScript.cs)*