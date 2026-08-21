[@serenity-is/corelib](../README.md) / UploadResponse

# Interface: UploadResponse

Defined in: [src/ui/helpers/uploadhelper.tsx:359](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L359)

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

Defined in: [src/ui/helpers/uploadhelper.tsx:379](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L379)

The image height.

***

### IsImage

> **IsImage**: `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:371](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L371)

Whether the file is an image.

***

### Size

> **Size**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L367)

The file size in bytes.

***

### TemporaryFile

> **TemporaryFile**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:363](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L363)

The temporary file name.

***

### Width

> **Width**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:375](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L375)

The image width.
