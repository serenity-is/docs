[@serenity-is/corelib](../README.md) / useImperativeHandle

# Function: useImperativeHandle()

> **useImperativeHandle**\<`T`\>(`ref`, `init`): `void`

Defined in: [../domwise/dist/index.d.ts:2244](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2244)

Compatibility helper similar to React's `useImperativeHandle`.
Calls `setRef` with the result of `init()`. Prefer using `setRef` directly.

## Type Parameters

### T

`T`

## Parameters

### ref

[`Ref`](../type-aliases/Ref.md)\<`T`\>

A `RefObject` or ref callback.

### init

() => `T`

A factory function returning the value to assign to the ref.

## Returns

`void`
