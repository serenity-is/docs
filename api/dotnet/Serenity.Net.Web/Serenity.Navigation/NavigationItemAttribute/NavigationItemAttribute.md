# NavigationItemAttribute constructor (1 of 2)
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the attribute

```csharp
protected NavigationItemAttribute(int order, string path, string url, object permission, 
    string icon)
```

| parameter | description |
| --- | --- |
| order | Order |
| path | Path |
| url | Url |
| permission | Permission |
| icon | Icon class |

## See Also

* class [NavigationItemAttribute](../NavigationItemAttribute.md)

---

# NavigationItemAttribute constructor (2 of 2)
**namespace:** *[Serenity.Navigation](../../README.md#serenity.navigation-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the attribute

```csharp
protected NavigationItemAttribute(int order, string path, Type controller, string icon, 
    string action)
```

| parameter | description |
| --- | --- |
| order | Order |
| path | Path |
| controller | Controller to get URL and the permission from |
| icon | Icon class |
| action | The action name |

## See Also

* class [NavigationItemAttribute](../NavigationItemAttribute.md)