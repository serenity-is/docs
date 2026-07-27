# FileReadAccessAttribute.AllowBypass property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets or sets a value indicating whether bypass is allowed for this operation. The Bypass permission is usually given to administrators and set in FileReadAccessSettings. Default is true, meaning that users with the bypass permission are allowed to read the file.

```csharp
public bool AllowBypass { get; set; }
```

## See Also

* class [FileReadAccessAttribute](../FileReadAccessAttribute.md)