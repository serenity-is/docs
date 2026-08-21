[@serenity-is/corelib](../README.md) / RenderableContent

# Type Alias: RenderableContent

> **RenderableContent** = `string` \| `HTMLElement` \| `SVGElement` \| `MathMLElement` \| `DocumentFragment`

Defined in: [src/base/html.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/html.ts#L10)

Content that can be rendered as a toast/notification message or appended to the DOM.
Accepts plain strings, DOM elements (HTML/SVG/MathML) and document fragments, which are
handled by [appendToNode](../functions/appendToNode.md) and the notification helpers.
