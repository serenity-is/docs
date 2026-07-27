# IListMapFieldExpressionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An extension for list behaviors that can map fields to custom expressions within a ListRequestHandler lifecycle. Note that the first behavior that returns a non-null value will be used.

```csharp
public interface IListMapFieldExpressionBehavior
```

## Members

| name | description |
| --- | --- |
| [MapFieldExpression](IListMapFieldExpressionBehavior/MapFieldExpression.md)(…) | Maps field's expression to a custom one. Returns null if not mapped to a custom expression. |

## See Also

* **Source:** *[IListMapFieldExpressionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/List/IListMapFieldExpressionBehavior.cs)*