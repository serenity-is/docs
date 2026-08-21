[@serenity-is/corelib](../README.md) / removeDisposingListener

# Function: removeDisposingListener()

> **removeDisposingListener**\<`T`\>(`target`, `handler`, `regKey?`): `T`

Defined in: [../domwise/dist/index.d.ts:2552](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2552)

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

`T`

Element/event target to remove the listener from. No-op when `null`/`undefined`.

### handler

() => `void`

Callback whose registration should be removed. If `null`/`undefined`, matching falls back to `regKey`.

### regKey?

`string`

Optional registration key to match against.

## Returns

`T`

The `target` that was passed in, for chaining.
