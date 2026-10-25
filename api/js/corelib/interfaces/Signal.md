[@serenity-is/corelib](../README.md) / Signal

# Interface: Signal\<T\>

Defined in: [../domwise/dist/index.d.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L97)

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

Defined in: [../domwise/dist/index.d.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L98)

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

Defined in: [../domwise/dist/index.d.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L85)

Returns the current value without creating a dependency.

#### Returns

`T`

The current value.

#### Inherited from

[`SignalLike`](SignalLike.md).[`peek`](SignalLike.md#peek)

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

#### Inherited from

[`SignalLike`](SignalLike.md).[`subscribe`](SignalLike.md#subscribe)
