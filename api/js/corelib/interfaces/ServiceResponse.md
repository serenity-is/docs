[@serenity-is/corelib](../README.md) / ServiceResponse

# Interface: ServiceResponse

Defined in: [src/base/servicetypes.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L23)

Base contract for every Serenity service response.
Successful responses omit `Error`; failed responses populate it and may omit other fields.

## Extended by

- [`SaveResponse`](SaveResponse.md)
- [`DeleteResponse`](DeleteResponse.md)
- [`UndeleteResponse`](UndeleteResponse.md)
- [`ListResponse`](ListResponse.md)
- [`RetrieveResponse`](RetrieveResponse.md)
- [`UploadResponse`](UploadResponse.md)

## Properties

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L25)

Error information when the request failed; `undefined` on success.
