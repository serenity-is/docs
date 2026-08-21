# PageAuthorizeAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Authorizes access to a controller action. Optionally checks the permission provided as the first argument. Use special permission key `?` to check for logged-in users, and `*` to allow anyone including anonymous access.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class PageAuthorizeAttribute : TypeFilterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [PageAuthorizeAttribute](PageAuthorizeAttribute/PageAuthorizeAttribute.md)() | Initializes a new instance of the [`PageAuthorizeAttribute`](PageAuthorizeAttribute.md) class. |
| [PageAuthorizeAttribute](PageAuthorizeAttribute/PageAuthorizeAttribute.md)(…) | Initializes an instance of the [`PageAuthorizeAttribute`](PageAuthorizeAttribute.md) class, while reading the permission key from the NavigationPermissionAttribute or ReadPermissionAttribute of the source type. (4 constructors) |
| [Permission](PageAuthorizeAttribute/Permission.md) { get; } | Gets the permission key. |
| override [Equals](PageAuthorizeAttribute/Equals.md)(…) |  |
| override [GetHashCode](PageAuthorizeAttribute/GetHashCode.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| [PageAuthorizeAttribute](PageAuthorizeAttribute/PageAuthorizeAttribute.md)(…) | Initializes a new instance of the [`PageAuthorizeAttribute`](PageAuthorizeAttribute.md) class. |

## See Also

* **Source:** *[PageAuthorizeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Web/Mvc/PageAuthorizeAttribute.cs)*