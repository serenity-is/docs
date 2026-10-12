# IRetrieveExceptionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

This is an extension for retrieve behaviors that should be called for exceptions that occur during retrieve. It could be useful to preview the exception and raise another exception for JSON serialization errors etc.

```csharp
public interface IRetrieveExceptionBehavior
```

## Members

| name | description |
| --- | --- |
| [OnException](IRetrieveExceptionBehavior/OnException.md)(…) | Called when an exception occurs during retrieve |

## Remarks

All behaviors implementing this interface are called in order when a retrieve fails. A behavior may translate the original exception by throwing a new one; dispatch then stops and that new exception is what propagates, so the first behavior that throws wins and later behaviors never see the original exception. If no behavior throws, the original exception is rethrown unchanged.

## See Also

* **Source:** *[IRetrieveExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/82aa994c6b620f5437843f746972a159894edd63/src/services/RequestHandlers/Retrieve/IRetrieveExceptionBehavior.cs)*