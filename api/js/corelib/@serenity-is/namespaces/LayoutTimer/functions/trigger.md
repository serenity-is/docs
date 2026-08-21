[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / trigger

# ~~Function: trigger()~~

> **trigger**(`key`): `void`

Defined in: [src/compat/layouttimer.ts:136](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L136)

Manually triggers the handler for a registration if the element is currently visible (positive width and height).
Re-stores the baseline before and after invoking the handler.

## Parameters

### key

`number`

Registration key returned by [onSizeChange](onSizeChange.md).

## Returns

`void`
