[@serenity-is/corelib](../README.md) / Component

# Class: Component\<T\>

Defined in: [../domwise/dist/index.d.ts:2463](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2463)

Base class for class-based JSX components.

Extend this class and override [render](#render) to return a [JSXElement](../type-aliases/JSXElement.md).
Props (including optional `children` and `ref`) are available via [props](#props).

## Example

```tsx
class Greeting extends Component<{ name: string }> {
  render() {
    return <div>Hello, {this.props.name}!</div>;
  }
}
// usage: <Greeting name="World" />
```

## Type Parameters

### T

`T` = `any`

The type of the component's props (excluding `children` and `ref` which are added automatically).

## Constructors

### Constructor

> **new Component**\<`T`\>(`props`): `Component`\<`T`\>

Defined in: [../domwise/dist/index.d.ts:2473](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2473)

Creates a component instance.

#### Parameters

##### props

`T` & `object`

Props passed to the component, including optional `children` and `ref`.

#### Returns

`Component`\<`T`\>

## Properties

### props

> `readonly` **props**: `T` & `object`

Defined in: [../domwise/dist/index.d.ts:2478](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2478)

Props passed to this component instance, including optional `children` and `ref`.

#### Type Declaration

##### children?

> `optional` **children**: [`ComponentChildren`](../type-aliases/ComponentChildren.md)

##### ref?

> `optional` **ref**: [`Ref`](../type-aliases/Ref.md)\<`any`\>

***

### isComponent

> `static` **isComponent**: `boolean`

Defined in: [../domwise/dist/index.d.ts:2468](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2468)

Marker used by the JSX factory to distinguish class components from function components.
Do not modify.

## Methods

### render()

> **render**(): [`JSXElement`](../type-aliases/JSXElement.md)

Defined in: [../domwise/dist/index.d.ts:2487](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2487)

Renders the component's output.
Override in subclasses to return a DOM node, fragment, or `null`.

#### Returns

[`JSXElement`](../type-aliases/JSXElement.md)

The rendered [JSXElement](../type-aliases/JSXElement.md), or `null` to render nothing.
