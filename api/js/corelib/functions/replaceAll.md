[@serenity-is/corelib](../README.md) / replaceAll

# ~~Function: replaceAll()~~

> **replaceAll**(`str`, `find`, `replace`): `string`

Defined in: [src/compat/strings-compat.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/strings-compat.ts#L128)

Replaces all occurrences of `find` in `str` with `replace`.

## Parameters

### str

`string`

The source string; `null`/`undefined` is treated as `""`.

### find

`string`

The substring to search for. Must be a non-empty string.

### replace

`string`

The replacement string.

## Returns

`string`

A new string with all occurrences replaced.

## Deprecated

Prefer String.prototype.replaceAll when targeting modern runtimes; this shim falls back to `split/join`.
