# LocalTextScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Local text dynamic script.

```csharp
public class LocalTextScript : DynamicScript, INamedDynamicScript
```

| parameter | description |
| --- | --- |
| registry | The text registry. |
| package | The package key. |
| includes | The includes regex. |
| languageId | The language ID. |
| isPending | `true` to include pending texts. |

## Public Members

| name | description |
| --- | --- |
| [LocalTextScript](LocalTextScript/LocalTextScript.md)(…) | Local text dynamic script. |
| [ScriptName](LocalTextScript/ScriptName.md) { get; } |  |
| override [GetScript](LocalTextScript/GetScript.md)() |  |
| static [GetLocalTextPackageScript](LocalTextScript/GetLocalTextPackageScript.md)(…) | Gets the local text package script content. (2 methods) |
| static [GetScriptName](LocalTextScript/GetScriptName.md)(…) | Gets the script registration name for a local text package. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* or *package* is `null`. |

## Remarks

Initializes a new instance of the [`LocalTextScript`](./LocalTextScript.md) class.

## See Also

* class [DynamicScript](../../Serenity.Net.Services/Serenity.Web/DynamicScript.md)
* interface [INamedDynamicScript](../../Serenity.Net.Core/Serenity.Web/INamedDynamicScript.md)
* **Source:** *[LocalTextScript.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicScriptTypes/LocalTextScript.cs)*