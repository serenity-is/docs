[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / UploadHelper

# Namespace: UploadHelper

## Table of contents

### Functions

- [addUploadInput](UploadHelper.md#adduploadinput)
- [checkImageConstraints](UploadHelper.md#checkimageconstraints)
- [colorBox](UploadHelper.md#colorbox)
- [dbFileUrl](UploadHelper.md#dbfileurl)
- [fileNameSizeDisplay](UploadHelper.md#filenamesizedisplay)
- [fileSizeDisplay](UploadHelper.md#filesizedisplay)
- [hasImageExtension](UploadHelper.md#hasimageextension)
- [populateFileSymbols](UploadHelper.md#populatefilesymbols)
- [thumbFileName](UploadHelper.md#thumbfilename)

## Functions

### addUploadInput

▸ **addUploadInput**(`options`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`UploadInputOptions`](../interfaces/UploadInputOptions.md) |

#### Returns

`JQuery`

#### Defined in

[src/ui/helpers/uploadhelper.ts:5](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L5)

___

### checkImageConstraints

▸ **checkImageConstraints**(`file`, `opt`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `file` | [`UploadResponse`](../interfaces/UploadResponse.md) |
| `opt` | [`FileUploadConstraints`](../interfaces/FileUploadConstraints.md) |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/uploadhelper.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L99)

___

### colorBox

▸ **colorBox**(`link`, `options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `JQuery` |
| `options` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/uploadhelper.ts:183](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L183)

___

### dbFileUrl

▸ **dbFileUrl**(`filename`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filename` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/uploadhelper.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L178)

___

### fileNameSizeDisplay

▸ **fileNameSizeDisplay**(`name`, `bytes`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `name` | `string` |
| `bytes` | `number` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/uploadhelper.ts:138](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L138)

___

### fileSizeDisplay

▸ **fileSizeDisplay**(`bytes`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `bytes` | `number` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/uploadhelper.ts:142](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L142)

___

### hasImageExtension

▸ **hasImageExtension**(`filename`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filename` | `string` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/uploadhelper.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L160)

___

### populateFileSymbols

▸ **populateFileSymbols**(`container`, `items`, `displayOriginalName?`, `urlPrefix?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `container` | `JQuery` |
| `items` | [`UploadedFile`](../interfaces/UploadedFile.md)[] |
| `displayOriginalName?` | `boolean` |
| `urlPrefix?` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/uploadhelper.ts:192](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L192)

___

### thumbFileName

▸ **thumbFileName**(`filename`): `string`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filename` | `string` |

#### Returns

`string`

#### Defined in

[src/ui/helpers/uploadhelper.ts:169](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L169)
