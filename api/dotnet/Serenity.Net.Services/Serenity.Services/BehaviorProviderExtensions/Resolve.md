# BehaviorProviderExtensions.Resolve&lt;TRow,TBehavior&gt; method

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

* interface [IBehaviorProvider](../IBehaviorProvider.md)
* class [BehaviorProviderExtensions](../BehaviorProviderExtensions.md)