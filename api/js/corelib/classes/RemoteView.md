[@serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TItem\>

Defined in: [src/slick/remoteview.ts:42](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L42)

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

Defined in: [src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L96)

#### Parameters

##### options

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`TItem`\>

#### Returns

`RemoteView`\<`TItem`\>

## Properties

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L83)

Callback invoked before making AJAX calls

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onAjaxCall`](../interfaces/IRemoteView.md#onajaxcall)

***

### onDataChanged

> `readonly` **onDataChanged**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L86)

Event fired when the underlying data changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataChanged`](../interfaces/IRemoteView.md#ondatachanged)

***

### onDataLoaded

> `readonly` **onDataLoaded**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L87)

Event fired when data loading completes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoaded`](../interfaces/IRemoteView.md#ondataloaded)

***

### onDataLoading

> `readonly` **onDataLoading**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L88)

Event fired when data loading begins

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoading`](../interfaces/IRemoteView.md#ondataloading)

***

### onGroupCollapsed

> `readonly` **onGroupCollapsed**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L89)

Event fired when a group is collapsed

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupCollapsed`](../interfaces/IRemoteView.md#ongroupcollapsed)

***

### onGroupExpanded

> `readonly` **onGroupExpanded**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L90)

Event fired when a group is expanded

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupExpanded`](../interfaces/IRemoteView.md#ongroupexpanded)

***

### onPagingInfoChanged

> `readonly` **onPagingInfoChanged**: `EventEmitter`\<[`ArgsPagingInfo`](../interfaces/ArgsPagingInfo.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L91)

Event fired when paging information changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onPagingInfoChanged`](../interfaces/IRemoteView.md#onpaginginfochanged)

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

Callback invoked to process data received from the server

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onProcessData`](../interfaces/IRemoteView.md#onprocessdata)

***

### onRowCountChanged

> `readonly` **onRowCountChanged**: `EventEmitter`\<[`ArgsRowCountChanged`](../interfaces/ArgsRowCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L92)

Event fired when the row count changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowCountChanged`](../interfaces/IRemoteView.md#onrowcountchanged)

***

### onRowsChanged

> `readonly` **onRowsChanged**: `EventEmitter`\<[`ArgsRowsChanged`](../interfaces/ArgsRowsChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L93)

Event fired when specific rows change

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsChanged`](../interfaces/IRemoteView.md#onrowschanged)

***

### onRowsOrCountChanged

> `readonly` **onRowsOrCountChanged**: `EventEmitter`\<[`ArgsRowsOrCountChanged`](../interfaces/ArgsRowsOrCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L94)

Event fired when rows or count change

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsOrCountChanged`](../interfaces/IRemoteView.md#onrowsorcountchanged)

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L85)

Callback invoked before submitting a request, can cancel the operation

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onSubmit`](../interfaces/IRemoteView.md#onsubmit)

***

### params

> **params**: `Record`\<`string`, `any`\>

Defined in: [src/slick/remoteview.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L78)

Additional parameters to send with service requests

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`params`](../interfaces/IRemoteView.md#params)

***

### seekToPage

> **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L79)

The page number to seek to when loading data

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`seekToPage`](../interfaces/IRemoteView.md#seektopage)

***

### sortBy

> **sortBy**: `string`[]

Defined in: [src/slick/remoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L80)

Sort expressions for the data

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortBy`](../interfaces/IRemoteView.md#sortby)

***

### url

> **url**: `string`

Defined in: [src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L81)

The URL to fetch data from

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`url`](../interfaces/IRemoteView.md#url)

***

### groupingInfoDefaults

> `readonly` `static` **groupingInfoDefaults**: [`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>

Defined in: [src/slick/remoteview.ts:122](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L122)

Default configuration for grouping information

## Accessors

### idField

#### Get Signature

> **get** **idField**(): `string`

Defined in: [src/slick/remoteview.ts:1226](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1226)

##### Deprecated

Gets the ID property name, for compatibility

##### Returns

`string`

## Methods

### addData()

> **addData**(`data`): `boolean`

Defined in: [src/slick/remoteview.ts:1084](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1084)

Adds data received from the server to the view.

#### Parameters

##### data

`any`

The response data from the server

#### Returns

`boolean`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`addData`](../interfaces/IRemoteView.md#adddata)

***

### addItem()

> **addItem**(`item`): `void`

Defined in: [src/slick/remoteview.ts:501](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L501)

Adds an item to the end of the items array.

#### Parameters

##### item

`any`

The item to add

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`addItem`](../interfaces/IRemoteView.md#additem)

***

### beginUpdate()

> **beginUpdate**(): `void`

Defined in: [src/slick/remoteview.ts:137](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L137)

Begins a batch update operation. Multiple changes can be made without triggering refreshes.
Call endUpdate() to complete the batch and refresh the view.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`beginUpdate`](../interfaces/IRemoteView.md#beginupdate)

***

### collapseAllGroups()

> **collapseAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:626](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L626)

Collapses all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to collapse. If not specified, applies to all levels.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`collapseAllGroups`](../interfaces/IRemoteView.md#collapseallgroups)

***

### collapseGroup()

> **collapseGroup**(`constArgs`): `void`

Defined in: [src/slick/remoteview.ts:654](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L654)

Collapses a specific group.

#### Parameters

##### constArgs

`any`[]

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`collapseGroup`](../interfaces/IRemoteView.md#collapsegroup)

***

### deleteItem()

> **deleteItem**(`id`): `void`

Defined in: [src/slick/remoteview.ts:507](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L507)

Deletes an item by its ID.

#### Parameters

##### id

`any`

The ID of the item to delete

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`deleteItem`](../interfaces/IRemoteView.md#deleteitem)

***

### endUpdate()

> **endUpdate**(): `void`

Defined in: [src/slick/remoteview.ts:141](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L141)

Ends a batch update operation. If this is the outermost endUpdate call,
refreshes the view to reflect all changes made during the batch.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`endUpdate`](../interfaces/IRemoteView.md#endupdate)

***

### expandAllGroups()

> **expandAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:630](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L630)

Expands all groups at the specified level, or all levels if not specified.

#### Parameters

##### level?

`number`

Optional level to expand. If not specified, applies to all levels.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`expandAllGroups`](../interfaces/IRemoteView.md#expandallgroups)

***

### expandGroup()

> **expandGroup**(`constArgs`): `void`

Defined in: [src/slick/remoteview.ts:659](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L659)

Expands a specific group.

#### Parameters

##### constArgs

`any`[]

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`expandGroup`](../interfaces/IRemoteView.md#expandgroup)

***

### getFilter()

> **getFilter**(): [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:325](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L325)

Gets the current filter function.

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The current filter function

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilter`](../interfaces/IRemoteView.md#getfilter)

***

### getFilteredItems()

> **getFilteredItems**(): `any`[]

Defined in: [src/slick/remoteview.ts:321](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L321)

Gets the filtered items (after applying the current filter).

#### Returns

`any`[]

Array of filtered items

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilteredItems`](../interfaces/IRemoteView.md#getfiltereditems)

***

### getGrandTotals()

> **getGrandTotals**(): `IGroupTotals`

Defined in: [src/slick/remoteview.ts:344](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L344)

Gets the grand totals for all aggregated data.

#### Returns

`IGroupTotals`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrandTotals`](../interfaces/IRemoteView.md#getgrandtotals)

***

### getGrouping()

> **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:334](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L334)

Gets the current grouping configuration.

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Array of grouping information

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrouping`](../interfaces/IRemoteView.md#getgrouping)

***

### getGroupItemMetadataProvider()

> **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

Defined in: [src/slick/remoteview.ts:1217](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1217)

Gets the group item metadata provider.

#### Returns

`GroupItemMetadataProvider`

The metadata provider

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroupItemMetadataProvider`](../interfaces/IRemoteView.md#getgroupitemmetadataprovider)

***

### getGroups()

> **getGroups**(): `Group`\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:664](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L664)

Gets the current groups.

#### Returns

`Group`\<`TItem`\>[]

Array of groups

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroups`](../interfaces/IRemoteView.md#getgroups)

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

Defined in: [src/slick/remoteview.ts:184](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L184)

Gets the name of the property used as the unique identifier for items.

#### Returns

`string`

The ID property name

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdPropertyName`](../interfaces/IRemoteView.md#getidpropertyname)

***

### getIdxById()

> **getIdxById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:387](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L387)

Gets the index of an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`number`

The index of the item, or undefined if not found

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdxById`](../interfaces/IRemoteView.md#getidxbyid)

***

### getItem()

> **getItem**(`i`): `any`

Defined in: [src/slick/remoteview.ts:561](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L561)

Gets the item at the specified row index.

#### Parameters

##### i

`number`

#### Returns

`any`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItem`](../interfaces/IRemoteView.md#getitem)

***

### getItemById()

> **getItemById**(`id`): `TItem`

Defined in: [src/slick/remoteview.ts:410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L410)

Gets an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`TItem`

The item with the specified ID

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemById`](../interfaces/IRemoteView.md#getitembyid)

***

### getItemByIdx()

> **getItemByIdx**(`i`): `any`

Defined in: [src/slick/remoteview.ts:383](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L383)

Gets an item by its index in the items array.

#### Parameters

##### i

`number`

The index of the item

#### Returns

`any`

The item at the specified index

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemByIdx`](../interfaces/IRemoteView.md#getitembyidx)

***

### getItemMetadata()

> **getItemMetadata**(`row`): `any`

Defined in: [src/slick/remoteview.ts:582](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L582)

Gets metadata for the item at the specified row index.

#### Parameters

##### row

`number`

#### Returns

`any`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemMetadata`](../interfaces/IRemoteView.md#getitemmetadata)

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/slick/remoteview.ts:180](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L180)

Gets all items in the view.

#### Returns

`TItem`[]

Array of all items

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItems`](../interfaces/IRemoteView.md#getitems)

***

### getLength()

> **getLength**(): `number`

Defined in: [src/slick/remoteview.ts:557](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L557)

Gets the total number of rows in the view.

#### Returns

`number`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLength`](../interfaces/IRemoteView.md#getlength)

***

### getLocalSort()

> **getLocalSort**(): `boolean`

Defined in: [src/slick/remoteview.ts:306](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L306)

Gets whether local sorting is enabled.

#### Returns

`boolean`

true if local sorting is enabled

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLocalSort`](../interfaces/IRemoteView.md#getlocalsort)

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

Defined in: [src/slick/remoteview.ts:244](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L244)

Gets the current paging information.

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

Object containing paging state information

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getPagingInfo`](../interfaces/IRemoteView.md#getpaginginfo)

***

### getRowById()

> **getRowById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:405](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L405)

Gets the row index for an item by its ID.

#### Parameters

##### id

`any`

The ID of the item

#### Returns

`number`

The row index of the item

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRowById`](../interfaces/IRemoteView.md#getrowbyid)

***

### getRowByItem()

> **getRowByItem**(`item`): `number`

Defined in: [src/slick/remoteview.ts:400](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L400)

Gets the row index for an item.

#### Parameters

##### item

`any`

The item to find

#### Returns

`number`

The row index of the item

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRowByItem`](../interfaces/IRemoteView.md#getrowbyitem)

***

### getRows()

> **getRows**(): (`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Defined in: [src/slick/remoteview.ts:553](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L553)

Gets all rows in the view (including group rows and totals rows).

#### Returns

(`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Array of all rows

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRows`](../interfaces/IRemoteView.md#getrows)

***

### insertItem()

> **insertItem**(`insertBefore`, `item`): `void`

Defined in: [src/slick/remoteview.ts:495](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L495)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`insertItem`](../interfaces/IRemoteView.md#insertitem)

***

### mapIdsToRows()

> **mapIdsToRows**(`idArray`): `any`[]

Defined in: [src/slick/remoteview.ts:436](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L436)

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

Defined in: [src/slick/remoteview.ts:419](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L419)

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

Defined in: [src/slick/remoteview.ts:453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L453)

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

Defined in: [src/slick/remoteview.ts:1118](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1118)

Loads data from the server using the configured URL and parameters.

#### Returns

`boolean`

false if the operation was cancelled or no URL is configured

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populate`](../interfaces/IRemoteView.md#populate)

***

### populateLock()

> **populateLock**(): `void`

Defined in: [src/slick/remoteview.ts:1203](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1203)

Locks population to prevent automatic data loading.
Use this when you want to make multiple changes without triggering loads.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateLock`](../interfaces/IRemoteView.md#populatelock)

***

### populateUnlock()

> **populateUnlock**(): `void`

Defined in: [src/slick/remoteview.ts:1209](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1209)

Unlocks population. If there were pending populate calls while locked, executes them.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateUnlock`](../interfaces/IRemoteView.md#populateunlock)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/slick/remoteview.ts:930](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L930)

Refresh the view by recalculating the rows and notifying changes.
Note that this does not re-fetch the data from the server, use populate
method for that purpose.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`refresh`](../interfaces/IRemoteView.md#refresh)

***

### reSort()

> **reSort**(): `void`

Defined in: [src/slick/remoteview.ts:317](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L317)

Re-sorts the items using the current sort settings.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`reSort`](../interfaces/IRemoteView.md#resort)

***

### setFilter()

> **setFilter**(`filterFn`): `void`

Defined in: [src/slick/remoteview.ts:329](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L329)

Sets the filter function to apply to items.

#### Parameters

##### filterFn

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The filter function to apply

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setFilter`](../interfaces/IRemoteView.md#setfilter)

***

### setGrouping()

> **setGrouping**(`groupingInfo`): `void`

Defined in: [src/slick/remoteview.ts:364](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L364)

Sets the grouping configuration for the view.

#### Parameters

##### groupingInfo

Grouping information or array of grouping information

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\> | [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setGrouping`](../interfaces/IRemoteView.md#setgrouping)

***

### setGroupItemMetadataProvider()

> **setGroupItemMetadataProvider**(`value`): `void`

Defined in: [src/slick/remoteview.ts:1221](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1221)

Sets the group item metadata provider.

#### Parameters

##### value

`GroupItemMetadataProvider`

The metadata provider to set

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setGroupItemMetadataProvider`](../interfaces/IRemoteView.md#setgroupitemmetadataprovider)

***

### setItems()

> **setItems**(`data`, `newIdProperty?`): `void`

Defined in: [src/slick/remoteview.ts:188](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L188)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setItems`](../interfaces/IRemoteView.md#setitems)

***

### setLocalSort()

> **setLocalSort**(`value`): `void`

Defined in: [src/slick/remoteview.ts:310](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L310)

Sets whether to use local sorting. When enabled, sorting is done client-side.

#### Parameters

##### value

`boolean`

Whether to enable local sorting

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setLocalSort`](../interfaces/IRemoteView.md#setlocalsort)

***

### setPagingOptions()

> **setPagingOptions**(`args`): `void`

Defined in: [src/slick/remoteview.ts:213](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L213)

Sets paging options and triggers a data reload if options changed.

#### Parameters

##### args

[`PagingOptions`](../interfaces/PagingOptions.md)

The paging options to set

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setPagingOptions`](../interfaces/IRemoteView.md#setpagingoptions)

***

### setRefreshHints()

> **setRefreshHints**(`hints`): `void`

Defined in: [src/slick/remoteview.ts:151](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L151)

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

Defined in: [src/slick/remoteview.ts:338](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L338)

Sets summary/aggregation options for the view.

#### Parameters

##### summary

[`SummaryOptions`](../interfaces/SummaryOptions.md)

Object containing aggregators and other summary options

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`setSummaryOptions`](../interfaces/IRemoteView.md#setsummaryoptions)

***

### sort()

> **sort**(`comparer?`, `ascending?`): `void`

Defined in: [src/slick/remoteview.ts:289](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L289)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sort`](../interfaces/IRemoteView.md#sort)

***

### sortedAddItem()

> **sortedAddItem**(`item`): `void`

Defined in: [src/slick/remoteview.ts:518](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L518)

Adds an item in sorted order.

#### Parameters

##### item

`any`

The item to add

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortedAddItem`](../interfaces/IRemoteView.md#sortedadditem)

***

### sortedUpdateItem()

> **sortedUpdateItem**(`id`, `item`): `void`

Defined in: [src/slick/remoteview.ts:522](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L522)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortedUpdateItem`](../interfaces/IRemoteView.md#sortedupdateitem)

***

### syncGridCellCssStyles()

> **syncGridCellCssStyles**(`grid`, `key`): `void`

Defined in: [src/slick/remoteview.ts:1034](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1034)

Syncs cell CSS styles between the grid and the data view.

#### Parameters

##### grid

`ISleekGrid`

##### key

`string`

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`syncGridCellCssStyles`](../interfaces/IRemoteView.md#syncgridcellcssstyles)

***

### syncGridSelection()

> **syncGridSelection**(`sleekGrid`, `preserveHidden?`, `preserveHiddenOnSelectionChange?`): `EventEmitter`\<`any`\>

Defined in: [src/slick/remoteview.ts:983](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L983)

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

Defined in: [src/slick/remoteview.ts:463](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L463)

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

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`updateItem`](../interfaces/IRemoteView.md#updateitem)
