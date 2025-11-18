[@serenity-is/domwise](../README.md) / addDisposingListener

# Function: addDisposingListener()

> **addDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T` \| `null` \| `undefined`

Defined in: [src/disposing-listener.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L93)

Adds a disposing listener to an element. Note that the listener itself is not added as an event listener,
but will be called when the `disposing` event is dispatched on the element, along with other disposing listeners.

## Type Parameters

### T

`T` *extends* `EventTarget`

## Parameters

### target

The element to add the listener to.

`T` | `null` | `undefined`

### handler

The disposing listener to add.

(`el`) => `void` | `null` | `undefined`

### regKey?

`string`

An optional registration key to identify the listener.

## Returns

`T` \| `null` \| `undefined`

The element that the listener was added to.
