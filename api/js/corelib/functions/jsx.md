[@serenity-is/corelib](../README.md) / jsx

# Function: jsx()

## Call Signature

> **jsx**\<`THtmlTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2739](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2739)

Creates a JSX element. This is the automatic JSX factory used by the
compiler (imported as `jsx` and `jsxs`). Handles HTML/SVG/MathML elements
and custom function or class components.

When `type` is a string, a real DOM element is created (with namespace
auto-detection for SVG/MathML), props are assigned via `assignProps`, and
children are appended. `select[value]` signals are resolved and applied.
When `type` is a function/class, it is invoked or instantiated as a
component and the resulting node is returned. `defaultProps` are respected
and `ref` is forwarded via [setRef](setRef.md).

Unlike [createElement](createElement.md) / `h`, children are expected inside `props`
(`props.children`) rather than as rest arguments.

### Type Parameters

#### THtmlTag

`THtmlTag` *extends* `"object"` \| `"map"` \| `"dialog"` \| `"a"` \| `"abbr"` \| `"address"` \| `"area"` \| `"article"` \| `"aside"` \| `"audio"` \| `"b"` \| `"base"` \| `"bdi"` \| `"bdo"` \| `"blockquote"` \| `"body"` \| `"br"` \| `"button"` \| `"canvas"` \| `"caption"` \| `"cite"` \| `"code"` \| `"col"` \| `"colgroup"` \| `"data"` \| `"datalist"` \| `"dd"` \| `"del"` \| `"details"` \| `"dfn"` \| `"div"` \| `"dl"` \| `"dt"` \| `"em"` \| `"embed"` \| `"fieldset"` \| `"figcaption"` \| `"figure"` \| `"footer"` \| `"form"` \| `"h1"` \| `"h2"` \| `"h3"` \| `"h4"` \| `"h5"` \| `"h6"` \| `"head"` \| `"header"` \| `"hgroup"` \| `"hr"` \| `"html"` \| `"i"` \| `"iframe"` \| `"img"` \| `"input"` \| `"ins"` \| `"kbd"` \| `"label"` \| `"legend"` \| `"li"` \| `"link"` \| `"main"` \| `"mark"` \| `"menu"` \| `"meta"` \| `"meter"` \| `"nav"` \| `"noscript"` \| `"ol"` \| `"optgroup"` \| `"option"` \| `"output"` \| `"p"` \| `"picture"` \| `"pre"` \| `"progress"` \| `"q"` \| `"rp"` \| `"rt"` \| `"ruby"` \| `"s"` \| `"samp"` \| `"script"` \| `"search"` \| `"section"` \| `"select"` \| `"slot"` \| `"small"` \| `"source"` \| `"span"` \| `"strong"` \| `"style"` \| `"sub"` \| `"summary"` \| `"sup"` \| `"table"` \| `"tbody"` \| `"td"` \| `"template"` \| `"textarea"` \| `"tfoot"` \| `"th"` \| `"thead"` \| `"time"` \| `"title"` \| `"tr"` \| `"track"` \| `"u"` \| `"ul"` \| `"var"` \| `"video"` \| `"wbr"`

#### TElement

`TElement` *extends* `HTMLLinkElement` \| `HTMLElement` \| `HTMLObjectElement` \| `HTMLMapElement` \| `HTMLDialogElement` \| `HTMLAnchorElement` \| `HTMLAreaElement` \| `HTMLAudioElement` \| `HTMLBaseElement` \| `HTMLQuoteElement` \| `HTMLBodyElement` \| `HTMLBRElement` \| `HTMLButtonElement` \| `HTMLCanvasElement` \| `HTMLTableCaptionElement` \| `HTMLTableColElement` \| `HTMLDataElement` \| `HTMLDataListElement` \| `HTMLModElement` \| `HTMLDetailsElement` \| `HTMLDivElement` \| `HTMLDListElement` \| `HTMLEmbedElement` \| `HTMLFieldSetElement` \| `HTMLFormElement` \| `HTMLHeadingElement` \| `HTMLHeadElement` \| `HTMLHRElement` \| `HTMLHtmlElement` \| `HTMLIFrameElement` \| `HTMLImageElement` \| `HTMLInputElement` \| `HTMLLabelElement` \| `HTMLLegendElement` \| `HTMLLIElement` \| `HTMLMenuElement` \| `HTMLMetaElement` \| `HTMLMeterElement` \| `HTMLOListElement` \| `HTMLOptGroupElement` \| `HTMLOptionElement` \| `HTMLOutputElement` \| `HTMLParagraphElement` \| `HTMLPictureElement` \| `HTMLPreElement` \| `HTMLProgressElement` \| `HTMLScriptElement` \| `HTMLSelectElement` \| `HTMLSlotElement` \| `HTMLSourceElement` \| `HTMLSpanElement` \| `HTMLStyleElement` \| `HTMLTableElement` \| `HTMLTableSectionElement` \| `HTMLTableCellElement` \| `HTMLTemplateElement` \| `HTMLTextAreaElement` \| `HTMLTimeElement` \| `HTMLTitleElement` \| `HTMLTableRowElement` \| `HTMLTrackElement` \| `HTMLUListElement` \| `HTMLVideoElement`

### Parameters

#### type

`THtmlTag`

HTML/SVG/MathML tag name or a component function/class.

#### props?

[`HTMLElementTags`](../interfaces/HTMLElementTags.md)\[`THtmlTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

Attributes/props for the element. Children are read from `props.children`; may be `null`.

### Returns

`TElement`

The created DOM node (or component render result).

## Call Signature

> **jsx**\<`TSVGTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2740](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2740)

Creates a JSX element. This is the automatic JSX factory used by the
compiler (imported as `jsx` and `jsxs`). Handles HTML/SVG/MathML elements
and custom function or class components.

When `type` is a string, a real DOM element is created (with namespace
auto-detection for SVG/MathML), props are assigned via `assignProps`, and
children are appended. `select[value]` signals are resolved and applied.
When `type` is a function/class, it is invoked or instantiated as a
component and the resulting node is returned. `defaultProps` are respected
and `ref` is forwarded via [setRef](setRef.md).

Unlike [createElement](createElement.md) / `h`, children are expected inside `props`
(`props.children`) rather than as rest arguments.

### Type Parameters

#### TSVGTag

`TSVGTag` *extends* `"symbol"` \| `"filter"` \| `"animate"` \| `"animateMotion"` \| `"animateTransform"` \| `"circle"` \| `"clipPath"` \| `"defs"` \| `"desc"` \| `"ellipse"` \| `"feBlend"` \| `"feColorMatrix"` \| `"feComponentTransfer"` \| `"feComposite"` \| `"feConvolveMatrix"` \| `"feDiffuseLighting"` \| `"feDisplacementMap"` \| `"feDistantLight"` \| `"feDropShadow"` \| `"feFlood"` \| `"feFuncA"` \| `"feFuncB"` \| `"feFuncG"` \| `"feFuncR"` \| `"feGaussianBlur"` \| `"feImage"` \| `"feMerge"` \| `"feMergeNode"` \| `"feMorphology"` \| `"feOffset"` \| `"fePointLight"` \| `"feSpecularLighting"` \| `"feSpotLight"` \| `"feTile"` \| `"feTurbulence"` \| `"foreignObject"` \| `"g"` \| `"image"` \| `"line"` \| `"linearGradient"` \| `"marker"` \| `"mask"` \| `"metadata"` \| `"mpath"` \| `"path"` \| `"pattern"` \| `"polygon"` \| `"polyline"` \| `"radialGradient"` \| `"rect"` \| `"set"` \| `"stop"` \| `"svg"` \| `"switch"` \| `"text"` \| `"textPath"` \| `"tspan"` \| `"use"` \| `"view"`

#### TElement

`TElement` *extends* `SVGSymbolElement` \| `SVGFilterElement` \| `SVGAnimateElement` \| `SVGAnimateMotionElement` \| `SVGAnimateTransformElement` \| `SVGCircleElement` \| `SVGClipPathElement` \| `SVGDefsElement` \| `SVGDescElement` \| `SVGEllipseElement` \| `SVGFEBlendElement` \| `SVGFEColorMatrixElement` \| `SVGFEComponentTransferElement` \| `SVGFECompositeElement` \| `SVGFEConvolveMatrixElement` \| `SVGFEDiffuseLightingElement` \| `SVGFEDisplacementMapElement` \| `SVGFEDistantLightElement` \| `SVGFEDropShadowElement` \| `SVGFEFloodElement` \| `SVGFEFuncAElement` \| `SVGFEFuncBElement` \| `SVGFEFuncGElement` \| `SVGFEFuncRElement` \| `SVGFEGaussianBlurElement` \| `SVGFEImageElement` \| `SVGFEMergeElement` \| `SVGFEMergeNodeElement` \| `SVGFEMorphologyElement` \| `SVGFEOffsetElement` \| `SVGFEPointLightElement` \| `SVGFESpecularLightingElement` \| `SVGFESpotLightElement` \| `SVGFETileElement` \| `SVGFETurbulenceElement` \| `SVGForeignObjectElement` \| `SVGGElement` \| `SVGImageElement` \| `SVGLineElement` \| `SVGLinearGradientElement` \| `SVGMarkerElement` \| `SVGMaskElement` \| `SVGMetadataElement` \| `SVGMPathElement` \| `SVGPathElement` \| `SVGPatternElement` \| `SVGPolygonElement` \| `SVGPolylineElement` \| `SVGRadialGradientElement` \| `SVGRectElement` \| `SVGSetElement` \| `SVGStopElement` \| `SVGSVGElement` \| `SVGSwitchElement` \| `SVGTextElement` \| `SVGTextPathElement` \| `SVGTSpanElement` \| `SVGUseElement` \| `SVGViewElement`

### Parameters

#### type

`TSVGTag`

HTML/SVG/MathML tag name or a component function/class.

#### props?

[`SVGElementTags`](../interfaces/SVGElementTags.md)\[`TSVGTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

Attributes/props for the element. Children are read from `props.children`; may be `null`.

### Returns

`TElement`

The created DOM node (or component render result).

## Call Signature

> **jsx**(`type`, `props?`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2741](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2741)

Creates a JSX element. This is the automatic JSX factory used by the
compiler (imported as `jsx` and `jsxs`). Handles HTML/SVG/MathML elements
and custom function or class components.

When `type` is a string, a real DOM element is created (with namespace
auto-detection for SVG/MathML), props are assigned via `assignProps`, and
children are appended. `select[value]` signals are resolved and applied.
When `type` is a function/class, it is invoked or instantiated as a
component and the resulting node is returned. `defaultProps` are respected
and `ref` is forwarded via [setRef](setRef.md).

Unlike [createElement](createElement.md) / `h`, children are expected inside `props`
(`props.children`) rather than as rest arguments.

### Parameters

#### type

`string`

HTML/SVG/MathML tag name or a component function/class.

#### props?

[`ElementAttributes`](../interfaces/ElementAttributes.md)\<[`JSXElement`](../type-aliases/JSXElement.md)\> & `Record`\<`` `data-${string}` ``, `string` \| `number`\>

Attributes/props for the element. Children are read from `props.children`; may be `null`.

### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created DOM node (or component render result).

## Call Signature

> **jsx**\<`P`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [../domwise/dist/index.d.ts:2742](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2742)

Creates a JSX element. This is the automatic JSX factory used by the
compiler (imported as `jsx` and `jsxs`). Handles HTML/SVG/MathML elements
and custom function or class components.

When `type` is a string, a real DOM element is created (with namespace
auto-detection for SVG/MathML), props are assigned via `assignProps`, and
children are appended. `select[value]` signals are resolved and applied.
When `type` is a function/class, it is invoked or instantiated as a
component and the resulting node is returned. `defaultProps` are respected
and `ref` is forwarded via [setRef](setRef.md).

Unlike [createElement](createElement.md) / `h`, children are expected inside `props`
(`props.children`) rather than as rest arguments.

### Type Parameters

#### P

`P` *extends* `object`

#### TElement

`TElement` *extends* [`JSXElement`](../type-aliases/JSXElement.md) = [`JSXElement`](../type-aliases/JSXElement.md)

### Parameters

#### type

[`ComponentType`](../type-aliases/ComponentType.md)\<`P`, `TElement`\>

HTML/SVG/MathML tag name or a component function/class.

#### props?

`P` & `object`

Attributes/props for the element. Children are read from `props.children`; may be `null`.

### Returns

`TElement`

The created DOM node (or component render result).
