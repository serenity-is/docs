# ListRequestCapabilitiesAttribute class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Specifies the ListRequest capabilities supported by a list endpoint action.

```csharp
[AttributeUsage(AttributeTargets.Method)]
public sealed class ListRequestCapabilitiesAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ListRequestCapabilitiesAttribute](ListRequestCapabilitiesAttribute/ListRequestCapabilitiesAttribute.md)(…) | Initializes a new instance of the [`ListRequestCapabilitiesAttribute`](./ListRequestCapabilitiesAttribute.md) class. |
| [Capabilities](ListRequestCapabilitiesAttribute/Capabilities.md) { get; } | Gets the supported ListRequest capabilities. |
| [Exclude](ListRequestCapabilitiesAttribute/Exclude.md) { get; set; } | Gets or sets the capabilities to remove from [`Capabilities`](./ListRequestCapabilitiesAttribute/Capabilities.md). |

## Remarks

[`Capabilities`](./ListRequestCapabilitiesAttribute/Capabilities.md) declares the supported set. [`Exclude`](./ListRequestCapabilitiesAttribute/Exclude.md) removes specific capabilities from that set.

## See Also

* **Source:** *[ListRequestCapabilitiesAttribute.cs](https://github.com/serenity-is/Serenity/blob/f19d8098527e3131b61db7edf5c8ad1271a00941/src/core/ComponentModel/Services/ListRequestCapabilitiesAttribute.cs)*