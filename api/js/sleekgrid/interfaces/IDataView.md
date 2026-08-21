[@serenity-is/sleekgrid](../README.md) / IDataView

# Interface: IDataView\<TItem\>

Defined in: [src/core/idataview.ts:10](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L10)

Minimal data-view contract consumed by the grid. Implemented by `DataView`.

## Type Parameters

### TItem

`TItem` = `any`

Row item type.

## Properties

### onDataChanged?

> `readonly` `optional` **onDataChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ \}\>

Defined in: [src/core/idataview.ts:34](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L34)

Event fired when the underlying data set changes.

***

### onRowCountChanged?

> `readonly` `optional` **onRowCountChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ `current`: `number`; `previous`: `number`; \}\>

Defined in: [src/core/idataview.ts:39](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L39)

Event fired when the row count changes.
Payload is `{ previous, current }` with the counts before and after the change.

***

### onRowsChanged?

> `readonly` `optional` **onRowsChanged**: [`EventEmitter`](../classes/EventEmitter.md)\<\{ `rows`: `number`[]; \}\>

Defined in: [src/core/idataview.ts:44](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L44)

Event fired when specific view rows change (values or metadata).
Payload is `{ rows }` with the list of affected view indices.

## Methods

### getGrandTotals()

> **getGrandTotals**(): [`IGroupTotals`](IGroupTotals.md)

Defined in: [src/core/idataview.ts:15](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L15)

Gets grand totals aggregated over the entire data set.

#### Returns

[`IGroupTotals`](IGroupTotals.md)

Grand totals object containing `sum`/`avg`/`min`/`max`, if any.

***

### getItem()

> **getItem**(`row`): `TItem` \| [`IGroupTotals`](IGroupTotals.md)\<`any`\> \| [`Group`](../classes/Group.md)\<`TItem`\>

Defined in: [src/core/idataview.ts:26](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L26)

Gets the item at the specified view row.

#### Parameters

##### row

`number`

Zero-based view index.

#### Returns

`TItem` \| [`IGroupTotals`](IGroupTotals.md)\<`any`\> \| [`Group`](../classes/Group.md)\<`TItem`\>

Data item, `Group` header, or `IGroupTotals` row.

***

### getItemMetadata()?

> `optional` **getItemMetadata**(`row`): [`ItemMetadata`](ItemMetadata.md)\<`TItem`\>

Defined in: [src/core/idataview.ts:32](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L32)

Gets row metadata (CSS classes, per-column overrides) for the specified view row.

#### Parameters

##### row

`number`

Zero-based view index.

#### Returns

[`ItemMetadata`](ItemMetadata.md)\<`TItem`\>

Metadata object or `undefined` when none applies.

***

### getLength()

> **getLength**(): `number`

Defined in: [src/core/idataview.ts:20](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/idataview.ts#L20)

Gets the total number of rows currently in the view (including group headers/totals).

#### Returns

`number`

Row count.
