[@serenity-is/corelib](../README.md) / toggleClass

# Function: toggleClass()

> **toggleClass**(`el`, `cls`, `add?`): `void`

Defined in: [src/base/html.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L51)

Toggles one or more CSS classes on an element, supporting space-separated lists.
When `cls` contains spaces it is split and each token is toggled individually.

## Parameters

### el

`Element`

Target element. No-op if falsy.

### cls

`string`

Single class or space-separated class list to toggle. No-op if `null`/empty.

### add?

`boolean`

Force mode: `true` to add, `false` to remove, `undefined` to toggle.

## Returns

`void`

## Remarks

Delegates to `Element.classList.toggle` per token, preserving existing classes.
