[@serenity-is/corelib](../README.md) / formatDayHourAndMin

# Function: formatDayHourAndMin()

> **formatDayHourAndMin**(`n`): `string`

Defined in: [src/compat/formatting-compat.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L62)

Formats a duration given in minutes as `"d.hh:mm"` (days, hours, minutes).

## Parameters

### n

`number`

Total minutes; `null`/`undefined` yields `""`, `0` yields `"0"`.

## Returns

`string`

Formatted string — e.g. `1500` → `"1.01:00"`, `90` → `"01:30"`.

## Remarks

Days are omitted when zero; minutes part `"00:00"` is omitted when zero unless days is also zero. Compat helper from `Q.formatDayHourAndMin`.

## Example

```ts
formatDayHourAndMin(1500); // "1.01:00"
formatDayHourAndMin(0);    // "0"
```
