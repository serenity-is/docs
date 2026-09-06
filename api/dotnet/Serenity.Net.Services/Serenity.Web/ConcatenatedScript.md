# ConcatenatedScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A dynamic script that is formed from the concatenation of other scripts.

```csharp
public class ConcatenatedScript : DynamicScript
```

| parameter | description |
| --- | --- |
| scriptParts | The script parts. |
| separator | The separator. |
| checkRights | Callback to check permissions for individual scripts. |

## Public Members

| name | description |
| --- | --- |
| [ConcatenatedScript](ConcatenatedScript/ConcatenatedScript.md)(…) | A dynamic script that is formed from the concatenation of other scripts. |
| override [CheckRights](ConcatenatedScript/CheckRights.md)(…) |  |
| override [GetScript](ConcatenatedScript/GetScript.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Script parts are null. |

## Remarks

Creates a new instance of the class.

## See Also

* class [DynamicScript](./DynamicScript.md)
* **Source:** *[ConcatenatedScript.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/DynamicScript/ConcatenatedScript.cs)*