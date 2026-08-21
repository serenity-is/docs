# PropertyItemsLocalTextRegistration.GetPropertyItemsTextPrefix method
**namespace:** *[Serenity.Localization](../../README.md#serenity.localization-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets the form/column local text key prefix for the given type.

```csharp
public static string GetPropertyItemsTextPrefix(Type type)
```

| parameter | description |
| --- | --- |
| type | The type with a form or column attribute. |

## Return Value

The local text key prefix, or `null` if the type has neither a form nor a column attribute.

## See Also

* class [PropertyItemsLocalTextRegistration](../PropertyItemsLocalTextRegistration.md)