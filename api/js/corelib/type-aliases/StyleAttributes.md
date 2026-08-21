[@serenity-is/corelib](../README.md) / StyleAttributes

# Type Alias: StyleAttributes

> **StyleAttributes** = `Partial`\<[`ExcludeMethods`](ExcludeMethods.md)\<[`RemoveIndex`](RemoveIndex.md)\<`Omit`\<`CSSStyleDeclaration`, `"length"` \| `"parentRules"`\>\>\>\>

Defined in: [../domwise/dist/index.d.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L215)

Style properties that can be assigned to the `style` attribute, with methods,
readonly properties, and the index signature filtered out of
`CSSStyleDeclaration`.
