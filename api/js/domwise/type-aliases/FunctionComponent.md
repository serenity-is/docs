[@serenity-is/domwise](../README.md) / FunctionComponent

# Type Alias: FunctionComponent()\<P, T\>

> **FunctionComponent**\<`P`, `T`\> = (`props`) => `T` \| `null`

Defined in: [types/components.d.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/components.d.ts#L35)

A function-based JSX component that receives props (including `children`)
and returns a `JSXElement` or `null`.

## Type Parameters

### P

`P` = \{ \}

The type of the component's props.

### T

`T` *extends* `Node` = [`JSXElement`](JSXElement.md)

The type of the DOM node the component renders.

## Parameters

### props

`P` & `object`

## Returns

`T` \| `null`
