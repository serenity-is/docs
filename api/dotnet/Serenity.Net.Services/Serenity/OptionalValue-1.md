# OptionalValue&lt;T&gt; structure
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

An optional value returned by some methods like interceptors. It can be used to indicate that the result is optional and if default is returned, the operation should continue normally.

```csharp
public struct OptionalValue<T>
```

| parameter | description |
| --- | --- |
| T | Value type |
| value | Value |

## Public Members

| name | description |
| --- | --- |
| [OptionalValue](OptionalValue-1/OptionalValue.md)(…) | An optional value returned by some methods like interceptors. It can be used to indicate that the result is optional and if default is returned, the operation should continue normally. |
| [HasValue](OptionalValue-1/HasValue.md) { get; } | True if the object has a meaningful value. |
| [Value](OptionalValue-1/Value.md) { get; } | The meaningful value of the object. |
| [implicit operator](OptionalValue-1/op_Implicit.md) |  |

## See Also

* **Source:** *[OptionalValue.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Extensions/OptionalValue.cs)*