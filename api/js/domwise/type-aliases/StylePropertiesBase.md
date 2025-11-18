[@serenity-is/domwise](../README.md) / StylePropertiesBase

# Type Alias: StylePropertiesBase

> **StylePropertiesBase** = `Partial`\<`Pick`\<`CSSStyleDeclaration`, `{ [K in keyof CSSStyleDeclaration]: K extends string ? CSSStyleDeclaration[K] extends string ? K : never : never }`\[keyof `CSSStyleDeclaration`\]\>\>

Defined in: [types/style-attributes.d.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L9)

CSSStyleDeclaration contains methods, readonly properties and an index signature, which we all need to filter out.
