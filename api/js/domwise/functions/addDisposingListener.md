[@serenity-is/domwise](../README.md) / addDisposingListener

# Function: addDisposingListener()

> **addDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T` \| `null` \| `undefined`

Defined in: [src/disposing-listener.ts:118](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L118)

Registers a disposing listener for an element.

The `handler` is not added as a direct DOM event listener; instead it is
stored in an internal `WeakMap` and invoked when a `disposing` event is
dispatched on `target` (via [dispatchDisposingEvent](dispatchDisposingEvent.md) or
[invokeDisposingListeners](invokeDisposingListeners.md)). The first registration on a given target
also installs a one-shot `disposing` event listener to drive the callback
list. Duplicate `handler` references are ignored (with optional `regKey`
tracking), so calling this multiple times with the same callback is safe.

## Type Parameters

### T

`T` *extends* `EventTarget`

Type of the target event target.

## Parameters

### target

Element/event target to attach the listener to. No-op when `null`/`undefined`.

`T` | `null` | `undefined`

### handler

Callback invoked with the element when it is disposing. No-op when `null`/`undefined`.

(`el`) => `void` | `null` | `undefined`

### regKey?

`string`

Optional registration key used to de-duplicate or later remove this listener.

## Returns

`T` \| `null` \| `undefined`

The `target` that was passed in, for chaining.

## Throws

When the same `handler` is already registered with a different `regKey`.
