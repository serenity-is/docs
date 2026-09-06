# BehaviorProviderExtensions.AutoWrapBehaviors&lt;TBase,TSource,TNative&gt; method
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Takes a list of behaviors implementing a common marker interface *TBase*, and converts it to a list of behaviors implementing *TNative*. Behaviors already implementing *TNative* are returned as is, while behaviors implementing only the source variant *TSource* are wrapped using the *wrap* factory function.

```csharp
public static IEnumerable<TNative> AutoWrapBehaviors<TBase, TSource, TNative>(
    IEnumerable<TBase> input, Func<TSource, TNative> wrap)
    where TSource : TBase
    where TNative : TBase
```

| parameter | description |
| --- | --- |
| TBase | Common base (marker) interface, e.g. [`ISaveBehavior`](../ISaveBehavior.md) |
| TSource | The source variant interface, e.g. [`ISaveBehaviorAsync`](../ISaveBehaviorAsync.md) when wrapping to sync |
| TNative | The target variant interface, e.g. [`ISaveBehaviorSync`](../ISaveBehaviorSync.md) |
| input | List of behaviors |
| wrap | Factory to wrap a behavior of type *TSource* into one of type *TNative* |

## Return Value

List of behaviors implementing *TNative*

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | One of the behaviors implements neither *TSource* nor *TNative*. |

## See Also

* class [TNative](../Serenity.Net.Services/../BehaviorProviderExtensions.TNative.md)
* class [TBase](../Serenity.Net.Services/../BehaviorProviderExtensions.TBase.md)
* class [TSource](../Serenity.Net.Services/../BehaviorProviderExtensions.TSource.md)
* class [BehaviorProviderExtensions](../BehaviorProviderExtensions.md)