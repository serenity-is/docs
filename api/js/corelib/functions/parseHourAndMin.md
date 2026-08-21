[@serenity-is/corelib](../README.md) / parseHourAndMin

# Function: parseHourAndMin()

> **parseHourAndMin**(`value`): `number`

Defined in: [src/compat/formatting-compat.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L90)

Parses a `"hh:mm"` time string into total minutes.

## Parameters

### value

`string`

String to parse (accepts `h:mm` or `hh:mm`; surrounding whitespace is trimmed).

## Returns

`number`

Total minutes (`h*60+m`), `null` for empty/whitespace input, or `NaN` if the format or range is invalid (hours must be 0–23, minutes 0–59, length 4–5 chars).

## Remarks

Compat helper from `Q.parseHourAndMin`.

## Example

```ts
parseHourAndMin("02:30"); // 150
parseHourAndMin("2:05");  // 125
```
