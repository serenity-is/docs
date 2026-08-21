[@serenity-is/corelib](../README.md) / addClass

# Function: addClass()

> **addClass**(`el`, `cls`): `void`

Defined in: [src/base/html.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L71)

Adds one or more CSS classes to an element.

## Parameters

### el

`Element`

Target element.

### cls

`string`

Class name or space-separated list of class names to add.

## Returns

`void`

## Remarks

Wraps [toggleClass](toggleClass.md) with `add=true`; no-ops for empty/null inputs.
