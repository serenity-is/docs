[@serenity-is/corelib](../README.md) / SignalOptions

# Interface: SignalOptions\<T\>

Defined in: [../domwise/dist/index.d.ts:2887](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2887)

Options for creating a signal via [signal](../variables/signal.md) / [computed](../variables/computed.md).
Re-exported from `@preact/signals-core`.

## Type Parameters

### T

`T`

Type of the signal's value.

## Properties

### name?

> `optional` **name**: `string`

Defined in: [../domwise/dist/index.d.ts:2893](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2893)

Optional debug name for the signal.

***

### unwatched()?

> `optional` **unwatched**: (`this`) => `void`

Defined in: [../domwise/dist/index.d.ts:2891](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2891)

Called when the signal loses its last subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`

***

### watched()?

> `optional` **watched**: (`this`) => `void`

Defined in: [../domwise/dist/index.d.ts:2889](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2889)

Called when the signal gains its first subscriber.

#### Parameters

##### this

[`SignalLike`](SignalLike.md)\<`T`\>

#### Returns

`void`
