# ConnectionExtensions.NewFor&lt;TClass&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Creates a new connection for the specified class, determining the connection key by checking its [`ConnectionKeyAttribute`](../ConnectionKeyAttribute.md).

```csharp
public static IDbConnection NewFor<TClass>(this ISqlConnections factory)
```

| parameter | description |
| --- | --- |
| TClass | The type of the class. |
| factory | The connection factory. |

## Return Value

A new connection.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentOutOfRangeException | Type has no ConnectionKey attribute! |

## See Also

* interface [ISqlConnections](../ISqlConnections.md)
* class [ConnectionExtensions](../ConnectionExtensions.md)