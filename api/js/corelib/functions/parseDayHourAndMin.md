[@serenity-is/corelib](../README.md) / parseDayHourAndMin

# Function: parseDayHourAndMin()

> **parseDayHourAndMin**(`s`): `number`

Defined in: [src/compat/formatting-compat.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L121)

Parses a `"d.hh:mm"` duration string into total minutes (also accepts plain `"hh:mm"` or day count).

## Parameters

### s

`string`

String to parse; whitespace is trimmed.

## Returns

`number`

Total minutes, `null` for empty input, or `NaN` for invalid format/range (hours 0–23, minutes 0–59).

## Remarks

Accepts `"d"` (days), `"hh:mm"`, or `"d.hh:mm"` (two-part split on `.`). Delegates the time part to [parseHourAndMin](parseHourAndMin.md). Compat helper from `Q.parseDayHourAndMin`.

## Example

```ts
parseDayHourAndMin("1.01:00"); // 1500
parseDayHourAndMin("01:30");   // 90
```
