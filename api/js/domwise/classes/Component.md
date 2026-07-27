[@serenity-is/domwise](../README.md) / Component

# Class: Component\<T\>

Defined in: [src/component.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L9)

Base class for creating JSX components with optional props, children, and ref support.
Extend this class and override the `render` method to return a `JSXElement`.

## Type Parameters

### T

`T` = `any`

The type of the component's props.

## Constructors

### Constructor

> **new Component**\<`T`\>(`props`): `Component`\<`T`\>

Defined in: [src/component.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L12)

#### Parameters

##### props

`T` & `object`

#### Returns

`Component`\<`T`\>

## Properties

### props

> `readonly` **props**: `T` & `object`

Defined in: [src/component.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L16)

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

##### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`any`\>

***

### isComponent

> `static` **isComponent**: `boolean` = `true`

Defined in: [src/component.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L10)

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md) \| `null`

Defined in: [src/component.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/component.ts#L18)

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md) \| `null`
