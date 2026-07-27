[@serenity-is/corelib](../README.md) / setRef

# Function: setRef()

> **setRef**\<`T`\>(`ref`, `current`): `void`

Defined in: [../domwise/dist/index.d.ts:2337](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2337)

Sets the `current` property of a `RefObject`, or calls a ref callback with the given value.

## Type Parameters

### T

`T` = `Node`

The type of the referenced node.

## Parameters

### ref

[`Ref`](../type-aliases/Ref.md)\<`T`\>

A `RefObject` or a ref callback, or `undefined`.

### current

`T`

The value to assign to the ref.

## Returns

`void`
