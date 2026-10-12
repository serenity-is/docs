[@serenity-is/corelib](../README.md) / Signal

# Interface: Signal\<T\>

Defined in: [../domwise/dist/index.d.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L101)

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

Defined in: [../domwise/dist/index.d.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L102)

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

Defined in: [../domwise/dist/index.d.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L89)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

***

### subscribe()

> **subscribe**(`fn`): () => `void`

Defined in: [../domwise/dist/index.d.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L95)

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
