# DateHelper class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Static class with common date utilities and constants

```csharp
public static class DateHelper
```

## Public Members

| name | description |
| --- | --- |
| static [CurrentDateElementOrder](DateHelper/CurrentDateElementOrder.md) { get; } | Returns one of "dmy", "ymd", "mdy" date element order depending on current culture. |
| static [CurrentDateFormat](DateHelper/CurrentDateFormat.md) { get; } | Gets default date format for current culture. |
| static [CurrentDateTimeFormat](DateHelper/CurrentDateTimeFormat.md) { get; } | Gets default date time format for current culture. |
| static [ISODateTimeFormatLocal](DateHelper/ISODateTimeFormatLocal.md) | ISO Date and Time Format (up to milliseconds). |
| static [ISODateTimeFormatUTC](DateHelper/ISODateTimeFormatUTC.md) | ISO Date and Time Format (up to milliseconds). |
| static [DateElementOrderFor](DateHelper/DateElementOrderFor.md)(…) | Gets the date element order for specified short date time format. |
| static [DateOrderString](DateHelper/DateOrderString.md)(…) | Gets date order string (one of "dmy", "ymd", "mdy") for a specified order. |
| static [DefaultDateFormat](DateHelper/DefaultDateFormat.md)(…) | Gets default date format for specified order. |
| static [DefaultDateTimeFormat](DateHelper/DefaultDateTimeFormat.md)(…) | Gets default date time format for specified order. |
| static [TryParseISO8601DateTime](DateHelper/TryParseISO8601DateTime.md)(…) | Tries to parse an ISO 8601 date-time string. |

## See Also

* **Source:** *[DateHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Helpers/DateHelper.cs)*