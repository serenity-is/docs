[@serenity-is/corelib](../README.md) / jsx

# Function: jsx()

## Call Signature

> **jsx**\<`THtmlTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2414](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2414)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Type Parameters

#### THtmlTag

`THtmlTag` *extends* `"object"` \| `"map"` \| `"dialog"` \| `"a"` \| `"abbr"` \| `"address"` \| `"area"` \| `"article"` \| `"aside"` \| `"audio"` \| `"b"` \| `"base"` \| `"bdi"` \| `"bdo"` \| `"blockquote"` \| `"body"` \| `"br"` \| `"button"` \| `"canvas"` \| `"caption"` \| `"cite"` \| `"code"` \| `"col"` \| `"colgroup"` \| `"data"` \| `"datalist"` \| `"dd"` \| `"del"` \| `"details"` \| `"dfn"` \| `"div"` \| `"dl"` \| `"dt"` \| `"em"` \| `"embed"` \| `"fieldset"` \| `"figcaption"` \| `"figure"` \| `"footer"` \| `"form"` \| `"h1"` \| `"h2"` \| `"h3"` \| `"h4"` \| `"h5"` \| `"h6"` \| `"head"` \| `"header"` \| `"hgroup"` \| `"hr"` \| `"html"` \| `"i"` \| `"iframe"` \| `"img"` \| `"input"` \| `"ins"` \| `"kbd"` \| `"label"` \| `"legend"` \| `"li"` \| `"link"` \| `"main"` \| `"mark"` \| `"menu"` \| `"meta"` \| `"meter"` \| `"nav"` \| `"noscript"` \| `"ol"` \| `"optgroup"` \| `"option"` \| `"output"` \| `"p"` \| `"picture"` \| `"pre"` \| `"progress"` \| `"q"` \| `"rp"` \| `"rt"` \| `"ruby"` \| `"s"` \| `"samp"` \| `"script"` \| `"search"` \| `"section"` \| `"select"` \| `"slot"` \| `"small"` \| `"source"` \| `"span"` \| `"strong"` \| `"style"` \| `"sub"` \| `"summary"` \| `"sup"` \| `"table"` \| `"tbody"` \| `"td"` \| `"template"` \| `"textarea"` \| `"tfoot"` \| `"th"` \| `"thead"` \| `"time"` \| `"title"` \| `"tr"` \| `"track"` \| `"u"` \| `"ul"` \| `"var"` \| `"video"` \| `"wbr"`

#### TElement

`TElement` *extends* `HTMLLinkElement` \| `HTMLElement` \| `HTMLObjectElement` \| `HTMLMapElement` \| `HTMLDialogElement` \| `HTMLAnchorElement` \| `HTMLAreaElement` \| `HTMLAudioElement` \| `HTMLBaseElement` \| `HTMLQuoteElement` \| `HTMLBodyElement` \| `HTMLBRElement` \| `HTMLButtonElement` \| `HTMLCanvasElement` \| `HTMLTableCaptionElement` \| `HTMLTableColElement` \| `HTMLDataElement` \| `HTMLDataListElement` \| `HTMLModElement` \| `HTMLDetailsElement` \| `HTMLDivElement` \| `HTMLDListElement` \| `HTMLEmbedElement` \| `HTMLFieldSetElement` \| `HTMLFormElement` \| `HTMLHeadingElement` \| `HTMLHeadElement` \| `HTMLHRElement` \| `HTMLHtmlElement` \| `HTMLIFrameElement` \| `HTMLImageElement` \| `HTMLInputElement` \| `HTMLLabelElement` \| `HTMLLegendElement` \| `HTMLLIElement` \| `HTMLMenuElement` \| `HTMLMetaElement` \| `HTMLMeterElement` \| `HTMLOListElement` \| `HTMLOptGroupElement` \| `HTMLOptionElement` \| `HTMLOutputElement` \| `HTMLParagraphElement` \| `HTMLPictureElement` \| `HTMLPreElement` \| `HTMLProgressElement` \| `HTMLScriptElement` \| `HTMLSelectElement` \| `HTMLSlotElement` \| `HTMLSourceElement` \| `HTMLSpanElement` \| `HTMLStyleElement` \| `HTMLTableElement` \| `HTMLTableSectionElement` \| `HTMLTableCellElement` \| `HTMLTemplateElement` \| `HTMLTextAreaElement` \| `HTMLTimeElement` \| `HTMLTitleElement` \| `HTMLTableRowElement` \| `HTMLTrackElement` \| `HTMLUListElement` \| `HTMLVideoElement`

### Parameters

#### type

`THtmlTag`

The HTML/SVG/MathML tag name or a component function/class.

#### props?

[`HTMLElementTags`](../interfaces/HTMLElementTags.md)\[`THtmlTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

The attributes/props for the element. Children are passed via `props.children`.

### Returns

`TElement`

The created JSX element (DOM node).

## Call Signature

> **jsx**\<`TSVGTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2415](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2415)

Creates a JSX element. Acts as the JSX factory function (used as `jsx()` and `jsxs()`).
Supports HTML elements, SVG elements, MathML elements, and custom components.
When the tag is a string, it creates a DOM element; when it is a function/class,
it instantiates a component.

Unlike `createElement` (or `h`), which takes children as additional arguments,
`jsx` expects children as part of the `props` object (`props.children`).

### Type Parameters

#### TSVGTag

`TSVGTag` *extends* `"symbol"` \| `"filter"` \| `"animate"` \| `"animateMotion"` \| `"animateTransform"` \| `"circle"` \| `"clipPath"` \| `"defs"` \| `"desc"` \| `"ellipse"` \| `"feBlend"` \| `"feColorMatrix"` \| `"feComponentTransfer"` \| `"feComposite"` \| `"feConvolveMatrix"` \| `"feDiffuseLighting"` \| `"feDisplacementMap"` \| `"feDistantLight"` \| `"feDropShadow"` \| `"feFlood"` \| `"feFuncA"` \| `"feFuncB"` \| `"feFuncG"` \| `"feFuncR"` \| `"feGaussianBlur"` \| `"feImage"` \| `"feMerge"` \| `"feMergeNode"` \| `"feMorphology"` \| `"feOffset"` \| `"fePointLight"` \| `"feSpecularLighting"` \| `"feSpotLight"` \| `"feTile"` \| `"feTurbulence"` \| `"foreignObject"` \| `"g"` \| `"image"` \| `"line"` \| `"linearGradient"` \| `"marker"` \| `"mask"` \| `"metadata"` \| `"mpath"` \| `"path"` \| `"pattern"` \| `"polygon"` \| `"polyline"` \| `"radialGradient"` \| `"rect"` \| `"set"` \| `"stop"` \| `"svg"` \| `"switch"` \| `"text"` \| `"textPath"` \| `"tspan"` \| `"use"` \| `"view"`

#### TElement

`TElement` *extends* `SVGSymbolElement` \| `SVGFilterElement` \| `SVGAnimateElement` \| `SVGAnimateMotionElement` \| `SVGAnimateTransformElement` \| `SVGCircleElement` \| `SVGClipPathElement` \| `SVGDefsElement` \| `SVGDescElement` \| `SVGEllipseElement` \| `SVGFEBlendElement` \| `SVGFEColorMatrixElement` \| `SVGFEComponentTransferElement` \| `SVGFECompositeElement` \| `SVGFEConvolveMatrixElement` \| `SVGFEDiffuseLightingElement` \| `SVGFEDisplacementMapElement` \| `SVGFEDistantLightElement` \| `SVGFEDropShadowElement` \| `SVGFEFloodElement` \| `SVGFEFuncAElement` \| `SVGFEFuncBElement` \| `SVGFEFuncGElement` \| `SVGFEFuncRElement` \| `SVGFEGaussianBlurElement` \| `SVGFEImageElement` \| `SVGFEMergeElement` \| `SVGFEMergeNodeElement` \| `SVGFEMorphologyElement` \| `SVGFEOffsetElement` \| `SVGFEPointLightElement` \| `SVGFESpecularLightingElement` \| `SVGFESpotLightElement` \| `SVGFETileElement` \| `SVGFETurbulenceElement` \| `SVGForeignObjectElement` \| `SVGGElement` \| `SVGImageElement` \| `SVGLineElement` \| `SVGLinearGradientElement` \| `SVGMarkerElement` \| `SVGMaskElement` \| `SVGMetadataElement` \| `SVGMPathElement` \| `SVGPathElement` \| `SVGPatternElement` \| `SVGPolygonElement` \| `SVGPolylineElement` \| `SVGRadialGradientElement` \| `SVGRectElement` \| `SVGSetElement` \| `SVGStopElement` \| `SVGSVGElement` \| `SVGSwitchElement` \| `SVGTextElement` \| `SVGTextPathElement` \| `SVGTSpanElement` \| `SVGUseElement` \| `SVGViewElement`

### Parameters

#### type

`TSVGTag`

The HTML/SVG/MathML tag name or a component function/class.

#### props?

[`SVGElementTags`](../interfaces/SVGElementTags.md)\[`TSVGTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

The attributes/props for the element. Children are passed via `props.children`.

### Returns

`TElement`

The created JSX element (DOM node).

## Call Signature

> **jsx**(`type`, `props?`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2416](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2416)

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

[`ElementAttributes`](../interfaces/ElementAttributes.md)\<[`JSXElement`](../type-aliases/JSXElement.md)\> & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

The attributes/props for the element. Children are passed via `props.children`.

### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created JSX element (DOM node).

## Call Signature

> **jsx**\<`P`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2417](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2417)

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

`P` & `object`

The attributes/props for the element. Children are passed via `props.children`.

### Returns

`TElement`

The created JSX element (DOM node).
