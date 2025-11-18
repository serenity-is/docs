[@serenity-is/domwise](../README.md) / jsx

# Function: jsx()

## Call Signature

> **jsx**\<`THtmlTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L14)

### Type Parameters

#### THtmlTag

`THtmlTag` *extends* keyof `HTMLElementTagNameMap`

#### TElement

`TElement` *extends* `HTMLElement` \| `HTMLInputElement` \| `HTMLSelectElement` \| `HTMLTextAreaElement` \| `HTMLAnchorElement` \| `HTMLAreaElement` \| `HTMLAudioElement` \| `HTMLBaseElement` \| `HTMLQuoteElement` \| `HTMLBodyElement` \| `HTMLBRElement` \| `HTMLButtonElement` \| `HTMLCanvasElement` \| `HTMLTableCaptionElement` \| `HTMLTableColElement` \| `HTMLDataElement` \| `HTMLDataListElement` \| `HTMLModElement` \| `HTMLDetailsElement` \| `HTMLDialogElement` \| `HTMLDivElement` \| `HTMLDListElement` \| `HTMLEmbedElement` \| `HTMLFieldSetElement` \| `HTMLFormElement` \| `HTMLHeadingElement` \| `HTMLHeadElement` \| `HTMLHRElement` \| `HTMLHtmlElement` \| `HTMLIFrameElement` \| `HTMLImageElement` \| `HTMLLabelElement` \| `HTMLLegendElement` \| `HTMLLIElement` \| `HTMLLinkElement` \| `HTMLMapElement` \| `HTMLMenuElement` \| `HTMLMetaElement` \| `HTMLMeterElement` \| `HTMLObjectElement` \| `HTMLOListElement` \| `HTMLOptGroupElement` \| `HTMLOptionElement` \| `HTMLOutputElement` \| `HTMLParagraphElement` \| `HTMLPictureElement` \| `HTMLPreElement` \| `HTMLProgressElement` \| `HTMLScriptElement` \| `HTMLSlotElement` \| `HTMLSourceElement` \| `HTMLSpanElement` \| `HTMLStyleElement` \| `HTMLTableElement` \| `HTMLTableSectionElement` \| `HTMLTableCellElement` \| `HTMLTemplateElement` \| `HTMLTimeElement` \| `HTMLTitleElement` \| `HTMLTableRowElement` \| `HTMLTrackElement` \| `HTMLUListElement` \| `HTMLVideoElement`

### Parameters

#### type

`THtmlTag`

#### props?

[`HTMLElementTags`](../interfaces/HTMLElementTags.md)\[`THtmlTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

## Call Signature

> **jsx**\<`TSVGTag`, `TElement`\>(`type`, `props?`): `TElement`

Defined in: [src/jsx-factory.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L18)

### Type Parameters

#### TSVGTag

`TSVGTag` *extends* `"symbol"` \| `"svg"` \| `"clipPath"` \| `"filter"` \| `"marker"` \| `"mask"` \| `"text"` \| `"switch"` \| `"image"` \| `"rect"` \| `"circle"` \| `"pattern"` \| `"metadata"` \| `"path"` \| `"animate"` \| `"animateMotion"` \| `"animateTransform"` \| `"defs"` \| `"desc"` \| `"ellipse"` \| `"feBlend"` \| `"feColorMatrix"` \| `"feComponentTransfer"` \| `"feComposite"` \| `"feConvolveMatrix"` \| `"feDiffuseLighting"` \| `"feDisplacementMap"` \| `"feDistantLight"` \| `"feDropShadow"` \| `"feFlood"` \| `"feFuncA"` \| `"feFuncB"` \| `"feFuncG"` \| `"feFuncR"` \| `"feGaussianBlur"` \| `"feImage"` \| `"feMerge"` \| `"feMergeNode"` \| `"feMorphology"` \| `"feOffset"` \| `"fePointLight"` \| `"feSpecularLighting"` \| `"feSpotLight"` \| `"feTile"` \| `"feTurbulence"` \| `"foreignObject"` \| `"g"` \| `"line"` \| `"linearGradient"` \| `"mpath"` \| `"polygon"` \| `"polyline"` \| `"radialGradient"` \| `"set"` \| `"stop"` \| `"textPath"` \| `"tspan"` \| `"use"` \| `"view"`

#### TElement

`TElement` *extends* `SVGAnimateElement` \| `SVGAnimateMotionElement` \| `SVGAnimateTransformElement` \| `SVGCircleElement` \| `SVGClipPathElement` \| `SVGDefsElement` \| `SVGDescElement` \| `SVGEllipseElement` \| `SVGFEBlendElement` \| `SVGFEColorMatrixElement` \| `SVGFEComponentTransferElement` \| `SVGFECompositeElement` \| `SVGFEConvolveMatrixElement` \| `SVGFEDiffuseLightingElement` \| `SVGFEDisplacementMapElement` \| `SVGFEDistantLightElement` \| `SVGFEDropShadowElement` \| `SVGFEFloodElement` \| `SVGFEFuncAElement` \| `SVGFEFuncBElement` \| `SVGFEFuncGElement` \| `SVGFEFuncRElement` \| `SVGFEGaussianBlurElement` \| `SVGFEImageElement` \| `SVGFEMergeElement` \| `SVGFEMergeNodeElement` \| `SVGFEMorphologyElement` \| `SVGFEOffsetElement` \| `SVGFEPointLightElement` \| `SVGFESpecularLightingElement` \| `SVGFESpotLightElement` \| `SVGFETileElement` \| `SVGFETurbulenceElement` \| `SVGFilterElement` \| `SVGForeignObjectElement` \| `SVGGElement` \| `SVGImageElement` \| `SVGLineElement` \| `SVGLinearGradientElement` \| `SVGMarkerElement` \| `SVGMaskElement` \| `SVGMetadataElement` \| `SVGMPathElement` \| `SVGPathElement` \| `SVGPatternElement` \| `SVGPolygonElement` \| `SVGPolylineElement` \| `SVGRadialGradientElement` \| `SVGRectElement` \| `SVGSetElement` \| `SVGStopElement` \| `SVGSVGElement` \| `SVGSwitchElement` \| `SVGSymbolElement` \| `SVGTextElement` \| `SVGTextPathElement` \| `SVGTSpanElement` \| `SVGUseElement` \| `SVGViewElement`

### Parameters

#### type

`TSVGTag`

#### props?

[`SVGElementTags`](../interfaces/SVGElementTags.md)\[`TSVGTag`\] & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

`TElement`

## Call Signature

> **jsx**(`type`, `props?`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/jsx-factory.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/jsx-factory.ts#L22)

### Parameters

#### type

`string`

#### props?

[`ElementAttributes`](../interfaces/ElementAttributes.md)\<[`JSXElement`](../type-aliases/JSXElement.md)\> & `Record`\<`` `data-${string}` ``, `string` \| `number`\> | `null`

### Returns

[`JSXElement`](../type-aliases/JSXElement.md)
