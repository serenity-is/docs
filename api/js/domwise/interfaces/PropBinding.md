[@serenity-is/domwise](../README.md) / PropBinding

# Interface: PropBinding()\<T, TElement\>

Defined in: [types/basic-types.d.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L39)

## Extends

- [`PropHook`](PropHook.md)\<`TElement`\>

## Type Parameters

### T

`T` = `any`

### TElement

`TElement` *extends* `Element` = `Element`

## Call Signature

> **PropBinding**(): `T`

Defined in: [types/basic-types.d.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L40)

### Returns

`T`

## Call Signature

> **PropBinding**(`value`): `T`

Defined in: [types/basic-types.d.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L41)

### Parameters

#### value

`T`

### Returns

`T`

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [src/prop-hook.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/prop-hook.ts#L5)

#### Parameters

##### node

`TElement`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)
