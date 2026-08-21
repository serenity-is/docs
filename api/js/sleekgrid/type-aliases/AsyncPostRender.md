[@serenity-is/sleekgrid](../README.md) / AsyncPostRender

# Type Alias: AsyncPostRender()\<TItem\>

> **AsyncPostRender**\<`TItem`\> = (`cellNode`, `row`, `item`, `column`, `reRender`) => `void`

Defined in: [src/core/formatting.ts:152](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L152)

Callback invoked asynchronously after a cell node has been rendered and attached.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Parameters

### cellNode

`HTMLElement`

Rendered cell DOM node.

### row

`number`

Row index.

### item

`TItem`

Row data item.

### column

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column definition.

### reRender

`boolean`

Whether the call is due to a re-render of an already visible row.

## Returns

`void`
