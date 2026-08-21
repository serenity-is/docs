[@serenity-is/corelib](../README.md) / getElementReadOnly

# Function: getElementReadOnly()

> **getElementReadOnly**(`el`): `boolean`

Defined in: [src/base/html.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L158)

Gets the read-only state of a DOM element without consulting attached widgets.
Considers the `readonly` CSS class, the `disabled` attribute for `select`/`radio`/`checkbox`,
and the `readonly` attribute for other inputs.

## Parameters

### el

`Element`

Element to inspect. Returns `null` if `el` is `null`/`undefined`.

## Returns

`boolean`

`true` if read-only/disabled, `false` otherwise, or `null` when `el` is absent.
