# LoggingRow&lt;TFields&gt; class
**namespace:** *[Serenity.Extensions.Entities](../README.md#serenity.extensions.entities-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

This is a sample base class for rows that does insert/update date and user audit logging automatically. It is recommended to create your own base class, if your auditing field names are different than these. You should implement IInsertLogRow and/or IUpdateLogRow interfaces. ILoggingRow is a combination of these two. There is also an optional IDeleteLogRow interface that supports auditing on delete but for it to work you need to also implement IIsActiveDeletedRow so that your rows aren't actually deleted.

```csharp
public abstract class LoggingRow<TFields> : Row<TFields>, ILoggingRow
    where TFields : LoggingRowFields
```

## Public Members

| name | description |
| --- | --- |
| [InsertDate](LoggingRow-1/InsertDate.md) { get; set; } | Gets or sets the date and time the row was inserted. |
| [InsertUserId](LoggingRow-1/InsertUserId.md) { get; set; } | Gets or sets the ID of the user who inserted the row. |
| [UpdateDate](LoggingRow-1/UpdateDate.md) { get; set; } | Gets or sets the date and time the row was last updated. |
| [UpdateUserId](LoggingRow-1/UpdateUserId.md) { get; set; } | Gets or sets the ID of the user who last updated the row. |

## Protected Members

| name | description |
| --- | --- |
| [LoggingRow](LoggingRow-1/LoggingRow.md)() | Creates a new instance of the class. |
| [LoggingRow](LoggingRow-1/LoggingRow.md)(…) | Creates a new instance of the class with the specified fields. |

## See Also

* class [Row&lt;TFields&gt;](../../Serenity.Net.Services/Serenity.Data/Row-1.md)
* interface [ILoggingRow](../../Serenity.Net.Services/Serenity.Data/ILoggingRow.md)
* class [LoggingRowFields](./LoggingRowFields.md)
* **Source:** *[LoggingRow.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/BaseEntities/LoggingRow.cs)*