[@serenity-is/corelib](../README.md) / RetrieveResponse

# Interface: RetrieveResponse\<TEntity\>

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Type Parameters

• **TEntity**

## Properties

### Entity?

> `optional` **Entity**: `TEntity`

#### Defined in

[src/base/servicetypes.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L92)

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

#### Defined in

[src/base/servicetypes.ts:10](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L10)

***

### Localizations?

> `optional` **Localizations**: `object`

#### Index Signature

 \[`languageId`: `string`\]: `Partial`\<`TEntity`\>

#### Defined in

[src/base/servicetypes.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L93)
