# ServiceAuthorizationExtensions.AuthorizeUndelete&lt;TRow&gt; method (1 of 2)

Authorizes undelete request access similar to [AuthorizeUndelete] attribute.

```csharp
public static void AuthorizeUndelete<TRow>(this IRequestContext context)
```

| parameter | description |
| --- | --- |
| TRow | Type of row to get Undelete/Delete/Modify/Read permission attribute from |
| context | Request context |

## See Also

* interface [IRequestContext](../../Serenity.Services/IRequestContext.md)
* class [ServiceAuthorizationExtensions](../ServiceAuthorizationExtensions.md)

---

# ServiceAuthorizationExtensions.AuthorizeUndelete&lt;TRow&gt; method (2 of 2)

Authorizes undelete request access similar to [AuthorizeUndelete] attribute.

```csharp
public static void AuthorizeUndelete<TRow>(this IPermissionService permissions, 
    ITextLocalizer localizer)
```

| parameter | description |
| --- | --- |
| TRow | Type of row to get Undelete/Delete/Modify/Read permission attribute from |
| permissions | Permission service |
| localizer | Text localizer |

## See Also

* interface [IPermissionService](../../../Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* interface [ITextLocalizer](../../../Serenity.Net.Core/Serenity/ITextLocalizer.md)
* class [ServiceAuthorizationExtensions](../ServiceAuthorizationExtensions.md)