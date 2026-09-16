[@serenity-is/corelib](../README.md) / UploadInputOptions

# Interface: UploadInputOptions

Defined in: [src/ui/helpers/uploadhelper.tsx:320](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L320)

Options for creating an upload input.

## Properties

### allowMultiple?

> `optional` **allowMultiple**: `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:340](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L340)

Whether multiple files may be selected.

***

### container?

> `optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L324)

The container element to add the input to.

***

### fileDone()?

> `optional` **fileDone**: (`p1`, `p2`, `p3`) => `void`

Defined in: [src/ui/helpers/uploadhelper.tsx:352](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L352)

Callback invoked when a file upload completes.

#### Parameters

##### p1

[`UploadResponse`](UploadResponse.md)

##### p2

`string`

##### p3

`any`

#### Returns

`void`

***

### inputName?

> `optional` **inputName**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:336](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L336)

The name of the input element.

***

### progress?

> `optional` **progress**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L332)

The progress element.

***

### uploadIntent?

> `optional` **uploadIntent**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L344)

An optional upload intent appended to the upload URL.

***

### uploadUrl?

> `optional` **uploadUrl**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:348](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L348)

The upload URL. Defaults to the temporary upload endpoint.

***

### zone?

> `optional` **zone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L328)

The drop zone element.
