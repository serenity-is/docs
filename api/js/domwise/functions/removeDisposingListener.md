[@serenity-is/domwise](../README.md) / removeDisposingListener

# Function: removeDisposingListener()

> **removeDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T` \| `null` \| `undefined`

Defined in: [src/disposing-listener.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/disposing-listener.ts#L163)

Removes a previously registered disposing listener from an element.

This removes the entry from the internal disposing-listener registry, not a
direct DOM `EventListener`. A listener matches when either its `handler`
reference equals the stored callback or its `regKey` equals the stored key.
When the last listener is removed the underlying `disposing` DOM listener
is also detached from the target.

## Type Parameters

### T

`T` *extends* `EventTarget`

Type of the target event target.

## Parameters

### target

Element/event target to remove the listener from. No-op when `null`/`undefined`.

`T` | `null` | `undefined`

### handler

Callback whose registration should be removed. If `null`/`undefined`, matching falls back to `regKey`.

() => `void` | `null` | `undefined`

### regKey?

Optional registration key to match against.

`string` | `null`

## Returns

`T` \| `null` \| `undefined`

The `target` that was passed in, for chaining.
