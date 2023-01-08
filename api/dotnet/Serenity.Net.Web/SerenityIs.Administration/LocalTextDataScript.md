# LocalTextDataScript class
**namespace:** *[SerenityIs.Administration](../README.md#serenityis.administration-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Local text data script to access local texts from an external app like mobile

```csharp
public class LocalTextDataScript : DataScript<IDictionary<string, string>>, ICacheSuffix
```

## Public Members

| name | description |
| --- | --- |
| [LocalTextDataScript](LocalTextDataScript/LocalTextDataScript.md)(…) | Creates an instance of the class |
| [CacheSuffix](LocalTextDataScript/CacheSuffix.md) { get; } |  |
| static [GetPackageData](LocalTextDataScript/GetPackageData.md)(…) | Gets a local text package as a dictionary |

## Protected Members

| name | description |
| --- | --- |
| override [GetData](LocalTextDataScript/GetData.md)() |  |

## See Also

* class [DataScript&lt;TData&gt;](../Serenity.Web/DataScript-1.md)
* interface [ICacheSuffix](../Serenity.Web/ICacheSuffix.md)
* **Source:** *[LocalTextDataScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/LocalTextDataScript.cs)*