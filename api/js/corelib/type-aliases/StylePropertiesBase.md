[@serenity-is/corelib](../README.md) / StylePropertiesBase

# Type Alias: StylePropertiesBase

> **StylePropertiesBase** = `Partial`\<`Pick`\<`CSSStyleDeclaration`, `{ [K in keyof CSSStyleDeclaration]: K extends string ? CSSStyleDeclaration[K] extends string ? K : never : never }`\[keyof `CSSStyleDeclaration`\]\>\>

Defined in: [../domwise/dist/index.d.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L100)

CSSStyleDeclaration contains methods, readonly properties and an index signature, which we all need to filter out.
