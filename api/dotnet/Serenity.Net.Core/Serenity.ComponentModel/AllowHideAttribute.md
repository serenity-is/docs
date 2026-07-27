# AllowHideAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls users ability to hide a column, e.g. using column picker.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class AllowHideAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `false` column can't be hidden by user. |

## Public Members

| name | description |
| --- | --- |
| [AllowHideAttribute](AllowHideAttribute/AllowHideAttribute.md)(…) | Controls users ability to hide a column, e.g. using column picker. |
| [Value](AllowHideAttribute/Value.md) { get; } | Gets a value indicating whether this [`AllowHideAttribute`](AllowHideAttribute.md) is ON. |

## Remarks

Initializes a new instance of the [`AllowHideAttribute`](AllowHideAttribute.md) class.

## See Also

* **Source:** *[AllowHideAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Common/AllowHideAttribute.cs)*