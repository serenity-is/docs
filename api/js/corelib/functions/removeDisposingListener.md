[@serenity-is/corelib](../README.md) / removeDisposingListener

# Function: removeDisposingListener()

> **removeDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T`

Defined in: [../domwise/dist/index.d.ts:2306](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2306)

Removes a disposing listener from an element. Note that this does not remove an event listener from the element,
but removes the listener from the list of disposing listeners that will be called when the `disposing` event
is dispatched on the element. If no more disposing listeners remain, the `disposing` event listener is also
removed from the element.

## Type Parameters

### T

`T` *extends* `EventTarget`

## Parameters

### target

`T`

The element to remove the listener from.

### handler

() => `void`

The disposing listener to remove.

### regKey?

`string`

An optional registration key to identify the listener.

## Returns

`T`

The element that the listener was removed from.
