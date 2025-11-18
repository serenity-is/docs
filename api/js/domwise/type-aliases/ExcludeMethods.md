[@serenity-is/domwise](../README.md) / ExcludeMethods

# Type Alias: ExcludeMethods\<T\>

> **ExcludeMethods**\<`T`\> = `Pick`\<`T`, `{ [K in keyof T]: T[K] extends Function ? never : K }`\[keyof `T`\]\>

Defined in: [types/style-attributes.d.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L5)

## Type Parameters

### T

`T`
