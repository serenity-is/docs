# LocalTextDataScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Local text data script to access local texts from an external app like mobile

```csharp
public class LocalTextDataScript : DataScript<IDictionary<string, string>>, ICacheSuffix
```

| parameter | description |
| --- | --- |
| localTextRegistry | Local text registry |
| localTextPackages | Package list |
| httpContextAccessor | HTTP context accessor |

## Public Members

| name | description |
| --- | --- |
| [LocalTextDataScript](LocalTextDataScript/LocalTextDataScript.md)(…) | Local text data script to access local texts from an external app like mobile |
| [CacheSuffix](LocalTextDataScript/CacheSuffix.md) { get; } |  |
| static [GetPackageData](LocalTextDataScript/GetPackageData.md)(…) | Gets a local text package as a dictionary |

## Protected Members

| name | description |
| --- | --- |
| override [GetData](LocalTextDataScript/GetData.md)() |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## Remarks

Creates an instance of the class

## See Also

* class [DataScript&lt;TData&gt;](../Serenity.Net.Services/DataScript-1.md)
* interface [ICacheSuffix](ICacheSuffix.md)
* **Source:** *[LocalTextDataScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/DynamicScript/DynamicScriptTypes/LocalTextDataScript.cs)*