[@serenity-is/corelib](../README.md) / SNoInfer

# Type Alias: SNoInfer\<T\>

> **SNoInfer**\<`T`\> = \[`T`\]\[`T` *extends* `any` ? `0` : `never`\]

Defined in: [src/base/system.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/system.ts#L439)

Utility type that prevents TypeScript from inferring `T` from a specific position.
Prefers the inferred type from other positions. TypeScript 5.4+ provides a built-in `NoInfer<T>` that can be used instead.

## Type Parameters

### T

`T`

Type to block inference for.
