# IUndeleteExceptionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

This is an extension for undelete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc.

```csharp
public interface IUndeleteExceptionBehavior
```

## Members

| name | description |
| --- | --- |
| [OnException](IUndeleteExceptionBehavior/OnException.md)(…) | Called when an exception occurs during undelete |

## See Also

* **Source:** *[IUndeleteExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/IUndeleteExceptionBehavior.cs)*