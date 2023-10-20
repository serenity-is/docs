[@serenity-is/corelib](../README.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

## Table of contents

### Constructors

- [constructor](GridRowSelectionMixin.md#constructor)

### Properties

- [grid](GridRowSelectionMixin.md#grid)
- [idField](GridRowSelectionMixin.md#idfield)
- [include](GridRowSelectionMixin.md#include)
- [options](GridRowSelectionMixin.md#options)

### Methods

- [clear](GridRowSelectionMixin.md#clear)
- [getSelectedAsInt32](GridRowSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](GridRowSelectionMixin.md#getselectedasint64)
- [getSelectedKeys](GridRowSelectionMixin.md#getselectedkeys)
- [isSelectable](GridRowSelectionMixin.md#isselectable)
- [resetCheckedAndRefresh](GridRowSelectionMixin.md#resetcheckedandrefresh)
- [selectKeys](GridRowSelectionMixin.md#selectkeys)
- [setSelectedKeys](GridRowSelectionMixin.md#setselectedkeys)
- [updateSelectAll](GridRowSelectionMixin.md#updateselectall)
- [createSelectColumn](GridRowSelectionMixin.md#createselectcolumn)

## Constructors

### constructor

• **new GridRowSelectionMixin**(`grid`, `options?`)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `options?` | [`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md) |

#### Defined in

[src/ui/helpers/slickhelpers.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L24)

## Properties

### grid

• `Private` **grid**: [`IDataGrid`](../interfaces/IDataGrid.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:21](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L21)

___

### idField

• `Private` **idField**: `string`

#### Defined in

[src/ui/helpers/slickhelpers.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L19)

___

### include

• `Private` **include**: `Object`

#### Index signature

▪ [key: `string`]: `boolean`

#### Defined in

[src/ui/helpers/slickhelpers.ts:20](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L20)

___

### options

• `Private` **options**: [`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:22](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L22)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L91)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L114)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L120)

___

### getSelectedKeys

▸ **getSelectedKeys**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L110)

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

[src/ui/helpers/slickhelpers.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L135)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L96)

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

[src/ui/helpers/slickhelpers.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L102)

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

[src/ui/helpers/slickhelpers.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L126)

___

### updateSelectAll

▸ **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L78)

___

### createSelectColumn

▸ `Static` **createSelectColumn**(`getMixin`): `Column`<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRowSelectionMixin`](GridRowSelectionMixin.md) |

#### Returns

`Column`<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L141)
