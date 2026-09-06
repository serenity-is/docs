# BehaviorProviderExtensions class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extension methods for behavior provider

```csharp
public static class BehaviorProviderExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [AutoWrapBehaviors&lt;TBase,TSource,TNative&gt;](BehaviorProviderExtensions/AutoWrapBehaviors.md)(…) | Takes a list of behaviors implementing a common marker interface *TBase*, and converts it to a list of behaviors implementing *TNative*. Behaviors already implementing *TNative* are returned as is, while behaviors implementing only the source variant *TSource* are wrapped using the *wrap* factory function. |
| static [Resolve&lt;TRow,TBehavior&gt;](BehaviorProviderExtensions/Resolve.md)(…) | Resolves behaviors for handler, row and behavior type |

## See Also

* **Source:** *[BehaviorProviderExtensions.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Behavior/BehaviorProviderExtensions.cs)*