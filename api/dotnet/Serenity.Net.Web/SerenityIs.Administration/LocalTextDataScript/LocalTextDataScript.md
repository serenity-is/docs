# LocalTextDataScript constructor
**namespace:** *[SerenityIs.Administration](../../README.md#serenityis.administration-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates an instance of the class

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

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextPackages](../../Serenity.Web/LocalTextPackages.md)
* class [LocalTextDataScript](../LocalTextDataScript.md)