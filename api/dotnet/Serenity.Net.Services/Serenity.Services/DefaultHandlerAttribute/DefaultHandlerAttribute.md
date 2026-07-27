# DefaultHandlerAttribute constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Specifies that the class this attribute attached to is the default handler (list, create, delete, update etc). and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler.

```csharp
public DefaultHandlerAttribute(bool isDefault = true)
```

| parameter | description |
| --- | --- |
| isDefault | True to specify this as default. Default is true. |

## Remarks

Creates an instance of the attribute

## See Also

* class [DefaultHandlerAttribute](../DefaultHandlerAttribute.md)