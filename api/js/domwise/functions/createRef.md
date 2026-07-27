[@serenity-is/domwise](../README.md) / createRef

# Function: createRef()

> **createRef**\<`T`\>(): [`RefObject`](../type-aliases/RefObject.md)\<`T`\>

Defined in: [src/ref.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/ref.ts#L9)

Creates a new `RefObject` with `current` initially set to `null`.
The returned object is sealed to prevent extension.

## Type Parameters

### T

`T` = `any`

The type of the referenced value.

## Returns

[`RefObject`](../type-aliases/RefObject.md)\<`T`\>

A new sealed `RefObject<T>`.
