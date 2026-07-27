[@serenity-is/corelib](../README.md) / SignalLike

# Interface: SignalLike\<T\>

Defined in: [../domwise/dist/index.d.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L22)

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

Defined in: [../domwise/dist/index.d.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L23)

##### Returns

`T`

## Methods

### peek()

> **peek**(): `T`

Defined in: [../domwise/dist/index.d.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L24)

#### Returns

`T`

***

### subscribe()

> **subscribe**(`fn`): () => `void`

Defined in: [../domwise/dist/index.d.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L25)

#### Parameters

##### fn

(`value`) => `void`

#### Returns

> (): `void`

##### Returns

`void`
