[@serenity-is/sleekgrid](../README.md) / LayoutEngine

# Interface: LayoutEngine

## Table of contents

### Properties

- [layoutName](LayoutEngine.md#layoutname)

### Methods

- [afterHeaderColumnDrag](LayoutEngine.md#afterheadercolumndrag)
- [afterRenderRows](LayoutEngine.md#afterrenderrows)
- [afterSetOptions](LayoutEngine.md#aftersetoptions)
- [appendCachedRow](LayoutEngine.md#appendcachedrow)
- [applyColumnWidths](LayoutEngine.md#applycolumnwidths)
- [beforeCleanupAndRenderCells](LayoutEngine.md#beforecleanupandrendercells)
- [bindAncestorScrollEvents](LayoutEngine.md#bindancestorscrollevents)
- [calcCanvasWidth](LayoutEngine.md#calccanvaswidth)
- [destroy](LayoutEngine.md#destroy)
- [getCanvasNodeFor](LayoutEngine.md#getcanvasnodefor)
- [getCanvasNodes](LayoutEngine.md#getcanvasnodes)
- [getCanvasWidth](LayoutEngine.md#getcanvaswidth)
- [getFooterRowCols](LayoutEngine.md#getfooterrowcols)
- [getFooterRowColsFor](LayoutEngine.md#getfooterrowcolsfor)
- [getFooterRowColumn](LayoutEngine.md#getfooterrowcolumn)
- [getFrozenCols](LayoutEngine.md#getfrozencols)
- [getFrozenRowOffset](LayoutEngine.md#getfrozenrowoffset)
- [getFrozenRows](LayoutEngine.md#getfrozenrows)
- [getHeaderCols](LayoutEngine.md#getheadercols)
- [getHeaderColsFor](LayoutEngine.md#getheadercolsfor)
- [getHeaderColumn](LayoutEngine.md#getheadercolumn)
- [getHeaderRowCols](LayoutEngine.md#getheaderrowcols)
- [getHeaderRowColsFor](LayoutEngine.md#getheaderrowcolsfor)
- [getHeaderRowColumn](LayoutEngine.md#getheaderrowcolumn)
- [getRowFromCellNode](LayoutEngine.md#getrowfromcellnode)
- [getScrollCanvasY](LayoutEngine.md#getscrollcanvasy)
- [getScrollContainerX](LayoutEngine.md#getscrollcontainerx)
- [getScrollContainerY](LayoutEngine.md#getscrollcontainery)
- [getTopPanelFor](LayoutEngine.md#gettoppanelfor)
- [getTopPanelNodes](LayoutEngine.md#gettoppanelnodes)
- [getViewportNodeFor](LayoutEngine.md#getviewportnodefor)
- [getViewportNodes](LayoutEngine.md#getviewportnodes)
- [handleScrollH](LayoutEngine.md#handlescrollh)
- [handleScrollV](LayoutEngine.md#handlescrollv)
- [init](LayoutEngine.md#init)
- [isFrozenRow](LayoutEngine.md#isfrozenrow)
- [realScrollHeightChange](LayoutEngine.md#realscrollheightchange)
- [reorderViewColumns](LayoutEngine.md#reorderviewcolumns)
- [resizeCanvas](LayoutEngine.md#resizecanvas)
- [setOverflow](LayoutEngine.md#setoverflow)
- [setPaneVisibility](LayoutEngine.md#setpanevisibility)
- [setScroller](LayoutEngine.md#setscroller)
- [updateCanvasWidth](LayoutEngine.md#updatecanvaswidth)
- [updateHeadersWidth](LayoutEngine.md#updateheaderswidth)

## Properties

### layoutName

• **layoutName**: `string`

#### Defined in

[grid/layout.ts:62](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L62)

## Methods

### afterHeaderColumnDrag

▸ **afterHeaderColumnDrag**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L26)

___

### afterRenderRows

▸ **afterRenderRows**(`rendered`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rendered` | [`ViewRange`](ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/layout.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L30)

___

### afterSetOptions

▸ **afterSetOptions**(`args`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `args` | [`GridOptions`](GridOptions.md)<`any`\> |

#### Returns

`void`

#### Defined in

[grid/layout.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L27)

___

### appendCachedRow

▸ **appendCachedRow**(`row`, `rowNodeL`, `rowNodeR`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |
| `rowNodeL` | `HTMLElement` |
| `rowNodeR` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[grid/layout.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L25)

___

### applyColumnWidths

▸ **applyColumnWidths**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L28)

___

### beforeCleanupAndRenderCells

▸ **beforeCleanupAndRenderCells**(`rendered`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rendered` | [`ViewRange`](ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/layout.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L29)

___

### bindAncestorScrollEvents

▸ **bindAncestorScrollEvents**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L31)

___

### calcCanvasWidth

▸ **calcCanvasWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L32)

___

### destroy

▸ **destroy**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L35)

___

### getCanvasNodeFor

▸ **getCanvasNodeFor**(`cell`, `row`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |
| `row` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L36)

___

### getCanvasNodes

▸ **getCanvasNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L37)

___

### getCanvasWidth

▸ **getCanvasWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:38](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L38)

___

### getFooterRowCols

▸ **getFooterRowCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L40)

___

### getFooterRowColsFor

▸ **getFooterRowColsFor**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:41](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L41)

___

### getFooterRowColumn

▸ **getFooterRowColumn**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:42](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L42)

___

### getFrozenCols

▸ **getFrozenCols**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:43](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L43)

___

### getFrozenRowOffset

▸ **getFrozenRowOffset**(`row`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`number`

#### Defined in

[grid/layout.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L44)

___

### getFrozenRows

▸ **getFrozenRows**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L45)

___

### getHeaderCols

▸ **getHeaderCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:46](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L46)

___

### getHeaderColsFor

▸ **getHeaderColsFor**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:47](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L47)

___

### getHeaderColumn

▸ **getHeaderColumn**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L48)

___

### getHeaderRowCols

▸ **getHeaderRowCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L49)

___

### getHeaderRowColsFor

▸ **getHeaderRowColsFor**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:50](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L50)

___

### getHeaderRowColumn

▸ **getHeaderRowColumn**(`cell`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:51](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L51)

___

### getRowFromCellNode

▸ **getRowFromCellNode**(`cellNode`, `clientX`, `clientY`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cellNode` | `HTMLElement` |
| `clientX` | `number` |
| `clientY` | `number` |

#### Returns

`number`

#### Defined in

[grid/layout.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L39)

___

### getScrollCanvasY

▸ **getScrollCanvasY**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L52)

___

### getScrollContainerX

▸ **getScrollContainerX**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:53](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L53)

___

### getScrollContainerY

▸ **getScrollContainerY**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:54](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L54)

___

### getTopPanelFor

▸ **getTopPanelFor**(`arg0`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `arg0` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:55](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L55)

___

### getTopPanelNodes

▸ **getTopPanelNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:56](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L56)

___

### getViewportNodeFor

▸ **getViewportNodeFor**(`cell`, `row`): `HTMLElement`

#### Parameters

| Name | Type |
| :------ | :------ |
| `cell` | `number` |
| `row` | `number` |

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:57](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L57)

___

### getViewportNodes

▸ **getViewportNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:58](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L58)

___

### handleScrollH

▸ **handleScrollH**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:59](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L59)

___

### handleScrollV

▸ **handleScrollV**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:60](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L60)

___

### init

▸ **init**(`host`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `host` | [`LayoutHost`](LayoutHost.md) |

#### Returns

`void`

#### Defined in

[grid/layout.ts:61](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L61)

___

### isFrozenRow

▸ **isFrozenRow**(`row`): `boolean`

#### Parameters

| Name | Type |
| :------ | :------ |
| `row` | `number` |

#### Returns

`boolean`

#### Defined in

[grid/layout.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L34)

___

### realScrollHeightChange

▸ **realScrollHeightChange**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L63)

___

### reorderViewColumns

▸ **reorderViewColumns**(`viewCols`, `options?`): [`Column`](Column.md)<`any`\>[]

this might be called before init, chicken egg situation

#### Parameters

| Name | Type |
| :------ | :------ |
| `viewCols` | [`Column`](Column.md)<`any`\>[] |
| `options?` | [`GridOptions`](GridOptions.md)<`any`\> |

#### Returns

[`Column`](Column.md)<`any`\>[]

#### Defined in

[grid/layout.ts:65](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L65)

___

### resizeCanvas

▸ **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:66](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L66)

___

### setOverflow

▸ **setOverflow**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L69)

___

### setPaneVisibility

▸ **setPaneVisibility**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:67](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L67)

___

### setScroller

▸ **setScroller**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:68](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L68)

___

### updateCanvasWidth

▸ **updateCanvasWidth**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/layout.ts:70](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L70)

___

### updateHeadersWidth

▸ **updateHeadersWidth**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L33)
