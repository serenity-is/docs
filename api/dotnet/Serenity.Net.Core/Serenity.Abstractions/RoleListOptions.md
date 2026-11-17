# RoleListOptions class
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Options for listing roles with [`IRoleListService`](./IRoleListService.md).

```csharp
public class RoleListOptions
```

## Public Members

| name | description |
| --- | --- |
| [RoleListOptions](RoleListOptions/RoleListOptions.md)() | The default constructor. |
| [ContainsText](RoleListOptions/ContainsText.md) { get; set; } | Gets or sets a text that the name or the key of the roles should contain, which is compared the way the database compares text, so it is case insensitive with the usual collations. All roles match when it is blank. |
| [Take](RoleListOptions/Take.md) { get; set; } | Gets or sets the maximum number of roles to list, ordered by name. All roles are listed when it is zero or less. |

## See Also

* **Source:** *[RoleListOptions.cs](https://github.com/serenity-is/Serenity/blob/882461e9795b4808b6c6068fb00cfed131e6a69d/src/core/Authorization/RoleListOptions.cs)*