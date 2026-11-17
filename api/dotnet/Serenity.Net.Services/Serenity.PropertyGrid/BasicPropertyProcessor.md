# BasicPropertyProcessor class
**namespace:** *[Serenity.PropertyGrid](../README.md#serenity.propertygrid-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Basic property processor

```csharp
public class BasicPropertyProcessor : PropertyProcessor
```

| parameter | description |
| --- | --- |
| options | The options. |

## Public Members

| name | description |
| --- | --- |
| [BasicPropertyProcessor](BasicPropertyProcessor/BasicPropertyProcessor.md)(…) | Basic property processor |
| override [Priority](BasicPropertyProcessor/Priority.md) { get; } | Gets the priority. |
| override [Process](BasicPropertyProcessor/Process.md)(…) | Sets properties of a PropertyItem by analysing a property source |
| static [SetServiceLookupParams](BasicPropertyProcessor/SetServiceLookupParams.md)(…) | Sets the options of a service lookup editor that its attribute doesn't give, like the service, the id, text and icon fields, the capabilities, and the columns to include, as they are for a property with the attribute. It does nothing for other attributes. Options that are already in the dictionary are left as they are. |

## See Also

* class [PropertyProcessor](./PropertyProcessor.md)
* **Source:** *[BasicPropertyProcessor.Alignment.cs](https://github.com/serenity-is/Serenity/blob/a208f637c41c1cd64c6a2dff54e77302d53f73a8/src/services/Entity/PropertyGrid/BasicPropertyProcessor/BasicPropertyProcessor.Alignment.cs)*