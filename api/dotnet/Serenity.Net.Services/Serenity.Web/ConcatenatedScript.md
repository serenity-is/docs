# ConcatenatedScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A dynamic script that is formed from concatenation of other scripts

```csharp
public class ConcatenatedScript : DynamicScript
```

| parameter | description |
| --- | --- |
| scriptParts | Script parts |
| separator | Separator |
| checkRights | Callback to check permissions for individual scripts |

## Public Members

| name | description |
| --- | --- |
| [ConcatenatedScript](ConcatenatedScript/ConcatenatedScript.md)(…) | A dynamic script that is formed from concatenation of other scripts |
| override [CheckRights](ConcatenatedScript/CheckRights.md)(…) |  |
| override [GetScript](ConcatenatedScript/GetScript.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script parts is null |

## Remarks

Creates a new instance of the class

## See Also

* class [DynamicScript](DynamicScript.md)
* **Source:** *[ConcatenatedScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/DynamicScript/ConcatenatedScript.cs)*