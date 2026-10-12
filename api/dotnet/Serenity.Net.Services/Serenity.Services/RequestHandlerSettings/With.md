# RequestHandlerSettings.With method

Creates a copy of these settings with the specified changes applied, without modifying this instance. Useful for returning different settings per request / entity, e.g. a limited page size for public access and unlimited for administrators.

```csharp
public RequestHandlerSettings With(Action<RequestHandlerSettings> configure)
```

| parameter | description |
| --- | --- |
| configure | Action that modifies the copied settings. |

## Return Value

The copied settings.

## See Also

* class [RequestHandlerSettings](../RequestHandlerSettings.md)