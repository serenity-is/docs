# ServiceRequest.CustomData property
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

A custom data dictionary. Please consider subclassing the service request before passing data via this property. This should be only used in limited cases where subclassing is not feasible. Another option could be to add a [JsonExtensionData] but that could open way to the side effect ignoring typos.

```csharp
public Dictionary<string, object> CustomData { get; set; }
```

## See Also

* class [ServiceRequest](../ServiceRequest.md)