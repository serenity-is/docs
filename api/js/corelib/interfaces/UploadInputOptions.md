[@serenity-is/corelib](../README.md) / UploadInputOptions

# Interface: UploadInputOptions

Defined in: [src/ui/helpers/uploadhelper.tsx:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L321)

Options for creating an upload input.

## Properties

### allowMultiple?

> `optional` **allowMultiple**: `boolean`

Defined in: [src/ui/helpers/uploadhelper.tsx:341](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L341)

Whether multiple files may be selected.

***

### container?

> `optional` **container**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L325)

The container element to add the input to.

***

### fileDone()?

> `optional` **fileDone**: (`p1`, `p2`, `p3`) => `void`

Defined in: [src/ui/helpers/uploadhelper.tsx:353](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L353)

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

Defined in: [src/ui/helpers/uploadhelper.tsx:337](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L337)

The name of the input element.

***

### progress?

> `optional` **progress**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:333](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L333)

The progress element.

***

### uploadIntent?

> `optional` **uploadIntent**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:345](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L345)

An optional upload intent appended to the upload URL.

***

### uploadUrl?

> `optional` **uploadUrl**: `string`

Defined in: [src/ui/helpers/uploadhelper.tsx:349](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L349)

The upload URL. Defaults to the temporary upload endpoint.

***

### zone?

> `optional` **zone**: `HTMLElement` \| `ArrayLike`\<`HTMLElement`\>

Defined in: [src/ui/helpers/uploadhelper.tsx:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L329)

The drop zone element.
