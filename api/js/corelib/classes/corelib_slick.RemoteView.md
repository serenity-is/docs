[@serenity-is](../README.md) / [Modules](../modules.md) / [corelib/slick](../modules/corelib_slick.md) / RemoteView

# Class: RemoteView<TEntity\>

[corelib/slick](../modules/corelib_slick.md).RemoteView

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Table of contents

### Constructors

- [constructor](corelib_slick.RemoteView.md#constructor)

### Properties

- [errormsg](corelib_slick.RemoteView.md#errormsg)
- [fastSort](corelib_slick.RemoteView.md#fastsort)
- [idField](corelib_slick.RemoteView.md#idfield)
- [method](corelib_slick.RemoteView.md#method)
- [onAjaxCall](corelib_slick.RemoteView.md#onajaxcall)
- [onDataChanged](corelib_slick.RemoteView.md#ondatachanged)
- [onDataLoaded](corelib_slick.RemoteView.md#ondataloaded)
- [onDataLoading](corelib_slick.RemoteView.md#ondataloading)
- [onGroupCollapsed](corelib_slick.RemoteView.md#ongroupcollapsed)
- [onGroupExpanded](corelib_slick.RemoteView.md#ongroupexpanded)
- [onPagingInfoChanged](corelib_slick.RemoteView.md#onpaginginfochanged)
- [onProcessData](corelib_slick.RemoteView.md#onprocessdata)
- [onRowCountChanged](corelib_slick.RemoteView.md#onrowcountchanged)
- [onRowsChanged](corelib_slick.RemoteView.md#onrowschanged)
- [onRowsOrCountChanged](corelib_slick.RemoteView.md#onrowsorcountchanged)
- [onSubmit](corelib_slick.RemoteView.md#onsubmit)
- [params](corelib_slick.RemoteView.md#params)
- [rowsPerPage](corelib_slick.RemoteView.md#rowsperpage)
- [seekToPage](corelib_slick.RemoteView.md#seektopage)
- [sortBy](corelib_slick.RemoteView.md#sortby)
- [url](corelib_slick.RemoteView.md#url)

### Methods

- [addData](corelib_slick.RemoteView.md#adddata)
- [addItem](corelib_slick.RemoteView.md#additem)
- [beginUpdate](corelib_slick.RemoteView.md#beginupdate)
- [collapseAllGroups](corelib_slick.RemoteView.md#collapseallgroups)
- [collapseGroup](corelib_slick.RemoteView.md#collapsegroup)
- [deleteItem](corelib_slick.RemoteView.md#deleteitem)
- [endUpdate](corelib_slick.RemoteView.md#endupdate)
- [expandAllGroups](corelib_slick.RemoteView.md#expandallgroups)
- [expandGroup](corelib_slick.RemoteView.md#expandgroup)
- [getFilter](corelib_slick.RemoteView.md#getfilter)
- [getFilteredItems](corelib_slick.RemoteView.md#getfiltereditems)
- [getGrandTotals](corelib_slick.RemoteView.md#getgrandtotals)
- [getGroupItemMetadataProvider](corelib_slick.RemoteView.md#getgroupitemmetadataprovider)
- [getGrouping](corelib_slick.RemoteView.md#getgrouping)
- [getGroups](corelib_slick.RemoteView.md#getgroups)
- [getIdPropertyName](corelib_slick.RemoteView.md#getidpropertyname)
- [getIdxById](corelib_slick.RemoteView.md#getidxbyid)
- [getItem](corelib_slick.RemoteView.md#getitem)
- [getItemById](corelib_slick.RemoteView.md#getitembyid)
- [getItemByIdx](corelib_slick.RemoteView.md#getitembyidx)
- [getItemMetadata](corelib_slick.RemoteView.md#getitemmetadata)
- [getItems](corelib_slick.RemoteView.md#getitems)
- [getLength](corelib_slick.RemoteView.md#getlength)
- [getLocalSort](corelib_slick.RemoteView.md#getlocalsort)
- [getPagingInfo](corelib_slick.RemoteView.md#getpaginginfo)
- [getRowById](corelib_slick.RemoteView.md#getrowbyid)
- [getRowByItem](corelib_slick.RemoteView.md#getrowbyitem)
- [getRows](corelib_slick.RemoteView.md#getrows)
- [insertItem](corelib_slick.RemoteView.md#insertitem)
- [mapIdsToRows](corelib_slick.RemoteView.md#mapidstorows)
- [mapItemsToRows](corelib_slick.RemoteView.md#mapitemstorows)
- [mapRowsToIds](corelib_slick.RemoteView.md#maprowstoids)
- [populate](corelib_slick.RemoteView.md#populate)
- [populateLock](corelib_slick.RemoteView.md#populatelock)
- [populateUnlock](corelib_slick.RemoteView.md#populateunlock)
- [reSort](corelib_slick.RemoteView.md#resort)
- [refresh](corelib_slick.RemoteView.md#refresh)
- [setFilter](corelib_slick.RemoteView.md#setfilter)
- [setFilterArgs](corelib_slick.RemoteView.md#setfilterargs)
- [setGroupItemMetadataProvider](corelib_slick.RemoteView.md#setgroupitemmetadataprovider)
- [setGrouping](corelib_slick.RemoteView.md#setgrouping)
- [setItems](corelib_slick.RemoteView.md#setitems)
- [setLocalSort](corelib_slick.RemoteView.md#setlocalsort)
- [setPagingOptions](corelib_slick.RemoteView.md#setpagingoptions)
- [setRefreshHints](corelib_slick.RemoteView.md#setrefreshhints)
- [setSummaryOptions](corelib_slick.RemoteView.md#setsummaryoptions)
- [sort](corelib_slick.RemoteView.md#sort)
- [sortedAddItem](corelib_slick.RemoteView.md#sortedadditem)
- [sortedUpdateItem](corelib_slick.RemoteView.md#sortedupdateitem)
- [syncGridCellCssStyles](corelib_slick.RemoteView.md#syncgridcellcssstyles)
- [syncGridSelection](corelib_slick.RemoteView.md#syncgridselection)
- [updateItem](corelib_slick.RemoteView.md#updateitem)

## Constructors

### constructor

• **new RemoteView**<`TEntity`\>(`options`)

#### Type parameters

| Name |
| :------ |
| `TEntity` |

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`RemoteViewOptions`](../interfaces/corelib_slick.RemoteViewOptions.md) |

#### Defined in

[src/slick/remoteview.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;119)

## Properties

### errormsg

• **errormsg**: `string`

#### Defined in

[src/slick/remoteview.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;105)

___

### fastSort

• **fastSort**: `any`

#### Defined in

[src/slick/remoteview.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;66)

___

### idField

• **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;114)

___

### method

• **method**: `string`

#### Defined in

[src/slick/remoteview.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;113)

___

### onAjaxCall

• **onAjaxCall**: [`RemoteViewAjaxCallback`](../modules/corelib_slick.md#remoteviewajaxcallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;54)

___

### onDataChanged

• **onDataChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;44)

___

### onDataLoaded

• **onDataLoaded**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;46)

___

### onDataLoading

• **onDataLoading**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;45)

___

### onGroupCollapsed

• **onGroupCollapsed**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;53)

___

### onGroupExpanded

• **onGroupExpanded**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;52)

___

### onPagingInfoChanged

• **onPagingInfoChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;47)

___

### onProcessData

• **onProcessData**: [`RemoteViewProcessCallback`](../modules/corelib_slick.md#remoteviewprocesscallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;55)

___

### onRowCountChanged

• **onRowCountChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;48)

___

### onRowsChanged

• **onRowsChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;49)

___

### onRowsOrCountChanged

• **onRowsOrCountChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;50)

___

### onSubmit

• **onSubmit**: [`CancellableViewCallback`](../modules/corelib_slick.md#cancellableviewcallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;43)

___

### params

• **params**: `any`

#### Defined in

[src/slick/remoteview.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;106)

___

### rowsPerPage

• **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;104)

___

### seekToPage

• `Optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;115)

___

### sortBy

• **sortBy**: `string`[]

#### Defined in

[src/slick/remoteview.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;111)

___

### url

• **url**: `string`

#### Defined in

[src/slick/remoteview.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;112)

## Methods

### addData

▸ **addData**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](../interfaces/corelib_q.ListResponse.md)<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;56)

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

[src/slick/remoteview.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;88)

___

### beginUpdate

▸ **beginUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;57)

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

[src/slick/remoteview.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;92)

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

[src/slick/remoteview.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;95)

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

[src/slick/remoteview.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;59)

___

### endUpdate

▸ **endUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;58)

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

[src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;93)

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

[src/slick/remoteview.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;94)

___

### getFilter

▸ **getFilter**(): [`RemoteViewFilter`](../modules/corelib_slick.md#remoteviewfilter)<`TEntity`\>

#### Returns

[`RemoteViewFilter`](../modules/corelib_slick.md#remoteviewfilter)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;62)

___

### getFilteredItems

▸ **getFilteredItems**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;63)

___

### getGrandTotals

▸ **getGrandTotals**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;70)

___

### getGroupItemMetadataProvider

▸ **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

#### Returns

`GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;64)

___

### getGrouping

▸ **getGrouping**(): [`GroupInfo`](../interfaces/corelib_slick.GroupInfo.md)<`TEntity`\>[]

#### Returns

[`GroupInfo`](../interfaces/corelib_slick.GroupInfo.md)<`TEntity`\>[]

#### Defined in

[src/slick/remoteview.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;71)

___

### getGroups

▸ **getGroups**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;72)

___

### getIdPropertyName

▸ **getIdPropertyName**(): `string`

#### Returns

`string`

#### Defined in

[src/slick/remoteview.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;68)

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

[src/slick/remoteview.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;89)

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

[src/slick/remoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;102)

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

[src/slick/remoteview.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;69)

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

[src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;90)

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

[src/slick/remoteview.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;86)

___

### getItems

▸ **getItems**(): `TEntity`[]

#### Returns

`TEntity`[]

#### Defined in

[src/slick/remoteview.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;60)

___

### getLength

▸ **getLength**(): `number`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;103)

___

### getLocalSort

▸ **getLocalSort**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;107)

___

### getPagingInfo

▸ **getPagingInfo**(): [`PagingInfo`](../interfaces/corelib_slick.PagingInfo.md)

#### Returns

[`PagingInfo`](../interfaces/corelib_slick.PagingInfo.md)

#### Defined in

[src/slick/remoteview.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;51)

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

[src/slick/remoteview.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;73)

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

[src/slick/remoteview.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;74)

___

### getRows

▸ **getRows**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;75)

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

[src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;81)

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

[src/slick/remoteview.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;78)

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

[src/slick/remoteview.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;76)

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

[src/slick/remoteview.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;77)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;99)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;100)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;101)

___

### reSort

▸ **reSort**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;110)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;98)

___

### setFilter

▸ **setFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`RemoteViewFilter`](../modules/corelib_slick.md#remoteviewfilter)<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;61)

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

[src/slick/remoteview.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;79)

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

[src/slick/remoteview.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;65)

___

### setGrouping

▸ **setGrouping**(`groupInfo`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `groupInfo` | [`GroupInfo`](../interfaces/corelib_slick.GroupInfo.md)<`TEntity`\>[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;91)

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

[src/slick/remoteview.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;67)

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

[src/slick/remoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;108)

___

### setPagingOptions

▸ **setPagingOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`PagingOptions`](../interfaces/corelib_slick.PagingOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;97)

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

[src/slick/remoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;80)

___

### setSummaryOptions

▸ **setSummaryOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`SummaryOptions`](../interfaces/corelib_slick.SummaryOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;96)

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

[src/slick/remoteview.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;109)

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

[src/slick/remoteview.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;82)

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

[src/slick/remoteview.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;83)

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

[src/slick/remoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;85)

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

[src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;84)

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

[src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#line&#x3D;87)
