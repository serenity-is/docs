[@serenity-is/corelib](../README.md) / SignalOptions

# Interface: SignalOptions\<T\>

Defined in: [../domwise/dist/index.d.ts:3000](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3000)

Options for creating a signal via [signal](../variables/signal.md) / [computed](../variables/computed.md).
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

Type of the signal's value.

## Properties

### name?

> `optional` **name**: `string`

Defined in: [../domwise/dist/index.d.ts:3006](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3006)

Optional debug name for the signal.

***

### unwatched()?

> `optional` **unwatched**: (`this`) => `void`

Defined in: [../domwise/dist/index.d.ts:3004](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3004)

Called when the signal loses its last subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`

***

### watched()?

> `optional` **watched**: (`this`) => `void`

Defined in: [../domwise/dist/index.d.ts:3002](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3002)

Called when the signal gains its first subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`
