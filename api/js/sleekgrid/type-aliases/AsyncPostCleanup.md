[@serenity-is/sleekgrid](../README.md) / AsyncPostCleanup

# Type Alias: AsyncPostCleanup()\<TItem\>

> **AsyncPostCleanup**\<`TItem`\> = (`cellNode`, `row?`, `column?`) => `void`

Defined in: [src/core/formatting.ts:161](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/formatting.ts#L161)

Cleanup counterpart to [AsyncPostRender](AsyncPostRender.md); invoked before the cell node is removed.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Parameters

### cellNode

`HTMLElement`

Cell DOM node being cleaned up.

### row?

`number`

Row index, if known.

### column?

[`Column`](../interfaces/Column.md)\<`TItem`\>

Column definition, if known.

## Returns

`void`
