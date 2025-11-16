[serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TItem\>

Defined in: [src/slick/remoteview.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L44)

A data view that supports remote data loading, sorting, filtering, grouping, and paging.
Extends the functionality of SleekGrid's DataView with server-side data operations.

## Typeparam

TItem The type of entities in the view

## Type Parameters

### TItem

`TItem` = `any`

## Implements

- [`IRemoteView`](../interfaces/IRemoteView.md)\<`TItem`\>

## Constructors

### Constructor

> **new RemoteView**\<`TItem`\>(`options`): `RemoteView`\<`TItem`\>

Defined in: [src/slick/remoteview.ts:128](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L128)

#### Parameters

##### options

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)\<`TItem`\>

#### Returns

`RemoteView`\<`TItem`\>

## Properties

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L93)

Callback invoked before making AJAX calls

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onAjaxCall`](../interfaces/IRemoteView.md#onajaxcall)

***

### onDataChanged

> `readonly` **onDataChanged**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L102)

Event fired when the underlying data changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataChanged`](../interfaces/IRemoteView.md#ondatachanged)

***

### onDataLoaded

> `readonly` **onDataLoaded**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L105)

Event fired when data loading completes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoaded`](../interfaces/IRemoteView.md#ondataloaded)

***

### onDataLoading

> `readonly` **onDataLoading**: `EventEmitter`\<[`ArgsRemoteView`](../interfaces/ArgsRemoteView.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L108)

Event fired when data loading begins

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onDataLoading`](../interfaces/IRemoteView.md#ondataloading)

***

### onGroupCollapsed

> `readonly` **onGroupCollapsed**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L111)

Event fired when a group is collapsed

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupCollapsed`](../interfaces/IRemoteView.md#ongroupcollapsed)

***

### onGroupExpanded

> `readonly` **onGroupExpanded**: `EventEmitter`\<[`ArgsGroupToggle`](../interfaces/ArgsGroupToggle.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L114)

Event fired when a group is expanded

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onGroupExpanded`](../interfaces/IRemoteView.md#ongroupexpanded)

***

### onPagingInfoChanged

> `readonly` **onPagingInfoChanged**: `EventEmitter`\<[`ArgsPagingInfo`](../interfaces/ArgsPagingInfo.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:117](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L117)

Event fired when paging information changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onPagingInfoChanged`](../interfaces/IRemoteView.md#onpaginginfochanged)

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L96)

Callback invoked to process data received from the server

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onProcessData`](../interfaces/IRemoteView.md#onprocessdata)

***

### onRowCountChanged

> `readonly` **onRowCountChanged**: `EventEmitter`\<[`ArgsRowCountChanged`](../interfaces/ArgsRowCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L120)

Event fired when the row count changes

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowCountChanged`](../interfaces/IRemoteView.md#onrowcountchanged)

***

### onRowsChanged

> `readonly` **onRowsChanged**: `EventEmitter`\<[`ArgsRowsChanged`](../interfaces/ArgsRowsChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:123](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L123)

Event fired when specific rows change

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsChanged`](../interfaces/IRemoteView.md#onrowschanged)

***

### onRowsOrCountChanged

> `readonly` **onRowsOrCountChanged**: `EventEmitter`\<[`ArgsRowsOrCountChanged`](../interfaces/ArgsRowsOrCountChanged.md), \{ \}\>

Defined in: [src/slick/remoteview.ts:126](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L126)

Event fired when rows or count change

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onRowsOrCountChanged`](../interfaces/IRemoteView.md#onrowsorcountchanged)

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L99)

Callback invoked before submitting a request, can cancel the operation

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`onSubmit`](../interfaces/IRemoteView.md#onsubmit)

***

### params

> **params**: `Record`\<`string`, `any`\>

Defined in: [src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L81)

Additional parameters to send with service requests

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`params`](../interfaces/IRemoteView.md#params)

***

### seekToPage

> **seekToPage**: `number`

Defined in: [src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

The page number to seek to when loading data

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`seekToPage`](../interfaces/IRemoteView.md#seektopage)

***

### sortBy

> **sortBy**: `string`[]

Defined in: [src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L87)

Sort expressions for the data

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`sortBy`](../interfaces/IRemoteView.md#sortby)

***

### url

> **url**: `string`

Defined in: [src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L90)

The URL to fetch data from

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`url`](../interfaces/IRemoteView.md#url)

***

### groupingInfoDefaults

> `readonly` `static` **groupingInfoDefaults**: [`GroupInfo`](../interfaces/GroupInfo.md)\<`any`\>

Defined in: [src/slick/remoteview.ts:154](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L154)

Default configuration for grouping information

## Accessors

### idField

#### Get Signature

> **get** **idField**(): `string`

Defined in: [src/slick/remoteview.ts:1458](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1458)

##### Deprecated

Gets the ID property name, for compatibility

##### Returns

`string`

## Methods

### addData()

> **addData**(`data`): `boolean`

Defined in: [src/slick/remoteview.ts:1297](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1297)

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

Defined in: [src/slick/remoteview.ts:645](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L645)

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

Defined in: [src/slick/remoteview.ts:173](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L173)

Begins a batch update operation. Multiple changes can be made without triggering refreshes.
Call endUpdate() to complete the batch and refresh the view.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`beginUpdate`](../interfaces/IRemoteView.md#beginupdate)

***

### collapseAllGroups()

> **collapseAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:805](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L805)

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

Defined in: [src/slick/remoteview.ts:843](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L843)

Collapses a specific group.

#### Parameters

##### constArgs

`any`[]

Either a Slick.Group's "groupingKey" property, or a
constiable argument list of grouping values denoting a unique path to the row.
For example, calling collapseGroup('high', '10%') will collapse the '10%' subgroup of the 'high' group.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`collapseGroup`](../interfaces/IRemoteView.md#collapsegroup)

***

### deleteItem()

> **deleteItem**(`id`): `void`

Defined in: [src/slick/remoteview.ts:655](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L655)

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

Defined in: [src/slick/remoteview.ts:181](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L181)

Ends a batch update operation. If this is the outermost endUpdate call,
refreshes the view to reflect all changes made during the batch.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`endUpdate`](../interfaces/IRemoteView.md#endupdate)

***

### expandAllGroups()

> **expandAllGroups**(`level?`): `void`

Defined in: [src/slick/remoteview.ts:813](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L813)

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

Defined in: [src/slick/remoteview.ts:854](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L854)

Expands a specific group.

#### Parameters

##### constArgs

`any`[]

Either a Slick.Group's "groupingKey" property, or a
constiable argument list of grouping values denoting a unique path to the row.
For example, calling expandGroup('high', '10%') will expand the '10%' subgroup of the 'high' group.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`expandGroup`](../interfaces/IRemoteView.md#expandgroup)

***

### getFilter()

> **getFilter**(): [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

Defined in: [src/slick/remoteview.ts:410](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L410)

Gets the current filter function.

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TItem`\>

The current filter function

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getFilter`](../interfaces/IRemoteView.md#getfilter)

***

### getFilteredItems()

> **getFilteredItems**(): `any`[]

Defined in: [src/slick/remoteview.ts:402](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L402)

Gets the filtered items (after applying the current filter).

#### Returns

`any`[]

Array of filtered items

***

### getGrandTotals()

> **getGrandTotals**(): `IGroupTotals`

Defined in: [src/slick/remoteview.ts:445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L445)

Gets the grand totals for all aggregated data.

#### Returns

`IGroupTotals`

Object containing grand totals

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrandTotals`](../interfaces/IRemoteView.md#getgrandtotals)

***

### getGrouping()

> **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:427](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L427)

Gets the current grouping configuration.

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TItem`\>[]

Array of grouping information

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGrouping`](../interfaces/IRemoteView.md#getgrouping)

***

### getGroupItemMetadataProvider()

> **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

Defined in: [src/slick/remoteview.ts:1445](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1445)

Gets the group item metadata provider.

#### Returns

`GroupItemMetadataProvider`

The metadata provider

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroupItemMetadataProvider`](../interfaces/IRemoteView.md#getgroupitemmetadataprovider)

***

### getGroups()

> **getGroups**(): `Group`\<`TItem`\>[]

Defined in: [src/slick/remoteview.ts:863](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L863)

Gets the current groups.

#### Returns

`Group`\<`TItem`\>[]

Array of groups

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getGroups`](../interfaces/IRemoteView.md#getgroups)

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

Defined in: [src/slick/remoteview.ts:232](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L232)

Gets the name of the property used as the unique identifier for items.

#### Returns

`string`

The ID property name

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getIdPropertyName`](../interfaces/IRemoteView.md#getidpropertyname)

***

### getIdxById()

> **getIdxById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:502](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L502)

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

Defined in: [src/slick/remoteview.ts:731](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L731)

Gets the item at the specified row index.

#### Parameters

##### i

`number`

The row index

#### Returns

`any`

The item at the row index

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItem`](../interfaces/IRemoteView.md#getitem)

***

### getItemById()

> **getItemById**(`id`): `TItem`

Defined in: [src/slick/remoteview.ts:540](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L540)

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

Defined in: [src/slick/remoteview.ts:493](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L493)

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

Defined in: [src/slick/remoteview.ts:757](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L757)

Gets metadata for the item at the specified row index.

#### Parameters

##### row

`number`

The row index

#### Returns

`any`

Metadata object or null

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItemMetadata`](../interfaces/IRemoteView.md#getitemmetadata)

***

### getItems()

> **getItems**(): `TItem`[]

Defined in: [src/slick/remoteview.ts:224](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L224)

Gets all items in the view.

#### Returns

`TItem`[]

Array of all items

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getItems`](../interfaces/IRemoteView.md#getitems)

***

### getLength()

> **getLength**(): `number`

Defined in: [src/slick/remoteview.ts:722](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L722)

Gets the total number of rows in the view.

#### Returns

`number`

The number of rows

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLength`](../interfaces/IRemoteView.md#getlength)

***

### getLocalSort()

> **getLocalSort**(): `boolean`

Defined in: [src/slick/remoteview.ts:376](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L376)

Gets whether local sorting is enabled.

#### Returns

`boolean`

true if local sorting is enabled

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getLocalSort`](../interfaces/IRemoteView.md#getlocalsort)

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

Defined in: [src/slick/remoteview.ts:305](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L305)

Gets the current paging information.

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

Object containing paging state information

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getPagingInfo`](../interfaces/IRemoteView.md#getpaginginfo)

***

### getRowById()

> **getRowById**(`id`): `number`

Defined in: [src/slick/remoteview.ts:530](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L530)

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

Defined in: [src/slick/remoteview.ts:520](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L520)

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

Defined in: [src/slick/remoteview.ts:714](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L714)

Gets all rows in the view (including group rows and totals rows).

#### Returns

(`TItem` \| `Group`\<`any`\> \| `GroupTotals`\<`any`\>)[]

Array of all rows

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`getRows`](../interfaces/IRemoteView.md#getrows)

***

### insertItem()

> **insertItem**(`insertBefore`, `item`): `void`

Defined in: [src/slick/remoteview.ts:635](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L635)

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

Defined in: [src/slick/remoteview.ts:566](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L566)

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

Defined in: [src/slick/remoteview.ts:549](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L549)

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

Defined in: [src/slick/remoteview.ts:583](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L583)

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

Defined in: [src/slick/remoteview.ts:1335](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1335)

Loads data from the server using the configured URL and parameters.

#### Returns

`boolean`

false if the operation was cancelled or no URL is configured

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populate`](../interfaces/IRemoteView.md#populate)

***

### populateLock()

> **populateLock**(): `void`

Defined in: [src/slick/remoteview.ts:1424](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1424)

Locks population to prevent automatic data loading.
Use this when you want to make multiple changes without triggering loads.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateLock`](../interfaces/IRemoteView.md#populatelock)

***

### populateUnlock()

> **populateUnlock**(): `void`

Defined in: [src/slick/remoteview.ts:1433](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1433)

Unlocks population. If there were pending populate calls while locked, executes them.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`populateUnlock`](../interfaces/IRemoteView.md#populateunlock)

***

### refresh()

> **refresh**(): `void`

Defined in: [src/slick/remoteview.ts:1134](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1134)

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

Defined in: [src/slick/remoteview.ts:394](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L394)

Re-sorts the items using the current sort settings.

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`reSort`](../interfaces/IRemoteView.md#resort)

***

### setFilter()

> **setFilter**(`filterFn`): `void`

Defined in: [src/slick/remoteview.ts:418](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L418)

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

Defined in: [src/slick/remoteview.ts:469](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L469)

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

Defined in: [src/slick/remoteview.ts:1453](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1453)

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

Defined in: [src/slick/remoteview.ts:241](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L241)

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

Defined in: [src/slick/remoteview.ts:384](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L384)

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

Defined in: [src/slick/remoteview.ts:270](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L270)

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

Defined in: [src/slick/remoteview.ts:191](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L191)

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

Defined in: [src/slick/remoteview.ts:435](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L435)

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

Defined in: [src/slick/remoteview.ts:355](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L355)

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

Defined in: [src/slick/remoteview.ts:670](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L670)

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

Defined in: [src/slick/remoteview.ts:679](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L679)

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

Defined in: [src/slick/remoteview.ts:1243](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1243)

Syncs cell CSS styles between the grid and the data view.

#### Parameters

##### grid

`ISleekGrid`

The grid to sync styles with

##### key

`string`

The style key to sync

#### Returns

`void`

#### Implementation of

[`IRemoteView`](../interfaces/IRemoteView.md).[`syncGridCellCssStyles`](../interfaces/IRemoteView.md#syncgridcellcssstyles)

***

### syncGridSelection()

> **syncGridSelection**(`sleekGrid`, `preserveHidden?`, `preserveHiddenOnSelectionChange?`): `EventEmitter`\<`any`\>

Defined in: [src/slick/remoteview.ts:1187](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L1187)

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

Defined in: [src/slick/remoteview.ts:598](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L598)

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
