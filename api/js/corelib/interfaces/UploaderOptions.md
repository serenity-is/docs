[@serenity-is/corelib](../README.md) / UploaderOptions

# Interface: UploaderOptions

## Properties

### accept?

> `optional` **accept**: `string`

Accept. If not specified, read from the passed input

#### Defined in

[src/base/uploader.ts:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L11)

***

### allStart()?

> `optional` **allStart**: () => `void`

Progress event that is called before first batch start is about to be uploaded

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L19)

***

### allStop()?

> `optional` **allStop**: () => `void`

Progress event that is called after last batch is ended uploading or failed

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L21)

***

### autoClear?

> `optional` **autoClear**: `boolean`

Auto clear input value after selection, so when same file selected it works. Default is true

#### Defined in

[src/base/uploader.ts:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L13)

***

### batchHandler()?

> `optional` **batchHandler**: (`batch`, `uploader`) => `void` \| `Promise`\<`void`\>

Callback to handle a batch. If not specified, a default handler is used.

#### Parameters

##### batch

[`UploaderBatch`](UploaderBatch.md)

##### uploader

[`Uploader`](../classes/Uploader.md)

#### Returns

`void` \| `Promise`\<`void`\>

#### Defined in

[src/base/uploader.ts:31](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L31)

***

### batchProgress()?

> `optional` **batchProgress**: (`data`) => `void`

Progress event that is called during upload

#### Parameters

##### data

###### data.batch

[`UploaderBatch`](UploaderBatch.md)

###### data.loaded

`number`

###### data.total

`number`

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L29)

***

### batchSize?

> `optional` **batchSize**: `number`

Only used for multiple, default is 1 to upload multiple files in batches of size 1

#### Defined in

[src/base/uploader.ts:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L15)

***

### batchStart()?

> `optional` **batchStart**: (`data`) => `void`

Progress event that is called when a batch is about to be uploaded

#### Parameters

##### data

###### data.batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:23](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L23)

***

### batchStop()?

> `optional` **batchStop**: (`data`) => `void`

Progress event that is called when a batch is ended uploading or failed

#### Parameters

##### data

###### data.batch

[`UploaderBatch`](UploaderBatch.md)

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L25)

***

### batchSuccess()?

> `optional` **batchSuccess**: (`data`) => `void`

Called after batch is uploaded successfully

#### Parameters

##### data

[`UploaderSuccessData`](UploaderSuccessData.md)

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:27](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L27)

***

### changeCallback()?

> `optional` **changeCallback**: (`e`) => `void`

Only called when a change/drop event occurs, but files can't be determined

#### Parameters

##### e

`Event`

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:33](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L33)

***

### dropZone?

> `optional` **dropZone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

An optional list of dropzones.

#### Defined in

[src/base/uploader.ts:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L17)

***

### errorHandler()?

> `optional` **errorHandler**: (`data`) => `void`

Error handler, if not specified Uploader.errorHandler is used

#### Parameters

##### data

[`UploaderErrorData`](UploaderErrorData.md)

#### Returns

`void`

#### Defined in

[src/base/uploader.ts:35](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L35)

***

### ignoreType?

> `optional` **ignoreType**: `boolean`

Ignore file types, e.g. don't check accept property of input or this options

#### Defined in

[src/base/uploader.ts:37](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L37)

***

### input?

> `optional` **input**: `HTMLInputElement`

Target input. If null, dropZone should be specified.

#### Defined in

[src/base/uploader.ts:39](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L39)

***

### multiple?

> `optional` **multiple**: `boolean`

Allow multiple files. If not specified is read from the input

#### Defined in

[src/base/uploader.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L41)

***

### name?

> `optional` **name**: `string`

The field name to use in FormData object. Default is files[]

#### Defined in

[src/base/uploader.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L43)
