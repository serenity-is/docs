[@serenity-is/corelib](../README.md) / UploaderRequest

# Interface: UploaderRequest

## Table of contents

### Properties

- [headers](UploaderRequest.md#headers)
- [responseType](UploaderRequest.md#responsetype)
- [url](UploaderRequest.md#url)

## Properties

### headers

• `Optional` **headers**: `Record`\<`string`, `string`\>

A function that will return headers to be sent with request, or static set of headers

#### Defined in

[src/base/uploader.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L43)

___

### responseType

• `Optional` **responseType**: ``"text"`` \| ``"json"``

Response type expected from the server. Default is json

#### Defined in

[src/base/uploader.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L45)

___

### url

• `Optional` **url**: `string`

URL to send the request to. Default is ~/File/TemporaryUpload

#### Defined in

[src/base/uploader.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L47)
