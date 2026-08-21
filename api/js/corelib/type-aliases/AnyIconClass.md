[@serenity-is/corelib](../README.md) / AnyIconClass

# Type Alias: AnyIconClass

> **AnyIconClass** = [`KnownIconClass`](KnownIconClass.md) \| `string` & `object`

Defined in: [src/base/icons.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/icons.ts#L80)

Icon class type that accepts either a [KnownIconClass](KnownIconClass.md) (with completions) or any custom string class.
The `(string & {})` trick preserves autocomplete for known values while still allowing arbitrary classes.
