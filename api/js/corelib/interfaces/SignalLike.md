[@serenity-is/corelib](../README.md) / SignalLike

# Interface: SignalLike\<T\>

Defined in: [../domwise/dist/index.d.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L78)

A read-only signal-like value that can be subscribed to and peeked.
Compatible with `@preact/signals-core` and any duck-typed signal that
exposes `value`, `peek`, and `subscribe`.

## Extended by

- [`Signal`](Signal.md)
- [`Computed`](Computed.md)

## Type Parameters

### T

`T`

The type of the signal's value.

## Accessors

### value

#### Get Signature

> **get** **value**(): `T`

Defined in: [../domwise/dist/index.d.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L80)

Current value; reading may track a dependency when inside an effect/computed.

##### Returns

`T`

## Methods

### peek()

> **peek**(): `T`

Defined in: [../domwise/dist/index.d.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L85)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

***

### subscribe()

> **subscribe**(`fn`): () => `void`

Defined in: [../domwise/dist/index.d.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L91)

Subscribes to value changes.

#### Parameters

##### fn

(`value`) => `void`

Callback invoked with each new value (and typically immediately with the current value).

#### Returns

A disposer that unsubscribes, or `null` if unsubscription is not supported.

> (): `void`

##### Returns

`void`
