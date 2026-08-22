# UserPreferenceRow class
**namespace:** *[Serenity.Extensions.Entities](../README.md#serenity.extensions.entities-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Row for user preferences.

```csharp
public sealed class UserPreferenceRow : Row<RowFields>, IIdRow, INameRow
```

## Public Members

| name | description |
| --- | --- |
| [UserPreferenceRow](UserPreferenceRow/UserPreferenceRow.md)() | The default constructor. |
| [Name](UserPreferenceRow/Name.md) { get; set; } | The preference name. |
| [PreferenceType](UserPreferenceRow/PreferenceType.md) { get; set; } | The preference type. |
| [UserId](UserPreferenceRow/UserId.md) { get; set; } | The ID of the user the preference belongs to. |
| [UserPreferenceId](UserPreferenceRow/UserPreferenceId.md) { get; set; } | The user preference ID. |
| [Value](UserPreferenceRow/Value.md) { get; set; } | The preference value. |
| class [RowFields](UserPreferenceRow.RowFields.md) | The fields of the [`UserPreferenceRow`](UserPreferenceRow.md). |

## See Also

* class [Row&lt;TFields&gt;](../Serenity.Net.Services/../Serenity.Data/Row-1.md)
* class [RowFields](UserPreferenceRow.RowFields.md)
* interface [IIdRow](../Serenity.Net.Services/../Serenity.Data/IIdRow.md)
* interface [INameRow](../Serenity.Net.Services/../Serenity.Data/INameRow.md)
* **Source:** *[UserPreferenceRow.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/UserPreference/UserPreferenceRow.cs)*