[@serenity-is/corelib](../README.md) / round

# Function: round()

> **round**(`num`, `d?`): `number`

Defined in: [src/base/formatting.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L289)

Rounds a number to the specified number of fractional digits using "away from zero" rounding.

## Parameters

### num

`number`

Value to round; `undefined` / `NaN` is forwarded to `Math.round` semantics.

### d?

`number`

Number of digits after the decimal point.

## Returns

`number`

The rounded value. `0` is normalized to `0` (not `-0`).

## Default Value

`0` (integer rounding).

## Remarks

Unlike `Math.round`, `1.5` rounds to `2` and `-1.5` rounds to `-2`. Implemented via exponent shifting to avoid floating-point artifacts.

## Example

```ts
round(1.005, 2); // 1.01
round(-1.5);     // -2
```
