[@serenity-is/corelib](../README.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

## Table of contents

### Constructors

- [constructor](GridRadioSelectionMixin.md#constructor)

### Properties

- [grid](GridRadioSelectionMixin.md#grid)
- [idField](GridRadioSelectionMixin.md#idfield)
- [include](GridRadioSelectionMixin.md#include)
- [options](GridRadioSelectionMixin.md#options)

### Methods

- [clear](GridRadioSelectionMixin.md#clear)
- [getSelectedAsInt32](GridRadioSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](GridRadioSelectionMixin.md#getselectedasint64)
- [getSelectedKey](GridRadioSelectionMixin.md#getselectedkey)
- [isSelectable](GridRadioSelectionMixin.md#isselectable)
- [resetCheckedAndRefresh](GridRadioSelectionMixin.md#resetcheckedandrefresh)
- [setSelectedKey](GridRadioSelectionMixin.md#setselectedkey)
- [createSelectColumn](GridRadioSelectionMixin.md#createselectcolumn)

## Constructors

### constructor

• **new GridRadioSelectionMixin**(`grid`, `options?`): [`GridRadioSelectionMixin`](GridRadioSelectionMixin.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `options?` | [`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md) |

#### Returns

[`GridRadioSelectionMixin`](GridRadioSelectionMixin.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L178)

## Properties

### grid

• `Private` **grid**: [`IDataGrid`](../interfaces/IDataGrid.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:175](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L175)

___

### idField

• `Private` **idField**: `string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L173)

___

### include

• `Private` **include**: `Object`

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L174)

___

### options

• `Private` **options**: [`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L176)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L217)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:235](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L235)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:247](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L247)

___

### getSelectedKey

▸ **getSelectedKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L226)

___

### isSelectable

▸ **isSelectable**(`item`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:211](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L211)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L221)

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

[src/ui/helpers/slickhelpers.ts:259](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L259)

___

### createSelectColumn

▸ **createSelectColumn**(`getMixin`): `Column`\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRadioSelectionMixin`](GridRadioSelectionMixin.md) |

#### Returns

`Column`\<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:264](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L264)
