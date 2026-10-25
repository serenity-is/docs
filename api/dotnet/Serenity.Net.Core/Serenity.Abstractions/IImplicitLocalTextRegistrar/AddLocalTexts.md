# IImplicitLocalTextRegistrar.AddLocalTexts method

Adds local text keys and their default translations to the specified registry. This is usually called before other registration types like NestedLocalText so texts added here might be overridden by subsequent registrations. It is a good practice to skip adding keys that already exist in the registry.

```csharp
public void AddLocalTexts(ILocalTextRegistry registry, MemberInfo memberInfo)
```

| parameter | description |
| --- | --- |
| registry | The local text registry to which the local text keys will be added. |
| memberInfo | The type or member info for which to add implicit local text keys. |

## See Also

* interface [ILocalTextRegistry](../ILocalTextRegistry.md)
* interface [IImplicitLocalTextRegistrar](../IImplicitLocalTextRegistrar.md)