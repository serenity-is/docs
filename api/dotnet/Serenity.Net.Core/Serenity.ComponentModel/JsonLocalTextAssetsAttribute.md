# JsonLocalTextAssetsAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Registers a folder with JSON local text files packed as static web assets for the assembly.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public sealed class JsonLocalTextAssetsAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [JsonLocalTextAssetsAttribute](JsonLocalTextAssetsAttribute/JsonLocalTextAssetsAttribute.md)(…) | Registers a folder with JSON local text files packed as static web assets for the assembly. |
| [Path](JsonLocalTextAssetsAttribute/Path.md) { get; } | The path for the static web assets folder with JSON local text files. |

## Remarks

Initializes a new instance of the [`JsonLocalTextAssetsAttribute`](./JsonLocalTextAssetsAttribute.md) class.

## See Also

* **Source:** *[JsonLocalTextAssetsAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Extensibility/JsonLocalTextAssetsAttribute.cs)*