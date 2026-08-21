[@serenity-is/domwise](../README.md) / StyleProperties

# Type Alias: StyleProperties

> **StyleProperties** = `{ [K in keyof StylePropertiesBase]: SignalOrValue<StylePropertiesBase[K]> }`

Defined in: [types/style-attributes.d.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L31)

Style properties for the `style` JSX attribute, where each CSS property may
be a plain value or a signal-like value that updates reactively.
