# InsertableAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls if this field is editable in new record mode. When used with fields, turns on or off the insertable flag.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class InsertableAttribute : Attribute
```

| parameter | description |
| --- | --- |
| insertable | True to make the field insertable. |

## Public Members

| name | description |
| --- | --- |
| [InsertableAttribute](InsertableAttribute/InsertableAttribute.md)(…) | Controls if this field is editable in new record mode. When used with fields, turns on or off the insertable flag. |
| [Value](InsertableAttribute/Value.md) { get; } | Gets a value indicating whether this [`InsertableAttribute`](./InsertableAttribute.md) is enabled. |

## Remarks

When placed on a field, this attribute controls whether the field is included when inserting a new record.

## See Also

* **Source:** *[InsertableAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Common/InsertableAttribute.cs)*