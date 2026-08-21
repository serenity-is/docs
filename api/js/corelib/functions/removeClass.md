[@serenity-is/corelib](../README.md) / removeClass

# Function: removeClass()

> **removeClass**(`el`, `cls`): `void`

Defined in: [src/base/html.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L81)

Removes one or more CSS classes from an element.

## Parameters

### el

`Element`

Target element.

### cls

`string`

Class name or space-separated list of class names to remove.

## Returns

`void`

## Remarks

Wraps [toggleClass](toggleClass.md) with `add=false`; no-ops for empty/null inputs.
