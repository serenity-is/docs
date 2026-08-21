[@serenity-is/corelib](../README.md) / UploaderRequest

# Interface: UploaderRequest

Defined in: [src/base/uploader.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L52)

Request configuration for [Uploader.uploadBatch](../classes/Uploader.md#uploadbatch).

## Properties

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/base/uploader.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L54)

Extra headers to send with the upload request.

***

### responseType?

> `optional` **responseType**: `"text"` \| `"json"`

Defined in: [src/base/uploader.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L56)

Expected response type. Defaults to `"json"`.

***

### url?

> `optional` **url**: `string`

Defined in: [src/base/uploader.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L58)

Endpoint URL for the upload. Defaults to `~/File/TemporaryUpload`.
