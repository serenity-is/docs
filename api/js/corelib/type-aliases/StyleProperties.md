[@serenity-is/corelib](../README.md) / StyleProperties

# Type Alias: StyleProperties

> **StyleProperties** = `{ [K in keyof StylePropertiesBase]: SignalOrValue<StylePropertiesBase[K]> }`

Defined in: [../domwise/dist/index.d.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L224)

Style properties for the `style` JSX attribute, where each CSS property may
be a plain value or a signal-like value that updates reactively.
