# DefaultHandlerAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public class DefaultHandlerAttribute : Attribute
```

| parameter | description |
| --- | --- |
| isDefault | True to specify this as default. Default is true. |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerAttribute](DefaultHandlerAttribute/DefaultHandlerAttribute.md)(…) | Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler. |
| [Value](DefaultHandlerAttribute/Value.md) { get; } | Gets if the handler marked as default. |

## Remarks

Creates an instance of the attribute

## See Also

* **Source:** *[DefaultHandlerAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/Handler/DefaultHandlerAttribute.cs)*