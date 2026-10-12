[@serenity-is/domwise](../README.md) / StylePropertyKeys

# Type Alias: StylePropertyKeys

> **StylePropertyKeys** = `{ [K in keyof CSSStyleDeclaration]: K extends string ? CSSStyleDeclaration[K] extends string ? K : never : never }`\[keyof `CSSStyleDeclaration`\]

Defined in: [types/style-attributes.d.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L14)

CSSStyleDeclaration contains methods, readonly properties and an index signature, which we all need to filter out.
