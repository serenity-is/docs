# ImplicitLocalTextRegistration.AddImplicitTexts method

Adds implicit local text keys defined by attributes implementing [`IImplicitLocalTextRegistrar`](../../Serenity.Abstractions/IImplicitLocalTextRegistrar.md) to the specified registry. This method iterates through all types provided by the *typeSource* and invokes the [`AddLocalTexts`](../../Serenity.Abstractions/IImplicitLocalTextRegistrar/AddLocalTexts.md) method on each attribute implementing [`IImplicitLocalTextRegistrar`](../../Serenity.Abstractions/IImplicitLocalTextRegistrar.md).

```csharp
public static void AddImplicitTexts(this ILocalTextRegistry registry, ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| registry | The local text registry to which the local text keys will be added. |
| typeSource | The type source to search for types with implicit local text registrars. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Thrown if either *registry* or *typeSource* is null. |

## See Also

* interface [ILocalTextRegistry](../../Serenity.Abstractions/ILocalTextRegistry.md)
* interface [ITypeSource](../../Serenity.Abstractions/ITypeSource.md)
* class [ImplicitLocalTextRegistration](../ImplicitLocalTextRegistration.md)