[@serenity-is/domwise](../README.md) / signal

# Variable: signal()

> `const` **signal**: \{\<`T`\>(`value`, `options?`): [`Signal`](../interfaces/Signal.md)\<`T`\>; \<`T`\>(): [`Signal`](../interfaces/Signal.md)\<`T` \| `undefined`\>; \}

Defined in: [src/signals.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L18)

## Call Signature

> \<`T`\>(`value`, `options?`): [`Signal`](../interfaces/Signal.md)\<`T`\>

### Type Parameters

#### T

`T`

### Parameters

#### value

`T`

#### options?

[`SignalOptions`](../interfaces/SignalOptions.md)\<`T`\>

### Returns

[`Signal`](../interfaces/Signal.md)\<`T`\>

## Call Signature

> \<`T`\>(): [`Signal`](../interfaces/Signal.md)\<`T` \| `undefined`\>

### Type Parameters

#### T

`T` = `undefined`

### Returns

[`Signal`](../interfaces/Signal.md)\<`T` \| `undefined`\>
