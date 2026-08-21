[@serenity-is/domwise](../README.md) / useImperativeHandle

# Function: useImperativeHandle()

> **useImperativeHandle**\<`T`\>(`ref`, `init`): `void`

Defined in: [src/compat-api.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/compat-api.ts#L47)

Compatibility helper similar to React's `useImperativeHandle`.

Evaluates `init()` and forwards the result to `ref` via [setRef](setRef.md).
Prefer calling [setRef](setRef.md) directly in new code.

## Type Parameters

### T

`T`

Type of the value exposed through the ref.

## Parameters

### ref

[`Ref`](../type-aliases/Ref.md)\<`T`\>

Target `RefObject` or ref callback to update.

### init

() => `T`

Factory that produces the value to assign to the ref.

## Returns

`void`
