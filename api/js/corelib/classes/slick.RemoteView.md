[@serenity-is](../README.md) / [Modules](../modules.md) / [slick](../modules/slick.md) / RemoteView

# Class: RemoteView<TEntity\>

[slick](../modules/slick.md).RemoteView

## Type parameters

| Name |
| :------ |
| `TEntity` |

## Table of contents

### Constructors

- [constructor](slick.RemoteView.md#constructor)

### Properties

- [errormsg](slick.RemoteView.md#errormsg)
- [fastSort](slick.RemoteView.md#fastsort)
- [idField](slick.RemoteView.md#idfield)
- [method](slick.RemoteView.md#method)
- [onAjaxCall](slick.RemoteView.md#onajaxcall)
- [onDataChanged](slick.RemoteView.md#ondatachanged)
- [onDataLoaded](slick.RemoteView.md#ondataloaded)
- [onDataLoading](slick.RemoteView.md#ondataloading)
- [onGroupCollapsed](slick.RemoteView.md#ongroupcollapsed)
- [onGroupExpanded](slick.RemoteView.md#ongroupexpanded)
- [onPagingInfoChanged](slick.RemoteView.md#onpaginginfochanged)
- [onProcessData](slick.RemoteView.md#onprocessdata)
- [onRowCountChanged](slick.RemoteView.md#onrowcountchanged)
- [onRowsChanged](slick.RemoteView.md#onrowschanged)
- [onRowsOrCountChanged](slick.RemoteView.md#onrowsorcountchanged)
- [onSubmit](slick.RemoteView.md#onsubmit)
- [params](slick.RemoteView.md#params)
- [rowsPerPage](slick.RemoteView.md#rowsperpage)
- [seekToPage](slick.RemoteView.md#seektopage)
- [sortBy](slick.RemoteView.md#sortby)
- [url](slick.RemoteView.md#url)

### Methods

- [addData](slick.RemoteView.md#adddata)
- [addItem](slick.RemoteView.md#additem)
- [beginUpdate](slick.RemoteView.md#beginupdate)
- [collapseAllGroups](slick.RemoteView.md#collapseallgroups)
- [collapseGroup](slick.RemoteView.md#collapsegroup)
- [deleteItem](slick.RemoteView.md#deleteitem)
- [endUpdate](slick.RemoteView.md#endupdate)
- [expandAllGroups](slick.RemoteView.md#expandallgroups)
- [expandGroup](slick.RemoteView.md#expandgroup)
- [getFilter](slick.RemoteView.md#getfilter)
- [getFilteredItems](slick.RemoteView.md#getfiltereditems)
- [getGrandTotals](slick.RemoteView.md#getgrandtotals)
- [getGroupItemMetadataProvider](slick.RemoteView.md#getgroupitemmetadataprovider)
- [getGrouping](slick.RemoteView.md#getgrouping)
- [getGroups](slick.RemoteView.md#getgroups)
- [getIdPropertyName](slick.RemoteView.md#getidpropertyname)
- [getIdxById](slick.RemoteView.md#getidxbyid)
- [getItem](slick.RemoteView.md#getitem)
- [getItemById](slick.RemoteView.md#getitembyid)
- [getItemByIdx](slick.RemoteView.md#getitembyidx)
- [getItemMetadata](slick.RemoteView.md#getitemmetadata)
- [getItems](slick.RemoteView.md#getitems)
- [getLength](slick.RemoteView.md#getlength)
- [getLocalSort](slick.RemoteView.md#getlocalsort)
- [getPagingInfo](slick.RemoteView.md#getpaginginfo)
- [getRowById](slick.RemoteView.md#getrowbyid)
- [getRowByItem](slick.RemoteView.md#getrowbyitem)
- [getRows](slick.RemoteView.md#getrows)
- [insertItem](slick.RemoteView.md#insertitem)
- [mapIdsToRows](slick.RemoteView.md#mapidstorows)
- [mapItemsToRows](slick.RemoteView.md#mapitemstorows)
- [mapRowsToIds](slick.RemoteView.md#maprowstoids)
- [populate](slick.RemoteView.md#populate)
- [populateLock](slick.RemoteView.md#populatelock)
- [populateUnlock](slick.RemoteView.md#populateunlock)
- [reSort](slick.RemoteView.md#resort)
- [refresh](slick.RemoteView.md#refresh)
- [setFilter](slick.RemoteView.md#setfilter)
- [setFilterArgs](slick.RemoteView.md#setfilterargs)
- [setGroupItemMetadataProvider](slick.RemoteView.md#setgroupitemmetadataprovider)
- [setGrouping](slick.RemoteView.md#setgrouping)
- [setItems](slick.RemoteView.md#setitems)
- [setLocalSort](slick.RemoteView.md#setlocalsort)
- [setPagingOptions](slick.RemoteView.md#setpagingoptions)
- [setRefreshHints](slick.RemoteView.md#setrefreshhints)
- [setSummaryOptions](slick.RemoteView.md#setsummaryoptions)
- [sort](slick.RemoteView.md#sort)
- [sortedAddItem](slick.RemoteView.md#sortedadditem)
- [sortedUpdateItem](slick.RemoteView.md#sortedupdateitem)
- [syncGridCellCssStyles](slick.RemoteView.md#syncgridcellcssstyles)
- [syncGridSelection](slick.RemoteView.md#syncgridselection)
- [updateItem](slick.RemoteView.md#updateitem)

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
| `options` | [`RemoteViewOptions`](../interfaces/slick.RemoteViewOptions.md) |

#### Defined in

[src/slick/remoteview.ts:119](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L119)

## Properties

### errormsg

• **errormsg**: `string`

#### Defined in

[src/slick/remoteview.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L105)

___

### fastSort

• **fastSort**: `any`

#### Defined in

[src/slick/remoteview.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L66)

___

### idField

• **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L114)

___

### method

• **method**: `string`

#### Defined in

[src/slick/remoteview.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L113)

___

### onAjaxCall

• **onAjaxCall**: [`RemoteViewAjaxCallback`](../modules/slick.md#remoteviewajaxcallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L54)

___

### onDataChanged

• **onDataChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L44)

___

### onDataLoaded

• **onDataLoaded**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L46)

___

### onDataLoading

• **onDataLoading**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L45)

___

### onGroupCollapsed

• **onGroupCollapsed**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L53)

___

### onGroupExpanded

• **onGroupExpanded**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L52)

___

### onPagingInfoChanged

• **onPagingInfoChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L47)

___

### onProcessData

• **onProcessData**: [`RemoteViewProcessCallback`](../modules/slick.md#remoteviewprocesscallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L55)

___

### onRowCountChanged

• **onRowCountChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L48)

___

### onRowsChanged

• **onRowsChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L49)

___

### onRowsOrCountChanged

• **onRowsOrCountChanged**: `EventEmitter`<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L50)

___

### onSubmit

• **onSubmit**: [`CancellableViewCallback`](../modules/slick.md#cancellableviewcallback)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:43](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L43)

___

### params

• **params**: `any`

#### Defined in

[src/slick/remoteview.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L106)

___

### rowsPerPage

• **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L104)

___

### seekToPage

• `Optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L115)

___

### sortBy

• **sortBy**: `string`[]

#### Defined in

[src/slick/remoteview.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L111)

___

### url

• **url**: `string`

#### Defined in

[src/slick/remoteview.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L112)

## Methods

### addData

▸ **addData**(`data`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `data` | [`ListResponse`](../interfaces/q.ListResponse.md)<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L56)

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

[src/slick/remoteview.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L88)

___

### beginUpdate

▸ **beginUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L57)

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

[src/slick/remoteview.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L92)

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

[src/slick/remoteview.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L95)

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

[src/slick/remoteview.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L59)

___

### endUpdate

▸ **endUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L58)

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

[src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L93)

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

[src/slick/remoteview.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L94)

___

### getFilter

▸ **getFilter**(): [`RemoteViewFilter`](../modules/slick.md#remoteviewfilter)<`TEntity`\>

#### Returns

[`RemoteViewFilter`](../modules/slick.md#remoteviewfilter)<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L62)

___

### getFilteredItems

▸ **getFilteredItems**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L63)

___

### getGrandTotals

▸ **getGrandTotals**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L70)

___

### getGroupItemMetadataProvider

▸ **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

#### Returns

`GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L64)

___

### getGrouping

▸ **getGrouping**(): [`GroupInfo`](../interfaces/slick.GroupInfo.md)<`TEntity`\>[]

#### Returns

[`GroupInfo`](../interfaces/slick.GroupInfo.md)<`TEntity`\>[]

#### Defined in

[src/slick/remoteview.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L71)

___

### getGroups

▸ **getGroups**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L72)

___

### getIdPropertyName

▸ **getIdPropertyName**(): `string`

#### Returns

`string`

#### Defined in

[src/slick/remoteview.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L68)

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

[src/slick/remoteview.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L89)

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

[src/slick/remoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L102)

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

[src/slick/remoteview.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L69)

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

[src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L90)

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

[src/slick/remoteview.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L86)

___

### getItems

▸ **getItems**(): `TEntity`[]

#### Returns

`TEntity`[]

#### Defined in

[src/slick/remoteview.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L60)

___

### getLength

▸ **getLength**(): `number`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L103)

___

### getLocalSort

▸ **getLocalSort**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L107)

___

### getPagingInfo

▸ **getPagingInfo**(): [`PagingInfo`](../interfaces/slick.PagingInfo.md)

#### Returns

[`PagingInfo`](../interfaces/slick.PagingInfo.md)

#### Defined in

[src/slick/remoteview.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L51)

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

[src/slick/remoteview.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L73)

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

[src/slick/remoteview.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L74)

___

### getRows

▸ **getRows**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L75)

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

[src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L81)

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

[src/slick/remoteview.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L78)

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

[src/slick/remoteview.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L76)

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

[src/slick/remoteview.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L77)

___

### populate

▸ **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L99)

___

### populateLock

▸ **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L100)

___

### populateUnlock

▸ **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L101)

___

### reSort

▸ **reSort**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L110)

___

### refresh

▸ **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L98)

___

### setFilter

▸ **setFilter**(`filter`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `filter` | [`RemoteViewFilter`](../modules/slick.md#remoteviewfilter)<`TEntity`\> |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L61)

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

[src/slick/remoteview.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L79)

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

[src/slick/remoteview.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L65)

___

### setGrouping

▸ **setGrouping**(`groupInfo`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `groupInfo` | [`GroupInfo`](../interfaces/slick.GroupInfo.md)<`TEntity`\>[] |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L91)

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

[src/slick/remoteview.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L67)

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

[src/slick/remoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L108)

___

### setPagingOptions

▸ **setPagingOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`PagingOptions`](../interfaces/slick.PagingOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L97)

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

[src/slick/remoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L80)

___

### setSummaryOptions

▸ **setSummaryOptions**(`options`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `options` | [`SummaryOptions`](../interfaces/slick.SummaryOptions.md) |

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L96)

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

[src/slick/remoteview.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L109)

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

[src/slick/remoteview.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L82)

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

[src/slick/remoteview.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L83)

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

[src/slick/remoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L85)

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

[src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

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

[src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L87)
