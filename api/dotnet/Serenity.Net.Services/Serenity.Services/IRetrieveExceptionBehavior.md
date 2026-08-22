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

## See Also

* **Source:** *[IRetrieveExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/fa206546471018db1a28b90b807e2a73904efdfa/src/services/RequestHandlers/Retrieve/IRetrieveExceptionBehavior.cs)*