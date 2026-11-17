[@serenity-is/corelib](../README.md) / DeleteResponse

# Interface: DeleteResponse

Defined in: [src/base/servicetypes.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L69)

Response DTO for `Delete` handlers. No additional fields beyond [ServiceResponse](ServiceResponse.md).

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Properties

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L27)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)
