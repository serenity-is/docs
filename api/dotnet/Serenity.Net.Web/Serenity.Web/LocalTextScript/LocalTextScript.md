# LocalTextScript constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Local text dynamic script.

```csharp
public LocalTextScript(ILocalTextRegistry registry, string package, string includes, 
    string languageId, bool isPending)
```

| parameter | description |
| --- | --- |
| registry | The text registry. |
| package | The package key. |
| includes | The includes regex. |
| languageId | The language ID. |
| isPending | `true` to include pending texts. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* or *package* is `null`. |

## Remarks

Initializes a new instance of the [`LocalTextScript`](../LocalTextScript.md) class.

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [LocalTextScript](../LocalTextScript.md)