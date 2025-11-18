[@serenity-is/domwise](../README.md) / SignalLike

# Interface: SignalLike\<T\>

Defined in: [types/basic-types.d.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L24)

## Extended by

- [`Signal`](Signal.md)
- [`Computed`](Computed.md)

## Type Parameters

### T

`T`

## Accessors

### value

#### Get Signature

> **get** **value**(): `T`

Defined in: [types/basic-types.d.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L25)

##### Returns

`T`

## Methods

### peek()

> **peek**(): `T`

Defined in: [types/basic-types.d.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L26)

#### Returns

`T`

***

### subscribe()

> **subscribe**(`fn`): [`EffectDisposer`](../type-aliases/EffectDisposer.md)

Defined in: [types/basic-types.d.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L27)

#### Parameters

##### fn

(`value`) => `void`

#### Returns

[`EffectDisposer`](../type-aliases/EffectDisposer.md)
