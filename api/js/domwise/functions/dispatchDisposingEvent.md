[@serenity-is/domwise](../README.md) / dispatchDisposingEvent

# Function: dispatchDisposingEvent()

> **dispatchDisposingEvent**(`target`, `opt?`): `void`

Defined in: [src/disposing-listener.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L31)

Dispatches a `disposing` event on the target element, causing any
listeners registered via [addDisposingListener](addDisposingListener.md) to be invoked.
No-ops when `target` is falsy or `CustomEvent` is unavailable.

## Parameters

### target

`EventTarget`

Event target to dispatch the event on.

### opt?

Optional event configuration.

#### bubbles?

`boolean`

Whether the event should bubble. Defaults to `false`.

#### cancelable?

`boolean`

Whether the event is cancelable. Defaults to `false`.

## Returns

`void`
