[@serenity-is/corelib](../README.md) / TreeGridMixinOptions

# Interface: TreeGridMixinOptions\<TItem\>

## Type parameters

| Name |
| :------ |
| `TItem` |

## Table of contents

### Properties

- [getParentId](TreeGridMixinOptions.md#getparentid)
- [grid](TreeGridMixinOptions.md#grid)
- [initialCollapse](TreeGridMixinOptions.md#initialcollapse)
- [toggleField](TreeGridMixinOptions.md#togglefield)

## Properties

### getParentId

• **getParentId**: (`item`: `TItem`) => `any`

#### Type declaration

▸ (`item`): `any`

##### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TItem` |

##### Returns

`any`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L119)

___

### grid

• **grid**: [`DataGrid`](../classes/DataGrid.md)\<`TItem`, `any`\>

#### Defined in

[src/ui/datagrid/treegridmixin.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L117)

___

### initialCollapse

• `Optional` **initialCollapse**: () => `boolean`

#### Type declaration

▸ (): `boolean`

##### Returns

`boolean`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L123)

___

### toggleField

• **toggleField**: `string`

#### Defined in

[src/ui/datagrid/treegridmixin.ts:121](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L121)
