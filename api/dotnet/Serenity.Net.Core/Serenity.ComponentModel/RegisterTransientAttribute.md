# RegisterTransientAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Enables auto registering for the implementation type this attribute is placed on by using {Try}AddTransient{Keyed} method.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public class RegisterTransientAttribute : RegisterServiceAttribute
```

## Public Members

| name | description |
| --- | --- |
| [RegisterTransientAttribute](RegisterTransientAttribute/RegisterTransientAttribute.md)() | Creates a new instance of the attribute. |
| [RegisterTransientAttribute](RegisterTransientAttribute/RegisterTransientAttribute.md)(…) | Creates a new instance of the attribute for specified types. |

## See Also

* class [RegisterServiceAttribute](RegisterServiceAttribute.md)
* **Source:** *[RegisterTransientAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/AutoRegister/RegisterTransientAttribute.cs)*