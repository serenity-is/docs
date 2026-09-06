# FallbackRowFieldsProvider class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Fallback row fields provider for cases where a IServiceProvider is not available.

```csharp
public class FallbackRowFieldsProvider : IRowFieldsProvider
```

## Public Members

| name | description |
| --- | --- |
| static [Instance](FallbackRowFieldsProvider/Instance.md) | The instance |
| [Resolve](FallbackRowFieldsProvider/Resolve.md)(…) | Resolves the fields instance for the specified fields type. |
| [ResolveWithAlias](FallbackRowFieldsProvider/ResolveWithAlias.md)(…) | Resolves the fields instance for the specified fields type with the given alias applied. |

## See Also

* interface [IRowFieldsProvider](./IRowFieldsProvider.md)
* **Source:** *[FallbackRowFieldsProvider.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/Row/FallbackRowFieldsProvider.cs)*