[@serenity-is/domwise](../README.md) / JSXElement

# Type Alias: JSXElement

> **JSXElement** = `HTMLElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"svg"`\] *extends* `false` ? `never` : `SVGElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"mathml"`\] *extends* `false` ? `never` : `MathMLElement`

Defined in: [types/jsx-namespace.d.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/jsx-namespace.d.ts#L8)

This technically should include `DocumentFragment` as well, but a lot of web APIs expect an `Element`.
