[@serenity-is/corelib](../README.md) / UploaderOptions

# Interface: UploaderOptions

Defined in: [src/base/uploader.ts:12](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L12)

Options controlling file selection, drag-and-drop, batching, and event callbacks for [Uploader](../classes/Uploader.md).

## Properties

### accept?

> `optional` **accept**: `string`

Defined in: [src/base/uploader.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L14)

MIME / extension filter (e.g. `"image/*,.pdf"`). Falls back to the `accept` attribute of [UploaderOptions.input](#input) when omitted.

***

### allStart()?

> `optional` **allStart**: () => `void`

Defined in: [src/base/uploader.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L22)

Called once before the first batch starts uploading.

#### Returns

`void`

***

### allStop()?

> `optional` **allStop**: () => `void`

Defined in: [src/base/uploader.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L24)

Called once after the last batch completes or fails.

#### Returns

`void`

***

### autoClear?

> `optional` **autoClear**: `boolean`

Defined in: [src/base/uploader.ts:16](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L16)

When `true` (default) clears the input value after handling the change event so re-selecting the same file re-triggers the handler.

***

### batchHandler()?

> `optional` **batchHandler**: (`batch`, `uploader`) => `void` \| `Promise`\<`void`\>

Defined in: [src/base/uploader.ts:34](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L34)

Custom handler for uploading a batch. When omitted [Uploader.uploadBatch](../classes/Uploader.md#uploadbatch) is used.

#### Parameters

##### batch

[`UploaderBatch`](UploaderBatch.md)

##### uploader

[`Uploader`](../classes/Uploader.md)

#### Returns

`void` \| `Promise`\<`void`\>

***

### batchProgress()?

> `optional` **batchProgress**: (`data`) => `void`

Defined in: [src/base/uploader.ts:32](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L32)

Called periodically with upload progress for the current batch.

#### Parameters

##### data

###### batch

[`UploaderBatch`](UploaderBatch.md)

###### loaded

`number`

###### total

`number`

#### Returns

`void`

***

### batchSize?

> `optional` **batchSize**: `number`

Defined in: [src/base/uploader.ts:18](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L18)

Number of files per batch when `multiple` is enabled. Defaults to `1`. Larger values upload files in groups.

***

### batchStart()?

> `optional` **batchStart**: (`data`) => `void`

Defined in: [src/base/uploader.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L26)

Called when an individual batch is about to be uploaded.

#### Parameters

##### data

###### batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

***

### batchStop()?

> `optional` **batchStop**: (`data`) => `void`

Defined in: [src/base/uploader.ts:28](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L28)

Called when an individual batch finishes uploading or fails.

#### Parameters

##### data

###### batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

***

### batchSuccess()?

> `optional` **batchSuccess**: (`data`) => `void`

Defined in: [src/base/uploader.ts:30](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L30)

Called after a batch uploads successfully.

#### Parameters

##### data

[`UploaderSuccessData`](UploaderSuccessData.md)

#### Returns

`void`

***

### changeCallback()?

> `optional` **changeCallback**: (`e`) => `void`

Defined in: [src/base/uploader.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L36)

Called when a change / drop / paste event occurs but no files could be resolved.

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### dropZone?

> `optional` **dropZone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/base/uploader.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L20)

One or more elements that act as drag-and-drop targets.

***

### errorHandler()?

> `optional` **errorHandler**: (`data`) => `void`

Defined in: [src/base/uploader.ts:38](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L38)

Error handler for upload failures. Defaults to [Uploader.errorHandler](../classes/Uploader.md#errorhandler).

#### Parameters

##### data

[`UploaderErrorData`](UploaderErrorData.md)

#### Returns

`void`

***

### ignoreType?

> `optional` **ignoreType**: `boolean`

Defined in: [src/base/uploader.ts:40](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L40)

When `true` disables MIME-type filtering against `accept`.

***

### input?

> `optional` **input**: `HTMLInputElement`

Defined in: [src/base/uploader.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L42)

File input that triggers selection. When `null`, [UploaderOptions.dropZone](#dropzone) must be provided.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/base/uploader.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L44)

Allows multiple file selection. Falls back to the `multiple` attribute of [UploaderOptions.input](#input) when omitted.

***

### name?

> `optional` **name**: `string`

Defined in: [src/base/uploader.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L46)

Form field name used when appending files to `FormData`. Defaults to `"files[]"`.
