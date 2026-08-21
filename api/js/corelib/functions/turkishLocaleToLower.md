[@serenity-is/corelib](../README.md) / turkishLocaleToLower

# ~~Function: turkishLocaleToLower()~~

> **turkishLocaleToLower**(`a`): `string`

Defined in: [src/compat/formatting-compat.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/formatting-compat.ts#L11)

Lowercases a string with Turkish-specific handling (`İ` → `i`, `I` → `ı`).

## Parameters

### a

`string`

Input string; if falsy, returned as-is.

## Returns

`string`

Lowercased string with Turkish dotted/dotless-I mapping preserved.

## Remarks

Compat shim retained because native `String.prototype.toLocaleLowerCase('tr')` behaves differently across engines; prefer locale-aware APIs for new code.

## Deprecated

Retained for legacy `Q.turkishLocaleToLower` call sites.

## Example

```ts
turkishLocaleToLower("İSTANBUL"); // "istanbul" with ı handling
```
