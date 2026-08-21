[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / onWidthChange

# ~~Function: onWidthChange()~~

> **onWidthChange**(`element`, `handler`, `opt?`): `number`

Defined in: [src/compat/layouttimer.ts:187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L187)

Registers a handler invoked only when the width of the element changes.
Convenience wrapper around [onSizeChange](onSizeChange.md) with `height: false`.

## Parameters

### element

() => `HTMLElement`

Factory returning the target `HTMLElement`.

### handler

() => `void`

Callback invoked on width change.

### opt?

Optional debounce configuration.

#### debounceTimes?

`number`

Number of polls to debounce before firing.

## Returns

`number`

A numeric registration key.
