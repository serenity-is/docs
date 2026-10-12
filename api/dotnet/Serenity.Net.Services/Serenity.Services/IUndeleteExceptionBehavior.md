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

## Remarks

All behaviors implementing this interface are called in order when an undelete fails. A behavior may translate the original exception by throwing a new one; dispatch then stops and that new exception is what propagates, so the first behavior that throws wins and later behaviors never see the original exception. If no behavior throws, the original exception is rethrown unchanged.

## See Also

* **Source:** *[IUndeleteExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/82aa994c6b620f5437843f746972a159894edd63/src/services/RequestHandlers/Undelete/IUndeleteExceptionBehavior.cs)*