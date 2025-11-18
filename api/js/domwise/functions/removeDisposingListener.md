[@serenity-is/domwise](../README.md) / removeDisposingListener

# Function: removeDisposingListener()

> **removeDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T` \| `null` \| `undefined`

Defined in: [src/disposing-listener.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L133)

Removes a disposing listener from an element. Note that this does not remove an event listener from the element,
but removes the listener from the list of disposing listeners that will be called when the `disposing` event
is dispatched on the element. If no more disposing listeners remain, the `disposing` event listener is also 
removed from the element.

## Type Parameters

### T

`T` *extends* `EventTarget`

## Parameters

### target

The element to remove the listener from.

`T` | `null` | `undefined`

### handler

The disposing listener to remove.

() => `void` | `null` | `undefined`

### regKey?

An optional registration key to identify the listener.

`string` | `null`

## Returns

`T` \| `null` \| `undefined`

The element that the listener was removed from.
