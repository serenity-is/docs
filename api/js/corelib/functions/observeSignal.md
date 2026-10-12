[@serenity-is/corelib](../README.md) / observeSignal

# Function: observeSignal()

> **observeSignal**\<`T`\>(`signal`, `callback`, `opt?`): () => `void`

Defined in: [../domwise/dist/index.d.ts:2954](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2954)

Subscribes to a signal and invokes `callback` immediately and on every subsequent change.

On subscription a SignalObserveArgs object is created and `callback` is
invoked synchronously with `isInitial: true`. Future notifications update
`newValue`/`prevValue`/`hasChanged` and invoke `callback` again. The
returned disposer (when non-null) can be used to unsubscribe; it is also
automatically registered as a disposing listener on `lifecycleNode` /
`lifecycleRoot` so it is cleaned up when the owning DOM node is disposed.

## Type Parameters

### T

`T`

Type of the signal's value.

## Parameters

### signal

[`SignalLike`](../interfaces/SignalLike.md)\<`T`\>

Signal-like object to observe (must have `subscribe`/`peek`/`value`).

### callback

`ObserveSignalCallback`\<`T`\>

Function called initially and on each change.

### opt?

Optional lifecycle wiring.

#### disposeDerivedSignal?

`boolean`

When `true`, the signal's `derivedDisposer` (the subscription from a
derived signal to its source) is registered on the lifecycle node too.
Defaults to `false` so that disposing one consumer of a shared derived
signal does not tear it down for the others.

#### lifecycleNode?

`EventTarget`

Optional DOM node whose `disposing` event will automatically dispose the
subscription via [addDisposingListener](addDisposingListener.md).

#### useLifecycleRoot?

`boolean`

When `true`, the current lifecycle root (see [currentLifecycleRoot](currentLifecycleRoot.md))
at subscription time is recorded as SignalObserveArgs.lifecycleRoot.

## Returns

A disposer function for the subscription, or `null`/`undefined` if the signal does not expose one.

> (): `void`

### Returns

`void`
