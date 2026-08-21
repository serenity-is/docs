[@serenity-is/domwise](../README.md) / setRef

# Function: setRef()

> **setRef**\<`T`\>(`ref`, `current`): `void`

Defined in: [src/ref.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/ref.ts#L42)

Assigns a value to a ref, handling both object and callback forms.

- If `ref` is a `RefObject`, its `current` property is set to `current`.
- If `ref` is a function, it is invoked with `current`.
- If `ref` is `null`/`undefined` or neither form, no action is taken.

## Type Parameters

### T

`T` = `Node`

Type of the node/value being assigned.

## Parameters

### ref

Target `RefObject`, callback, or `null`/`undefined`.

[`Ref`](../type-aliases/Ref.md)\<`T`\> | `undefined`

### current

`T`

Value to assign to the ref.

## Returns

`void`
