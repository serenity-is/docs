[@serenity-is/corelib](../README.md) / formatDate

# Function: formatDate()

> **formatDate**(`d`, `format?`, `locale?`): `string`

Defined in: [src/base/formatting.ts:680](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L680)

Formats a `Date` (or date string) using .NET-style format tokens and locale settings.

## Parameters

### d

Date to format, or an ISO / locale date string that is first parsed. Falsy yields `""`.

`string` | `Date`

### format?

`string`

Format string. Special single-letter presets: `"d"` (short date), `"g"` (short datetime without seconds), `"G"` (full datetime), `"t"` (time only), `"s"` (sortable `yyyy-MM-ddTHH:mm:ss`), `"u"` (UTC sortable), `"U"` (locale datetime in UTC), `"i"`/`"id"`/`"it"` (JS `toString` variants). Prefixing with `"%"` forces a custom token (e.g. `"%M"`). When `null`, the locale's `dateFormat` is used.

### locale?

[`Locale`](../interfaces/Locale.md)

Locale overrides token names and separators. Defaults to [Culture](../variables/Culture.md).

## Returns

`string`

The formatted date string, or `""` / the original string on parse failure.

## Example

```ts
formatDate(new Date(2019, 0, 1), "yyyy-MM-dd");                // "2019-01-01"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss");   // "2019-01-01 12:00:00"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff"); // "2019-01-01 12:00:00.000"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff tt"); // "2019-01-01 12:00:00.000 PM"
```
