[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib](../modules/corelib.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

[corelib](../modules/corelib.md).GridRadioSelectionMixin

## Table of contents

### Constructors

- [constructor](corelib.GridRadioSelectionMixin.md#constructor)

### Properties

- [grid](corelib.GridRadioSelectionMixin.md#grid)
- [idField](corelib.GridRadioSelectionMixin.md#idfield)
- [include](corelib.GridRadioSelectionMixin.md#include)
- [options](corelib.GridRadioSelectionMixin.md#options)

### Methods

- [clear](corelib.GridRadioSelectionMixin.md#clear)
- [getSelectedAsInt32](corelib.GridRadioSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](corelib.GridRadioSelectionMixin.md#getselectedasint64)
- [getSelectedKey](corelib.GridRadioSelectionMixin.md#getselectedkey)
- [isSelectable](corelib.GridRadioSelectionMixin.md#isselectable)
- [resetCheckedAndRefresh](corelib.GridRadioSelectionMixin.md#resetcheckedandrefresh)
- [setSelectedKey](corelib.GridRadioSelectionMixin.md#setselectedkey)
- [createSelectColumn](corelib.GridRadioSelectionMixin.md#createselectcolumn)

## Constructors

### constructor

• **new GridRadioSelectionMixin**(`grid`, `options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/corelib.IDataGrid.md) |
| `options?` | [`GridRadioSelectionMixinOptions`](../interfaces/corelib.GridRadioSelectionMixinOptions.md) |

#### Defined in

[src/ui/helpers/slickhelpers.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;176)

## Properties

### grid

• `Private` **grid**: [`IDataGrid`](../interfaces/corelib.IDataGrid.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;173)

___

### idField

• `Private` **idField**: `string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;171)

___

### include

• `Private` **include**: `Object`

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;172)

___

### options

• `Private` **options**: [`GridRadioSelectionMixinOptions`](../interfaces/corelib.GridRadioSelectionMixinOptions.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;174)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;215)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;233)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;245)

___

### getSelectedKey

▸ **getSelectedKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;224)

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

[src/ui/helpers/slickhelpers.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;209)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;219)

___

### setSelectedKey

▸ **setSelectedKey**(`key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `key` | `string` |

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;257)

___

### createSelectColumn

▸ `Static` **createSelectColumn**(`getMixin`): `Column`<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRadioSelectionMixin`](corelib.GridRadioSelectionMixin.md) |

#### Returns

`Column`<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#line&#x3D;262)
