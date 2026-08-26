# Common Helpers

Serenity provides a set of small static helper classes in the `Serenity` namespace for common operations. They're used throughout the framework and are available to your application code. This page gives a brief overview — see the API reference for the full member lists.

## StringHelper

[StringHelper](../api/dotnet/Serenity.Net.Core/Serenity/StringHelper.md) contains extension methods that operate on strings. The most commonly used ones:

- `TrimToNull()` — trims a string and returns `null` if the result is empty (used when saving user input to the database).
- `TrimToEmpty()` — trims a string and returns `""` if the result is empty.
- `IsEmptyOrNull()` / `IsNullOrEmpty()` / `IsTrimmedEmpty()` — null/empty checks.
- `IsTrimmedSame()` — compares two strings ignoring leading/trailing whitespace.
- `ToSingleLine()`, `RemoveDiacritics()`, and other text utilities.

## DateHelper

[DateHelper](../api/dotnet/Serenity.Net.Core/Serenity/DateHelper.md) contains date utilities and constants:

- `ISODateTimeFormatUTC` / `ISODateTimeFormatLocal` — ISO 8601 format strings.
- `TryParseISO8601DateTime()` — parses an ISO 8601 date-time string.
- `CurrentDateElementOrder` / `DateElementOrderFor()` — determines the date element order (`dmy`, `mdy`, `ymd`) for a culture.
- `DateElementOrder` enum — the possible date element orders.

## EnumMapper

[EnumMapper](../api/dotnet/Serenity.Net.Core/Serenity/EnumMapper.md) provides cached enum parsing:

- `Parse<TEnum>(string key)` — parses an enum key or numeric value.
- `TryParse<TEnum>(string key, out TEnum value)` — tries to parse without throwing.
- `ToString(Enum)` — converts an enum value to its key.

## Invariants

[Invariants](../api/dotnet/Serenity.Net.Core/Serenity/Invariants.md) provides invariant-culture constants and conversion helpers:

- `NumberFormat` / `DateTimeFormat` — invariant culture format info.
- `ToInvariant()` — extension methods that convert values (`int`, `long`, `double`, `decimal`, `DateTime`, etc.) to strings using the invariant culture.
- `ToDateTime()` — parses a string to `DateTime` using the invariant culture.

These are important for producing culture-independent strings (e.g. for storage or serialization).

## CollectionExtensions

[CollectionExtensions](../api/dotnet/Serenity.Net.Core/Serenity/CollectionExtensions.md) provides basic collection helpers:

- `AddRange()` — adds multiple items to a collection.
- `Get()` — dictionary lookup that returns the default value if the key isn't found.

## ExceptionExtensions

[ExceptionExtensions](../api/dotnet/Serenity.Net.Core/Serenity/ExceptionExtensions.md) provides exception helpers:

- `SetData()` — sets custom data on the base exception.

## UriHelper

[UriHelper](../api/dotnet/Serenity.Net.Core/Serenity/UriHelper.md) provides URL helpers:

- `Combine(url, fileName)` — combines a URL and a filename by inserting a `/` (like `Path.Combine`), rejecting paths containing `..`.

## PathHelper

[PathHelper](../api/dotnet/Serenity.Net.Core/Serenity/PathHelper.md) provides secure path helpers:

- `IsSecureRelativePath()` / `IsSecureRelativeFile()` — checks whether a path is a safe relative path (no `..`, no root, no invalid characters).
- `SecureCombine(root, relativePath)` — combines a root and a relative path after validating it.
- `ToUrl()` — converts a path to a URL.

These are used by the upload system and other places that handle user-supplied paths.

## IServiceResolver

[IServiceResolver&lt;TService&gt;](../api/dotnet/Serenity.Net.Core/Serenity/IServiceResolver-1.md) is a generic version of `IServiceProvider` that resolves a service on demand. It's covered in detail in [Dependency Injection](dependency-injection.md).

## See Also

- [Dependency Injection](dependency-injection.md)
- [File System](file-system.md)
- [JSON Serialization](json.md)