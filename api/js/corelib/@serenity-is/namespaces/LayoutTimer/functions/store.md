[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / store

# ~~Function: store()~~

> **store**(`key`): `void`

Defined in: [src/compat/layouttimer.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L116)

Captures and stores the current size of a registered element without firing its handler.
Used to reset the baseline so the next poll compares against the current dimensions.

## Parameters

### key

`number`

Registration key returned by [onSizeChange](onSizeChange.md) / [onShown](onShown.md) / etc.

## Returns

`void`
