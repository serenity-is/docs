[@serenity-is/sleekgrid](../README.md) / LayoutEngine

# Interface: LayoutEngine

## Properties

### layoutName

> **layoutName**: `string`

#### Defined in

[grid/layout.ts:62](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L62)

## Methods

### afterHeaderColumnDrag()

> **afterHeaderColumnDrag**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:26](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L26)

***

### afterRenderRows()

> **afterRenderRows**(`rendered`): `void`

#### Parameters

##### rendered

[`ViewRange`](ViewRange.md)

#### Returns

`void`

#### Defined in

[grid/layout.ts:30](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L30)

***

### afterSetOptions()

> **afterSetOptions**(`args`): `void`

#### Parameters

##### args

[`GridOptions`](GridOptions.md)\<`any`\>

#### Returns

`void`

#### Defined in

[grid/layout.ts:27](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L27)

***

### appendCachedRow()

> **appendCachedRow**(`row`, `rowNodeL`, `rowNodeR`): `void`

#### Parameters

##### row

`number`

##### rowNodeL

`HTMLElement`

##### rowNodeR

`HTMLElement`

#### Returns

`void`

#### Defined in

[grid/layout.ts:25](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L25)

***

### applyColumnWidths()

> **applyColumnWidths**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:28](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L28)

***

### beforeCleanupAndRenderCells()

> **beforeCleanupAndRenderCells**(`rendered`): `void`

#### Parameters

##### rendered

[`ViewRange`](ViewRange.md)

#### Returns

`void`

#### Defined in

[grid/layout.ts:29](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L29)

***

### bindAncestorScrollEvents()

> **bindAncestorScrollEvents**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:31](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L31)

***

### calcCanvasWidth()

> **calcCanvasWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:32](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L32)

***

### destroy()

> **destroy**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:35](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L35)

***

### getCanvasNodeFor()

> **getCanvasNodeFor**(`cell`, `row`): `HTMLElement`

#### Parameters

##### cell

`number`

##### row

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:36](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L36)

***

### getCanvasNodes()

> **getCanvasNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:37](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L37)

***

### getCanvasWidth()

> **getCanvasWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:38](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L38)

***

### getFooterRowCols()

> **getFooterRowCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:40](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L40)

***

### getFooterRowColsFor()

> **getFooterRowColsFor**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:41](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L41)

***

### getFooterRowColumn()

> **getFooterRowColumn**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:42](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L42)

***

### getFrozenCols()

> **getFrozenCols**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:43](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L43)

***

### getFrozenRowOffset()

> **getFrozenRowOffset**(`row`): `number`

#### Parameters

##### row

`number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:44](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L44)

***

### getFrozenRows()

> **getFrozenRows**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:45](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L45)

***

### getHeaderCols()

> **getHeaderCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:46](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L46)

***

### getHeaderColsFor()

> **getHeaderColsFor**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:47](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L47)

***

### getHeaderColumn()

> **getHeaderColumn**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:48](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L48)

***

### getHeaderRowCols()

> **getHeaderRowCols**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:49](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L49)

***

### getHeaderRowColsFor()

> **getHeaderRowColsFor**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:50](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L50)

***

### getHeaderRowColumn()

> **getHeaderRowColumn**(`cell`): `HTMLElement`

#### Parameters

##### cell

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:51](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L51)

***

### getRowFromCellNode()

> **getRowFromCellNode**(`cellNode`, `clientX`, `clientY`): `number`

#### Parameters

##### cellNode

`HTMLElement`

##### clientX

`number`

##### clientY

`number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:39](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L39)

***

### getScrollCanvasY()

> **getScrollCanvasY**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:52](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L52)

***

### getScrollContainerX()

> **getScrollContainerX**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:53](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L53)

***

### getScrollContainerY()

> **getScrollContainerY**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:54](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L54)

***

### getTopPanelFor()

> **getTopPanelFor**(`arg0`): `HTMLElement`

#### Parameters

##### arg0

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:55](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L55)

***

### getTopPanelNodes()

> **getTopPanelNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:56](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L56)

***

### getViewportNodeFor()

> **getViewportNodeFor**(`cell`, `row`): `HTMLElement`

#### Parameters

##### cell

`number`

##### row

`number`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:57](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L57)

***

### getViewportNodes()

> **getViewportNodes**(): `HTMLElement`[]

#### Returns

`HTMLElement`[]

#### Defined in

[grid/layout.ts:58](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L58)

***

### handleScrollH()

> **handleScrollH**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:59](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L59)

***

### handleScrollV()

> **handleScrollV**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:60](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L60)

***

### init()

> **init**(`host`): `void`

#### Parameters

##### host

[`LayoutHost`](LayoutHost.md)

#### Returns

`void`

#### Defined in

[grid/layout.ts:61](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L61)

***

### isFrozenRow()

> **isFrozenRow**(`row`): `boolean`

#### Parameters

##### row

`number`

#### Returns

`boolean`

#### Defined in

[grid/layout.ts:34](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L34)

***

### realScrollHeightChange()

> **realScrollHeightChange**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:63](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L63)

***

### reorderViewColumns()

> **reorderViewColumns**(`viewCols`, `options`?): [`Column`](Column.md)\<`any`\>[]

this might be called before init, chicken egg situation

#### Parameters

##### viewCols

[`Column`](Column.md)\<`any`\>[]

##### options?

[`GridOptions`](GridOptions.md)\<`any`\>

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Defined in

[grid/layout.ts:65](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L65)

***

### resizeCanvas()

> **resizeCanvas**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:66](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L66)

***

### setOverflow()

> **setOverflow**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:69](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L69)

***

### setPaneVisibility()

> **setPaneVisibility**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:67](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L67)

***

### setScroller()

> **setScroller**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:68](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L68)

***

### updateCanvasWidth()

> **updateCanvasWidth**(): `boolean`

#### Returns

`boolean`

#### Defined in

[grid/layout.ts:70](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L70)

***

### updateHeadersWidth()

> **updateHeadersWidth**(): `void`

#### Returns

`void`

#### Defined in

[grid/layout.ts:33](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L33)
