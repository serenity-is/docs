[@serenity-is/domwise](../README.md) / RemoveIndex

# Type Alias: RemoveIndex\<T\>

> **RemoveIndex**\<`T`\> = `{ [K in keyof T as string extends K ? never : number extends K ? never : K]: T[K] }`

Defined in: [types/style-attributes.d.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L3)

## Type Parameters

### T

`T`
