# ServiceLookupPermissionAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets a permission to read only lookup fields in a row via List service Lookup field means ID, Name, and [LookupInclude] properties in a row. You must use [AuthorizeList(typeof(XRow))] instead of ServiceAuthorize in service endpoint.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class ServiceLookupPermissionAttribute : PermissionAttributeBase
```

## Public Members

| name | description |
| --- | --- |
| [ServiceLookupPermissionAttribute](ServiceLookupPermissionAttribute/ServiceLookupPermissionAttribute.md)(…) | Initializes a new instance of the [`ServiceLookupPermissionAttribute`](ServiceLookupPermissionAttribute.md) class. (3 constructors) |

## See Also

* class [PermissionAttributeBase](PermissionAttributeBase.md)
* **Source:** *[ServiceLookupPermissionAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Permission/ServiceLookupPermissionAttribute.cs)*