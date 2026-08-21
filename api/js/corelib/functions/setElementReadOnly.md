[@serenity-is/corelib](../README.md) / setElementReadOnly

# Function: setElementReadOnly()

> **setElementReadOnly**(`elements`, `value`): `void`

Defined in: [src/base/html.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L178)

Sets the read-only appearance and attribute on one or more elements without touching attached widgets.
Toggles the `readonly` CSS class and sets `disabled` (for `select`/`radio`/`checkbox`) or `readonly` (for other elements).

## Parameters

### elements

Single element or array-like collection of elements. No-op if falsy.

`Element` | `ArrayLike`\<`Element`\>

### value

`boolean`

`true` to make read-only/disabled, `false` to make editable.

## Returns

`void`
