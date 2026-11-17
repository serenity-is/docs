# DefaultLocalTextInitializer.AddDynamicTexts method

Adds the texts of the IDynamicLocalTextSource services, after the ones of the texts files, so that they only add what is missing.

```csharp
protected virtual void AddDynamicTexts(ILocalTextRegistry registry)
```

| parameter | description |
| --- | --- |
| registry | The target registry. |

## See Also

* interface [ILocalTextRegistry](../../../Serenity.Net.Core/Serenity.Abstractions/ILocalTextRegistry.md)
* class [DefaultLocalTextInitializer](../DefaultLocalTextInitializer.md)