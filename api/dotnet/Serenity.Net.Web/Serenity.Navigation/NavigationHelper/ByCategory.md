# NavigationHelper.ByCategory method

Creates a lookup of navigation item attributes by their category.

```csharp
public static ILookup<string, NavigationItemAttribute> ByCategory(
    IEnumerable<NavigationItemAttribute> list)
```

| parameter | description |
| --- | --- |
| list | The list with navigation item attributes. |

## Return Value

A lookup of navigation item attributes by category.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *list* is `null`. |

## See Also

* class [NavigationItemAttribute](../../../Serenity.Net.Core/Serenity.Navigation/NavigationItemAttribute.md)
* class [NavigationHelper](../NavigationHelper.md)