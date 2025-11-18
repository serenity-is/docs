[@serenity-is/domwise](../README.md) / observeSignal

# Function: observeSignal()

> **observeSignal**\<`T`\>(`signal`, `callback`, `opt?`): [`EffectDisposer`](../type-aliases/EffectDisposer.md) \| `undefined`

Defined in: [src/signal-util.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signal-util.ts#L123)

Observes a signal and calls the callback immediately upon subscription and when the signal changes.

## Type Parameters

### T

`T`

## Parameters

### signal

[`SignalLike`](../interfaces/SignalLike.md)\<`T`\>

Signal to observe

### callback

`ObserveSignalCallback`\<`T`\>

Callback to execute immediately upon subscription and when the signal value changes.

### opt?

#### lifecycleNode?

`EventTarget`

Optional node to tie the signal's lifecycle to.

#### useLifecycleRoot?

`boolean`

If true, `currentLifecycleRoot()` at the time of subscription will be recorded
to be potentially used as the lifecycle node.

## Returns

[`EffectDisposer`](../type-aliases/EffectDisposer.md) \| `undefined`
