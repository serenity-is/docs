[@serenity-is/corelib](../../../../README.md) / [UploadHelper](../README.md) / populateFileSymbols

# Function: populateFileSymbols()

> **populateFileSymbols**(`c`, `items`, `displayOriginalName?`, `urlPrefix?`): `void`

Defined in: [src/ui/helpers/uploadhelper.tsx:265](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.tsx#L265)

Populates a container with file item elements for the given uploaded files.

## Parameters

### c

The container element (or array-like of elements) to populate.

`HTMLElement` | `ArrayLike`\<`HTMLElement`\>

### items

[`UploadedFile`](../../../../interfaces/UploadedFile.md)[]

The uploaded files to display.

### displayOriginalName?

`boolean`

Whether to display the original file names.

### urlPrefix?

`string`

Optional URL prefix prepended to file names.

## Returns

`void`
