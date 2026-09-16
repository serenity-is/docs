[@serenity-is/corelib](../README.md) / FileUploadEditorOptions

# Interface: FileUploadEditorOptions

Defined in: [src/ui/editors/uploadeditors.tsx:11](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L11)

Options for the [FileUploadEditor](../classes/FileUploadEditor.md).

## Extends

- [`FileUploadConstraints`](FileUploadConstraints.md)

## Extended by

- [`ImageUploadEditorOptions`](ImageUploadEditorOptions.md)
- [`MultipleFileUploadEditorOptions`](MultipleFileUploadEditorOptions.md)

## Properties

### allowNonImage?

> `optional` **allowNonImage**: `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:412](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L412)

Whether non-image files are allowed.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`allowNonImage`](FileUploadConstraints.md#allownonimage)

***

### displayFileName?

> `optional` **displayFileName**: `boolean`

Defined in: [src/ui/editors/uploadeditors.tsx:13](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L13)

Whether to display the original file name.

***

### maxHeight?

> `optional` **maxHeight**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L400)

The maximum image height.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`maxHeight`](FileUploadConstraints.md#maxheight)

***

### maxSize?

> `optional` **maxSize**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:408](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L408)

The maximum file size in bytes.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`maxSize`](FileUploadConstraints.md#maxsize)

***

### maxWidth?

> `optional` **maxWidth**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:392](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L392)

The maximum image width.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`maxWidth`](FileUploadConstraints.md#maxwidth)

***

### minHeight?

> `optional` **minHeight**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:396](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L396)

The minimum image height.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`minHeight`](FileUploadConstraints.md#minheight)

***

### minSize?

> `optional` **minSize**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L404)

The minimum file size in bytes.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`minSize`](FileUploadConstraints.md#minsize)

***

### minWidth?

> `optional` **minWidth**: `number`

Defined in: [src/ui/helpers/uploadhelper.tsx:388](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L388)

The minimum image width.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`minWidth`](FileUploadConstraints.md#minwidth)

***

### originalNameProperty?

> `optional` **originalNameProperty**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:416](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L416)

The name of the property holding the original file name.

#### Inherited from

[`FileUploadConstraints`](FileUploadConstraints.md).[`originalNameProperty`](FileUploadConstraints.md#originalnameproperty)

***

### uploadIntent?

> `optional` **uploadIntent**: `string`

Defined in: [src/ui/editors/uploadeditors.tsx:15](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L15)

Upload intent for the upload service.

***

### uploadUrl?

> `optional` **uploadUrl**: `string`

Defined in: [src/ui/editors/uploadeditors.tsx:17](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L17)

Upload URL.

***

### urlPrefix?

> `optional` **urlPrefix**: `string`

Defined in: [src/ui/editors/uploadeditors.tsx:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/uploadeditors.tsx#L19)

URL prefix for file links.
