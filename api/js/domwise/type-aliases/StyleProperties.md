[@serenity-is/domwise](../README.md) / StyleProperties

# Type Alias: StyleProperties

> **StyleProperties** = \{ \[K in StylePropertyKeys\]?: SignalOrValue\<string \| number \| undefined\> \} & `object`

Defined in: [types/style-attributes.d.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/style-attributes.d.ts#L28)

Style properties for the `style` JSX attribute, where each CSS property may
be a string (e.g. `"14px"`), a number (raw value, or `px` for non-unitless
properties), or a signal-like value that updates reactively. CSS custom
properties (`--*`) are supported too.
