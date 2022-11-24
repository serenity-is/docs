# DynamicScriptManager.PeekScriptHash method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Peeks the script hash for a script without actually executing it

```csharp
public string PeekScriptHash(string name, IDynamicScript script)
```

| parameter | description |
| --- | --- |
| name | Registration name |
| script | Dynamic script |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | name is null |

## See Also

* interface [IDynamicScript](../IDynamicScript.md)
* class [DynamicScriptManager](../DynamicScriptManager.md)