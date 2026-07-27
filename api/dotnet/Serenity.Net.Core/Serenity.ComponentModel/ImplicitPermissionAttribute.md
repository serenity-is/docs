# ImplicitPermissionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Placed on permission keys to define an implicitly assigned permissions when a user / role has the permission. Currently only implemented in premium app.

```csharp
[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class ImplicitPermissionAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [ImplicitPermissionAttribute](ImplicitPermissionAttribute/ImplicitPermissionAttribute.md)(…) | Placed on permission keys to define an implicitly assigned permissions when a user / role has the permission. Currently only implemented in premium app. |
| [Value](ImplicitPermissionAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`ImplicitPermissionAttribute`](ImplicitPermissionAttribute.md) class.

## See Also

* **Source:** *[ImplicitPermissionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Permission/ImplicitPermissionAttribute.cs)*