[@serenity-is/corelib](../../../../README.md) / [LayoutTimer](../README.md) / onSizeChange

# ~~Function: onSizeChange()~~

> **onSizeChange**(`element`, `handler`, `opt?`): `number`

Defined in: [src/compat/layouttimer.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/compat/layouttimer.ts#L160)

Registers a handler invoked when the size of the element returned by `element()` changes.
Polls via an internal timer; supports filtering by width / height and optional debouncing.

## Parameters

### element

() => `Window` \| `HTMLElement`

Factory returning the target `HTMLElement` or `Window` to watch.

### handler

() => `void`

Callback invoked when a matching size change is detected.

### opt?

Watch options.

#### debounceTimes?

`number`

Number of polls to debounce before firing. `0` fires immediately. Defaults to `0`.

#### height?

`boolean`

When `false`, height changes are ignored. Defaults to `true`.

#### width?

`boolean`

When `false`, width changes are ignored. Defaults to `true`.

## Returns

`number`

A numeric registration key that can be passed to [store](store.md), [trigger](trigger.md), or [off](off.md).
