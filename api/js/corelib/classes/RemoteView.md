[@serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TItem\>

Defined in: [src/slick/remoteview.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L82)

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

Defined in: [src/slick/remoteview.ts:159](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L159)

Creates a new RemoteView.

#### Parameters

##### options

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`TItem`\>

Configuration options for the view.

#### Returns

`RemoteView`\<`TItem`\>

## Properties

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:129](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L129)

Callback invoked before AJAX calls are made.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onAjaxCall`](../interfaces/IRemoteView.md#onajaxcall)

***

### onDataChanged

> `readonly` **onDataChanged**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:135](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L135)

Event fired when the underlying data changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataChanged`](../interfaces/IRemoteView.md#ondatachanged)

***

### onDataLoaded

> `readonly` **onDataLoaded**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L137)

Event fired when data loading completes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoaded`](../interfaces/IRemoteView.md#ondataloaded)

***

### onDataLoading

> `readonly` **onDataLoading**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:139](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L139)

Event fired when data loading begins.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoading`](../interfaces/IRemoteView.md#ondataloading)

***

### onGroupCollapsed

> `readonly` **onGroupCollapsed**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L141)

Event fired when a group is collapsed.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupCollapsed`](../interfaces/IRemoteView.md#ongroupcollapsed)

***

### onGroupExpanded

> `readonly` **onGroupExpanded**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:143](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L143)

Event fired when a group is expanded.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupExpanded`](../interfaces/IRemoteView.md#ongroupexpanded)

***

### onPagingInfoChanged

> `readonly` **onPagingInfoChanged**: `EventEmitter`\<[`ArgsPagingInfo`](../interfaces/ArgsPagingInfo.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:145](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L145)

Event fired when paging information changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onPagingInfoChanged`](../interfaces/IRemoteView.md#onpaginginfochanged)

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:131](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L131)

Callback invoked to process data received from the server.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onProcessData`](../interfaces/IRemoteView.md#onprocessdata)

***

### onRecalcRows

> `readonly` **onRecalcRows**: `EventEmitter`\<[`ArgsRecalcRows`](../interfaces/ArgsRecalcRows.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:147](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L147)

Event fired when rows need to be recalculated.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRecalcRows`](../interfaces/IRemoteView.md#onrecalcrows)

***

### onRowCountChanged

> `readonly` **onRowCountChanged**: `EventEmitter`\<[`ArgsRowCountChanged`](../interfaces/ArgsRowCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:149](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L149)

Event fired when the row count changes.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowCountChanged`](../interfaces/IRemoteView.md#onrowcountchanged)

***

### onRowsChanged

> `readonly` **onRowsChanged**: `EventEmitter`\<[`ArgsRowsChanged`](../interfaces/ArgsRowsChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L151)

Event fired when row indices change.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsChanged`](../interfaces/IRemoteView.md#onrowschanged)

***

### onRowsOrCountChanged

> `readonly` **onRowsOrCountChanged**: `EventEmitter`\<[`ArgsRowsOrCountChanged`](../interfaces/ArgsRowsOrCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:153](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L153)

Event fired when rows or row count change.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsOrCountChanged`](../interfaces/IRemoteView.md#onrowsorcountchanged)

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:133](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L133)

Callback invoked before submitting a request; return false to cancel.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onSubmit`](../interfaces/IRemoteView.md#onsubmit)

***

### params

> **params**: `Record`\<`string`, `any`\>

Defined in: [src/slick/remoteview.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L120)

Additional parameters to send with service requests.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`params`](../interfaces/IRemoteView.md#params)

***

### seekToPage

> **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L122)

The page number to seek to when loading data.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`seekToPage`](../interfaces/IRemoteView.md#seektopage)

***

### sortBy

> **sortBy**: `string`[]

Defined in: [src/slick/remoteview.ts:124](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L124)

Sort expressions for the data (e.g. "Name" or "Name desc").

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortBy`](../interfaces/IRemoteView.md#sortby)

***

### url

> **url**: `string`

Defined in: [src/slick/remoteview.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L126)

The URL of the service endpoint for data requests.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`url`](../interfaces/IRemoteView.md#url)

***

### groupingInfoDefaults

> `readonly` `static` **groupingInfoDefaults**: [`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>

Defined in: [src/slick/remoteview.ts:185](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L185)

Default configuration for grouping information

## Accessors

### idField

#### Get Signature

> **get** **idField**(): `string`

Defined in: [src/slick/remoteview.ts:1510](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1510)

##### Deprecated

Gets the ID property name, for compatibility.

##### Returns

`string`

The ID property name.

## Methods

### addData()

> **addData**(`data`): `boolean`

Defined in: [src/slick/remoteview.ts:1324](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1324)

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

Defined in: [src/slick/remoteview.ts:671](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L671)

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

### beginUpdate()

> **beginUpdate**(): `void`

Defined in: [src/slick/remoteview.ts:201](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L201)

Begins a batch update; suspends refresh until endUpdate is called.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`beginUpdate`](../interfaces/IRemoteView.md#beginupdate)

***

### collapseAllGroups()

> **collapseAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:831](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L831)

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

Defined in: [src/slick/remoteview.ts:867](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L867)

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

Defined in: [src/slick/remoteview.ts:681](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L681)

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

Defined in: [src/slick/remoteview.ts:206](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L206)

Ends a batch update and refreshes the view if outermost.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`endUpdate`](../interfaces/IRemoteView.md#endupdate)

***

### expandAllGroups()

> **expandAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:839](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L839)

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

Defined in: [src/slick/remoteview.ts:876](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L876)

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

Defined in: [src/slick/remoteview.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L436)

Gets the current filter function.

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The current filter function.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilter`](../interfaces/IRemoteView.md#getfilter)

***

### getFilteredItems()

> **getFilteredItems**(): `TItem`[]

Defined in: [src/slick/remoteview.ts:428](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L428)

Gets the filtered items (after applying the current filter).

#### Returns

`TItem`[]

Array of filtered items.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilteredItems`](../interfaces/IRemoteView.md#getfiltereditems)

***

### getGrandTotals()

> **getGrandTotals**(): `IGroupTotals`

Defined in: [src/slick/remoteview.ts:471](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L471)

Gets the grand totals for the view.

#### Returns

`IGroupTotals`

The grand totals object.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrandTotals`](../interfaces/IRemoteView.md#getgrandtotals)

***

### getGrouping()

> **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L453)

Gets the current grouping configuration.

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Array of grouping information.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrouping`](../interfaces/IRemoteView.md#getgrouping)

***

### getGroupItemMetadataProvider()

> **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

Defined in: [src/slick/remoteview.ts:1478](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1478)

Gets the group item metadata provider.

#### Returns

`GroupItemMetadataProvider`

The metadata provider.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroupItemMetadataProvider`](../interfaces/IRemoteView.md#getgroupitemmetadataprovider)

***

### getGroups()

> **getGroups**(): `Group`\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:885](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L885)

Gets the current groups.

#### Returns

`Group`\<`TItem`\>[]

Array of groups.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroups`](../interfaces/IRemoteView.md#getgroups)

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

Defined in: [src/slick/remoteview.ts:257](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L257)

Gets the name of the property used as the unique identifier for items.

#### Returns

`string`

The ID property name.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdPropertyName`](../interfaces/IRemoteView.md#getidpropertyname)

***

### getIdxById()

> **getIdxById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:528](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L528)

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

Defined in: [src/slick/remoteview.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L757)

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

Defined in: [src/slick/remoteview.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L566)

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

Defined in: [src/slick/remoteview.ts:519](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L519)

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

Defined in: [src/slick/remoteview.ts:783](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L783)

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

Defined in: [src/slick/remoteview.ts:1494](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1494)

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

Defined in: [src/slick/remoteview.ts:249](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L249)

Gets all items in the view.

#### Returns

`TItem`[]

Array of all items.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItems`](../interfaces/IRemoteView.md#getitems)

***

### getLength()

> **getLength**(): `number`

Defined in: [src/slick/remoteview.ts:748](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L748)

Gets the number of rows in the view.

#### Returns

`number`

The row count.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLength`](../interfaces/IRemoteView.md#getlength)

***

### getLocalSort()

> **getLocalSort**(): `boolean`

Defined in: [src/slick/remoteview.ts:404](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L404)

Gets whether local sorting is enabled.

#### Returns

`boolean`

True if local sorting is enabled.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLocalSort`](../interfaces/IRemoteView.md#getlocalsort)

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

Defined in: [src/slick/remoteview.ts:332](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L332)

Gets the current paging information.

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

Object containing paging state.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getPagingInfo`](../interfaces/IRemoteView.md#getpaginginfo)

***

### getRowById()

> **getRowById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:556](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L556)

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

Defined in: [src/slick/remoteview.ts:546](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L546)

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

Defined in: [src/slick/remoteview.ts:740](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L740)

Gets all rows in the view (including group rows and totals rows).

#### Returns

(`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Array of all rows.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRows`](../interfaces/IRemoteView.md#getrows)

***

### insertItem()

> **insertItem**(`insertBefore`, `item`): `void`

Defined in: [src/slick/remoteview.ts:661](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L661)

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

### mapIdsToRows()

> **mapIdsToRows**(`idArray`): `any`[]

Defined in: [src/slick/remoteview.ts:592](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L592)

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

Defined in: [src/slick/remoteview.ts:575](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L575)

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

Defined in: [src/slick/remoteview.ts:609](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L609)

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

Defined in: [src/slick/remoteview.ts:1367](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1367)

Loads data from the server using the configured URL and parameters.

#### Returns

`boolean`

False if the operation was cancelled or no URL is configured.

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populate`](../interfaces/IRemoteView.md#populate)

***

### populateLock()

> **populateLock**(): `void`

Defined in: [src/slick/remoteview.ts:1459](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1459)

Locks population to prevent automatic data loading.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateLock`](../interfaces/IRemoteView.md#populatelock)

***

### populateUnlock()

> **populateUnlock**(): `void`

Defined in: [src/slick/remoteview.ts:1466](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1466)

Unlocks population; executes pending populate calls if any.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateUnlock`](../interfaces/IRemoteView.md#populateunlock)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/slick/remoteview.ts:1160](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1160)

Refreshes the view by recalculating rows and notifying changes.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`refresh`](../interfaces/IRemoteView.md#refresh)

***

### reSort()

> **reSort**(): `void`

Defined in: [src/slick/remoteview.ts:420](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L420)

Re-sorts the items using the current sort settings.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`reSort`](../interfaces/IRemoteView.md#resort)

***

### setFilter()

> **setFilter**(`filterFn`): `void`

Defined in: [src/slick/remoteview.ts:444](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L444)

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

Defined in: [src/slick/remoteview.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L495)

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

Defined in: [src/slick/remoteview.ts:1486](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1486)

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

Defined in: [src/slick/remoteview.ts:1502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1502)

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

Defined in: [src/slick/remoteview.ts:266](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L266)

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

Defined in: [src/slick/remoteview.ts:412](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L412)

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

Defined in: [src/slick/remoteview.ts:295](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L295)

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

Defined in: [src/slick/remoteview.ts:216](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L216)

Sets hints for the next refresh operation to optimize performance.

#### Parameters

##### hints

`any`

Object containing refresh hints like isFilterNarrowing, isFilterExpanding, etc.

#### Returns

`void`

***

### setSummaryOptions()

> **setSummaryOptions**(`summary`): `void`

Defined in: [src/slick/remoteview.ts:461](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L461)

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

Defined in: [src/slick/remoteview.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L383)

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

Defined in: [src/slick/remoteview.ts:696](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L696)

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

Defined in: [src/slick/remoteview.ts:705](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L705)

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

Defined in: [src/slick/remoteview.ts:1269](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1269)

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

Defined in: [src/slick/remoteview.ts:1213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1213)

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

Defined in: [src/slick/remoteview.ts:624](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L624)

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
