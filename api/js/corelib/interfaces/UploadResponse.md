[@serenity-is/corelib](../README.md) / UploadResponse

# Interface: UploadResponse

Defined in: [src/ui/helpers/uploadhelper.tsx:358](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L358)

The response returned by a file upload service.

## Extends

- [`ServiceResponse`](ServiceResponse.md)

## Properties

### Error?

> `optional` **Error**: [`ServiceError`](ServiceError.md)

Defined in: [src/base/servicetypes.ts:25](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/base/servicetypes.ts#L25)

Error information when the request failed; `undefined` on success.

#### Inherited from

[`ServiceResponse`](ServiceResponse.md).[`Error`](ServiceResponse.md#error)

***

### Height

> **Height**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:378](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L378)

The image height.

***

### IsImage

> **IsImage**: `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:370](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L370)

Whether the file is an image.

***

### Size

> **Size**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:366](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L366)

The file size in bytes.

***

### TemporaryFile

> **TemporaryFile**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:362](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L362)

The temporary file name.

***

### Width

> **Width**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:374](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L374)

The image width.
