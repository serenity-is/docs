[@serenity-is/corelib](../README.md) / formatDate

# Function: formatDate()

> **formatDate**(`d`, `format`?, `locale`?): `string`

Formats a date using the specified format string and optional culture.
Supports .NET style format strings including custom formats.
See .NET documentation for supported formats.

## Parameters

### d

`string` | `Date`

### format?

`string`

the format string to use. If null, it uses the current culture's default format.
'G' uses the culture's datetime format.
'g' uses the culture's datetime format with secs removed. 
'd' uses the culture's date format.
't' uses the culture's time format.
'u' uses the sortable ISO format with UTC time.
'U' uses the culture's date format with UTC time.

### locale?

[`Locale`](../interfaces/Locale.md)

the locale to use

## Returns

`string`

the formatted date

## Examples

```ts
// returns "2019-01-01"
formatDate(new Date(2019, 0, 1), "yyyy-MM-dd");
```

```ts
// returns "2019-01-01 12:00:00"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss");
```

```ts
// returns "2019-01-01 12:00:00.000"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff");
```

```ts
// returns "2019-01-01 12:00:00.000 AM"
formatDate(new Date(2019, 0, 1, 12), "yyyy-MM-dd HH:mm:ss.fff tt");
```

## Defined in

[src/base/formatting.ts:622](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L622)
