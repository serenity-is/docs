# RegisterScopedAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Enables auto registering for the implementation type this attribute is placed on by using the {Try}AddScoped{Keyed} method.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public class RegisterScopedAttribute : RegisterServiceAttribute
```

## Public Members

| name | description |
| --- | --- |
| [RegisterScopedAttribute](RegisterScopedAttribute/RegisterScopedAttribute.md)() | Creates a new instance of the attribute. |
| [RegisterScopedAttribute](RegisterScopedAttribute/RegisterScopedAttribute.md)(…) | Creates a new instance of the attribute for the specified types. |

## See Also

* class [RegisterServiceAttribute](./RegisterServiceAttribute.md)
* **Source:** *[RegisterScopedAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/AutoRegister/RegisterScopedAttribute.cs)*