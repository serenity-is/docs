# StringHelper class
**namespace:** *[Serenity](../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

This static class contains some helper functions that operate on String objects.

```csharp
public static class StringHelper
```

## Public Members

| name | description |
| --- | --- |
| static [IsEmptyOrNull](StringHelper/IsEmptyOrNull.md)(…) | Returns true if String is `null` or empty (zero length) (2 methods) |
| static [IsNullOrEmpty](StringHelper/IsNullOrEmpty.md)(…) | Returns true if String is `null` or empty (zero length) |
| static [IsTrimmedEmpty](StringHelper/IsTrimmedEmpty.md)(…) | Checks if a string String is `null`, empty or just contains whitespace characters. |
| static [IsTrimmedSame](StringHelper/IsTrimmedSame.md)(…) | Compares two strings ignoring whitespace at the left or right. |
| static [Join](StringHelper/Join.md)(…) | Joins two strings conditionally, by putting separator between if both are non empty |
| static [QuoteString](StringHelper/QuoteString.md)(…) | Quotes a string |
| static [RemoveDiacritics](StringHelper/RemoveDiacritics.md)(…) | Removes the diacritic characters from string by replacing them with ASCII versions. |
| static [SafeSubstring](StringHelper/SafeSubstring.md)(…) | A substring function that doesn't raise out of bound errors or null reference exception. |
| static [SanitizeFilename](StringHelper/SanitizeFilename.md)(…) | Sanitizes the filename by replacing /, :, &amp;, ı characters. |
| static [ThreeDots](StringHelper/ThreeDots.md)(…) | If the string's length is over a specified limit, trims its right and adds three points ("..."). |
| static [ToSingleLine](StringHelper/ToSingleLine.md)(…) | Converts the string to single line by replacing line endings with space. |
| static [ToSingleQuoted](StringHelper/ToSingleQuoted.md)(…) | Converts the string to its single quoted representation. |
| static [ToStringDefault&lt;T&gt;](StringHelper/ToStringDefault.md)(…) | Formats a nullable struct (2 methods) |
| static [TrimToEmpty](StringHelper/TrimToEmpty.md)(…) | Removes whitespace characters in the left or right of the String string, and if resulting string is empty or null, returns empty. |
| static [TrimToNull](StringHelper/TrimToNull.md)(…) | Removes whitespace characters in the left or right of the String string, and if resulting string is empty or null, returns null. |

## See Also

* **Source:** *[StringHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Helpers/StringHelper.cs)*