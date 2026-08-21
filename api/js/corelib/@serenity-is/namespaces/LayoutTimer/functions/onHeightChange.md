[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / onHeightChange

# ~~Function: onHeightChange()~~

> **onHeightChange**(`element`, `handler`, `opt?`): `number`

Defined in: [src/compat/layouttimer.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L200)

Registers a handler invoked only when the height of the element changes.
Convenience wrapper around [onSizeChange](onSizeChange.md) with `width: false`.

## Parameters

### element

() => `HTMLElement`

Factory returning the target `HTMLElement`.

### handler

() => `void`

Callback invoked on height change.

### opt?

Optional debounce configuration.

#### debounceTimes?

`number`

Number of polls to debounce before firing.

## Returns

`number`

A numeric registration key.
