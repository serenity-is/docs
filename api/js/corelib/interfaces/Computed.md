[@serenity-is/corelib](../README.md) / Computed

# Interface: Computed\<T\>

Defined in: [../domwise/dist/index.d.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L30)

## Extends

- [`SignalLike`](SignalLike.md)\<`T`\>

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

#### Inherited from

[`SignalLike`](SignalLike.md).[`value`](SignalLike.md#value)

## Methods

### peek()

> **peek**(): `T`

Defined in: [../domwise/dist/index.d.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L24)

#### Returns

`T`

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

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

#### Inherited from

[`SignalLike`](SignalLike.md).[`subscribe`](SignalLike.md#subscribe)
