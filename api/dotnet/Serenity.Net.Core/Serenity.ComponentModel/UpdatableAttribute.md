# UpdatableAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls if this field is editable in update record mode. When used with fields, turns on or off the updatable flag.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class UpdatableAttribute : Attribute
```

| parameter | description |
| --- | --- |
| updatable | True to make the field updatable. |

## Public Members

| name | description |
| --- | --- |
| [UpdatableAttribute](UpdatableAttribute/UpdatableAttribute.md)(…) | Controls if this field is editable in update record mode. When used with fields, turns on or off the updatable flag. |
| [Value](UpdatableAttribute/Value.md) { get; } | Gets a value indicating whether this [`UpdatableAttribute`](./UpdatableAttribute.md) is enabled. |

## Remarks

When placed on a field, this attribute controls whether the field is included when updating an existing record.

## See Also

* **Source:** *[UpdatableAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Common/UpdatableAttribute.cs)*