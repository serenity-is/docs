# AllowHideAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls the user's ability to hide a column, e.g. using the column picker.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class AllowHideAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | If set to `false`, the column cannot be hidden by the user. |

## Public Members

| name | description |
| --- | --- |
| [AllowHideAttribute](AllowHideAttribute/AllowHideAttribute.md)(…) | Controls the user's ability to hide a column, e.g. using the column picker. |
| [Value](AllowHideAttribute/Value.md) { get; } | Gets a value indicating whether this [`AllowHideAttribute`](./AllowHideAttribute.md) is on. |

## Remarks

Initializes a new instance of the [`AllowHideAttribute`](./AllowHideAttribute.md) class.

## See Also

* **Source:** *[AllowHideAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Common/AllowHideAttribute.cs)*