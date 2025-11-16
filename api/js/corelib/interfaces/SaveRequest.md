[corelib](../README.md) / SaveRequest

# Interface: SaveRequest\<TEntity\>

Defined in: [src/base/servicetypes.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L16)

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Type Parameters

### TEntity

`TEntity`

## Properties

### Entity?

> `optional` **Entity**: `TEntity`

Defined in: [src/base/servicetypes.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L18)

***

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L17)

***

### Localizations?

> `optional` **Localizations**: `object`

Defined in: [src/base/servicetypes.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L19)

#### Index Signature

\[`languageId`: `string`\]: `Partial`\<`TEntity`\>
