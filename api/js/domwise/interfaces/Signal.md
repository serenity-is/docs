[@serenity-is/domwise](../README.md) / Signal

# Interface: Signal\<T\>

Defined in: [types/basic-types.d.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L102)

A writable signal whose `value` can be set.

## Extends

- [`SignalLike`](SignalLike.md)\<`T`\>

## Type Parameters

### T

`T`

The type of the signal's value.

## Accessors

### value

#### Set Signature

> **set** **value**(`value`): `void`

Defined in: [types/basic-types.d.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L103)

Current value; reading may track a dependency when inside an effect/computed.

##### Parameters

###### value

`T`

##### Returns

`void`

#### Overrides

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
