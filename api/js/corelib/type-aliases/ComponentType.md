[@serenity-is/corelib](../README.md) / ComponentType

# Type Alias: ComponentType\<P, T\>

> **ComponentType**\<`P`, `T`\> = [`ComponentClass`](../interfaces/ComponentClass.md)\<`P`, `T`\> \| [`FunctionComponent`](FunctionComponent.md)\<`P`, `T`\>

Defined in: [../domwise/dist/index.d.ts:2347](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2347)

A JSX component: either a class-based or a function-based component.

## Type Parameters

### P

`P` = \{ \}

The type of the component's props.

### T

`T` *extends* `Node` = [`JSXElement`](JSXElement.md)

The type of the DOM node the component renders.
