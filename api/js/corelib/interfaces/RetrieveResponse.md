[@serenity-is/corelib](../README.md) / RetrieveResponse

# Interface: RetrieveResponse\<TEntity\>

Defined in: [src/base/servicetypes.ts:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L388)

Response DTO for `Retrieve` handlers.

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Type Parameters

### TEntity

`TEntity`

Row / entity type.

## Properties

### Entity?

> `optional` **Entity**: `TEntity`

Defined in: [src/base/servicetypes.ts:390](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L390)

The retrieved entity, or `undefined` if not found (depending on handler).

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L27)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### Localizations?

> `optional` **Localizations**: `object`

Defined in: [src/base/servicetypes.ts:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L392)

Per-language values for localizable fields, keyed by language ID.

#### Index Signature

\[`languageId`: `string`\]: `Partial`\<`TEntity`\>
