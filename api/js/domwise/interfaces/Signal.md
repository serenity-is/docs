[@serenity-is/domwise](../README.md) / Signal

# Interface: Signal\<T\>

Defined in: [types/basic-types.d.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L30)

## Extends

- [`SignalLike`](SignalLike.md)\<`T`\>

## Type Parameters

### T

`T`

## Accessors

### value

#### Set Signature

> **set** **value**(`value`): `void`

Defined in: [types/basic-types.d.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L31)

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

Defined in: [types/basic-types.d.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L26)

#### Returns

`T`

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

***

### subscribe()

> **subscribe**(`fn`): [`EffectDisposer`](../type-aliases/EffectDisposer.md)

Defined in: [types/basic-types.d.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L27)

#### Parameters

##### fn

(`value`) => `void`

#### Returns

[`EffectDisposer`](../type-aliases/EffectDisposer.md)

#### Inherited from

[`SignalLike`](SignalLike.md).[`subscribe`](SignalLike.md#subscribe)
