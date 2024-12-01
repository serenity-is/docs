[@serenity-is/corelib](../README.md) / RemoteView

# Class: RemoteView\<TEntity\>

## Type Parameters

• **TEntity**

## Constructors

### new RemoteView()

> **new RemoteView**\<`TEntity`\>(`options`): [`RemoteView`](RemoteView.md)\<`TEntity`\>

#### Parameters

##### options

[`RemoteViewOptions`](../interfaces/RemoteViewOptions.md)

#### Returns

[`RemoteView`](RemoteView.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:120](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L120)

## Properties

### errormsg

> **errormsg**: `string`

#### Defined in

[src/slick/remoteview.ts:106](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L106)

***

### fastSort

> **fastSort**: `any`

#### Defined in

[src/slick/remoteview.ts:67](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L67)

***

### idField

> **idField**: `string`

#### Defined in

[src/slick/remoteview.ts:115](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L115)

***

### method

> **method**: `string`

#### Defined in

[src/slick/remoteview.ts:114](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L114)

***

### onAjaxCall

> **onAjaxCall**: [`RemoteViewAjaxCallback`](../type-aliases/RemoteViewAjaxCallback.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:55](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L55)

***

### onDataChanged

> **onDataChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:45](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L45)

***

### onDataLoaded

> **onDataLoaded**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:47](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L47)

***

### onDataLoading

> **onDataLoading**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:46](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L46)

***

### onGroupCollapsed

> **onGroupCollapsed**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:54](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L54)

***

### onGroupExpanded

> **onGroupExpanded**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:53](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L53)

***

### onPagingInfoChanged

> **onPagingInfoChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:48](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L48)

***

### onProcessData

> **onProcessData**: [`RemoteViewProcessCallback`](../type-aliases/RemoteViewProcessCallback.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:56](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L56)

***

### onRowCountChanged

> **onRowCountChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:49](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L49)

***

### onRowsChanged

> **onRowsChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:50](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L50)

***

### onRowsOrCountChanged

> **onRowsOrCountChanged**: `EventEmitter`\<`any`, `IEventData`\>

#### Defined in

[src/slick/remoteview.ts:51](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L51)

***

### onSubmit

> **onSubmit**: [`CancellableViewCallback`](../type-aliases/CancellableViewCallback.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:44](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L44)

***

### params

> **params**: `any`

#### Defined in

[src/slick/remoteview.ts:107](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L107)

***

### rowsPerPage

> **rowsPerPage**: `number`

#### Defined in

[src/slick/remoteview.ts:105](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L105)

***

### seekToPage?

> `optional` **seekToPage**: `number`

#### Defined in

[src/slick/remoteview.ts:116](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L116)

***

### sortBy

> **sortBy**: `string`[]

#### Defined in

[src/slick/remoteview.ts:112](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L112)

***

### url

> **url**: `string`

#### Defined in

[src/slick/remoteview.ts:113](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L113)

## Methods

### addData()

> **addData**(`data`): `void`

#### Parameters

##### data

[`ListResponse`](../interfaces/ListResponse.md)\<`TEntity`\>

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:57](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L57)

***

### addItem()

> **addItem**(`item`): `void`

#### Parameters

##### item

`TEntity`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:89](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L89)

***

### beginUpdate()

> **beginUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:58](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L58)

***

### collapseAllGroups()

> **collapseAllGroups**(`level`): `void`

#### Parameters

##### level

`number`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:93](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L93)

***

### collapseGroup()

> **collapseGroup**(`keys`): `void`

#### Parameters

##### keys

`any`[]

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:96](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L96)

***

### deleteItem()

> **deleteItem**(`id`): `void`

#### Parameters

##### id

`any`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:60](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L60)

***

### endUpdate()

> **endUpdate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:59](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L59)

***

### expandAllGroups()

> **expandAllGroups**(`level`): `void`

#### Parameters

##### level

`number`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:94](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L94)

***

### expandGroup()

> **expandGroup**(`keys`): `void`

#### Parameters

##### keys

`any`[]

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:95](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L95)

***

### getFilter()

> **getFilter**(): [`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TEntity`\>

#### Returns

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TEntity`\>

#### Defined in

[src/slick/remoteview.ts:63](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L63)

***

### getFilteredItems()

> **getFilteredItems**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:64](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L64)

***

### getGrandTotals()

> **getGrandTotals**(): `any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:71](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L71)

***

### getGrouping()

> **getGrouping**(): [`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[]

#### Returns

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[]

#### Defined in

[src/slick/remoteview.ts:72](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L72)

***

### getGroupItemMetadataProvider()

> **getGroupItemMetadataProvider**(): `GroupItemMetadataProvider`

#### Returns

`GroupItemMetadataProvider`

#### Defined in

[src/slick/remoteview.ts:65](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L65)

***

### getGroups()

> **getGroups**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:73](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L73)

***

### getIdPropertyName()

> **getIdPropertyName**(): `string`

#### Returns

`string`

#### Defined in

[src/slick/remoteview.ts:69](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L69)

***

### getIdxById()

> **getIdxById**(`id`): `any`

#### Parameters

##### id

`any`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:90](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L90)

***

### getItem()

> **getItem**(`row`): `any`

#### Parameters

##### row

`number`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:103](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L103)

***

### getItemById()

> **getItemById**(`id`): `TEntity`

#### Parameters

##### id

`any`

#### Returns

`TEntity`

#### Defined in

[src/slick/remoteview.ts:70](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L70)

***

### getItemByIdx()

> **getItemByIdx**(`index`): `any`

#### Parameters

##### index

`number`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:91](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L91)

***

### getItemMetadata()

> **getItemMetadata**(`i`): `any`

#### Parameters

##### i

`number`

#### Returns

`any`

#### Defined in

[src/slick/remoteview.ts:87](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L87)

***

### getItems()

> **getItems**(): `TEntity`[]

#### Returns

`TEntity`[]

#### Defined in

[src/slick/remoteview.ts:61](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L61)

***

### getLength()

> **getLength**(): `number`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:104](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L104)

***

### getLocalSort()

> **getLocalSort**(): `boolean`

#### Returns

`boolean`

#### Defined in

[src/slick/remoteview.ts:108](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L108)

***

### getPagingInfo()

> **getPagingInfo**(): [`PagingInfo`](../interfaces/PagingInfo.md)

#### Returns

[`PagingInfo`](../interfaces/PagingInfo.md)

#### Defined in

[src/slick/remoteview.ts:52](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L52)

***

### getRowById()

> **getRowById**(`id`): `number`

#### Parameters

##### id

`any`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:74](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L74)

***

### getRowByItem()

> **getRowByItem**(`item`): `number`

#### Parameters

##### item

`any`

#### Returns

`number`

#### Defined in

[src/slick/remoteview.ts:75](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L75)

***

### getRows()

> **getRows**(): `any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:76](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L76)

***

### insertItem()

> **insertItem**(`insertBefore`, `item`): `void`

#### Parameters

##### insertBefore

`number`

##### item

`any`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:82](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L82)

***

### mapIdsToRows()

> **mapIdsToRows**(`idAray`): `number`[]

#### Parameters

##### idAray

`any`[]

#### Returns

`number`[]

#### Defined in

[src/slick/remoteview.ts:79](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L79)

***

### mapItemsToRows()

> **mapItemsToRows**(`itemArray`): `any`[]

#### Parameters

##### itemArray

`any`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:77](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L77)

***

### mapRowsToIds()

> **mapRowsToIds**(`rowArray`): `any`[]

#### Parameters

##### rowArray

`number`[]

#### Returns

`any`[]

#### Defined in

[src/slick/remoteview.ts:78](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L78)

***

### populate()

> **populate**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:100](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L100)

***

### populateLock()

> **populateLock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:101](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L101)

***

### populateUnlock()

> **populateUnlock**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:102](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L102)

***

### refresh()

> **refresh**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:99](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L99)

***

### reSort()

> **reSort**(): `void`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:111](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L111)

***

### setFilter()

> **setFilter**(`filter`): `void`

#### Parameters

##### filter

[`RemoteViewFilter`](../type-aliases/RemoteViewFilter.md)\<`TEntity`\>

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:62](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L62)

***

### setFilterArgs()

> **setFilterArgs**(`args`): `void`

#### Parameters

##### args

`any`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:80](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L80)

***

### setGrouping()

> **setGrouping**(`groupInfo`): `void`

#### Parameters

##### groupInfo

[`GroupInfo`](../interfaces/GroupInfo.md)\<`TEntity`\>[]

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:92](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L92)

***

### setGroupItemMetadataProvider()

> **setGroupItemMetadataProvider**(`value`): `void`

#### Parameters

##### value

`GroupItemMetadataProvider`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:66](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L66)

***

### setItems()

> **setItems**(`items`, `newIdProperty`?): `void`

#### Parameters

##### items

`any`[]

##### newIdProperty?

`string` | `boolean`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:68](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L68)

***

### setLocalSort()

> **setLocalSort**(`value`): `void`

#### Parameters

##### value

`boolean`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:109](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L109)

***

### setPagingOptions()

> **setPagingOptions**(`options`): `void`

#### Parameters

##### options

[`PagingOptions`](../interfaces/PagingOptions.md)

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:98](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L98)

***

### setRefreshHints()

> **setRefreshHints**(`hints`): `void`

#### Parameters

##### hints

`any`[]

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:81](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L81)

***

### setSummaryOptions()

> **setSummaryOptions**(`options`): `void`

#### Parameters

##### options

[`SummaryOptions`](../interfaces/SummaryOptions.md)

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:97](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L97)

***

### sort()

> **sort**(`comparer`?, `ascending`?): `void`

#### Parameters

##### comparer?

(`a`, `b`) => `number`

##### ascending?

`boolean`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:110](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L110)

***

### sortedAddItem()

> **sortedAddItem**(`item`): `void`

#### Parameters

##### item

`any`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:83](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L83)

***

### sortedUpdateItem()

> **sortedUpdateItem**(`id`, `item`): `void`

#### Parameters

##### id

`any`

##### item

`any`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:84](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L84)

***

### syncGridCellCssStyles()

> **syncGridCellCssStyles**(`grid`, `key`): `void`

#### Parameters

##### grid

`any`

##### key

`string`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:86](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L86)

***

### syncGridSelection()

> **syncGridSelection**(`grid`, `preserveHidden`?, `preserveHiddenOnSelectionChange`?): `void`

#### Parameters

##### grid

`any`

##### preserveHidden?

`boolean`

##### preserveHiddenOnSelectionChange?

`boolean`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:85](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L85)

***

### updateItem()

> **updateItem**(`id`, `item`): `void`

#### Parameters

##### id

`any`

##### item

`TEntity`

#### Returns

`void`

#### Defined in

[src/slick/remoteview.ts:88](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/slick/remoteview.ts#L88)
