# IConcurrencyVersionRow interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface for rows that support optimistic concurrency via a version / rowversion field.

```csharp
public interface IConcurrencyVersionRow
```

## Members

| name | description |
| --- | --- |
| [ConcurrencyVersionField](IConcurrencyVersionRow/ConcurrencyVersionField.md) { get; } | Gets the concurrency version field. |

## Remarks

The [`ConcurrencyVersionField`](./IConcurrencyVersionRow/ConcurrencyVersionField.md) is expected to be a table field that is returned to the client (e.g. selected at Details level), but not editable, so it should normally be annotated with `[ReadOnly(true)]`, `[Insertable(false)]` and `[Updatable(false)]`. It can be a database generated row version (e.g. SQL Server `rowversion`) or an application managed version.

On update, the save handler always appends the version to the update's `WHERE` clause and throws a concurrency conflict if no row is affected, implementing optimistic concurrency without a load then update race. The value sent by the client is used when present (detecting a stale read); otherwise the value loaded from the database is used, which still detects a concurrent write between the load and the update (mirroring the server tracked concurrency token behavior of frameworks like EF Core / NHibernate). Databases that manage the version automatically do not need any extra work; for application managed versions, increment the field in a save behavior or a database trigger.

Client side, the value must be sent back with the entity even though there is no form field for it, e.g. it is transferred via row metadata to the entity dialog.

## See Also

* **Source:** *[IConcurrencyVersionRow.cs](https://github.com/serenity-is/Serenity/blob/d947fc2cb1fa45d4549127cb6158b7af08071c3d/src/services/Entity/Contracts/IConcurrencyVersionRow.cs)*