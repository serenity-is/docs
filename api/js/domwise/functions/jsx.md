[@serenity-is/domwise](../README.md) / jsx

# Function: jsx()

## Call Signature

> **jsx**\<`THtmlTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L34)

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

`THtmlTag` *extends* `"object"` \| `"search"` \| `"link"` \| `"small"` \| `"sub"` \| `"sup"` \| `"time"` \| `"menu"` \| `"dialog"` \| `"article"` \| `"button"` \| `"figure"` \| `"form"` \| `"img"` \| `"main"` \| `"meter"` \| `"option"` \| `"table"` \| `"input"` \| `"progress"` \| `"select"` \| `"slot"` \| `"style"` \| `"title"` \| `"audio"` \| `"embed"` \| `"script"` \| `"track"` \| `"video"` \| `"cite"` \| `"span"` \| `"a"` \| `"i"` \| `"label"` \| `"data"` \| `"code"` \| `"abbr"` \| `"col"` \| `"colgroup"` \| `"map"` \| `"address"` \| `"area"` \| `"aside"` \| `"b"` \| `"base"` \| `"bdi"` \| `"bdo"` \| `"blockquote"` \| `"body"` \| `"br"` \| `"canvas"` \| `"caption"` \| `"datalist"` \| `"dd"` \| `"del"` \| `"details"` \| `"dfn"` \| `"div"` \| `"dl"` \| `"dt"` \| `"em"` \| `"fieldset"` \| `"figcaption"` \| `"footer"` \| `"h1"` \| `"h2"` \| `"h3"` \| `"h4"` \| `"h5"` \| `"h6"` \| `"head"` \| `"header"` \| `"hgroup"` \| `"hr"` \| `"html"` \| `"iframe"` \| `"ins"` \| `"kbd"` \| `"legend"` \| `"li"` \| `"mark"` \| `"meta"` \| `"nav"` \| `"noscript"` \| `"ol"` \| `"optgroup"` \| `"output"` \| `"p"` \| `"picture"` \| `"pre"` \| `"q"` \| `"rp"` \| `"rt"` \| `"ruby"` \| `"s"` \| `"samp"` \| `"section"` \| `"source"` \| `"strong"` \| `"summary"` \| `"tbody"` \| `"td"` \| `"template"` \| `"textarea"` \| `"tfoot"` \| `"th"` \| `"thead"` \| `"tr"` \| `"u"` \| `"ul"` \| `"var"` \| `"wbr"`

#### TElement

`TElement` *extends* `HTMLElement` \| `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement` \| `HTMLAnchorElement` \| `HTMLAreaElement` \| `HTMLAudioElement` \| `HTMLBaseElement` \| `HTMLQuoteElement` \| `HTMLBodyElement` \| `HTMLBRElement` \| `HTMLButtonElement` \| `HTMLCanvasElement` \| `HTMLTableCaptionElement` \| `HTMLTableColElement` \| `HTMLDataElement` \| `HTMLDataListElement` \| `HTMLModElement` \| `HTMLDetailsElement` \| `HTMLDialogElement` \| `HTMLDivElement` \| `HTMLDListElement` \| `HTMLEmbedElement` \| `HTMLFieldSetElement` \| `HTMLFormElement` \| `HTMLHeadingElement` \| `HTMLHeadElement` \| `HTMLHRElement` \| `HTMLHtmlElement` \| `HTMLIFrameElement` \| `HTMLImageElement` \| `HTMLLabelElement` \| `HTMLLegendElement` \| `HTMLLIElement` \| `HTMLLinkElement` \| `HTMLMapElement` \| `HTMLMenuElement` \| `HTMLMetaElement` \| `HTMLMeterElement` \| `HTMLObjectElement` \| `HTMLOListElement` \| `HTMLOptGroupElement` \| `HTMLOptionElement` \| `HTMLOutputElement` \| `HTMLParagraphElement` \| `HTMLPictureElement` \| `HTMLPreElement` \| `HTMLProgressElement` \| `HTMLScriptElement` \| `HTMLSlotElement` \| `HTMLSourceElement` \| `HTMLSpanElement` \| `HTMLStyleElement` \| `HTMLTableElement` \| `HTMLTableSectionElement` \| `HTMLTableCellElement` \| `HTMLTemplateElement` \| `HTMLTimeElement` \| `HTMLTitleElement` \| `HTMLTableRowElement` \| `HTMLTrackElement` \| `HTMLUListElement` \| `HTMLVideoElement`

### Parameters

#### type

`THtmlTag`

HTML/SVG/MathML tag name or a component function/class.

#### props?

Attributes/props for the element. Children are read from `props.children`; may be `null`.

[`HTMLElementTags`](../interfaces/HTMLElementTags.md)\[`THtmlTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

The created DOM node (or component render result).

## Call Signature

> **jsx**\<`TSVGTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L38)

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

`TSVGTag` *extends* `"symbol"` \| `"svg"` \| `"clipPath"` \| `"filter"` \| `"marker"` \| `"mask"` \| `"text"` \| `"switch"` \| `"image"` \| `"rect"` \| `"circle"` \| `"pattern"` \| `"metadata"` \| `"path"` \| `"animate"` \| `"animateMotion"` \| `"animateTransform"` \| `"defs"` \| `"desc"` \| `"ellipse"` \| `"feBlend"` \| `"feColorMatrix"` \| `"feComponentTransfer"` \| `"feComposite"` \| `"feConvolveMatrix"` \| `"feDiffuseLighting"` \| `"feDisplacementMap"` \| `"feDistantLight"` \| `"feDropShadow"` \| `"feFlood"` \| `"feFuncA"` \| `"feFuncB"` \| `"feFuncG"` \| `"feFuncR"` \| `"feGaussianBlur"` \| `"feImage"` \| `"feMerge"` \| `"feMergeNode"` \| `"feMorphology"` \| `"feOffset"` \| `"fePointLight"` \| `"feSpecularLighting"` \| `"feSpotLight"` \| `"feTile"` \| `"feTurbulence"` \| `"foreignObject"` \| `"g"` \| `"line"` \| `"linearGradient"` \| `"mpath"` \| `"polygon"` \| `"polyline"` \| `"radialGradient"` \| `"set"` \| `"stop"` \| `"textPath"` \| `"tspan"` \| `"use"` \| `"view"`

#### TElement

`TElement` *extends* `SVGAnimateElement` \| `SVGAnimateMotionElement` \| `SVGAnimateTransformElement` \| `SVGCircleElement` \| `SVGClipPathElement` \| `SVGDefsElement` \| `SVGDescElement` \| `SVGEllipseElement` \| `SVGFEBlendElement` \| `SVGFEColorMatrixElement` \| `SVGFEComponentTransferElement` \| `SVGFECompositeElement` \| `SVGFEConvolveMatrixElement` \| `SVGFEDiffuseLightingElement` \| `SVGFEDisplacementMapElement` \| `SVGFEDistantLightElement` \| `SVGFEDropShadowElement` \| `SVGFEFloodElement` \| `SVGFEFuncAElement` \| `SVGFEFuncBElement` \| `SVGFEFuncGElement` \| `SVGFEFuncRElement` \| `SVGFEGaussianBlurElement` \| `SVGFEImageElement` \| `SVGFEMergeElement` \| `SVGFEMergeNodeElement` \| `SVGFEMorphologyElement` \| `SVGFEOffsetElement` \| `SVGFEPointLightElement` \| `SVGFESpecularLightingElement` \| `SVGFESpotLightElement` \| `SVGFETileElement` \| `SVGFETurbulenceElement` \| `SVGFilterElement` \| `SVGForeignObjectElement` \| `SVGGElement` \| `SVGImageElement` \| `SVGLineElement` \| `SVGLinearGradientElement` \| `SVGMarkerElement` \| `SVGMaskElement` \| `SVGMetadataElement` \| `SVGMPathElement` \| `SVGPathElement` \| `SVGPatternElement` \| `SVGPolygonElement` \| `SVGPolylineElement` \| `SVGRadialGradientElement` \| `SVGRectElement` \| `SVGSetElement` \| `SVGStopElement` \| `SVGSVGElement` \| `SVGSwitchElement` \| `SVGSymbolElement` \| `SVGTextElement` \| `SVGTextPathElement` \| `SVGTSpanElement` \| `SVGUseElement` \| `SVGViewElement`

### Parameters

#### type

`TSVGTag`

HTML/SVG/MathML tag name or a component function/class.

#### props?

Attributes/props for the element. Children are read from `props.children`; may be `null`.

[`SVGElementTags`](../interfaces/SVGElementTags.md)\[`TSVGTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

The created DOM node (or component render result).

## Call Signature

> **jsx**(`type`, `props?`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/jsx-factory.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L42)

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

Attributes/props for the element. Children are read from `props.children`; may be `null`.

[`ElementAttributes`](../interfaces/ElementAttributes.md)\<[`JSXElement`](../type-aliases/JSXElement.md)\> & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created DOM node (or component render result).

## Call Signature

> **jsx**\<`P`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L47)

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

Attributes/props for the element. Children are read from `props.children`; may be `null`.

`P` & `object` | `null`

### Returns

`TElement`

The created DOM node (or component render result).
