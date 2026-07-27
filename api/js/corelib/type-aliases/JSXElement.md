[@serenity-is/corelib](../README.md) / JSXElement

# Type Alias: JSXElement

> **JSXElement** = `HTMLElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"svg"`\] *extends* `false` ? `never` : `SVGElement` \| [`ConfigureElement`](../@serenity-is/namespaces/JSX/interfaces/ConfigureElement.md)\[`"mathml"`\] *extends* `false` ? `never` : `MathMLElement`

Defined in: [../domwise/dist/index.d.ts:2135](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2135)

This technically should include `DocumentFragment` as well, but a lot of web APIs expect an `Element`.
