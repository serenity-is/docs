[@serenity-is/domwise](../README.md) / SignalOptions

# Interface: SignalOptions\<T\>

Defined in: [src/signals.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L9)

Options for creating a signal via [signal](../variables/signal.md) / [computed](../variables/computed.md).
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

Type of the signal's value.

## Properties

### name?

> `optional` **name**: `string`

Defined in: [src/signals.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L15)

Optional debug name for the signal.

***

### unwatched()?

> `optional` **unwatched**: (`this`) => `void`

Defined in: [src/signals.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L13)

Called when the signal loses its last subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`

***

### watched()?

> `optional` **watched**: (`this`) => `void`

Defined in: [src/signals.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L11)

Called when the signal gains its first subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`
