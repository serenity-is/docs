[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](corelib.md) / UploadHelper

# Namespace: UploadHelper

[corelib](corelib.md).UploadHelper

## Table of contents

### Functions

- [addUploadInput](corelib.UploadHelper.md#adduploadinput)
- [checkImageConstraints](corelib.UploadHelper.md#checkimageconstraints)
- [colorBox](corelib.UploadHelper.md#colorbox)
- [dbFileUrl](corelib.UploadHelper.md#dbfileurl)
- [fileNameSizeDisplay](corelib.UploadHelper.md#filenamesizedisplay)
- [fileSizeDisplay](corelib.UploadHelper.md#filesizedisplay)
- [hasImageExtension](corelib.UploadHelper.md#hasimageextension)
- [populateFileSymbols](corelib.UploadHelper.md#populatefilesymbols)
- [thumbFileName](corelib.UploadHelper.md#thumbfilename)

## Functions

### addUploadInput

▸ **addUploadInput**(`options`): `JQuery`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`UploadInputOptions`](../interfaces/corelib.UploadInputOptions.md) |

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
| `file` | [`UploadResponse`](../interfaces/corelib.UploadResponse.md) |
| `opt` | [`FileUploadConstraints`](../interfaces/corelib.FileUploadConstraints.md) |

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
| `items` | [`UploadedFile`](../interfaces/corelib.UploadedFile.md)[] |
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
