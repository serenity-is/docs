# DefaultHandlerAttribute constructor

Specifies that the class this attribute is attached to is the default handler (list, create, delete, update etc.) and should be used by some behaviors like MasterDetailRelationBehavior instead of creating a generic handler.

```csharp
public DefaultHandlerAttribute(bool isDefault = true)
```

| parameter | description |
| --- | --- |
| isDefault | True to specify this as default. Default is true. |

## Remarks

Initializes a new instance of the attribute.

## See Also

* class [DefaultHandlerAttribute](../DefaultHandlerAttribute.md)