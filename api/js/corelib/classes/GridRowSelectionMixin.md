[@serenity-is/corelib](../README.md) / GridRowSelectionMixin

# Class: GridRowSelectionMixin

## Table of contents

### Constructors

- [constructor](GridRowSelectionMixin.md#constructor)

### Methods

- [clear](GridRowSelectionMixin.md#clear)
- [getSelectedAsInt32](GridRowSelectionMixin.md#getselectedasint32)
- [getSelectedAsInt64](GridRowSelectionMixin.md#getselectedasint64)
- [getSelectedKeys](GridRowSelectionMixin.md#getselectedkeys)
- [resetCheckedAndRefresh](GridRowSelectionMixin.md#resetcheckedandrefresh)
- [selectKeys](GridRowSelectionMixin.md#selectkeys)
- [setSelectedKeys](GridRowSelectionMixin.md#setselectedkeys)
- [updateSelectAll](GridRowSelectionMixin.md#updateselectall)
- [createSelectColumn](GridRowSelectionMixin.md#createselectcolumn)

## Constructors

### constructor

• **new GridRowSelectionMixin**(`grid`, `options?`): [`GridRowSelectionMixin`](GridRowSelectionMixin.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | [`IDataGrid`](../interfaces/IDataGrid.md) |
| `options?` | [`GridRowSelectionMixinOptions`](../interfaces/GridRowSelectionMixinOptions.md) |

#### Returns

[`GridRowSelectionMixin`](GridRowSelectionMixin.md)

#### Defined in

[src/ui/helpers/slickhelpers.ts:26](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L26)

## Methods

### clear

▸ **clear**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L93)

___

### getSelectedAsInt32

▸ **getSelectedAsInt32**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L116)

___

### getSelectedAsInt64

▸ **getSelectedAsInt64**(): `number`[]

#### Returns

`number`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L122)

___

### getSelectedKeys

▸ **getSelectedKeys**(): `string`[]

#### Returns

`string`[]

#### Defined in

[src/ui/helpers/slickhelpers.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L112)

___

### resetCheckedAndRefresh

▸ **resetCheckedAndRefresh**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L98)

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

[src/ui/helpers/slickhelpers.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L104)

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

[src/ui/helpers/slickhelpers.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L128)

___

### updateSelectAll

▸ **updateSelectAll**(): `void`

#### Returns

`void`

#### Defined in

[src/ui/helpers/slickhelpers.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L80)

___

### createSelectColumn

▸ **createSelectColumn**(`getMixin`): `Column`\<`any`\>

#### Parameters

| Name | Type |
| :------ | :------ |
| `getMixin` | () => [`GridRowSelectionMixin`](GridRowSelectionMixin.md) |

#### Returns

`Column`\<`any`\>

#### Defined in

[src/ui/helpers/slickhelpers.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/helpers/slickhelpers.ts#L143)
