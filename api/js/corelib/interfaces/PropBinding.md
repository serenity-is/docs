[@serenity-is/corelib](../README.md) / PropBinding

# Interface: PropBinding()\<T, TElement\>

Defined in: [../domwise/dist/index.d.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L119)

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

Defined in: [../domwise/dist/index.d.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L124)

Gets the current bound value.

### Returns

`T`

The current value.

## Call Signature

> **PropBinding**(`value`): `T`

Defined in: [../domwise/dist/index.d.ts:130](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L130)

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

Defined in: [../domwise/dist/index.d.ts:3102](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3102)

#### Parameters

##### node

`TElement`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)
