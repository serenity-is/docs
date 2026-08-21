[@serenity-is/corelib](../README.md) / isBS3

# Function: isBS3()

> **isBS3**(): `boolean`

Defined in: [src/base/environment.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/environment.ts#L21)

Determines whether Bootstrap 3 is loaded on the page.

## Returns

`boolean`

`true` if Bootstrap 3 is detected, otherwise `false`.

## Remarks

Inspects `jQuery.fn.modal.Constructor.VERSION`; the check is safe when
jQuery or the modal plugin is absent.
