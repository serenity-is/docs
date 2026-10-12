[@serenity-is/corelib](../README.md) / RetrieveResponse

# Interface: RetrieveResponse\<TEntity\>

Defined in: [src/base/servicetypes.ts:253](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L253)

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

Defined in: [src/base/servicetypes.ts:255](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L255)

The retrieved entity, or `undefined` if not found (depending on handler).

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L25)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### Localizations?

> `optional` **Localizations**: `object`

Defined in: [src/base/servicetypes.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L257)

Per-language values for localizable fields, keyed by language ID.

#### Index Signature

\[`languageId`: `string`\]: `Partial`\<`TEntity`\>
