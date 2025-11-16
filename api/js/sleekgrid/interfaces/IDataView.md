[serenity-is/sleekgrid](../README.md) / IDataView

# Interface: IDataView\<TItem\>

Defined in: [src/core/idataview.ts:6](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L6)

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### onDataChanged?

> `readonly` `optional` **onDataChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ \}\>

Defined in: [src/core/idataview.ts:16](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L16)

Event fired when the underlying data changes

***

### onRowCountChanged?

> `readonly` `optional` **onRowCountChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ `current`: `number`; `previous`: `number`; \}\>

Defined in: [src/core/idataview.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L18)

Event fired when the row count changes

***

### onRowsChanged?

> `readonly` `optional` **onRowsChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ `rows`: `number`[]; \}\>

Defined in: [src/core/idataview.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L20)

Event fired when specific rows change

## Methods

### getGrandTotals()

> **getGrandTotals**(): [`IGroupTotals`](IGroupTotals.md)

Defined in: [src/core/idataview.ts:8](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L8)

Gets the grand totals for all aggregated data.

#### Returns

[`IGroupTotals`](IGroupTotals.md)

***

### getItem()

> **getItem**(`row`): `TItem` \| [`IGroupTotals`](IGroupTotals.md)\<`any`\> \| [`Group`](../classes/Group.md)\<`TItem`\>

Defined in: [src/core/idataview.ts:12](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L12)

Gets the item at the specified row index.

#### Parameters

##### row

`number`

#### Returns

`TItem` \| [`IGroupTotals`](IGroupTotals.md)\<`any`\> \| [`Group`](../classes/Group.md)\<`TItem`\>

***

### getItemMetadata()?

> `optional` **getItemMetadata**(`row`): [`ItemMetadata`](ItemMetadata.md)\<`TItem`\>

Defined in: [src/core/idataview.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L14)

Gets metadata for the item at the specified row index.

#### Parameters

##### row

`number`

#### Returns

[`ItemMetadata`](ItemMetadata.md)\<`TItem`\>

***

### getLength()

> **getLength**(): `number`

Defined in: [src/core/idataview.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L10)

Gets the total number of rows in the view.

#### Returns

`number`
