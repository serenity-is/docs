[serenity-is/corelib](../README.md) / SNoInfer

# Type Alias: SNoInfer\<T\>

> **SNoInfer**\<`T`\> = \[`T`\]\[`T` *extends* `any` ? `0` : `never`\]

Defined in: [src/base/system.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L419)

Utility type to prevent type inference in generic types.
TypeScript 5.4 has added a built-in NoInfer<T> type that can be used instead of this.

## Type Parameters

### T

`T`
