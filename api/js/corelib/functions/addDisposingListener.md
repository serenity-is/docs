[@serenity-is/corelib](../README.md) / addDisposingListener

# Function: addDisposingListener()

> **addDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T`

Defined in: [../domwise/dist/index.d.ts:2295](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2295)

Adds a disposing listener to an element. Note that the listener itself is not added as an event listener,
but will be called when the `disposing` event is dispatched on the element, along with other disposing listeners.

## Type Parameters

### T

`T` *extends* `EventTarget`

## Parameters

### target

`T`

The element to add the listener to.

### handler

(`el`) => `void`

The disposing listener to add.

### regKey?

`string`

An optional registration key to identify the listener.

## Returns

`T`

The element that the listener was added to.
