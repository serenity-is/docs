[@serenity-is/domwise](../README.md) / jsx

# Function: jsx()

## Call Signature

> **jsx**\<`THtmlTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L28)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Type Parameters

#### THtmlTag

`THtmlTag` *extends* `"object"` \| `"search"` \| `"link"` \| `"small"` \| `"sub"` \| `"sup"` \| `"time"` \| `"menu"` \| `"dialog"` \| `"article"` \| `"button"` \| `"figure"` \| `"form"` \| `"img"` \| `"main"` \| `"meter"` \| `"option"` \| `"table"` \| `"input"` \| `"progress"` \| `"select"` \| `"slot"` \| `"style"` \| `"title"` \| `"audio"` \| `"embed"` \| `"script"` \| `"track"` \| `"video"` \| `"cite"` \| `"span"` \| `"a"` \| `"i"` \| `"label"` \| `"data"` \| `"code"` \| `"abbr"` \| `"col"` \| `"colgroup"` \| `"map"` \| `"address"` \| `"area"` \| `"aside"` \| `"b"` \| `"base"` \| `"bdi"` \| `"bdo"` \| `"blockquote"` \| `"body"` \| `"br"` \| `"canvas"` \| `"caption"` \| `"datalist"` \| `"dd"` \| `"del"` \| `"details"` \| `"dfn"` \| `"div"` \| `"dl"` \| `"dt"` \| `"em"` \| `"fieldset"` \| `"figcaption"` \| `"footer"` \| `"h1"` \| `"h2"` \| `"h3"` \| `"h4"` \| `"h5"` \| `"h6"` \| `"head"` \| `"header"` \| `"hgroup"` \| `"hr"` \| `"html"` \| `"iframe"` \| `"ins"` \| `"kbd"` \| `"legend"` \| `"li"` \| `"mark"` \| `"meta"` \| `"nav"` \| `"noscript"` \| `"ol"` \| `"optgroup"` \| `"output"` \| `"p"` \| `"picture"` \| `"pre"` \| `"q"` \| `"rp"` \| `"rt"` \| `"ruby"` \| `"s"` \| `"samp"` \| `"section"` \| `"source"` \| `"strong"` \| `"summary"` \| `"tbody"` \| `"td"` \| `"template"` \| `"textarea"` \| `"tfoot"` \| `"th"` \| `"thead"` \| `"tr"` \| `"u"` \| `"ul"` \| `"var"` \| `"wbr"`

#### TElement

`TElement` *extends* `HTMLElement` \| `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement` \| `HTMLAnchorElement` \| `HTMLAreaElement` \| `HTMLAudioElement` \| `HTMLBaseElement` \| `HTMLQuoteElement` \| `HTMLBodyElement` \| `HTMLBRElement` \| `HTMLButtonElement` \| `HTMLCanvasElement` \| `HTMLTableCaptionElement` \| `HTMLTableColElement` \| `HTMLDataElement` \| `HTMLDataListElement` \| `HTMLModElement` \| `HTMLDetailsElement` \| `HTMLDialogElement` \| `HTMLDivElement` \| `HTMLDListElement` \| `HTMLEmbedElement` \| `HTMLFieldSetElement` \| `HTMLFormElement` \| `HTMLHeadingElement` \| `HTMLHeadElement` \| `HTMLHRElement` \| `HTMLHtmlElement` \| `HTMLIFrameElement` \| `HTMLImageElement` \| `HTMLLabelElement` \| `HTMLLegendElement` \| `HTMLLIElement` \| `HTMLLinkElement` \| `HTMLMapElement` \| `HTMLMenuElement` \| `HTMLMetaElement` \| `HTMLMeterElement` \| `HTMLObjectElement` \| `HTMLOListElement` \| `HTMLOptGroupElement` \| `HTMLOptionElement` \| `HTMLOutputElement` \| `HTMLParagraphElement` \| `HTMLPictureElement` \| `HTMLPreElement` \| `HTMLProgressElement` \| `HTMLScriptElement` \| `HTMLSlotElement` \| `HTMLSourceElement` \| `HTMLSpanElement` \| `HTMLStyleElement` \| `HTMLTableElement` \| `HTMLTableSectionElement` \| `HTMLTableCellElement` \| `HTMLTemplateElement` \| `HTMLTimeElement` \| `HTMLTitleElement` \| `HTMLTableRowElement` \| `HTMLTrackElement` \| `HTMLUListElement` \| `HTMLVideoElement`

### Parameters

#### type

`THtmlTag`

The HTML/SVG/MathML tag name or a component function/class.

#### props?

The attributes/props for the element. Children are passed via `props.children`.

[`HTMLElementTags`](../interfaces/HTMLElementTags.md)\[`THtmlTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

The created JSX element (DOM node).

## Call Signature

> **jsx**\<`TSVGTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L32)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Type Parameters

#### TSVGTag

`TSVGTag` *extends* `"symbol"` \| `"svg"` \| `"clipPath"` \| `"filter"` \| `"marker"` \| `"mask"` \| `"text"` \| `"switch"` \| `"image"` \| `"rect"` \| `"circle"` \| `"pattern"` \| `"metadata"` \| `"path"` \| `"animate"` \| `"animateMotion"` \| `"animateTransform"` \| `"defs"` \| `"desc"` \| `"ellipse"` \| `"feBlend"` \| `"feColorMatrix"` \| `"feComponentTransfer"` \| `"feComposite"` \| `"feConvolveMatrix"` \| `"feDiffuseLighting"` \| `"feDisplacementMap"` \| `"feDistantLight"` \| `"feDropShadow"` \| `"feFlood"` \| `"feFuncA"` \| `"feFuncB"` \| `"feFuncG"` \| `"feFuncR"` \| `"feGaussianBlur"` \| `"feImage"` \| `"feMerge"` \| `"feMergeNode"` \| `"feMorphology"` \| `"feOffset"` \| `"fePointLight"` \| `"feSpecularLighting"` \| `"feSpotLight"` \| `"feTile"` \| `"feTurbulence"` \| `"foreignObject"` \| `"g"` \| `"line"` \| `"linearGradient"` \| `"mpath"` \| `"polygon"` \| `"polyline"` \| `"radialGradient"` \| `"set"` \| `"stop"` \| `"textPath"` \| `"tspan"` \| `"use"` \| `"view"`

#### TElement

`TElement` *extends* `SVGAnimateElement` \| `SVGAnimateMotionElement` \| `SVGAnimateTransformElement` \| `SVGCircleElement` \| `SVGClipPathElement` \| `SVGDefsElement` \| `SVGDescElement` \| `SVGEllipseElement` \| `SVGFEBlendElement` \| `SVGFEColorMatrixElement` \| `SVGFEComponentTransferElement` \| `SVGFECompositeElement` \| `SVGFEConvolveMatrixElement` \| `SVGFEDiffuseLightingElement` \| `SVGFEDisplacementMapElement` \| `SVGFEDistantLightElement` \| `SVGFEDropShadowElement` \| `SVGFEFloodElement` \| `SVGFEFuncAElement` \| `SVGFEFuncBElement` \| `SVGFEFuncGElement` \| `SVGFEFuncRElement` \| `SVGFEGaussianBlurElement` \| `SVGFEImageElement` \| `SVGFEMergeElement` \| `SVGFEMergeNodeElement` \| `SVGFEMorphologyElement` \| `SVGFEOffsetElement` \| `SVGFEPointLightElement` \| `SVGFESpecularLightingElement` \| `SVGFESpotLightElement` \| `SVGFETileElement` \| `SVGFETurbulenceElement` \| `SVGFilterElement` \| `SVGForeignObjectElement` \| `SVGGElement` \| `SVGImageElement` \| `SVGLineElement` \| `SVGLinearGradientElement` \| `SVGMarkerElement` \| `SVGMaskElement` \| `SVGMetadataElement` \| `SVGMPathElement` \| `SVGPathElement` \| `SVGPatternElement` \| `SVGPolygonElement` \| `SVGPolylineElement` \| `SVGRadialGradientElement` \| `SVGRectElement` \| `SVGSetElement` \| `SVGStopElement` \| `SVGSVGElement` \| `SVGSwitchElement` \| `SVGSymbolElement` \| `SVGTextElement` \| `SVGTextPathElement` \| `SVGTSpanElement` \| `SVGUseElement` \| `SVGViewElement`

### Parameters

#### type

`TSVGTag`

The HTML/SVG/MathML tag name or a component function/class.

#### props?

The attributes/props for the element. Children are passed via `props.children`.

[`SVGElementTags`](../interfaces/SVGElementTags.md)\[`TSVGTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

The created JSX element (DOM node).

## Call Signature

> **jsx**(`type`, `props?`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/jsx-factory.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L36)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Parameters

#### type

`string`

The HTML/SVG/MathML tag name or a component function/class.

#### props?

The attributes/props for the element. Children are passed via `props.children`.

[`ElementAttributes`](../interfaces/ElementAttributes.md)\<[`JSXElement`](../type-aliases/JSXElement.md)\> & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created JSX element (DOM node).

## Call Signature

> **jsx**\<`P`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L41)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Type Parameters

#### P

`P` *extends* `object`

#### TElement

`TElement` *extends* [`JSXElement`](../type-aliases/JSXElement.md) = [`JSXElement`](../type-aliases/JSXElement.md)

### Parameters

#### type

[`ComponentType`](../type-aliases/ComponentType.md)\<`P`, `TElement`\>

The HTML/SVG/MathML tag name or a component function/class.

#### props?

The attributes/props for the element. Children are passed via `props.children`.

`P` & `object` | `null`

### Returns

`TElement`

The created JSX element (DOM node).
