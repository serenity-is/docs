[@serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TEntity\>

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Table of contents

### Constructors

- [constructor](RemoteView.md#constructor)

### Properties

- [errormsg](RemoteView.md#errormsg)
- [fastSort](RemoteView.md#fastsort)
- [idField](RemoteView.md#idfield)
- [method](RemoteView.md#method)
- [onAjaxCall](RemoteView.md#onajaxcall)
- [onDataChanged](RemoteView.md#ondatachanged)
- [onDataLoaded](RemoteView.md#ondataloaded)
- [onDataLoading](RemoteView.md#ondataloading)
- [onGroupCollapsed](RemoteView.md#ongroupcollapsed)
- [onGroupExpanded](RemoteView.md#ongroupexpanded)
- [onPagingInfoChanged](RemoteView.md#onpaginginfochanged)
- [onProcessData](RemoteView.md#onprocessdata)
- [onRowCountChanged](RemoteView.md#onrowcountchanged)
- [onRowsChanged](RemoteView.md#onrowschanged)
- [onRowsOrCountChanged](RemoteView.md#onrowsorcountchanged)
- [onSubmit](RemoteView.md#onsubmit)
- [params](RemoteView.md#params)
- [rowsPerPage](RemoteView.md#rowsperpage)
- [seekToPage](RemoteView.md#seektopage)
- [sortBy](RemoteView.md#sortby)
- [url](RemoteView.md#url)

### Methods

- [addData](RemoteView.md#adddata)
- [addItem](RemoteView.md#additem)
- [beginUpdate](RemoteView.md#beginupdate)
- [collapseAllGroups](RemoteView.md#collapseallgroups)
- [collapseGroup](RemoteView.md#collapsegroup)
- [deleteItem](RemoteView.md#deleteitem)
- [endUpdate](RemoteView.md#endupdate)
- [expandAllGroups](RemoteView.md#expandallgroups)
- [expandGroup](RemoteView.md#expandgroup)
- [getFilter](RemoteView.md#getfilter)
- [getFilteredItems](RemoteView.md#getfiltereditems)
- [getGrandTotals](RemoteView.md#getgrandtotals)
- [getGroupItemMetadataProvider](RemoteView.md#getgroupitemmetadataprovider)
- [getGrouping](RemoteView.md#getgrouping)
- [getGroups](RemoteView.md#getgroups)
- [getIdPropertyName](RemoteView.md#getidpropertyname)
- [getIdxById](RemoteView.md#getidxbyid)
- [getItem](RemoteView.md#getitem)
- [getItemById](RemoteView.md#getitembyid)
- [getItemByIdx](RemoteView.md#getitembyidx)
- [getItemMetadata](RemoteView.md#getitemmetadata)
- [getItems](RemoteView.md#getitems)
- [getLength](RemoteView.md#getlength)
- [getLocalSort](RemoteView.md#getlocalsort)
- [getPagingInfo](RemoteView.md#getpaginginfo)
- [getRowById](RemoteView.md#getrowbyid)
- [getRowByItem](RemoteView.md#getrowbyitem)
- [getRows](RemoteView.md#getrows)
- [insertItem](RemoteView.md#insertitem)
- [mapIdsToRows](RemoteView.md#mapidstorows)
- [mapItemsToRows](RemoteView.md#mapitemstorows)
- [mapRowsToIds](RemoteView.md#maprowstoids)
- [populate](RemoteView.md#populate)
- [populateLock](RemoteView.md#populatelock)
- [populateUnlock](RemoteView.md#populateunlock)
- [reSort](RemoteView.md#resort)
- [refresh](RemoteView.md#refresh)
- [setFilter](RemoteView.md#setfilter)
- [setFilterArgs](RemoteView.md#setfilterargs)
- [setGroupItemMetadataProvider](RemoteView.md#setgroupitemmetadataprovider)
- [setGrouping](RemoteView.md#setgrouping)
- [setItems](RemoteView.md#setitems)
- [setLocalSort](RemoteView.md#setlocalsort)
- [setPagingOptions](RemoteView.md#setpagingoptions)
- [setRefreshHints](RemoteView.md#setrefreshhints)
- [setSummaryOptions](RemoteView.md#setsummaryoptions)
- [sort](RemoteView.md#sort)
- [sortedAddItem](RemoteView.md#sortedadditem)
- [sortedUpdateItem](RemoteView.md#sortedupdateitem)
- [syncGridCellCssStyles](RemoteView.md#syncgridcellcssstyles)
- [syncGridSelection](RemoteView.md#syncgridselection)
- [updateItem](RemoteView.md#updateitem)

## Constructors

### constructor

• **new RemoteView**\<`TEntity`\>(`options`): [`RemoteView`](RemoteView.md)\<`TEntity`\>

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`RemoteViewOptions`](../interfaces/RemoteViewOptions.md) |

#### Returns

[`RemoteView`](RemoteView.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L120)

## Properties

### errormsg

• **errormsg**: `string`

#### Defined in

[src/slick/remoteview.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L106)

___

### fastSort

• **fastSort**: `any`

#### Defined in

[src/slick/remoteview.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L67)

___

### idField

• **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L115)

___

### method

• **method**: `string`

#### Defined in

[src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L114)

___

### onAjaxCall

• **onAjaxCall**: [`RemoteViewAjaxCallback`](../README.md#remoteviewajaxcallback)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L55)

___

### onDataChanged

• **onDataChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L45)

___

### onDataLoaded

• **onDataLoaded**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L47)

___

### onDataLoading

• **onDataLoading**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L46)

___

### onGroupCollapsed

• **onGroupCollapsed**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L54)

___

### onGroupExpanded

• **onGroupExpanded**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L53)

___

### onPagingInfoChanged

• **onPagingInfoChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L48)

___

### onProcessData

• **onProcessData**: [`RemoteViewProcessCallback`](../README.md#remoteviewprocesscallback)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L56)

___

### onRowCountChanged

• **onRowCountChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L49)

___

### onRowsChanged

• **onRowsChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L50)

___

### onRowsOrCountChanged

• **onRowsOrCountChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L51)

___

### onSubmit

• **onSubmit**: [`CancellableViewCallback`](../README.md#cancellableviewcallback)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L44)

___

### params

• **params**: `any`

#### Defined in

[src/slick/remoteview.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L107)

___

### rowsPerPage

• **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L105)

___

### seekToPage

• `Optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L116)

___

### sortBy

• **sortBy**: `string`[]

#### Defined in

[src/slick/remoteview.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L112)

___

### url

• **url**: `string`

#### Defined in

[src/slick/remoteview.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L113)

## Methods

### addData

▸ **addData**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](../interfaces/ListResponse.md)\<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L57)

___

### addItem

▸ **addItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `TEntity` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L89)

___

### beginUpdate

▸ **beginUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L58)

___

### collapseAllGroups

▸ **collapseAllGroups**(`level`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `level` | `number` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L93)

___

### collapseGroup

▸ **collapseGroup**(`keys`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `keys` | `any`[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L96)

___

### deleteItem

▸ **deleteItem**(`id`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L60)

___

### endUpdate

▸ **endUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L59)

___

### expandAllGroups

▸ **expandAllGroups**(`level`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `level` | `number` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L94)

___

### expandGroup

▸ **expandGroup**(`keys`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `keys` | `any`[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L95)

___

### getFilter

▸ **getFilter**(): [`RemoteViewFilter`](../README.md#remoteviewfilter)\<`TEntity`\>

#### Returns

[`RemoteViewFilter`](../README.md#remoteviewfilter)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L63)

___

### getFilteredItems

▸ **getFilteredItems**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L64)

___

### getGrandTotals

▸ **getGrandTotals**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L71)

___

### getGroupItemMetadataProvider

▸ **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

#### Returns

`GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L65)

___

### getGrouping

▸ **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[]

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[]

#### Defined in

[src/slick/remoteview.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L72)

___

### getGroups

▸ **getGroups**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L73)

___

### getIdPropertyName

▸ **getIdPropertyName**(): `string`

#### Returns

`string`

#### Defined in

[src/slick/remoteview.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L69)

___

### getIdxById

▸ **getIdxById**(`id`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L90)

___

### getItem

▸ **getItem**(`row`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L103)

___

### getItemById

▸ **getItemById**(`id`): `TEntity`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

`TEntity`

#### Defined in

[src/slick/remoteview.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L70)

___

### getItemByIdx

▸ **getItemByIdx**(`index`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `index` | `number` |

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L91)

___

### getItemMetadata

▸ **getItemMetadata**(`i`): `any`

#### Parameters

| Name | Type |
| :------ | :------ |
| `i` | `number` |

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L87)

___

### getItems

▸ **getItems**(): `TEntity`[]

#### Returns

`TEntity`[]

#### Defined in

[src/slick/remoteview.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L61)

___

### getLength

▸ **getLength**(): `number`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L104)

___

### getLocalSort

▸ **getLocalSort**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L108)

___

### getPagingInfo

▸ **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

#### Defined in

[src/slick/remoteview.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L52)

___

### getRowById

▸ **getRowById**(`id`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L74)

___

### getRowByItem

▸ **getRowByItem**(`item`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L75)

___

### getRows

▸ **getRows**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L76)

___

### insertItem

▸ **insertItem**(`insertBefore`, `item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `insertBefore` | `number` |
| `item` | `any` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L82)

___

### mapIdsToRows

▸ **mapIdsToRows**(`idAray`): `number`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `idAray` | `any`[] |

#### Returns

`number`[]

#### Defined in

[src/slick/remoteview.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L79)

___

### mapItemsToRows

▸ **mapItemsToRows**(`itemArray`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `itemArray` | `any`[] |

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L77)

___

### mapRowsToIds

▸ **mapRowsToIds**(`rowArray`): `any`[]

#### Parameters

| Name | Type |
| :------ | :------ |
| `rowArray` | `number`[] |

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L78)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L100)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L101)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L102)

___

### reSort

▸ **reSort**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L111)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L99)

___

### setFilter

▸ **setFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`RemoteViewFilter`](../README.md#remoteviewfilter)\<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L62)

___

### setFilterArgs

▸ **setFilterArgs**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | `any` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L80)

___

### setGroupItemMetadataProvider

▸ **setGroupItemMetadataProvider**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `GroupItemMetadataProvider` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L66)

___

### setGrouping

▸ **setGrouping**(`groupInfo`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `groupInfo` | [`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L92)

___

### setItems

▸ **setItems**(`items`, `newIdProperty?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `items` | `any`[] |
| `newIdProperty?` | `string` \| `boolean` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L68)

___

### setLocalSort

▸ **setLocalSort**(`value`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `value` | `boolean` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L109)

___

### setPagingOptions

▸ **setPagingOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`PagingOptions`](../interfaces/PagingOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L98)

___

### setRefreshHints

▸ **setRefreshHints**(`hints`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `hints` | `any`[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L81)

___

### setSummaryOptions

▸ **setSummaryOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`SummaryOptions`](../interfaces/SummaryOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L97)

___

### sort

▸ **sort**(`comparer?`, `ascending?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `comparer?` | (`a`: `any`, `b`: `any`) => `number` |
| `ascending?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L110)

___

### sortedAddItem

▸ **sortedAddItem**(`item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `item` | `any` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L83)

___

### sortedUpdateItem

▸ **sortedUpdateItem**(`id`, `item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `item` | `any` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

___

### syncGridCellCssStyles

▸ **syncGridCellCssStyles**(`grid`, `key`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | `any` |
| `key` | `string` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L86)

___

### syncGridSelection

▸ **syncGridSelection**(`grid`, `preserveHidden?`, `preserveHiddenOnSelectionChange?`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `grid` | `any` |
| `preserveHidden?` | `boolean` |
| `preserveHiddenOnSelectionChange?` | `boolean` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L85)

___

### updateItem

▸ **updateItem**(`id`, `item`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `id` | `any` |
| `item` | `TEntity` |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L88)
