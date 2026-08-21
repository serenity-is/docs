[@serenity-is/corelib](../README.md) / TreeGridMixinOptions

# Interface: TreeGridMixinOptions\<TItem\>

Defined in: [src/ui/datagrid/treegridmixin.ts:125](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L125)

Options for [TreeGridMixin](../classes/TreeGridMixin.md).

## Type Parameters

### TItem

`TItem`

Row type displayed in the grid.

## Properties

### getParentId()

> **getParentId**: (`item`) => `any`

Defined in: [src/ui/datagrid/treegridmixin.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L129)

Callback that returns the parent identifier for a row.

#### Parameters

##### item

`TItem`

#### Returns

`any`

***

### grid

> **grid**: [`DataGrid`](../classes/DataGrid.md)\<`TItem`, `any`\>

Defined in: [src/ui/datagrid/treegridmixin.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L127)

Target data grid to enhance with tree behaviour.

***

### initialCollapse()?

> `optional` **initialCollapse**: () => `boolean`

Defined in: [src/ui/datagrid/treegridmixin.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L133)

Optional callback that controls whether rows start collapsed.

#### Returns

`boolean`

***

### toggleField

> **toggleField**: `string`

Defined in: [src/ui/datagrid/treegridmixin.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/datagrid/treegridmixin.ts#L131)

Field / column id where the expand/collapse toggle is rendered.
