# ConnectionExtensions.NewFor&lt;TClass&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Creates a new connection for specified class, determining the connection key by checking its [ConnectionKey] attribute.

```csharp
public static IDbConnection NewFor<TClass>(this ISqlConnections factory)
```

| parameter | description |
| --- | --- |
| TClass | The type of the class. |
| factory | Connection factory |

## Return Value

A new connection

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | Type has no ConnectionKey attribute! |

## See Also

* interface [ISqlConnections](../ISqlConnections.md)
* class [ConnectionExtensions](../ConnectionExtensions.md)