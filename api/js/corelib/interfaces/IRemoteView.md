[@serenity-is/corelib](../README.md) / IRemoteView

# Interface: IRemoteView\<TItem\>

Defined in: [src/slick/iremoteview.ts:9](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L9)

Interface for an extension of IDataView that support remote data loading

## Extends

- `IDataView`\<`TItem`\>

## Type Parameters

### TItem

`TItem` = `any`

## Properties

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:152](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L152)

Callback invoked before making AJAX calls

***

### onDataChanged

> `readonly` **onDataChanged**: `EventEmitter`\<[`ArgsRemoteView`](ArgsRemoteView.md)\>

Defined in: [src/slick/iremoteview.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L154)

Event fired when the underlying data changes

#### Overrides

`IDataView.onDataChanged`

***

### onDataLoaded

> `readonly` **onDataLoaded**: `EventEmitter`\<[`ArgsRemoteView`](ArgsRemoteView.md)\>

Defined in: [src/slick/iremoteview.ts:156](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L156)

Event fired when data loading completes

***

### onDataLoading

> `readonly` **onDataLoading**: `EventEmitter`\<[`ArgsRemoteView`](ArgsRemoteView.md)\>

Defined in: [src/slick/iremoteview.ts:158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L158)

Event fired when data loading begins

***

### onGroupCollapsed?

> `readonly` `optional` **onGroupCollapsed**: `EventEmitter`\<[`ArgsGroupToggle`](ArgsGroupToggle.md)\>

Defined in: [src/slick/iremoteview.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L160)

Event fired when a group is collapsed

***

### onGroupExpanded?

> `readonly` `optional` **onGroupExpanded**: `EventEmitter`\<[`ArgsGroupToggle`](ArgsGroupToggle.md)\>

Defined in: [src/slick/iremoteview.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L162)

Event fired when a group is expanded

***

### onPagingInfoChanged

> `readonly` **onPagingInfoChanged**: `EventEmitter`\<[`ArgsPagingInfo`](ArgsPagingInfo.md)\>

Defined in: [src/slick/iremoteview.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L164)

Event fired when paging information changes

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L166)

Callback invoked to process data received from the server

***

### onRecalcRows

> `readonly` **onRecalcRows**: `EventEmitter`\<[`ArgsRecalcRows`](ArgsRecalcRows.md)\>

Defined in: [src/slick/iremoteview.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L168)

Event fired when rows need to be recalculated

***

### onRowCountChanged

> `readonly` **onRowCountChanged**: `EventEmitter`\<[`ArgsRowCountChanged`](ArgsRowCountChanged.md)\>

Defined in: [src/slick/iremoteview.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L170)

Event fired when the row count changes

#### Overrides

`IDataView.onRowCountChanged`

***

### onRowsChanged?

> `readonly` `optional` **onRowsChanged**: `EventEmitter`\<\{ `rows`: `number`[]; \}\>

Defined in: [../sleekgrid/dist/index.d.ts:2490](https://github.com/serenity-is/serenity/blob/master/packages/sleekgrid/dist/index.d.ts#L2490)

Event fired when specific view rows change (values or metadata).
Payload is `{ rows }` with the list of affected view indices.

#### Inherited from

`IDataView.onRowsChanged`

***

### onRowsOrCountChanged?

> `readonly` `optional` **onRowsOrCountChanged**: `EventEmitter`\<[`ArgsRowsOrCountChanged`](ArgsRowsOrCountChanged.md)\>

Defined in: [src/slick/iremoteview.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L172)

Event fired when rows or count change

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L174)

Callback invoked before submitting a request, can cancel the operation

***

### params

> **params**: `Record`\<`string`, `any`\>

Defined in: [src/slick/iremoteview.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L176)

Additional parameters to send with service requests

***

### seekToPage

> **seekToPage**: `number`

Defined in: [src/slick/iremoteview.ts:202](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L202)

The page number to seek to when loading data

***

### sortBy

> **sortBy**: `string`[]

Defined in: [src/slick/iremoteview.ts:262](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L262)

Sort expressions for the data

***

### url

> **url**: `string`

Defined in: [src/slick/iremoteview.ts:283](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L283)

The URL to fetch data from

## Methods

### addData()?

> `optional` **addData**(`data`): `boolean`

Defined in: [src/slick/iremoteview.ts:14](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L14)

Adds data received from the server to the view.

#### Parameters

##### data

`any`

The response data from the server

#### Returns

`boolean`

***

### addItem()?

> `optional` **addItem**(`item`): `void`

Defined in: [src/slick/iremoteview.ts:19](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L19)

Adds an item to the end of the items array.

#### Parameters

##### item

`any`

The item to add

#### Returns

`void`

***

### beginUpdate()

> **beginUpdate**(): `void`

Defined in: [src/slick/iremoteview.ts:24](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L24)

Begins a batch update operation. Multiple changes can be made without triggering refreshes.
Call endUpdate() to complete the batch and refresh the view.

#### Returns

`void`

***

### collapseAllGroups()?

> `optional` **collapseAllGroups**(`level?`): `void`

Defined in: [src/slick/iremoteview.ts:29](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L29)

Collapses all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to collapse. If not specified, applies to all levels.

#### Returns

`void`

***

### collapseGroup()?

> `optional` **collapseGroup**(`varArgs`): `void`

Defined in: [src/slick/iremoteview.ts:36](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L36)

Collapses a specific group.

#### Parameters

##### varArgs

`any`[]

Either a Slick.Group's "groupingKey" property, or a
variable argument list of grouping values denoting a unique path to the row.
For example, calling collapseGroup('high', '10%') will collapse the '10%' subgroup of the 'high' group.

#### Returns

`void`

***

### deleteItem()?

> `optional` **deleteItem**(`id`): `void`

Defined in: [src/slick/iremoteview.ts:41](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L41)

Deletes an item by its ID.

#### Parameters

##### id

`any`

The ID of the item to delete

#### Returns

`void`

***

### endUpdate()

> **endUpdate**(): `void`

Defined in: [src/slick/iremoteview.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L46)

Ends a batch update operation. If this is the outermost endUpdate call,
refreshes the view to reflect all changes made during the batch.

#### Returns

`void`

***

### expandAllGroups()?

> `optional` **expandAllGroups**(`level?`): `void`

Defined in: [src/slick/iremoteview.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L51)

Expands all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to expand. If not specified, applies to all levels.

#### Returns

`void`

***

### expandGroup()?

> `optional` **expandGroup**(`varArgs`): `void`

Defined in: [src/slick/iremoteview.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L58)

Expands a specific group.

#### Parameters

##### varArgs

`any`[]

Either a Slick.Group's "groupingKey" property, or a
variable argument list of grouping values denoting a unique path to the row.
For example, calling expandGroup('high', '10%') will expand the '10%' subgroup of the 'high' group.

#### Returns

`void`

***

### getFilter()?

> `optional` **getFilter**(): [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L63)

Gets the current filter function.

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The current filter function

***

### getFilteredItems()

> **getFilteredItems**(): `any`[]

Defined in: [src/slick/iremoteview.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L69)

Gets the filtered items (after applying the current filter).

#### Returns

`any`[]

Array of filtered items

***

### getGrandTotals()

> **getGrandTotals**(): `IGroupTotals`

Defined in: [../sleekgrid/dist/index.d.ts:2458](https://github.com/serenity-is/serenity/blob/master/packages/sleekgrid/dist/index.d.ts#L2458)

Gets grand totals aggregated over the entire data set.

#### Returns

`IGroupTotals`

Grand totals object containing `sum`/`avg`/`min`/`max`, if any.

#### Inherited from

`IDataView.getGrandTotals`

***

### getGrouping()?

> `optional` **getGrouping**(): [`GroupInfo`](GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/iremoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L75)

Gets the current grouping configuration.

#### Returns

[`GroupInfo`](GroupInfo.md)\<`TItem`\>[]

Array of grouping information

***

### getGroupItemMetadataProvider()?

> `optional` **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

Defined in: [src/slick/iremoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L80)

Gets the group item metadata provider.

#### Returns

`GroupItemMetadataProvider`

The metadata provider

***

### getGroups()?

> `optional` **getGroups**(): `Group`\<`TItem`\>[]

Defined in: [src/slick/iremoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L85)

Gets the current groups.

#### Returns

`Group`\<`TItem`\>[]

Array of groups

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

Defined in: [src/slick/iremoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L90)

Gets the name of the property used as the unique identifier for items.

#### Returns

`string`

The ID property name

***

### getIdxById()

> **getIdxById**(`id`): `number`

Defined in: [src/slick/iremoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L96)

Gets the index of an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`number`

The index of the item, or undefined if not found

***

### getItem()

> **getItem**(`row`): `IGroupTotals`\<`any`\> \| `TItem` \| `Group`\<`TItem`\>

Defined in: [../sleekgrid/dist/index.d.ts:2469](https://github.com/serenity-is/serenity/blob/master/packages/sleekgrid/dist/index.d.ts#L2469)

Gets the item at the specified view row.

#### Parameters

##### row

`number`

Zero-based view index.

#### Returns

`IGroupTotals`\<`any`\> \| `TItem` \| `Group`\<`TItem`\>

Data item, `Group` header, or `IGroupTotals` row.

#### Inherited from

`IDataView.getItem`

***

### getItemById()

> **getItemById**(`id`): `TItem`

Defined in: [src/slick/iremoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L102)

Gets an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`TItem`

The item with the specified ID

***

### getItemByIdx()

> **getItemByIdx**(`i`): `any`

Defined in: [src/slick/iremoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L108)

Gets an item by its index in the items array.

#### Parameters

##### i

`number`

The index of the item

#### Returns

`any`

The item at the specified index

***

### getItemMetadata()?

> `optional` **getItemMetadata**(`row`): `ItemMetadata`\<`TItem`\>

Defined in: [../sleekgrid/dist/index.d.ts:2475](https://github.com/serenity-is/serenity/blob/master/packages/sleekgrid/dist/index.d.ts#L2475)

Gets row metadata (CSS classes, per-column overrides) for the specified view row.

#### Parameters

##### row

`number`

Zero-based view index.

#### Returns

`ItemMetadata`\<`TItem`\>

Metadata object or `undefined` when none applies.

#### Inherited from

`IDataView.getItemMetadata`

***

### getItemMetadataCallback()

> **getItemMetadataCallback**(): (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/iremoteview.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L112)

Gets a callback function to retrieve item metadata. This can be used to dynamically assign CSS classes or other properties to items.

#### Returns

> (`item`, `row`): `ItemMetadata`\<`TItem`\>

##### Parameters

###### item

`TItem`

###### row

`number`

##### Returns

`ItemMetadata`\<`TItem`\>

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/slick/iremoteview.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L117)

Gets all items in the view.

#### Returns

`TItem`[]

Array of all items

***

### getLength()

> **getLength**(): `number`

Defined in: [../sleekgrid/dist/index.d.ts:2463](https://github.com/serenity-is/serenity/blob/master/packages/sleekgrid/dist/index.d.ts#L2463)

Gets the total number of rows currently in the view (including group headers/totals).

#### Returns

`number`

Row count.

#### Inherited from

`IDataView.getLength`

***

### getLocalSort()?

> `optional` **getLocalSort**(): `boolean`

Defined in: [src/slick/iremoteview.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L122)

Gets whether local sorting is enabled.

#### Returns

`boolean`

true if local sorting is enabled

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](PagingInfo.md)

Defined in: [src/slick/iremoteview.ts:127](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L127)

Gets the current paging information.

#### Returns

[`PagingInfo`](PagingInfo.md)

Object containing paging state information

***

### getRowById()?

> `optional` **getRowById**(`id`): `number`

Defined in: [src/slick/iremoteview.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L133)

Gets the row index for an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`number`

The row index of the item

***

### getRowByItem()?

> `optional` **getRowByItem**(`item`): `number`

Defined in: [src/slick/iremoteview.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L139)

Gets the row index for an item.

#### Parameters

##### item

`any`

The item to find

#### Returns

`number`

The row index of the item

***

### getRows()

> **getRows**(): (`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Defined in: [src/slick/iremoteview.ts:144](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L144)

Gets all rows in the view (including group rows and totals rows).

#### Returns

(`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Array of all rows

***

### insertItem()?

> `optional` **insertItem**(`insertBefore`, `item`): `void`

Defined in: [src/slick/iremoteview.ts:150](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L150)

Inserts an item at the specified position.

#### Parameters

##### insertBefore

`number`

The index to insert before

##### item

`any`

The item to insert

#### Returns

`void`

***

### populate()

> **populate**(): `boolean`

Defined in: [src/slick/iremoteview.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L181)

Loads data from the server using the configured URL and parameters.

#### Returns

`boolean`

false if the operation was cancelled or no URL is configured

***

### populateLock()

> **populateLock**(): `void`

Defined in: [src/slick/iremoteview.ts:186](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L186)

Locks population to prevent automatic data loading.
Use this when you want to make multiple changes without triggering loads.

#### Returns

`void`

***

### populateUnlock()

> **populateUnlock**(): `void`

Defined in: [src/slick/iremoteview.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L190)

Unlocks population. If there were pending populate calls while locked, executes them.

#### Returns

`void`

***

### refresh()

> **refresh**(): `void`

Defined in: [src/slick/iremoteview.ts:196](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L196)

Refresh the view by recalculating the rows and notifying changes.
Note that this does not re-fetch the data from the server, use populate
method for that purpose.

#### Returns

`void`

***

### reSort()

> **reSort**(): `void`

Defined in: [src/slick/iremoteview.ts:200](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L200)

Re-sorts the items using the current sort settings.

#### Returns

`void`

***

### setFilter()

> **setFilter**(`filterFn`): `void`

Defined in: [src/slick/iremoteview.ts:207](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L207)

Sets the filter function to apply to items.

#### Parameters

##### filterFn

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The filter function to apply

#### Returns

`void`

***

### setGrouping()?

> `optional` **setGrouping**(`groupingInfo`): `void`

Defined in: [src/slick/iremoteview.ts:212](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L212)

Sets the grouping configuration for the view.

#### Parameters

##### groupingInfo

Grouping information or array of grouping information

[`GroupInfo`](GroupInfo.md)\<`TItem`\> | [`GroupInfo`](GroupInfo.md)\<`TItem`\>[]

#### Returns

`void`

***

### setGroupItemMetadataProvider()?

> `optional` **setGroupItemMetadataProvider**(`value`): `void`

Defined in: [src/slick/iremoteview.ts:217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L217)

Sets the group item metadata provider.

#### Parameters

##### value

`GroupItemMetadataProvider`

The metadata provider to set

#### Returns

`void`

***

### setItemMetadataCallback()

> **setItemMetadataCallback**(`value`): `void`

Defined in: [src/slick/iremoteview.ts:228](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L228)

Sets a callback function to retrieve item metadata. This can be used to dynamically assign CSS classes or other properties to items.

#### Parameters

##### value

(`item`, `row`) => `ItemMetadata`\<`TItem`\>

The item metadata callback.

#### Returns

`void`

***

### setItems()

> **setItems**(`data`, `newIdProperty?`): `void`

Defined in: [src/slick/iremoteview.ts:223](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L223)

Sets the items in the view and optionally changes the ID property.

#### Parameters

##### data

`any`[]

Array of items to set

##### newIdProperty?

Optional new ID property name, or boolean to reset

`string` | `boolean`

#### Returns

`void`

***

### setLocalSort()?

> `optional` **setLocalSort**(`value`): `void`

Defined in: [src/slick/iremoteview.ts:233](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L233)

Sets whether to use local sorting. When enabled, sorting is done client-side.

#### Parameters

##### value

`boolean`

Whether to enable local sorting

#### Returns

`void`

***

### setPagingOptions()

> **setPagingOptions**(`args`): `void`

Defined in: [src/slick/iremoteview.ts:238](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L238)

Sets paging options and triggers a data reload if options changed.

#### Parameters

##### args

[`PagingOptions`](PagingOptions.md)

The paging options to set

#### Returns

`void`

***

### setSummaryOptions()?

> `optional` **setSummaryOptions**(`summary`): `void`

Defined in: [src/slick/iremoteview.ts:243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L243)

Sets summary/aggregation options for the view.

#### Parameters

##### summary

[`SummaryOptions`](SummaryOptions.md)

Object containing aggregators and other summary options

#### Returns

`void`

***

### sort()?

> `optional` **sort**(`comparer?`, `ascending?`): `void`

Defined in: [src/slick/iremoteview.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L249)

Sorts the items using the specified comparer function.

#### Parameters

##### comparer?

(`a`, `b`) => `number`

Optional custom comparer function

##### ascending?

`boolean`

Whether to sort in ascending order (default true)

#### Returns

`void`

***

### sortedAddItem()?

> `optional` **sortedAddItem**(`item`): `void`

Defined in: [src/slick/iremoteview.ts:254](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L254)

Adds an item in sorted order.

#### Parameters

##### item

`any`

The item to add

#### Returns

`void`

***

### sortedUpdateItem()?

> `optional` **sortedUpdateItem**(`id`, `item`): `void`

Defined in: [src/slick/iremoteview.ts:260](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L260)

Updates an item while maintaining sorted order.

#### Parameters

##### id

`any`

The ID of the item to update

##### item

`any`

The new item data

#### Returns

`void`

***

### syncGridCellCssStyles()?

> `optional` **syncGridCellCssStyles**(`grid`, `key`): `void`

Defined in: [src/slick/iremoteview.ts:268](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L268)

Syncs cell CSS styles between the grid and the data view.

#### Parameters

##### grid

`ISleekGrid`

The grid to sync with.

##### key

`string`

The CSS style key.

#### Returns

`void`

***

### syncGridSelection()?

> `optional` **syncGridSelection**(`grid`, `preserveHidden?`, `preserveHiddenOnSelectionChange?`): `EventEmitter`\<`any`, \{ \}\>

Defined in: [src/slick/iremoteview.ts:275](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L275)

Wires the grid and the DataView together to keep row selection tied to item ids.

#### Parameters

##### grid

`ISleekGrid`

The grid to sync selection with.

##### preserveHidden?

`boolean`

Whether to keep selected items that go out of view due to filtering.

##### preserveHiddenOnSelectionChange?

`boolean`

Whether to keep hidden items selected when selection changes.

#### Returns

`EventEmitter`\<`any`, \{ \}\>

***

### updateItem()

> **updateItem**(`id`, `item`): `void`

Defined in: [src/slick/iremoteview.ts:281](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/iremoteview.ts#L281)

Updates an existing item in the view.

#### Parameters

##### id

`any`

The ID of the item to update

##### item

`any`

The new item data

#### Returns

`void`
