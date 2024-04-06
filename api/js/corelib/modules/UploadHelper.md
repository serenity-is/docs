[@serenity-is/corelib](../README.md) / UploadHelper

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

▸ **addUploadInput**(`options`): [`Fluent`](../interfaces/Fluent.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`UploadInputOptions`](../interfaces/UploadInputOptions.md) |

#### Returns

[`Fluent`](../interfaces/Fluent.md)

#### Defined in

[src/ui/helpers/uploadhelper.ts:6](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L6)

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

[src/ui/helpers/uploadhelper.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L63)

___

### colorBox

▸ **colorBox**(`link`, `options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `link` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `options` | `any` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/uploadhelper.ts:148](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L148)

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

[src/ui/helpers/uploadhelper.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L143)

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

[src/ui/helpers/uploadhelper.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L102)

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

[src/ui/helpers/uploadhelper.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L106)

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

[src/ui/helpers/uploadhelper.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L124)

___

### populateFileSymbols

▸ **populateFileSymbols**(`c`, `items`, `displayOriginalName?`, `urlPrefix?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `c` | `HTMLElement` \| `ArrayLike`\<`HTMLElement`\> |
| `items` | [`UploadedFile`](../interfaces/UploadedFile.md)[] |
| `displayOriginalName?` | `boolean` |
| `urlPrefix?` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/uploadhelper.ts:163](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L163)

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

[src/ui/helpers/uploadhelper.ts:134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/uploadhelper.ts#L134)
