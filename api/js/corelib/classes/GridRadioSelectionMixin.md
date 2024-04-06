[@serenity-is/corelib](../README.md) / GridRadioSelectionMixin

# Class: GridRadioSelectionMixin

## Table of contents

### Constructors

- [constructor](GridRadioSelectionMixin.md#constructor)

### Methods

- [clear](GridRadioSelectionMixin.md#clear)
- [getSelectedAsInt32](GridRadioSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](GridRadioSelectionMixin.md#getselectedasint64)
- [getSelectedKey](GridRadioSelectionMixin.md#getselectedkey)
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
