# IDeleteExceptionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

This is an extension for delete behaviors that should be called for exceptions that occur during delete. It could be useful to preview the exception and raise another exception for FK / PK database errors etc.

```csharp
public interface IDeleteExceptionBehavior
```

## Members

| name | description |
| --- | --- |
| [OnException](IDeleteExceptionBehavior/OnException.md)(…) | Called when an exception occurs during delete |

## See Also

* **Source:** *[IDeleteExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/IDeleteExceptionBehavior.cs)*