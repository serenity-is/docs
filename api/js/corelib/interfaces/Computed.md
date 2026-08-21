[@serenity-is/corelib](../README.md) / Computed

# Interface: Computed\<T\>

Defined in: [../domwise/dist/index.d.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L106)

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

Defined in: [../domwise/dist/index.d.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L82)

Current value; reading may track a dependency when inside an effect/computed.

##### Returns

`T`

#### Inherited from

[`SignalLike`](SignalLike.md).[`value`](SignalLike.md#value)

## Methods

### peek()

> **peek**(): `T`

Defined in: [../domwise/dist/index.d.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L87)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

***

### subscribe()

> **subscribe**(`fn`): () => `void`

Defined in: [../domwise/dist/index.d.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L93)

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

#### Inherited from

[`SignalLike`](SignalLike.md).[`subscribe`](SignalLike.md#subscribe)
