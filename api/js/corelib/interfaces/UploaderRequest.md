[@serenity-is/corelib](../README.md) / UploaderRequest

# Interface: UploaderRequest

Defined in: [src/base/uploader.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L46)

## Properties

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

Defined in: [src/base/uploader.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L48)

A function that will return headers to be sent with request, or static set of headers

***

### responseType?

> `optional` **responseType**: `"text"` \| `"json"`

Defined in: [src/base/uploader.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L50)

Response type expected from the server. Default is json

***

### url?

> `optional` **url**: `string`

Defined in: [src/base/uploader.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L52)

URL to send the request to. Default is ~/File/TemporaryUpload
