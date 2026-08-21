[@serenity-is/corelib](../README.md) / splitDateString

# Function: splitDateString()

> **splitDateString**(`s`): `string`[]

Defined in: [src/base/formatting.ts:974](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/formatting.ts#L974)

Splits a date string into its numeric parts using the first detected separator.

## Parameters

### s

`string`

String to split; trimmed before inspection. `null` / empty yields `null`.

## Returns

`string`[]

An array of substrings split by `"/"`, `"."`, `"-"`, or `"\"` (whichever appears first), or a single-element array when none of those separators is present.
