[serenity-is/corelib](../README.md) / Lookup

# Class: Lookup\<TItem\>

Defined in: [src/base/lookup.ts:7](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L7)

## Type Parameters

### TItem

`TItem`

## Constructors

### Constructor

> **new Lookup**\<`TItem`\>(`options`, `items?`): `Lookup`\<`TItem`\>

Defined in: [src/base/lookup.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L22)

#### Parameters

##### options

[`LookupOptions`](../interfaces/LookupOptions.md)\<`TItem`\>

##### items?

`TItem`[]

#### Returns

`Lookup`\<`TItem`\>

## Properties

### idField

> **idField**: `string`

Defined in: [src/base/lookup.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L10)

***

### itemById

> **itemById**: `object`

Defined in: [src/base/lookup.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L9)

#### Index Signature

\[`key`: `string`\]: `TItem`

***

### items

> **items**: `TItem`[]

Defined in: [src/base/lookup.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L8)

***

### parentIdField

> **parentIdField**: `string`

Defined in: [src/base/lookup.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L11)

***

### textField

> **textField**: `string`

Defined in: [src/base/lookup.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L12)

## Methods

### update()?

> `optional` **update**(`value`): `void`

Defined in: [src/base/lookup.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/lookup.ts#L34)

#### Parameters

##### value

`TItem`[]

#### Returns

`void`
