[@serenity-is/sleekgrid](../README.md) / parsePx

# Function: parsePx()

> **parsePx**(`str`): `number`

Defined in: [src/core/util.tsx:185](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/util.tsx#L185)

Parses a CSS pixel string (e.g. `"20px"`) into a number, returning `0` for non-numeric input.

## Parameters

### str

`string`

CSS length string to parse.

## Returns

`number`

Numeric pixel value or `0` when parsing fails.
