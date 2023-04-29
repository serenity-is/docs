[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

[corelib](../modules/corelib.md).GridRowSelectionMixin

## Table of contents

### Constructors

- [constructor](corelib.GridRowSelectionMixin.md#constructor)

### Properties

- [grid](corelib.GridRowSelectionMixin.md#grid)
- [idField](corelib.GridRowSelectionMixin.md#idfield)
- [include](corelib.GridRowSelectionMixin.md#include)
- [options](corelib.GridRowSelectionMixin.md#options)

### Methods

- [clear](corelib.GridRowSelectionMixin.md#clear)
- [getSelectedAsInt32](corelib.GridRowSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](corelib.GridRowSelectionMixin.md#getselectedasint64)
- [getSelectedKeys](corelib.GridRowSelectionMixin.md#getselectedkeys)
- [isSelectable](corelib.GridRowSelectionMixin.md#isselectable)
- [resetCheckedAndRefresh](corelib.GridRowSelectionMixin.md#resetcheckedandrefresh)
- [selectKeys](corelib.GridRowSelectionMixin.md#selectkeys)
- [setSelectedKeys](corelib.GridRowSelectionMixin.md#setselectedkeys)
- [updateSelectAll](corelib.GridRowSelectionMixin.md#updateselectall)
- [createSelectColumn](corelib.GridRowSelectionMixin.md#createselectcolumn)

## Constructors

### constructor

• **new GridRowSelectionMixin**(`grid`, `options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/corelib.IDataGrid.md) |
| `options?` | [`GridRowSelectionMixinOptions`](../interfaces/corelib.GridRowSelectionMixinOptions.md) |

#### Defined in

[src/ui/helpers/slickhelpers.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;24)

## Properties

### grid

• `Private` **grid**: [`IDataGrid`](../interfaces/corelib.IDataGrid.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;21)

___

### idField

• `Private` **idField**: `string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;19)

___

### include

• `Private` **include**: `Object`

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;20)

___

### options

• `Private` **options**: [`GridRowSelectionMixinOptions`](../interfaces/corelib.GridRowSelectionMixinOptions.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;22)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;91)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;114)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;120)

___

### getSelectedKeys

▸ **getSelectedKeys**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;110)

___

### isSelectable

▸ `Private` **isSelectable**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;135)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;96)

___

### selectKeys

▸ **selectKeys**(`keys`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `keys` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;102)

___

### setSelectedKeys

▸ **setSelectedKeys**(`keys`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `keys` | `string`[] |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;126)

___

### updateSelectAll

▸ **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;78)

___

### createSelectColumn

▸ `Static` **createSelectColumn**(`getMixin`): `Column`<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRowSelectionMixin`](corelib.GridRowSelectionMixin.md) |

#### Returns

`Column`<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;141)
