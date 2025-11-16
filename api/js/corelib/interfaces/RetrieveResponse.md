[serenity-is/corelib](../README.md) / RetrieveResponse

# Interface: RetrieveResponse\<TEntity\>

Defined in: [src/base/servicetypes.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L91)

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Type Parameters

### TEntity

`TEntity`

## Properties

### Entity?

> `optional` **Entity**: `TEntity`

Defined in: [src/base/servicetypes.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L92)

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L10)

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### Localizations?

> `optional` **Localizations**: `object`

Defined in: [src/base/servicetypes.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L93)

#### Index Signature

\[`languageId`: `string`\]: `Partial`\<`TEntity`\>
