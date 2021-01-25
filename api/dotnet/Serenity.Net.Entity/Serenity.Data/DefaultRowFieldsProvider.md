# DefaultRowFieldsProvider class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider.

```csharp
public class DefaultRowFieldsProvider : IRowFieldsProvider
```

## Public Members

| name | description |
| --- | --- |
| [DefaultRowFieldsProvider](DefaultRowFieldsProvider/DefaultRowFieldsProvider.md)(…) | Initializes a new instance of the [`DefaultRowFieldsProvider`](DefaultRowFieldsProvider.md) class. |
| [Resolve](DefaultRowFieldsProvider/Resolve.md)(…) | Resolves the specified fields type. |
| [ResolveWithAlias](DefaultRowFieldsProvider/ResolveWithAlias.md)(…) | Resolves the with alias. |

## See Also

* interface [IRowFieldsProvider](IRowFieldsProvider.md)
* **Source:** *[DefaultRowFieldsProvider.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/Row/DefaultRowFieldsProvider.cs)*