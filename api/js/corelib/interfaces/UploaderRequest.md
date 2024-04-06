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

[../base/dist/index.d.ts:1646](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1646)

___

### responseType

• `Optional` **responseType**: ``"text"`` \| ``"json"``

Response type expected from the server. Default is json

#### Defined in

[../base/dist/index.d.ts:1648](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1648)

___

### url

• `Optional` **url**: `string`

URL to send the request to. Default is ~/File/TemporaryUpload

#### Defined in

[../base/dist/index.d.ts:1650](https://github.com/serenity-is/serenity/blob/master/packages/base/dist/index.d.ts#L1650)
