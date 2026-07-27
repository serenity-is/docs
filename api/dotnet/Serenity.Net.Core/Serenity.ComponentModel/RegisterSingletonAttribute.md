# RegisterSingletonAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Enables auto registering for the implementation type this attribute is placed on by using {Try}AddSingleton{Keyed} method.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public class RegisterSingletonAttribute : RegisterServiceAttribute
```

## Public Members

| name | description |
| --- | --- |
| [RegisterSingletonAttribute](RegisterSingletonAttribute/RegisterSingletonAttribute.md)() | Creates a new instance of the attribute. |
| [RegisterSingletonAttribute](RegisterSingletonAttribute/RegisterSingletonAttribute.md)(…) | Creates a new instance of the attribute for specified types. |

## See Also

* class [RegisterServiceAttribute](RegisterServiceAttribute.md)
* **Source:** *[RegisterSingletonAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/AutoRegister/RegisterSingletonAttribute.cs)*