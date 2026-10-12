# ServiceLookupEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should use a "ServiceLookup" editor.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ServiceLookupEditorAttribute : ServiceLookupEditorBaseAttribute
```

## Public Members

| name | description |
| --- | --- |
| [ServiceLookupEditorAttribute](ServiceLookupEditorAttribute/ServiceLookupEditorAttribute.md)(…) | Initializes a new instance of the [`ServiceLookupEditorAttribute`](./ServiceLookupEditorAttribute.md) class. (2 constructors) |
| const [Key](ServiceLookupEditorAttribute/Key.md) | Editor type key |
| static [AutoServiceFor](ServiceLookupEditorAttribute/AutoServiceFor.md)(…) | When service is null, this method first tries to determine the service URL from a matching endpoint for row types, then falls back to the module identifier and type name convention. |
| static [TryGetEndpointActionMethod](ServiceLookupEditorAttribute/TryGetEndpointActionMethod.md)(…) | Tries to get an endpoint action method using the same action selection rules used when resolving a service URL. |
| static [TryGetEndpointForRow](ServiceLookupEditorAttribute/TryGetEndpointForRow.md)(…) | Tries to find the endpoint associated with a row type. |
| static [TryGetServiceFromEndpoint](ServiceLookupEditorAttribute/TryGetServiceFromEndpoint.md)(…) | Tries to get the service URL from an endpoint type and action name. |

## Protected Members

| name | description |
| --- | --- |
| [ServiceLookupEditorAttribute](ServiceLookupEditorAttribute/ServiceLookupEditorAttribute.md)() | Initializes a new instance of the [`ServiceLookupEditorAttribute`](./ServiceLookupEditorAttribute.md) class for use by derived editor attributes. |

## See Also

* class [CustomEditorAttribute](./CustomEditorAttribute.md)
* class [ServiceLookupEditorBaseAttribute](./ServiceLookupEditorBaseAttribute.md)
* **Source:** *[ServiceLookupEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/0f59ab4029e52542fa33f98635c200bc56b3773f/src/core/ComponentModel/PropertyGrid/EditorTypes/ServiceLookupEditorAttribute.cs)*