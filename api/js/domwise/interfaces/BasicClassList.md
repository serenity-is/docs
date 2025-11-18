[@serenity-is/domwise](../README.md) / BasicClassList

# Interface: BasicClassList()

Defined in: [types/basic-types.d.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L5)

## Extends

- [`PropHook`](PropHook.md)\<`Element`\>

> **BasicClassList**(): `DOMTokenList`

Defined in: [types/basic-types.d.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L6)

## Returns

`DOMTokenList`

## Properties

### size

> `readonly` **size**: `number`

Defined in: [types/basic-types.d.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L7)

***

### value

> `readonly` **value**: `string`

Defined in: [types/basic-types.d.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L8)

## Methods

### \[initPropHookSymbol\]()

> **\[initPropHookSymbol\]**(`node`, `propName`): `void`

Defined in: [src/prop-hook.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/domwise/src/prop-hook.ts#L5)

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

Defined in: [types/basic-types.d.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L9)

#### Parameters

##### tokens

...`string`[]

#### Returns

`void`

***

### contains()

> **contains**(`token`): `boolean`

Defined in: [types/basic-types.d.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L12)

#### Parameters

##### token

`string`

#### Returns

`boolean`

***

### remove()

> **remove**(...`tokens`): `void`

Defined in: [types/basic-types.d.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L10)

#### Parameters

##### tokens

...`string`[]

#### Returns

`void`

***

### toggle()

> **toggle**(`token`, `force?`): `void`

Defined in: [types/basic-types.d.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/domwise/types/basic-types.d.ts#L11)

#### Parameters

##### token

`string`

##### force?

`boolean`

#### Returns

`void`
