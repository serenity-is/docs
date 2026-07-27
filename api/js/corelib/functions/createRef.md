[@serenity-is/corelib](../README.md) / createRef

# Function: createRef()

> **createRef**\<`T`\>(): [`RefObject`](../type-aliases/RefObject.md)\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2330](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2330)

Creates a new `RefObject` with `current` initially set to `null`.
The returned object is sealed to prevent extension.

## Type Parameters

### T

`T` = `any`

The type of the referenced value.

## Returns

[`RefObject`](../type-aliases/RefObject.md)\<`T`\>

A new sealed `RefObject<T>`.
