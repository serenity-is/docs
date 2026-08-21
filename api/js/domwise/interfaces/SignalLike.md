[@serenity-is/domwise](../README.md) / SignalLike

# Interface: SignalLike\<T\>

Defined in: [types/basic-types.d.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L82)

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

Defined in: [types/basic-types.d.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L84)

Current value; reading may track a dependency when inside an effect/computed.

##### Returns

`T`

## Methods

### peek()

> **peek**(): `T`

Defined in: [types/basic-types.d.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L89)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

***

### subscribe()

> **subscribe**(`fn`): [`EffectDisposer`](../type-aliases/EffectDisposer.md)

Defined in: [types/basic-types.d.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L95)

Subscribes to value changes.

#### Parameters

##### fn

(`value`) => `void`

Callback invoked with each new value (and typically immediately with the current value).

#### Returns

[`EffectDisposer`](../type-aliases/EffectDisposer.md)

A disposer that unsubscribes, or `null` if unsubscription is not supported.
