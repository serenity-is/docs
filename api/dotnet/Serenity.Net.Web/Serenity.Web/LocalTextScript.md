# LocalTextScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Local text dynamic script

```csharp
public class LocalTextScript : DynamicScript, INamedDynamicScript
```

| parameter | description |
| --- | --- |
| registry | Text registry |
| package | Package key |
| includes | Includes regex |
| languageId | LanguageID |
| isPending | True to include pending texts |

## Public Members

| name | description |
| --- | --- |
| [LocalTextScript](LocalTextScript/LocalTextScript.md)(…) | Local text dynamic script |
| [ScriptName](LocalTextScript/ScriptName.md) { get; } |  |
| override [GetScript](LocalTextScript/GetScript.md)() |  |
| static [GetLocalTextPackageScript](LocalTextScript/GetLocalTextPackageScript.md)(…) | Gets local text package script content (2 methods) |
| static [GetScriptName](LocalTextScript/GetScriptName.md)(…) | Gets script registration name for a local text package |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## Remarks

Creates a new instance of the class

## See Also

* class [DynamicScript](../Serenity.Net.Services/DynamicScript.md)
* interface [INamedDynamicScript](../Serenity.Net.Core/INamedDynamicScript.md)
* **Source:** *[LocalTextScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/DynamicScript/DynamicScriptTypes/LocalTextScript.cs)*