[@serenity-is/corelib](../README.md) / UploaderSuccessData

# Interface: UploaderSuccessData

Defined in: [src/base/uploader.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L78)

Data passed to [UploaderOptions.batchSuccess](UploaderOptions.md#batchsuccess) after a successful upload.

## Properties

### batch

> **batch**: [`UploaderBatch`](UploaderBatch.md)

Defined in: [src/base/uploader.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L80)

The batch that was uploaded.

***

### event

> **event**: `ProgressEvent`

Defined in: [src/base/uploader.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L84)

XHR load event.

***

### request

> **request**: [`UploaderRequest`](UploaderRequest.md)

Defined in: [src/base/uploader.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L82)

Request configuration used for the upload.

***

### response

> **response**: `any`

Defined in: [src/base/uploader.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L88)

Parsed response body (JSON or text depending on [UploaderRequest.responseType](UploaderRequest.md#responsetype)).

***

### xhr

> **xhr**: `XMLHttpRequest`

Defined in: [src/base/uploader.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L86)

The underlying `XMLHttpRequest`.
