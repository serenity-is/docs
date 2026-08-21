[@serenity-is/corelib](../README.md) / UploaderErrorData

# Interface: UploaderErrorData

Defined in: [src/base/uploader.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L94)

Data passed to error handlers when an upload fails.

## Properties

### batch?

> `optional` **batch**: [`UploaderBatch`](UploaderBatch.md)

Defined in: [src/base/uploader.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L96)

The batch that failed, if available.

***

### event?

> `optional` **event**: `ProgressEvent`

Defined in: [src/base/uploader.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L98)

XHR progress / error event, if available.

***

### exception?

> `optional` **exception**: `any`

Defined in: [src/base/uploader.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L100)

Exception thrown during setup or handling, if any.

***

### request?

> `optional` **request**: [`UploaderRequest`](UploaderRequest.md)

Defined in: [src/base/uploader.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L102)

Request configuration used for the failed attempt.

***

### response?

> `optional` **response**: `any`

Defined in: [src/base/uploader.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L104)

Parsed response body, if available.

***

### xhr?

> `optional` **xhr**: `XMLHttpRequest`

Defined in: [src/base/uploader.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L106)

The underlying `XMLHttpRequest`, if available.
