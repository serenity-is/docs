[@serenity-is/corelib](../README.md) / UploaderOptions

# Interface: UploaderOptions

Defined in: [src/base/uploader.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L9)

## Properties

### accept?

> `optional` **accept**: `string`

Defined in: [src/base/uploader.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L11)

Accept. If not specified, read from the passed input

***

### allStart()?

> `optional` **allStart**: () => `void`

Defined in: [src/base/uploader.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L19)

Progress event that is called before first batch start is about to be uploaded

#### Returns

`void`

***

### allStop()?

> `optional` **allStop**: () => `void`

Defined in: [src/base/uploader.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L21)

Progress event that is called after last batch is ended uploading or failed

#### Returns

`void`

***

### autoClear?

> `optional` **autoClear**: `boolean`

Defined in: [src/base/uploader.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L13)

Auto clear input value after selection, so when same file selected it works. Default is true

***

### batchHandler()?

> `optional` **batchHandler**: (`batch`, `uploader`) => `void` \| `Promise`\<`void`\>

Defined in: [src/base/uploader.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L31)

Callback to handle a batch. If not specified, a default handler is used.

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

Defined in: [src/base/uploader.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L29)

Progress event that is called during upload

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

Defined in: [src/base/uploader.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L15)

Only used for multiple, default is 1 to upload multiple files in batches of size 1

***

### batchStart()?

> `optional` **batchStart**: (`data`) => `void`

Defined in: [src/base/uploader.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L23)

Progress event that is called when a batch is about to be uploaded

#### Parameters

##### data

###### batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

***

### batchStop()?

> `optional` **batchStop**: (`data`) => `void`

Defined in: [src/base/uploader.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L25)

Progress event that is called when a batch is ended uploading or failed

#### Parameters

##### data

###### batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

***

### batchSuccess()?

> `optional` **batchSuccess**: (`data`) => `void`

Defined in: [src/base/uploader.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L27)

Called after batch is uploaded successfully

#### Parameters

##### data

[`UploaderSuccessData`](UploaderSuccessData.md)

#### Returns

`void`

***

### changeCallback()?

> `optional` **changeCallback**: (`e`) => `void`

Defined in: [src/base/uploader.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L33)

Only called when a change/drop event occurs, but files can't be determined

#### Parameters

##### e

`Event`

#### Returns

`void`

***

### dropZone?

> `optional` **dropZone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/base/uploader.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L17)

An optional list of dropzones.

***

### errorHandler()?

> `optional` **errorHandler**: (`data`) => `void`

Defined in: [src/base/uploader.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L35)

Error handler, if not specified Uploader.errorHandler is used

#### Parameters

##### data

[`UploaderErrorData`](UploaderErrorData.md)

#### Returns

`void`

***

### ignoreType?

> `optional` **ignoreType**: `boolean`

Defined in: [src/base/uploader.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L37)

Ignore file types, e.g. don't check accept property of input or this options

***

### input?

> `optional` **input**: `HTMLInputElement`

Defined in: [src/base/uploader.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L39)

Target input. If null, dropZone should be specified.

***

### multiple?

> `optional` **multiple**: `boolean`

Defined in: [src/base/uploader.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L41)

Allow multiple files. If not specified is read from the input

***

### name?

> `optional` **name**: `string`

Defined in: [src/base/uploader.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L43)

The field name to use in FormData object. Default is files[]
