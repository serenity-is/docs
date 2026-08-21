[@serenity-is/corelib](../README.md) / setRef

# Function: setRef()

> **setRef**\<`T`\>(`ref`, `current`): `void`

Defined in: [../domwise/dist/index.d.ts:2605](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2605)

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

[`Ref`](../type-aliases/Ref.md)\<`T`\>

Target `RefObject`, callback, or `null`/`undefined`.

### current

`T`

Value to assign to the ref.

## Returns

`void`
