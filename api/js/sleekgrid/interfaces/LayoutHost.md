[@serenity-is/sleekgrid](../README.md) / LayoutHost

# Interface: LayoutHost

## Methods

### bindAncestorScroll()

> **bindAncestorScroll**(`el`): `void`

#### Parameters

##### el

`HTMLElement`

#### Returns

`void`

#### Defined in

[grid/layout.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L7)

***

### cleanUpAndRenderCells()

> **cleanUpAndRenderCells**(`range`): `void`

#### Parameters

##### range

[`ViewRange`](ViewRange.md)

#### Returns

`void`

#### Defined in

[grid/layout.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L8)

***

### getAvailableWidth()

> **getAvailableWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L9)

***

### getCellFromPoint()

> **getCellFromPoint**(`x`, `y`): [`RowCell`](RowCell.md)

#### Parameters

##### x

`number`

##### y

`number`

#### Returns

[`RowCell`](RowCell.md)

#### Defined in

[grid/layout.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L10)

***

### getColumnCssRules()

> **getColumnCssRules**(`idx`): `object`

#### Parameters

##### idx

`number`

#### Returns

`object`

##### left

> **left**: `any`

##### right

> **right**: `any`

#### Defined in

[grid/layout.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L11)

***

### getColumns()

> **getColumns**(): [`Column`](Column.md)\<`any`\>[]

#### Returns

[`Column`](Column.md)\<`any`\>[]

#### Defined in

[grid/layout.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L12)

***

### getContainerNode()

> **getContainerNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L13)

***

### getDataLength()

> **getDataLength**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L14)

***

### getOptions()

> **getOptions**(): [`GridOptions`](GridOptions.md)\<`any`\>

#### Returns

[`GridOptions`](GridOptions.md)\<`any`\>

#### Defined in

[grid/layout.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L15)

***

### getRowFromNode()

> **getRowFromNode**(`rowNode`): `number`

#### Parameters

##### rowNode

`HTMLElement`

#### Returns

`number`

#### Defined in

[grid/layout.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L16)

***

### getScrollDims()

> **getScrollDims**(): `object`

#### Returns

`object`

##### height

> **height**: `number`

##### width

> **width**: `number`

#### Defined in

[grid/layout.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L17)

***

### getScrollLeft()

> **getScrollLeft**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L18)

***

### getScrollTop()

> **getScrollTop**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L19)

***

### getViewportInfo()

> **getViewportInfo**(): [`ViewportInfo`](ViewportInfo.md)

#### Returns

[`ViewportInfo`](ViewportInfo.md)

#### Defined in

[grid/layout.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L20)

***

### renderRows()

> **renderRows**(`range`): `void`

#### Parameters

##### range

[`ViewRange`](ViewRange.md)

#### Returns

`void`

#### Defined in

[grid/layout.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#L21)
