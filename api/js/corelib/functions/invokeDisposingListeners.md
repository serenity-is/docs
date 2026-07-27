[@serenity-is/corelib](../README.md) / invokeDisposingListeners

# Function: invokeDisposingListeners()

> **invokeDisposingListeners**(`node`, `opt?`): `void`

Defined in: [../domwise/dist/index.d.ts:2283](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2283)

Invokes all registered disposing listeners for the element and removes the
global `disposing` event listener from the element as it is no longer needed.
Note that this does not dispatch a `disposing` event; to do that,
use `dispatchDisposingEvent` instead.

## Parameters

### node

`EventTarget`

The node that is being disposed.

### opt?

Optional configuration.

#### descendants?

`boolean`

If true, also invokes listeners on descendant nodes.

#### excludeSelf?

`boolean`

If true, skips invoking listeners on the node itself (only descendants).

## Returns

`void`
