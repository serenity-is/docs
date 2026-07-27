[@serenity-is/domwise](../README.md) / createElement

# Function: createElement()

> **createElement**(`tag`, `attr`, ...`children`): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [src/compat-api.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/compat-api.ts#L17)

Creates a JSX element using the classic (non-automatic) JSX factory signature.
Children are passed as additional arguments after `attr` (rest params).
If `attr` is a string or array, it is treated as the first child and `attr` becomes `{}`.
If `attr.children` exists and no additional children were given, `attr.children` is used.
Prefer using the `jsx` function directly when using the automatic JSX runtime.

## Parameters

### tag

`any`

The HTML/SVG tag name or component function/class.

### attr

`any`

The attributes/props for the element, or the first child if it is a string/array.

### children

...`any`[]

Child elements passed as rest arguments.

## Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The created JSX element.
