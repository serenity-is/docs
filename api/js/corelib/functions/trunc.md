[@serenity-is/corelib](../README.md) / trunc

# Function: trunc()

> **trunc**(`n`): `number`

Defined in: [src/base/formatting.ts:319](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L319)

Truncates a number toward zero to an integer.

## Parameters

### n

`number`

Value to truncate; `null` / `undefined` returns `null`.

## Returns

`number`

The integer part of `n` (toward zero), or `null` for nullish input.

## Example

```ts
trunc(1.9);  // 1
trunc(-1.9); // -1
```
