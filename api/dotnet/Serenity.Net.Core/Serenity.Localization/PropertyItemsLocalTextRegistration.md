# PropertyItemsLocalTextRegistration class
**namespace:** *[Serenity.Localization](../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Contains initialization method for adding local text keys implicitly defined by DisplayName, Tab, Placeholder, Hint etc. attributes used in Form definitions

```csharp
public static class PropertyItemsLocalTextRegistration
```

## Public Members

| name | description |
| --- | --- |
| static [AddPropertyItemsTexts](PropertyItemsLocalTextRegistration/AddPropertyItemsTexts.md)(…) | Adds local text translations defined implicitly by DisplayName, Tab, Placeholder, Hint etc. attributes used in Column/Form etc. definitions. |
| static [GetPropertyItemsTextPrefix](PropertyItemsLocalTextRegistration/GetPropertyItemsTextPrefix.md)(…) | Gets form/column local text key prefix for given type |
| static [IsLocalTextKeyCandidate](PropertyItemsLocalTextRegistration/IsLocalTextKeyCandidate.md)(…) | Returns true if the text value can be a local text key that could be passed to the client side |

## See Also

* **Source:** *[PropertyItemsLocalTextRegistration.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Localization/PropertyItemsLocalTextRegistration.cs)*