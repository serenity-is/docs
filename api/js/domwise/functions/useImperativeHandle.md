[@serenity-is/domwise](../README.md) / useImperativeHandle

# Function: useImperativeHandle()

> **useImperativeHandle**\<`T`\>(`ref`, `init`): `void`

Defined in: [src/compat-api.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/compat-api.ts#L38)

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
