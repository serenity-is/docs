# ListRequest.TimeZone property

The time zone of the user, an IANA one like `Europe/Istanbul`, which is what a browser gives, or a Windows one. It tells where the days start for the intervals of [`GroupBy`](./GroupBy.md), see [`Interval`](../GroupBy/Interval.md), so the dates and times of the fields that are UTC are grouped by the days the user sees. It doesn't change the filters, or the dates that are returned. A service can use it for other things it tells of. When it is not given, the dates are grouped as they are stored.

```csharp
public string? TimeZone { get; set; }
```

## See Also

* class [ListRequest](../ListRequest.md)