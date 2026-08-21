[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / off

# ~~Function: off()~~

> **off**(`key`): `number`

Defined in: [src/compat/layouttimer.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L223)

Unregisters a handler previously registered with [onSizeChange](onSizeChange.md) / [onWidthChange](onWidthChange.md) / [onHeightChange](onHeightChange.md) / [onShown](onShown.md).
Stops the internal polling timer when no registrations remain.

## Parameters

### key

`number`

Registration key to remove.

## Returns

`number`

`0` for compatibility with the legacy API.
