[@serenity-is/corelib](../README.md) / UploaderBatch

# Interface: UploaderBatch

Defined in: [src/base/uploader.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L64)

Represents a single upload batch queued by [Uploader](../classes/Uploader.md).

## Properties

### event?

> `optional` **event**: `Event`

Defined in: [src/base/uploader.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L66)

Originating DOM event (change / drop / paste).

***

### filePaths?

> `optional` **filePaths**: `string`[]

Defined in: [src/base/uploader.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L68)

Relative paths / names of files in this batch.

***

### formData

> **formData**: `FormData`

Defined in: [src/base/uploader.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L70)

`FormData` payload containing the batched files.

***

### isFirst?

> `optional` **isFirst**: `boolean`

Defined in: [src/base/uploader.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/uploader.ts#L72)

`true` for the first batch in a multi-batch sequence.
