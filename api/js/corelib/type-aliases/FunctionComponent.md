[@serenity-is/corelib](../README.md) / FunctionComponent

# Type Alias: FunctionComponent()\<P, T\>

> **FunctionComponent**\<`P`, `T`\> = (`props`) => `T` \| `null`

Defined in: [../domwise/dist/index.d.ts:2339](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2339)

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
