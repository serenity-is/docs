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

## Remarks

All behaviors implementing this interface are called in order when a save fails. A behavior may translate the original exception by throwing a new one; dispatch then stops and that new exception is what propagates, so the first behavior that throws wins and later behaviors never see the original exception. If no behavior throws, the original exception is rethrown unchanged.

## See Also

* **Source:** *[ISaveExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/82aa994c6b620f5437843f746972a159894edd63/src/services/RequestHandlers/Save/ISaveExceptionBehavior.cs)*