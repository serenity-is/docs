[@serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TItem\>

Defined in: [src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

A data view that supports remote data loading, sorting, filtering, grouping, and paging.
Extends the functionality of SleekGrid's DataView with server-side data operations.

## Type Parameters

### TItem

`TItem` = `any`

## Implements

- [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

## Constructors

### Constructor

> **new RemoteView**\<`TItem`\>(`options`): `RemoteView`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:190](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L190)

Creates a new RemoteView.

#### Parameters

##### options

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`TItem`\>

Configuration options for the view.

#### Returns

`RemoteView`\<`TItem`\>

## Properties

### indeterminatePaging

> **indeterminatePaging**: `boolean`

Defined in: [src/slick/remoteview.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L147)

Whether the view pages without knowing the total number of the rows, which is slow to count for large tables. It asks the
server whether there are more rows after the page, instead of their count, so the pager can only go to the next page
while there are more. The total count of its paging info is then only the number of the rows known so far, see
[PagingInfo.indeterminate](../interfaces/PagingInfo.md#indeterminate).

***

### more

> `protected` **more**: `boolean` = `false`

Defined in: [src/slick/remoteview.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L149)

Whether there are more rows after the ones of the view, which is only known when paging is indeterminate.

***

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L160)

Callback invoked before AJAX calls are made.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onAjaxCall`](../interfaces/IRemoteView.md#onajaxcall)

***

### onDataChanged

> `readonly` **onDataChanged**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:166](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L166)

Event fired when the underlying data changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataChanged`](../interfaces/IRemoteView.md#ondatachanged)

***

### onDataLoaded

> `readonly` **onDataLoaded**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:168](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L168)

Event fired when data loading completes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoaded`](../interfaces/IRemoteView.md#ondataloaded)

***

### onDataLoading

> `readonly` **onDataLoading**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:170](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L170)

Event fired when data loading begins.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoading`](../interfaces/IRemoteView.md#ondataloading)

***

### onGroupCollapsed

> `readonly` **onGroupCollapsed**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:172](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L172)

Event fired when a group is collapsed.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupCollapsed`](../interfaces/IRemoteView.md#ongroupcollapsed)

***

### onGroupExpanded

> `readonly` **onGroupExpanded**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:174](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L174)

Event fired when a group is expanded.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupExpanded`](../interfaces/IRemoteView.md#ongroupexpanded)

***

### onPagingInfoChanged

> `readonly` **onPagingInfoChanged**: `EventEmitter`\<[`ArgsPagingInfo`](../interfaces/ArgsPagingInfo.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:176](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L176)

Event fired when paging information changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onPagingInfoChanged`](../interfaces/IRemoteView.md#onpaginginfochanged)

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:162](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L162)

Callback invoked to process data received from the server.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onProcessData`](../interfaces/IRemoteView.md#onprocessdata)

***

### onRecalcRows

> `readonly` **onRecalcRows**: `EventEmitter`\<[`ArgsRecalcRows`](../interfaces/ArgsRecalcRows.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:178](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L178)

Event fired when rows need to be recalculated.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRecalcRows`](../interfaces/IRemoteView.md#onrecalcrows)

***

### onRowCountChanged

> `readonly` **onRowCountChanged**: `EventEmitter`\<[`ArgsRowCountChanged`](../interfaces/ArgsRowCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L180)

Event fired when the row count changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowCountChanged`](../interfaces/IRemoteView.md#onrowcountchanged)

***

### onRowsChanged

> `readonly` **onRowsChanged**: `EventEmitter`\<[`ArgsRowsChanged`](../interfaces/ArgsRowsChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:182](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L182)

Event fired when row indices change.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsChanged`](../interfaces/IRemoteView.md#onrowschanged)

***

### onRowsOrCountChanged

> `readonly` **onRowsOrCountChanged**: `EventEmitter`\<[`ArgsRowsOrCountChanged`](../interfaces/ArgsRowsOrCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L184)

Event fired when rows or row count change.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsOrCountChanged`](../interfaces/IRemoteView.md#onrowsorcountchanged)

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:164](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L164)

Callback invoked before submitting a request; return false to cancel.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onSubmit`](../interfaces/IRemoteView.md#onsubmit)

***

### page

> `protected` **page**: `number` = `1`

Defined in: [src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L114)

The page of the rows of the view, which a view that doesn't page by them, e.g. one appending the rows, keeps as 1.

***

### params

> **params**: `Record`\<`string`, `any`\>

Defined in: [src/slick/remoteview.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L133)

Additional parameters to send with service requests.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`params`](../interfaces/IRemoteView.md#params)

***

### seekToPage

> **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L153)

The page number to seek to when loading data.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`seekToPage`](../interfaces/IRemoteView.md#seektopage)

***

### serverAggregates

> **serverAggregates**: `boolean`

Defined in: [src/slick/remoteview.ts:140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L140)

Whether to ask the server to calculate the aggregates of the summary options, e.g. the totals of the grid footer, from all
the rows the request matches, instead of calculating them from the rows of the current page. A server that doesn't
support it doesn't return them, in which case the view calculates them from its rows as usual. The
aggregators that the server can't calculate, like the weighted average, are also calculated from the rows.

***

### sortBy

> **sortBy**: `string`[]

Defined in: [src/slick/remoteview.ts:155](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L155)

Sort expressions for the data (e.g. "Name" or "Name desc").

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortBy`](../interfaces/IRemoteView.md#sortby)

***

### totalCount

> `protected` **totalCount**: `number` = `null`

Defined in: [src/slick/remoteview.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L128)

The total number of the rows, or the number of the ones known so far when paging is indeterminate.

***

### url

> **url**: `string`

Defined in: [src/slick/remoteview.ts:157](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L157)

The URL of the service endpoint for data requests.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`url`](../interfaces/IRemoteView.md#url)

***

### groupingDelimiter

> `readonly` `static` **groupingDelimiter**: `string`

Defined in: [src/slick/remoteview.ts:577](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L577)

The text that separates the values of the groups in the grouping key of a group, from the outermost one.

***

### groupingInfoDefaults

> `readonly` `static` **groupingInfoDefaults**: [`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>

Defined in: [src/slick/remoteview.ts:218](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L218)

Default configuration for grouping information

## Accessors

### idField

#### Get Signature

> **get** **idField**(): `string`

Defined in: [src/slick/remoteview.ts:1867](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1867)

##### Deprecated

Gets the ID property name, for compatibility.

##### Returns

`string`

The ID property name.

## Methods

### addData()

> **addData**(`data`): `boolean`

Defined in: [src/slick/remoteview.ts:1612](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1612)

Adds data received from the server to the view.

#### Parameters

##### data

`any`

The response data from the server.

#### Returns

`boolean`

False if the data could not be added.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`addData`](../interfaces/IRemoteView.md#adddata)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/slick/remoteview.ts:935](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L935)

Adds an item to the end of the items array.

#### Parameters

##### item

`any`

The item to add.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`addItem`](../interfaces/IRemoteView.md#additem)

***

### applyResponse()

> `protected` **applyResponse**(`data`): `boolean` \| `void`

Defined in: [src/slick/remoteview.ts:1650](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1650)

Sets the paging state and the items of the view from a response, which replace the ones it has. A view that loads its
rows in another way, e.g. by appending them, can override it.

#### Parameters

##### data

[`ListResponse`](../interfaces/ListResponse.md)\<`TItem`\>

The response, whose TotalCount and Entities are never null.

#### Returns

`boolean` \| `void`

False if the rows of the response are not used, e.g. when another request is made instead.

***

### beginUpdate()

> **beginUpdate**(): `void`

Defined in: [src/slick/remoteview.ts:234](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L234)

Begins a batch update; suspends refresh until endUpdate is called.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`beginUpdate`](../interfaces/IRemoteView.md#beginupdate)

***

### collapseAllGroups()

> **collapseAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:1095](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1095)

Collapses all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to collapse.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`collapseAllGroups`](../interfaces/IRemoteView.md#collapseallgroups)

***

### collapseGroup()

> **collapseGroup**(`constArgs`): `void`

Defined in: [src/slick/remoteview.ts:1140](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1140)

Collapses a specific group.

#### Parameters

##### constArgs

`any`[]

Grouping key or values denoting the group path.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`collapseGroup`](../interfaces/IRemoteView.md#collapsegroup)

***

### deleteItem()

> **deleteItem**(`id`): `void`

Defined in: [src/slick/remoteview.ts:945](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L945)

Deletes an item by its ID.

#### Parameters

##### id

`any`

The ID of the item to delete.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`deleteItem`](../interfaces/IRemoteView.md#deleteitem)

***

### endUpdate()

> **endUpdate**(): `void`

Defined in: [src/slick/remoteview.ts:239](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L239)

Ends a batch update and refreshes the view if outermost.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`endUpdate`](../interfaces/IRemoteView.md#endupdate)

***

### expandAllGroups()

> **expandAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:1103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1103)

Expands all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to expand.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`expandAllGroups`](../interfaces/IRemoteView.md#expandallgroups)

***

### expandGroup()

> **expandGroup**(`constArgs`): `void`

Defined in: [src/slick/remoteview.ts:1149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1149)

Expands a specific group.

#### Parameters

##### constArgs

`any`[]

Grouping key or values denoting the group path.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`expandGroup`](../interfaces/IRemoteView.md#expandgroup)

***

### getFilter()

> **getFilter**(): [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L471)

Gets the current filter function.

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The current filter function.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilter`](../interfaces/IRemoteView.md#getfilter)

***

### getFilteredItems()

> **getFilteredItems**(): `TItem`[]

Defined in: [src/slick/remoteview.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L463)

Gets the filtered items (after applying the current filter).

#### Returns

`TItem`[]

Array of filtered items.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilteredItems`](../interfaces/IRemoteView.md#getfiltereditems)

***

### getGrandTotals()

> **getGrandTotals**(): `IGroupTotals`

Defined in: [src/slick/remoteview.ts:530](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L530)

Gets the grand totals for the view.

#### Returns

`IGroupTotals`

The grand totals object.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrandTotals`](../interfaces/IRemoteView.md#getgrandtotals)

***

### getGrouping()

> **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:488](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L488)

Gets the current grouping configuration.

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Array of grouping information.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrouping`](../interfaces/IRemoteView.md#getgrouping)

***

### getGroupItemMetadataProvider()

> **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

Defined in: [src/slick/remoteview.ts:1835](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1835)

Gets the group item metadata provider.

#### Returns

`GroupItemMetadataProvider`

The metadata provider.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroupItemMetadataProvider`](../interfaces/IRemoteView.md#getgroupitemmetadataprovider)

***

### getGroups()

> **getGroups**(): `Group`\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:1158](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1158)

Gets the current groups.

#### Returns

`Group`\<`TItem`\>[]

Array of groups.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroups`](../interfaces/IRemoteView.md#getgroups)

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

Defined in: [src/slick/remoteview.ts:290](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L290)

Gets the name of the property used as the unique identifier for items.

#### Returns

`string`

The ID property name.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdPropertyName`](../interfaces/IRemoteView.md#getidpropertyname)

***

### getIdxById()

> **getIdxById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:792](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L792)

Gets the index of an item by its ID.

#### Parameters

##### id

`any`

The ID of the item.

#### Returns

`number`

The index of the item, or undefined if not found.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdxById`](../interfaces/IRemoteView.md#getidxbyid)

***

### getItem()

> **getItem**(`i`): `any`

Defined in: [src/slick/remoteview.ts:1021](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1021)

Gets the item at the specified row index.

#### Parameters

##### i

`number`

The row index.

#### Returns

`any`

The item at the row.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItem`](../interfaces/IRemoteView.md#getitem)

***

### getItemById()

> **getItemById**(`id`): `TItem`

Defined in: [src/slick/remoteview.ts:830](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L830)

Gets an item by its ID.

#### Parameters

##### id

`any`

The ID of the item.

#### Returns

`TItem`

The item with the specified ID.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemById`](../interfaces/IRemoteView.md#getitembyid)

***

### getItemByIdx()

> **getItemByIdx**(`i`): `any`

Defined in: [src/slick/remoteview.ts:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L783)

Gets an item by its index in the items array.

#### Parameters

##### i

`number`

The index of the item.

#### Returns

`any`

The item at the specified index.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemByIdx`](../interfaces/IRemoteView.md#getitembyidx)

***

### getItemMetadata()

> **getItemMetadata**(`row`): `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1047](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1047)

Gets metadata for the specified row.

#### Parameters

##### row

`number`

The row index.

#### Returns

`ItemMetadata`\<`TItem`\>

The item metadata, or null.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemMetadata`](../interfaces/IRemoteView.md#getitemmetadata)

***

### getItemMetadataCallback()

> **getItemMetadataCallback**(): (`item`, `row`) => `ItemMetadata`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:1851](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1851)

Gets the callback for retrieving item metadata.

#### Returns

The item metadata callback.

> (`item`, `row`): `ItemMetadata`\<`TItem`\>

##### Parameters

###### item

`TItem`

###### row

`number`

##### Returns

`ItemMetadata`\<`TItem`\>

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemMetadataCallback`](../interfaces/IRemoteView.md#getitemmetadatacallback)

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/slick/remoteview.ts:282](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L282)

Gets all items in the view.

#### Returns

`TItem`[]

Array of all items.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItems`](../interfaces/IRemoteView.md#getitems)

***

### getLength()

> **getLength**(): `number`

Defined in: [src/slick/remoteview.ts:1012](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1012)

Gets the number of rows in the view.

#### Returns

`number`

The row count.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLength`](../interfaces/IRemoteView.md#getlength)

***

### getLocalSort()

> **getLocalSort**(): `boolean`

Defined in: [src/slick/remoteview.ts:439](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L439)

Gets whether local sorting is enabled.

#### Returns

`boolean`

True if local sorting is enabled.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLocalSort`](../interfaces/IRemoteView.md#getlocalsort)

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

Defined in: [src/slick/remoteview.ts:365](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L365)

Gets the current paging information.

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

Object containing paging state.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getPagingInfo`](../interfaces/IRemoteView.md#getpaginginfo)

***

### getRowById()

> **getRowById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:820](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L820)

Gets the row index for an item by its ID.

#### Parameters

##### id

`any`

The ID of the item.

#### Returns

`number`

The row index of the item.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRowById`](../interfaces/IRemoteView.md#getrowbyid)

***

### getRowByItem()

> **getRowByItem**(`item`): `number`

Defined in: [src/slick/remoteview.ts:810](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L810)

Gets the row index for an item.

#### Parameters

##### item

`any`

The item to find.

#### Returns

`number`

The row index of the item.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRowByItem`](../interfaces/IRemoteView.md#getrowbyitem)

***

### getRows()

> **getRows**(): (`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Defined in: [src/slick/remoteview.ts:1004](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1004)

Gets all rows in the view (including group rows and totals rows).

#### Returns

(`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Array of all rows.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRows`](../interfaces/IRemoteView.md#getrows)

***

### insertItem()

> **insertItem**(`insertBefore`, `item`): `void`

Defined in: [src/slick/remoteview.ts:925](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L925)

Inserts an item at the specified position.

#### Parameters

##### insertBefore

`number`

The index to insert before.

##### item

`any`

The item to insert.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`insertItem`](../interfaces/IRemoteView.md#insertitem)

***

### keepServerTotals()

> `protected` **keepServerTotals**(): `boolean`

Defined in: [src/slick/remoteview.ts:1704](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1704)

Whether the request that is being made keeps the server totals of the previous one instead of asking for them again,
which is for a view whose request matches the same rows, e.g. one that loads the rows after the ones it has. It is
called after [setRequestPaging](#setrequestpaging), and only when the previous request asked for them.

#### Returns

`boolean`

***

### mapIdsToRows()

> **mapIdsToRows**(`idArray`): `any`[]

Defined in: [src/slick/remoteview.ts:856](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L856)

Maps an array of IDs to their corresponding row indices.

#### Parameters

##### idArray

`any`[]

Array of item IDs to map

#### Returns

`any`[]

Array of row indices

***

### mapItemsToRows()

> **mapItemsToRows**(`itemArray`): `number`[]

Defined in: [src/slick/remoteview.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L839)

Maps an array of items to their corresponding row indices.

#### Parameters

##### itemArray

`any`[]

Array of items to map

#### Returns

`number`[]

Array of row indices

***

### mapRowsToIds()

> **mapRowsToIds**(`rowArray`): `any`[]

Defined in: [src/slick/remoteview.ts:873](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L873)

Maps an array of row indices to their corresponding item IDs.

#### Parameters

##### rowArray

`any`[]

Array of row indices to map

#### Returns

`any`[]

Array of item IDs

***

### populate()

> **populate**(): `boolean`

Defined in: [src/slick/remoteview.ts:1712](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1712)

Loads data from the server using the configured URL and parameters.

#### Returns

`boolean`

False if the operation was cancelled or no URL is configured.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populate`](../interfaces/IRemoteView.md#populate)

***

### populateLock()

> **populateLock**(): `void`

Defined in: [src/slick/remoteview.ts:1816](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1816)

Locks population to prevent automatic data loading.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateLock`](../interfaces/IRemoteView.md#populatelock)

***

### populateUnlock()

> **populateUnlock**(): `void`

Defined in: [src/slick/remoteview.ts:1823](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1823)

Unlocks population; executes pending populate calls if any.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateUnlock`](../interfaces/IRemoteView.md#populateunlock)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/slick/remoteview.ts:1448](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1448)

Refreshes the view by recalculating rows and notifying changes.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`refresh`](../interfaces/IRemoteView.md#refresh)

***

### reSort()

> **reSort**(): `void`

Defined in: [src/slick/remoteview.ts:455](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L455)

Re-sorts the items using the current sort settings.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`reSort`](../interfaces/IRemoteView.md#resort)

***

### setFilter()

> **setFilter**(`filterFn`): `void`

Defined in: [src/slick/remoteview.ts:479](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L479)

Sets the filter function to apply to items.

#### Parameters

##### filterFn

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The filter function to apply.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setFilter`](../interfaces/IRemoteView.md#setfilter)

***

### setGrouping()

> **setGrouping**(`groupingInfo`): `void`

Defined in: [src/slick/remoteview.ts:747](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L747)

Sets the grouping configuration for the view.

#### Parameters

##### groupingInfo

Grouping information or array of grouping information.

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\> | [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setGrouping`](../interfaces/IRemoteView.md#setgrouping)

***

### setGroupItemMetadataProvider()

> **setGroupItemMetadataProvider**(`value`): `void`

Defined in: [src/slick/remoteview.ts:1843](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1843)

Sets the group item metadata provider.

#### Parameters

##### value

`GroupItemMetadataProvider`

The metadata provider to set.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setGroupItemMetadataProvider`](../interfaces/IRemoteView.md#setgroupitemmetadataprovider)

***

### setItemMetadataCallback()

> **setItemMetadataCallback**(`value`): `void`

Defined in: [src/slick/remoteview.ts:1859](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1859)

Sets the callback for retrieving item metadata.

#### Parameters

##### value

(`item`, `row`) => `ItemMetadata`\<`TItem`\>

The item metadata callback.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setItemMetadataCallback`](../interfaces/IRemoteView.md#setitemmetadatacallback)

***

### setItems()

> **setItems**(`data`, `newIdProperty?`): `void`

Defined in: [src/slick/remoteview.ts:299](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L299)

Sets the items in the view and optionally changes the ID property.

#### Parameters

##### data

`any`[]

Array of items to set.

##### newIdProperty?

Optional new ID property name.

`string` | `boolean`

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setItems`](../interfaces/IRemoteView.md#setitems)

***

### setLocalSort()

> **setLocalSort**(`value`): `void`

Defined in: [src/slick/remoteview.ts:447](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L447)

Sets whether to use local sorting.

#### Parameters

##### value

`boolean`

Whether to enable local sorting.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setLocalSort`](../interfaces/IRemoteView.md#setlocalsort)

***

### setPagingOptions()

> **setPagingOptions**(`args`): `void`

Defined in: [src/slick/remoteview.ts:328](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L328)

Sets paging options and triggers a data reload if options changed.

#### Parameters

##### args

[`PagingOptions`](../interfaces/PagingOptions.md)

The paging options to set.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setPagingOptions`](../interfaces/IRemoteView.md#setpagingoptions)

***

### setRefreshHints()

> **setRefreshHints**(`hints`): `void`

Defined in: [src/slick/remoteview.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L249)

Sets hints for the next refresh operation to optimize performance.

#### Parameters

##### hints

`any`

Object containing refresh hints like isFilterNarrowing, isFilterExpanding, etc.

#### Returns

`void`

***

### setRequestPaging()

> `protected` **setRequestPaging**(`request`): `void`

Defined in: [src/slick/remoteview.ts:1690](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1690)

Sets the rows to skip and take of a request, which are the ones of the page to seek to. It is called after
onSubmit, so the params are the ones of the request. A view that loads its rows in another way can override it.

#### Parameters

##### request

[`ListRequest`](../interfaces/ListRequest.md)

The request to set the Skip and Take of.

#### Returns

`void`

***

### setSummaryOptions()

> **setSummaryOptions**(`summary`): `void`

Defined in: [src/slick/remoteview.ts:496](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L496)

Sets summary/aggregation options for the view.

#### Parameters

##### summary

[`SummaryOptions`](../interfaces/SummaryOptions.md)

Object containing aggregators and other summary options.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setSummaryOptions`](../interfaces/IRemoteView.md#setsummaryoptions)

***

### sort()

> **sort**(`comparer?`, `ascending?`): `void`

Defined in: [src/slick/remoteview.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L418)

Sorts the items using the specified comparer.

#### Parameters

##### comparer?

(`a`, `b`) => `number`

Optional custom comparer function.

##### ascending?

`boolean`

Whether to sort in ascending order.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sort`](../interfaces/IRemoteView.md#sort)

***

### sortedAddItem()

> **sortedAddItem**(`item`): `void`

Defined in: [src/slick/remoteview.ts:960](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L960)

Adds an item in sorted order.

#### Parameters

##### item

`any`

The item to add.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortedAddItem`](../interfaces/IRemoteView.md#sortedadditem)

***

### sortedUpdateItem()

> **sortedUpdateItem**(`id`, `item`): `void`

Defined in: [src/slick/remoteview.ts:969](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L969)

Updates an item while maintaining sorted order.

#### Parameters

##### id

`any`

The ID of the item to update.

##### item

`any`

The new item data.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortedUpdateItem`](../interfaces/IRemoteView.md#sortedupdateitem)

***

### syncGridCellCssStyles()

> **syncGridCellCssStyles**(`grid`, `key`): `void`

Defined in: [src/slick/remoteview.ts:1557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1557)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`syncGridCellCssStyles`](../interfaces/IRemoteView.md#syncgridcellcssstyles)

***

### syncGridSelection()

> **syncGridSelection**(`sleekGrid`, `preserveHidden?`, `preserveHiddenOnSelectionChange?`): `EventEmitter`\<`any`\>

Defined in: [src/slick/remoteview.ts:1501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1501)

Wires the grid and the DataView together to keep row selection tied to item ids.
This is useful since, without it, the grid only knows about rows, so if the items
move around, the same rows stay selected instead of the selection moving along
with the items.

NOTE:  This doesn't work with cell selection model.

#### Parameters

##### sleekGrid

`ISleekGrid`

The grid to sync selection with.

##### preserveHidden?

`boolean`

Whether to keep selected items that go out of the
    view due to them getting filtered out.

##### preserveHiddenOnSelectionChange?

`boolean`

Whether to keep selected items
    that are currently out of the view (see preserveHidden) as selected when selection
    changes.

#### Returns

`EventEmitter`\<`any`\>

An event that notifies when an internal list of selected row ids
    changes.  This is useful since, in combination with the above two options, it allows
    access to the full list selected row ids, and not just the ones visible to the grid.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`syncGridSelection`](../interfaces/IRemoteView.md#syncgridselection)

***

### updateItem()

> **updateItem**(`id`, `item`): `void`

Defined in: [src/slick/remoteview.ts:888](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L888)

Updates an existing item in the view.

#### Parameters

##### id

`any`

The ID of the item to update.

##### item

`any`

The new item data.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`updateItem`](../interfaces/IRemoteView.md#updateitem)

***

### copyServerValues()

> `static` **copyServerValues**(`node`): `Record`\<`string`, `Record`\<`string`, `any`\>\>

Defined in: [src/slick/remoteview.ts:584](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L584)

Copies the values of a group of the server by the aggregate key, then the field, as the aggregators store them in the totals.

#### Parameters

##### node

[`AggregateGroup`](../interfaces/AggregateGroup.md)

The group of the server, or its root for the totals of all the rows.

#### Returns

`Record`\<`string`, `Record`\<`string`, `any`\>\>

The totals, or null when the group has no values.

***

### findServerGroup()

> `static` **findServerGroup**(`root`, `groupingKey`): [`AggregateGroup`](../interfaces/AggregateGroup.md)

Defined in: [src/slick/remoteview.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L624)

Finds the group of the server for the grouping key of a group of a view, by its values from the outermost group, as
the server returns the groups by the fields of the groupings in the same order.

#### Parameters

##### root

[`AggregateGroup`](../interfaces/AggregateGroup.md)

The aggregates of a response.

##### groupingKey

`string`

The grouping key of the group.

#### Returns

[`AggregateGroup`](../interfaces/AggregateGroup.md)

The group of the server, or null when it has none.

***

### formatGroupValue()

> `static` **formatGroupValue**\<`TItem`\>(`groupingInfos`, `ctx`): `FormatterResult`

Defined in: [src/slick/remoteview.ts:1884](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1884)

Formats the value of a group for its row, by the format of its grouping when it has one.

#### Type Parameters

##### TItem

`TItem` = `any`

#### Parameters

##### groupingInfos

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

The groupings of the view.

##### ctx

`FormatterContext`\<`Group`\<`TItem`\>\>

The formatter context, whose item is the group.

#### Returns

`FormatterResult`

***

### getAggregatesToRequest()

> `static` **getAggregatesToRequest**(`aggregators`): [`AggregateBy`](../interfaces/AggregateBy.md)[]

Defined in: [src/slick/remoteview.ts:721](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L721)

Gets what to ask the server to calculate for some aggregators, which are the ones it can calculate.

#### Parameters

##### aggregators

[`IAggregator`](../interfaces/IAggregator.md)[]

The aggregators of the totals and the groups.

#### Returns

[`AggregateBy`](../interfaces/AggregateBy.md)[]

***

### getGroupByToRequest()

> `static` **getGroupByToRequest**(`groupingInfos`, `sortBy`): [`GroupBy`](../interfaces/GroupBy.md)[]

Defined in: [src/slick/remoteview.ts:701](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L701)

Gets the groups to ask the server for the groupings of a view, which can only be by the fields, so there are none when
one of the groupings is by a function.

#### Parameters

##### groupingInfos

[`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>[]

The groupings of the view.

##### sortBy

The sort expressions of the view, which the groups of a field that is sorted descending are in the order of.

`string` | `string`[]

#### Returns

[`GroupBy`](../interfaces/GroupBy.md)[]

***

### getRequestSort()

> `static` **getRequestSort**(`sortBy`, `groupingInfos`, `localSort?`): `string`[]

Defined in: [src/slick/remoteview.ts:662](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L662)

Gets the sort of a request, which has the fields the rows are grouped by first, so the rows of a group follow each other.
A field that is also sorted keeps its direction. It only counts for the groupings that are by a field, from the outermost.

#### Parameters

##### sortBy

The sort expressions of the view.

`string` | `string`[]

##### groupingInfos

[`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>[]

The groupings of the view.

##### localSort?

`boolean`

Whether the view sorts the rows itself, so the sort is not changed.

#### Returns

`string`[]

***

### groupKeyText()

> `static` **groupKeyText**(`value`): `string`

Defined in: [src/slick/remoteview.ts:596](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L596)

Makes the value of a group the same as the key of its group of the server, which are null and undefined for a missing one.

#### Parameters

##### value

`any`

#### Returns

`string`

***

### normalizeGroupingInfos()

> `static` **normalizeGroupingInfos**\<`TItem`\>(`groupingInfo`): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:768](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L768)

Gets the groupings of a view from what it is given, with the defaults of a grouping. The groupings in an array
are replaced with their copies that have the defaults, and the array itself is returned.

#### Type Parameters

##### TItem

`TItem` = `any`

#### Parameters

##### groupingInfo

Grouping information or array of grouping information.

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\> | [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

***

### resolveLevelAndGroupingKey()

> `static` **resolveLevelAndGroupingKey**(`args`): `object`

Defined in: [src/slick/remoteview.ts:1116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1116)

Gets the level and the grouping key of a group from the arguments of collapseGroup and expandGroup, which are either
its grouping key, or the values of the groups from the outermost one.

#### Parameters

##### args

`any`[]

The arguments.

#### Returns

`object`

##### groupingKey

> **groupingKey**: `string`

##### level

> **level**: `number`
