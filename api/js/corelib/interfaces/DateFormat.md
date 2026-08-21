[@serenity-is/corelib](../README.md) / DateFormat

# Interface: DateFormat

Defined in: [src/base/formatting.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L28)

Locale settings for date/time formatting, mirroring .NET `DateTimeFormatInfo`.

## Remarks

Consumed by [formatDate](../functions/formatDate.md) and [parseDate](../functions/parseDate.md) via [Culture](../variables/Culture.md).

## Extended by

- [`Locale`](Locale.md)

## Properties

### amDesignator?

> `optional` **amDesignator**: `string`

Defined in: [src/base/formatting.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L38)

Designator for AM hours (used with `t`/`tt` tokens).

#### Default Value

`"AM"`.

***

### dateFormat?

> `optional` **dateFormat**: `string`

Defined in: [src/base/formatting.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L32)

Default date-only format string (e.g. `"dd/MM/yyyy"`).

***

### dateOrder?

> `optional` **dateOrder**: `string`

Defined in: [src/base/formatting.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L34)

Token order for parsing ambiguous numeric dates: `"dmy"`, `"mdy"`, or `"ymd"`.

***

### dateSeparator?

> `optional` **dateSeparator**: `string`

Defined in: [src/base/formatting.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L30)

Character separating date parts (e.g. `"/"` or `"."`).

***

### dateTimeFormat?

> `optional` **dateTimeFormat**: `string`

Defined in: [src/base/formatting.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L36)

Default combined date+time format string (e.g. `"dd/MM/yyyy HH:mm:ss"`).

***

### dayNames?

> `optional` **dayNames**: `string`[]

Defined in: [src/base/formatting.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L46)

Full day names starting with Sunday — 7 entries.

***

### firstDayOfWeek?

> `optional` **firstDayOfWeek**: `number`

Defined in: [src/base/formatting.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L44)

Index of the first day of the week (`0` = Sunday, `1` = Monday).

***

### minimizedDayNames?

> `optional` **minimizedDayNames**: `string`[]

Defined in: [src/base/formatting.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L50)

Two-letter day names (e.g. `"Su"`, `"Mo"`). — 7 entries.

***

### monthNames?

> `optional` **monthNames**: `string`[]

Defined in: [src/base/formatting.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L52)

Full month names starting with January — 12 entries plus a trailing empty slot for compatibility.

***

### pmDesignator?

> `optional` **pmDesignator**: `string`

Defined in: [src/base/formatting.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L40)

Designator for PM hours (used with `t`/`tt` tokens).

#### Default Value

`"PM"`.

***

### shortDayNames?

> `optional` **shortDayNames**: `string`[]

Defined in: [src/base/formatting.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L48)

Abbreviated day names (e.g. `"Sun"`, `"Mon"`). — 7 entries.

***

### shortMonthNames?

> `optional` **shortMonthNames**: `string`[]

Defined in: [src/base/formatting.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L54)

Abbreviated month names (e.g. `"Jan"`, `"Feb"`). — 12 entries plus a trailing empty slot.

***

### timeSeparator?

> `optional` **timeSeparator**: `string`

Defined in: [src/base/formatting.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L42)

Character separating time parts.

#### Default Value

`":"`.
