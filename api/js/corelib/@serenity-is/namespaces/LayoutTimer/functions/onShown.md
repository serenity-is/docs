[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / onShown

# ~~Function: onShown()~~

> **onShown**(`element`, `handler`, `opt?`): `number`

Defined in: [src/compat/layouttimer.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L213)

Registers a handler invoked when the element becomes visible (transitions from zero to non-zero size).
Wrapper around [onSizeChange](onSizeChange.md) with both `width` and `height` set to `false` so only hidden-to-visible transitions fire.

## Parameters

### element

() => `HTMLElement`

Factory returning the target `HTMLElement`.

### handler

() => `void`

Callback invoked when the element is shown.

### opt?

Optional debounce configuration.

#### debounceTimes?

`number`

Number of polls to debounce before firing.

## Returns

`number`

A numeric registration key.
