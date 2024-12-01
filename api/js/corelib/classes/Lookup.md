[@serenity-is/corelib](../README.md) / Lookup

# Class: Lookup\<TItem\>

## Type Parameters

• **TItem**

## Constructors

### new Lookup()

> **new Lookup**\<`TItem`\>(`options`, `items`?): [`Lookup`](Lookup.md)\<`TItem`\>

#### Parameters

##### options

[`LookupOptions`](../interfaces/LookupOptions.md)\<`TItem`\>

##### items?

`TItem`[]

#### Returns

[`Lookup`](Lookup.md)\<`TItem`\>

#### Defined in

[src/base/lookup.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L22)

## Properties

### idField

> **idField**: `string`

#### Defined in

[src/base/lookup.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L10)

***

### itemById

> **itemById**: `object`

#### Index Signature

 \[`key`: `string`\]: `TItem`

#### Defined in

[src/base/lookup.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L9)

***

### items

> **items**: `TItem`[]

#### Defined in

[src/base/lookup.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L8)

***

### parentIdField

> **parentIdField**: `string`

#### Defined in

[src/base/lookup.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L11)

***

### textField

> **textField**: `string`

#### Defined in

[src/base/lookup.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L12)

## Methods

### update()?

> `optional` **update**(`value`): `void`

#### Parameters

##### value

`TItem`[]

#### Returns

`void`

#### Defined in

[src/base/lookup.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L34)
