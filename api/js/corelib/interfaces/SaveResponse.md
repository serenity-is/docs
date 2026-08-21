[@serenity-is/corelib](../README.md) / SaveResponse

# Interface: SaveResponse

Defined in: [src/base/servicetypes.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L51)

Response DTO for `Create` / `Update` handlers.

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Properties

### EntityId?

> `optional` **EntityId**: `any`

Defined in: [src/base/servicetypes.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L53)

Primary key of the created / updated entity as assigned / confirmed by the server.

***

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L25)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)
