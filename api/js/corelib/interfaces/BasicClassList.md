[@serenity-is/corelib](../README.md) / BasicClassList

# Interface: BasicClassList()

Defined in: [../domwise/dist/index.d.ts:3](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L3)

## Extends

- [`PropHook`](PropHook.md)\<`Element`\>

> **BasicClassList**(): `DOMTokenList`

Defined in: [../domwise/dist/index.d.ts:4](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L4)

## Returns

`DOMTokenList`

## Properties

### size

> `readonly` **size**: `number`

Defined in: [../domwise/dist/index.d.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L5)

***

### value

> `readonly` **value**: `string`

Defined in: [../domwise/dist/index.d.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L6)

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [../domwise/dist/index.d.ts:2425](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L2425)

#### Parameters

##### node

`Element`

##### propName

`string`

#### Returns

`void`

#### Inherited from

[`PropHook`](PropHook.md).[`[initPropHookSymbol]`](PropHook.md#initprophooksymbol)

***

### add()

> **add**(...`tokens`): `void`

Defined in: [../domwise/dist/index.d.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L7)

#### Parameters

##### tokens

...`string`[]

#### Returns

`void`

***

### contains()

> **contains**(`token`): `boolean`

Defined in: [../domwise/dist/index.d.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L10)

#### Parameters

##### token

`string`

#### Returns

`boolean`

***

### remove()

> **remove**(...`tokens`): `void`

Defined in: [../domwise/dist/index.d.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L8)

#### Parameters

##### tokens

...`string`[]

#### Returns

`void`

***

### toggle()

> **toggle**(`token`, `force?`): `void`

Defined in: [../domwise/dist/index.d.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/dist/index.d.ts#L9)

#### Parameters

##### token

`string`

##### force?

`boolean`

#### Returns

`void`
