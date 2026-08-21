[@serenity-is/domwise](../README.md) / Fragment

# Function: Fragment()

> **Fragment**(`attr`): `any`

Defined in: [src/fragment.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/fragment.ts#L14)

Creates a `DocumentFragment` containing the given children.

Intended as the JSX fragment factory (i.e. the target for the `<></>` syntax
when `jsxFragment` is set to `Fragment`). Accepts the standard
`{ children }` props bag produced by the JSX transform.

## Parameters

### attr

Props bag with optional `children` to append to the fragment.

#### children?

[`ComponentChildren`](../type-aliases/ComponentChildren.md)

## Returns

`any`

A `DocumentFragment` containing the appended children.
