[@serenity-is/corelib](../README.md) / PropBinding

# Interface: PropBinding()\<T, TElement\>

Defined in: [../domwise/dist/index.d.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L123)

A two-way prop binding hook created by `usePropBinding`. It acts as a
getter when called with no arguments and a setter when called with a value;
when attached as a prop hook it synchronizes that value to the bound element
attribute.

## Extends

- [`PropHook`](PropHook.md)\<`TElement`\>

## Type Parameters

### T

`T` = `any`

The type of the bound value.

### TElement

`TElement` *extends* `Element` = `Element`

The type of the element the binding is attached to.

## Call Signature

> **PropBinding**(): `T`

Defined in: [../domwise/dist/index.d.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L128)

Gets the current bound value.

### Returns

`T`

The current value.

## Call Signature

> **PropBinding**(`value`): `T`

Defined in: [../domwise/dist/index.d.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L134)

Sets the bound value and synchronizes it to the attached element (if any).

### Parameters

#### value

`T`

New value to store and propagate to the DOM.

### Returns

`T`

The value that was set.

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [../domwise/dist/index.d.ts:2800](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2800)

#### Parameters

##### node

`TElement`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)
