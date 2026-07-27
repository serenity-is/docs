[@serenity-is/corelib](../README.md) / observeSignal

# Function: observeSignal()

> **observeSignal**\<`T`\>(`signal`, `callback`, `opt?`): () => `void`

Defined in: [../domwise/dist/index.d.ts:2484](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2484)

Observes a signal and calls the callback immediately upon subscription and when the signal changes.
Returns an effect disposer that can be used to stop observing.

## Type Parameters

### T

`T`

## Parameters

### signal

[`SignalLike`](../interfaces/SignalLike.md)\<`T`\>

Signal to observe.

### callback

`ObserveSignalCallback`\<`T`\>

Callback to execute immediately upon subscription and when the signal value changes.

### opt?

Optional configuration. useLifecycleRoot - If true, `currentLifecycleRoot()` at
subscription time is recorded as the lifecycle node. lifecycleNode - Optional node to tie the signal's lifecycle
to (auto-disposal on dispose).

#### lifecycleNode?

`EventTarget`

Optional node to tie the signal's lifecycle to.

#### useLifecycleRoot?

`boolean`

If true, `currentLifecycleRoot()` at the time of subscription will be recorded
to be potentially used as the lifecycle node.

## Returns

An effect disposer function, or `null`/`undefined` if the signal does not support disposal.

> (): `void`

### Returns

`void`
