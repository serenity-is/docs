[@serenity-is/domwise](../README.md) / createElement

# Function: createElement()

> **createElement**(`tag`, `attr`, ...`children`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/compat-api.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/compat-api.ts#L22)

Creates a JSX element using the classic (non-automatic) JSX factory signature.

Children are passed as variadic rest arguments after `attr`. For compatibility,
if `attr` itself is a string or array it is treated as the first child and
`attr` is replaced with `{}`. If `attr.children` is set and no explicit
`children` were supplied, the `children` property is extracted from `attr`.

Prefer [jsx](jsx.md) when using the automatic JSX runtime (`"jsx": "automatic"`).

## Parameters

### tag

`any`

HTML/SVG tag name or a component function/class.

### attr

`any`

Attributes/props for the element, or the first child when a
string or array. May be `null`/`undefined` when no attributes are needed.

### children

...`any`[]

Child elements passed as rest arguments.

## Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created JSX DOM node.
