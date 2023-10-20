[@serenity-is/corelib](../README.md) / [Exports](../modules.md) / GridRadioSelectionMixin

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

• **new GridRadioSelectionMixin**(`grid`, `options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `options?` | [`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md) |

#### Defined in

[src/ui/helpers/slickhelpers.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L176)

## Properties

### grid

• `Private` **grid**: [`IDataGrid`](../interfaces/IDataGrid.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L173)

___

### idField

• `Private` **idField**: `string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:171](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L171)

___

### include

• `Private` **include**: `Object`

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L172)

___

### options

• `Private` **options**: [`GridRadioSelectionMixinOptions`](../interfaces/GridRadioSelectionMixinOptions.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L174)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:215](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L215)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L233)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`

#### Returns

`number`

#### Defined in

[src/ui/helpers/slickhelpers.ts:245](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L245)

___

### getSelectedKey

▸ **getSelectedKey**(): `string`

#### Returns

`string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L224)

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

[src/ui/helpers/slickhelpers.ts:209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L209)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:219](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L219)

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

[src/ui/helpers/slickhelpers.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L257)

___

### createSelectColumn

▸ `Static` **createSelectColumn**(`getMixin`): `Column`<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRadioSelectionMixin`](GridRadioSelectionMixin.md) |

#### Returns

`Column`<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L262)
