# IListExceptionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

This is an extension for list behaviors that should be called for exceptions that occur during list. It could be useful to preview the exception and raise another exception for JSON serialization errors etc.

```csharp
public interface IListExceptionBehavior
```

## Members

| name | description |
| --- | --- |
| [OnException](IListExceptionBehavior/OnException.md)(…) | Called when an exception occurs during list |

## See Also

* **Source:** *[IListExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/List/IListExceptionBehavior.cs)*