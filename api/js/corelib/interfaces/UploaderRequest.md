[@serenity-is/corelib](../README.md) / UploaderRequest

# Interface: UploaderRequest

## Properties

### headers?

> `optional` **headers**: `Record`\<`string`, `string`\>

A function that will return headers to be sent with request, or static set of headers

#### Defined in

[src/base/uploader.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L48)

***

### responseType?

> `optional` **responseType**: `"text"` \| `"json"`

Response type expected from the server. Default is json

#### Defined in

[src/base/uploader.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L50)

***

### url?

> `optional` **url**: `string`

URL to send the request to. Default is ~/File/TemporaryUpload

#### Defined in

[src/base/uploader.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L52)
