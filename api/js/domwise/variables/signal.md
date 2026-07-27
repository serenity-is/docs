[@serenity-is/domwise](../README.md) / signal

# Variable: signal()

> `const` **signal**: \{\<`T`\>(`value`, `options?`): [`Signal`](../interfaces/Signal.md)\<`T`\>; \<`T`\>(): [`Signal`](../interfaces/Signal.md)\<`T` \| `undefined`\>; \}

Defined in: [src/signals.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/signals.ts#L26)

Creates a new writable signal with an optional initial value.
Re-exported from `@preact/signals-core` with typed overloads.

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

## Type Param

The type of the signal's value.

## Param

Optional initial value.

## Param

Optional signal options (`watched`, `unwatched`, `name`).

## Returns

A writable `Signal<T>`.
