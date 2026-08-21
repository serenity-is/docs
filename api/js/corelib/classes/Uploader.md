[@serenity-is/corelib](../README.md) / Uploader

# Class: Uploader

Defined in: [src/base/uploader.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L116)

File uploader that handles `input` change, drag-and-drop, paste, and directory
traversal, batching files and uploading each batch via `XMLHttpRequest`.
Supports MIME filtering, progress events, CSRF headers, and custom batch handling.

## Constructors

### Constructor

> **new Uploader**(`opt`): `Uploader`

Defined in: [src/base/uploader.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L125)

Creates a new uploader and wires up the configured input and drop zones.

#### Parameters

##### opt

[`UploaderOptions`](../interfaces/UploaderOptions.md)

Uploader configuration; defaults from [Uploader.defaults](#defaults) are applied.

#### Returns

`Uploader`

## Properties

### defaults

> `static` **defaults**: `Partial`\<[`UploaderOptions`](../interfaces/UploaderOptions.md)\>

Defined in: [src/base/uploader.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L182)

Default [UploaderOptions](../interfaces/UploaderOptions.md) applied when constructing an instance.

***

### requestDefaults

> `static` **requestDefaults**: `Partial`\<[`UploaderRequest`](../interfaces/UploaderRequest.md)\>

Defined in: [src/base/uploader.ts:189](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L189)

Default [UploaderRequest](../interfaces/UploaderRequest.md) applied when [Uploader.uploadBatch](#uploadbatch) is called without explicit request options.

## Methods

### isMultiple()

> **isMultiple**(): `boolean`

Defined in: [src/base/uploader.ts:197](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L197)

Whether the uploader is configured for multiple file selection.

#### Returns

`boolean`

`true` if multiple files are allowed.

***

### uploadBatch()

> **uploadBatch**(`batch`, `request?`): `Promise`\<`void`\>

Defined in: [src/base/uploader.ts:397](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L397)

Uploads a single batch via `XMLHttpRequest`.

#### Parameters

##### batch

[`UploaderBatch`](../interfaces/UploaderBatch.md)

Batch payload containing `FormData` and file paths.

##### request?

[`UploaderRequest`](../interfaces/UploaderRequest.md)

Optional request overrides merged over [Uploader.requestDefaults](#requestdefaults).

#### Returns

`Promise`\<`void`\>

***

### errorHandler()

> `static` **errorHandler**(`data`): `void`

Defined in: [src/base/uploader.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L519)

Default error handler. Logs the exception, surfaces server error messages,
and falls back to generic notifications or an iframe dialog for HTML responses.

#### Parameters

##### data

[`UploaderErrorData`](../interfaces/UploaderErrorData.md)

Error context for the failed upload.

#### Returns

`void`
