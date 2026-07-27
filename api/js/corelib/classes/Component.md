[@serenity-is/corelib](../README.md) / Component

# Class: Component\<T\>

Defined in: [../domwise/dist/index.d.ts:2250](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2250)

Base class for creating JSX components with optional props, children, and ref support.
Extend this class and override the `render` method to return a `JSXElement`.

## Type Parameters

### T

`T` = `any`

The type of the component's props.

## Constructors

### Constructor

> **new Component**\<`T`\>(`props`): `Component`\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2252](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2252)

#### Parameters

##### props

`T` & `object`

#### Returns

`Component`\<`T`\>

## Properties

### props

> `readonly` **props**: `T` & `object`

Defined in: [../domwise/dist/index.d.ts:2256](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2256)

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

##### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`any`\>

***

### isComponent

> `static` **isComponent**: `boolean`

Defined in: [../domwise/dist/index.d.ts:2251](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2251)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2260](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2260)

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)
