[@serenity-is/corelib](../README.md) / RemoveIndex

# Type Alias: RemoveIndex\<T\>

> **RemoveIndex**\<`T`\> = `{ [K in keyof T as string extends K ? never : number extends K ? never : K]: T[K] }`

Defined in: [../domwise/dist/index.d.ts:203](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L203)

## Type Parameters

### T

`T`
