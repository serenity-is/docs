[@serenity-is/corelib](../README.md) / UndeleteResponse

# Interface: UndeleteResponse

Defined in: [src/base/servicetypes.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L83)

Response DTO for `Undelete` handlers. No additional fields beyond [ServiceResponse](ServiceResponse.md).

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Properties

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L27)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)
