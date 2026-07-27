[@serenity-is/domwise](../README.md) / setRef

# Function: setRef()

> **setRef**\<`T`\>(`ref`, `current`): `void`

Defined in: [src/ref.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/ref.ts#L28)

Sets the `current` property of a `RefObject`, or calls a ref callback with the given value.

## Type Parameters

### T

`T` = `Node`

The type of the referenced node.

## Parameters

### ref

A `RefObject` or a ref callback, or `undefined`.

[`Ref`](../type-aliases/Ref.md)\<`T`\> | `undefined`

### current

`T`

The value to assign to the ref.

## Returns

`void`
