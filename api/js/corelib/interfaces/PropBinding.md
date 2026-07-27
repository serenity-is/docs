[@serenity-is/corelib](../README.md) / PropBinding

# Interface: PropBinding()\<T, TElement\>

Defined in: [../domwise/dist/index.d.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L33)

## Extends

- [`PropHook`](PropHook.md)\<`TElement`\>

## Type Parameters

### T

`T` = `any`

### TElement

`TElement` *extends* `Element` = `Element`

## Call Signature

> **PropBinding**(): `T`

Defined in: [../domwise/dist/index.d.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L34)

### Returns

`T`

## Call Signature

> **PropBinding**(`value`): `T`

Defined in: [../domwise/dist/index.d.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L35)

### Parameters

#### value

`T`

### Returns

`T`

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [../domwise/dist/index.d.ts:2425](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2425)

#### Parameters

##### node

`TElement`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)
