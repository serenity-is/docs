[@serenity-is/domwise](../README.md) / StyleAttributes

# Type Alias: StyleAttributes

> **StyleAttributes** = `Partial`\<[`ExcludeMethods`](ExcludeMethods.md)\<[`RemoveIndex`](RemoveIndex.md)\<`Omit`\<`CSSStyleDeclaration`, `"length"` \| `"parentRules"`\>\>\>\>

Defined in: [types/style-attributes.d.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L11)

Style properties that can be assigned to the `style` attribute, with methods,
readonly properties, and the index signature filtered out of
`CSSStyleDeclaration`.
