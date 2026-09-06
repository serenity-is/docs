# ChainableExtensions.With&lt;TChain&gt; method

Allows to reference the call chain object itself without breaking a call chain.

```csharp
public static TChain With<TChain>(this TChain chain, Action<TChain> action)
    where TChain : IChainable
```

| parameter | description |
| --- | --- |
| chain | The chaining object. |
| action | An action that will be called with the chain object as parameter. |

## Return Value

The query itself.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *action* is null. |

## See Also

* interface [IChainable](../IChainable.md)
* class [ChainableExtensions](../ChainableExtensions.md)