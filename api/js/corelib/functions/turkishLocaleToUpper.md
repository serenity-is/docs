[@serenity-is/corelib](../README.md) / turkishLocaleToUpper

# ~~Function: turkishLocaleToUpper()~~

> **turkishLocaleToUpper**(`a`): `string`

Defined in: [src/compat/formatting-compat.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L26)

Uppercases a string with Turkish-specific handling (`i` → `İ`, `ı` → `I`).

## Parameters

### a

`string`

Input string; if falsy, returned as-is.

## Returns

`string`

Uppercased string with Turkish dotted/dotless-I mapping preserved.

## Remarks

Compat shim; for new code prefer `toLocaleUpperCase('tr')`.

## Deprecated

Retained for legacy `Q.turkishLocaleToUpper` call sites.

## Example

```ts
turkishLocaleToUpper("istanbul"); // handles dotted i
```
