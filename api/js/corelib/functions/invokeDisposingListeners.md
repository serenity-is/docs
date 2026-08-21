[@serenity-is/corelib](../README.md) / invokeDisposingListeners

# Function: invokeDisposingListeners()

> **invokeDisposingListeners**(`node`, `opt?`): `void`

Defined in: [../domwise/dist/index.d.ts:2514](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2514)

Synchronously invokes all disposing listeners registered for `node` and
removes the internal `disposing` DOM listener from the target.

This does **not** dispatch a `disposing` DOM event; use
[dispatchDisposingEvent](dispatchDisposingEvent.md) for that. Listener errors are swallowed.

## Parameters

### node

`EventTarget`

Target whose disposing listeners should be invoked. No-op when falsy.

### opt?

Optional behavior flags.

#### descendants?

`boolean`

When `true`, also invokes listeners registered on descendant elements/text/comment nodes found via `createNodeIterator`.

#### excludeSelf?

`boolean`

When `true`, skips listeners registered directly on `node` itself (only descendants are invoked, in combination with `descendants`).

## Returns

`void`
