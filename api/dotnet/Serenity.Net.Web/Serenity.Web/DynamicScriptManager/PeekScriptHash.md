# DynamicScriptManager.PeekScriptHash method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Peeks the script hash for a script without actually executing it.

```csharp
public string PeekScriptHash(string name, IDynamicScript script)
```

| parameter | description |
| --- | --- |
| name | The registration name. |
| script | The dynamic script. |

## Return Value

The cached hash for the script.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *name* is `null`. |

## See Also

* interface [IDynamicScript](../Serenity.Net.Core/../IDynamicScript.md)
* class [DynamicScriptManager](../DynamicScriptManager.md)