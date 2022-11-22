# BehaviorProviderExtensions.Resolve&lt;TRow,TBehavior&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Resolves behaviors for handler, row and behavior type

```csharp
public static IEnumerable<TBehavior> Resolve<TRow, TBehavior>(this IBehaviorProvider provider, 
    Type handlerType)
```

| parameter | description |
| --- | --- |
| TRow | Row type |
| TBehavior | Behavior type |
| provider | Provider |
| handlerType | Handler type |

## Return Value

Behavior

## See Also

* class [TBehavior](../Serenity.Net.Services/../BehaviorProviderExtensions.TBehavior.md)
* interface [IBehaviorProvider](../IBehaviorProvider.md)
* class [BehaviorProviderExtensions](../BehaviorProviderExtensions.md)