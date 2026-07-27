[@serenity-is/domwise](../README.md) / useUpdatableComputed

# Function: useUpdatableComputed()

> **useUpdatableComputed**(): `object`

Defined in: [src/signals.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L83)

Creates a factory for computed signals that can be manually refreshed as a batch.
Returns an object with a `computed` method that creates computed signals tied to an
internal updater signal, and an `update` method that triggers a refresh of all created
computed signals.

## Returns

`object`

An object with `computed` factory and `update` trigger.

### computed()

> **computed**: \<`T`\>(`fn`) => [`Computed`](../interfaces/Computed.md)\<`T`\>

#### Type Parameters

##### T

`T`

#### Parameters

##### fn

() => `T`

#### Returns

[`Computed`](../interfaces/Computed.md)\<`T`\>

### update()

> **update**: () => `void`

#### Returns

`void`
