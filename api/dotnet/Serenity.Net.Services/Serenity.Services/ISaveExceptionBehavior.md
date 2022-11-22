# ISaveExceptionBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

This is an extension for save behaviors that should be called for exceptions that occur during save. It could be useful to preview the exception and raise another exception for FK / PK database errors etc.

```csharp
public interface ISaveExceptionBehavior
```

## Members

| name | description |
| --- | --- |
| [OnException](ISaveExceptionBehavior/OnException.md)(…) | Called when an exception occurs during save |

## See Also

* **Source:** *[ISaveExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/ISaveExceptionBehavior.cs)*