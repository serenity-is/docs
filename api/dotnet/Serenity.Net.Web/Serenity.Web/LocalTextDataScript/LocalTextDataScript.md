# LocalTextDataScript constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Local text data script to access local texts from an external app like mobile.

```csharp
public LocalTextDataScript(ILocalTextRegistry localTextRegistry, 
    IOptions<LocalTextPackages> localTextPackages, IHttpContextAccessor httpContextAccessor)
```

| parameter | description |
| --- | --- |
| localTextRegistry | The local text registry. |
| localTextPackages | The package list. |
| httpContextAccessor | The HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## Remarks

Initializes a new instance of the [`LocalTextDataScript`](../LocalTextDataScript.md) class.

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextPackages](../Serenity.Net.Core/../LocalTextPackages.md)
* class [LocalTextDataScript](../LocalTextDataScript.md)