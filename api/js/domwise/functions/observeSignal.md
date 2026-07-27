[@serenity-is/domwise](../README.md) / observeSignal

# Function: observeSignal()

> **observeSignal**\<`T`\>(`signal`, `callback`, `opt?`): [`EffectDisposer`](../type-aliases/EffectDisposer.md) \| `undefined`

Defined in: [src/signal-util.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signal-util.ts#L143)

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

[`EffectDisposer`](../type-aliases/EffectDisposer.md) \| `undefined`

An effect disposer function, or `null`/`undefined` if the signal does not support disposal.
