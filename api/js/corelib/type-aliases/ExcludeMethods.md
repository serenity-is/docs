[@serenity-is/corelib](../README.md) / ExcludeMethods

# Type Alias: ExcludeMethods\<T\>

> **ExcludeMethods**\<`T`\> = `Pick`\<`T`, `{ [K in keyof T]: T[K] extends Function ? never : K }`\[keyof `T`\]\>

Defined in: [../domwise/dist/index.d.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L95)

## Type Parameters

### T

`T`
