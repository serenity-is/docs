# ImplicitPermissionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Placed on permission keys to define an implicitly assigned permissions when a user / role has the permission. Currently only implemented in premium app.

```csharp
[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public class ImplicitPermissionAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ImplicitPermissionAttribute](ImplicitPermissionAttribute/ImplicitPermissionAttribute.md)(…) | Initializes a new instance of the [`ImplicitPermissionAttribute`](ImplicitPermissionAttribute.md) class. |
| [Value](ImplicitPermissionAttribute/Value.md) { get; } | Gets the value. |

## See Also

* **Source:** *[ImplicitPermissionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Permission/ImplicitPermissionAttribute.cs)*