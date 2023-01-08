# ChainableExtensions.With&lt;TChain&gt; method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Allows to reference the call chain object itself without breaking a call chain.

```csharp
public static TChain With<TChain>(this TChain chain, Action<TChain> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | Chaining object |
| action | An action that will be called with the chain object as parameter. |

## Return Value

The query itself.

## See Also

* class [TChain](../Serenity.Net.Data/../ChainableExtensions.TChain.md)
* interface [IChainable](../IChainable.md)
* class [ChainableExtensions](../ChainableExtensions.md)