# IRow.TrackWithChecks property
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets or sets a flag indicating whether to track assignments to field values in addition to throwing an exception on read if an unassigned field with null value is accessed. Setting this to true implicitly sets TrackAssignments to true, and setting it to false does not change TrackAssignments value. This flag is useful when loading a partial row from a database query and you want to ensure that only assigned fields are read. Connection extensions like List, ById, etc. automatically set this flag to true for rows they load.

```csharp
public bool TrackWithChecks { get; set; }
```

## Property Value

`true` if track with checks; otherwise, `false`.

## See Also

* interface [IRow](../IRow.md)