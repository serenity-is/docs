[@serenity-is/corelib](../README.md) / SaveRequest

# Interface: SaveRequest\<TEntity\>

Defined in: [src/base/servicetypes.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L39)

Request DTO for `Create` / `Update` service handlers.

## Extends

- [`ServiceRequest`](ServiceRequest.md)

## Type Parameters

### TEntity

`TEntity`

Row / entity type being saved.

## Properties

### Entity?

> `optional` **Entity**: `TEntity`

Defined in: [src/base/servicetypes.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L43)

Entity fields to persist. For updates only modified fields need to be sent, depending on handler.

***

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L41)

Primary key of the entity to update; omit for inserts (server generates the key).

***

### Localizations?

> `optional` **Localizations**: `object`

Defined in: [src/base/servicetypes.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L45)

Per-language patches for localizable rows, keyed by language ID (e.g. `{ "en": { Name: "Hello" } }`).

#### Index Signature

\[`languageId`: `string`\]: `Partial`\<`TEntity`\>
