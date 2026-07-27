# ServiceAuthorizationExtensions.AuthorizeUpdate&lt;TRow&gt; method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Authorizes delete request access similar to [AuthorizeUpdate] attribute.

```csharp
public static void AuthorizeUpdate<TRow>(this IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Type of row to get Insert/Modify/Read permission attribute from |
| context | Request context |

## See Also

* interface [IRequestContext](../../Serenity.Services/IRequestContext.md)
* class [ServiceAuthorizationExtensions](../ServiceAuthorizationExtensions.md)

---

# ServiceAuthorizationExtensions.AuthorizeUpdate&lt;TRow&gt; method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Authorizes delete request access similar to [AuthorizeUpdate] attribute.

```csharp
public static void AuthorizeUpdate<TRow>(this IPermissionService permissions, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| TRow | Type of row to get Insert/Modify/Read permission attribute from |
| permissions | Permission service |
| localizer | Text localizer |

## See Also

* interface [IPermissionService](../Serenity.Net.Core/../../Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../Serenity.Net.Core/../../Serenity/ITextLocalizer.md)
* class [ServiceAuthorizationExtensions](../ServiceAuthorizationExtensions.md)