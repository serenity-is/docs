[@serenity-is/domwise](../README.md) / Computed

# Interface: Computed\<T\>

Defined in: [types/basic-types.d.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L110)

A read-only (computed) signal.

## Extends

- [`SignalLike`](SignalLike.md)\<`T`\>

## Type Parameters

### T

`T`

The type of the computed value.

## Accessors

### value

#### Get Signature

> **get** **value**(): `T`

Defined in: [types/basic-types.d.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L84)

Current value; reading may track a dependency when inside an effect/computed.

##### Returns

`T`

#### Inherited from

[`SignalLike`](SignalLike.md).[`value`](SignalLike.md#value)

## Methods

### peek()

> **peek**(): `T`

Defined in: [types/basic-types.d.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L89)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

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

#### Inherited from

[`SignalLike`](SignalLike.md).[`subscribe`](SignalLike.md#subscribe)
