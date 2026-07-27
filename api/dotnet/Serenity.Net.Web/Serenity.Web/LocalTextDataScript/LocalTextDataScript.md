# LocalTextDataScript constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Local text data script to access local texts from an external app like mobile

```csharp
public LocalTextDataScript(ILocalTextRegistry localTextRegistry, 
    IOptions<LocalTextPackages> localTextPackages, IHttpContextAccessor httpContextAccessor)
```

| parameter | description |
| --- | --- |
| localTextRegistry | Local text registry |
| localTextPackages | Package list |
| httpContextAccessor | HTTP context accessor |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## Remarks

Creates an instance of the class

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextPackages](../Serenity.Net.Core/../LocalTextPackages.md)
* class [LocalTextDataScript](../LocalTextDataScript.md)