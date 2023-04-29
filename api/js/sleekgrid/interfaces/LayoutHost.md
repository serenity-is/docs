[@serenity-is/sleekgrid](../README.md) / LayoutHost

# Interface: LayoutHost

## Table of contents

### Methods

- [bindAncestorScroll](LayoutHost.md#bindancestorscroll)
- [cleanUpAndRenderCells](LayoutHost.md#cleanupandrendercells)
- [getAvailableWidth](LayoutHost.md#getavailablewidth)
- [getCellFromPoint](LayoutHost.md#getcellfrompoint)
- [getColumnCssRules](LayoutHost.md#getcolumncssrules)
- [getColumns](LayoutHost.md#getcolumns)
- [getContainerNode](LayoutHost.md#getcontainernode)
- [getDataLength](LayoutHost.md#getdatalength)
- [getOptions](LayoutHost.md#getoptions)
- [getRowFromNode](LayoutHost.md#getrowfromnode)
- [getScrollDims](LayoutHost.md#getscrolldims)
- [getScrollLeft](LayoutHost.md#getscrollleft)
- [getScrollTop](LayoutHost.md#getscrolltop)
- [getViewportInfo](LayoutHost.md#getviewportinfo)
- [renderRows](LayoutHost.md#renderrows)

## Methods

### bindAncestorScroll

▸ **bindAncestorScroll**(`el`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `el` | `HTMLElement` |

#### Returns

`void`

#### Defined in

[grid/layout.ts:7](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;7)

___

### cleanUpAndRenderCells

▸ **cleanUpAndRenderCells**(`range`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `range` | [`ViewRange`](ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/layout.ts:8](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;8)

___

### getAvailableWidth

▸ **getAvailableWidth**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:9](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;9)

___

### getCellFromPoint

▸ **getCellFromPoint**(`x`, `y`): [`RowCell`](RowCell.md)

#### Parameters

| Name | Type |
| :------ | :------ |
| `x` | `number` |
| `y` | `number` |

#### Returns

[`RowCell`](RowCell.md)

#### Defined in

[grid/layout.ts:10](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;10)

___

### getColumnCssRules

▸ **getColumnCssRules**(`idx`): `Object`

#### Parameters

| Name | Type |
| :------ | :------ |
| `idx` | `number` |

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `left` | `any` |
| `right` | `any` |

#### Defined in

[grid/layout.ts:11](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;11)

___

### getColumns

▸ **getColumns**(): [`Column`](Column.md)<`any`\>[]

#### Returns

[`Column`](Column.md)<`any`\>[]

#### Defined in

[grid/layout.ts:12](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;12)

___

### getContainerNode

▸ **getContainerNode**(): `HTMLElement`

#### Returns

`HTMLElement`

#### Defined in

[grid/layout.ts:13](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;13)

___

### getDataLength

▸ **getDataLength**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:14](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;14)

___

### getOptions

▸ **getOptions**(): [`GridOptions`](GridOptions.md)<`any`\>

#### Returns

[`GridOptions`](GridOptions.md)<`any`\>

#### Defined in

[grid/layout.ts:15](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;15)

___

### getRowFromNode

▸ **getRowFromNode**(`rowNode`): `number`

#### Parameters

| Name | Type |
| :------ | :------ |
| `rowNode` | `HTMLElement` |

#### Returns

`number`

#### Defined in

[grid/layout.ts:16](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;16)

___

### getScrollDims

▸ **getScrollDims**(): `Object`

#### Returns

`Object`

| Name | Type |
| :------ | :------ |
| `height` | `number` |
| `width` | `number` |

#### Defined in

[grid/layout.ts:17](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;17)

___

### getScrollLeft

▸ **getScrollLeft**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:18](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;18)

___

### getScrollTop

▸ **getScrollTop**(): `number`

#### Returns

`number`

#### Defined in

[grid/layout.ts:19](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;19)

___

### getViewportInfo

▸ **getViewportInfo**(): [`ViewportInfo`](ViewportInfo.md)

#### Returns

[`ViewportInfo`](ViewportInfo.md)

#### Defined in

[grid/layout.ts:20](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;20)

___

### renderRows

▸ **renderRows**(`range`): `void`

#### Parameters

| Name | Type |
| :------ | :------ |
| `range` | [`ViewRange`](ViewRange.md) |

#### Returns

`void`

#### Defined in

[grid/layout.ts:21](https://github.com/serenity-is/sleekgrid/blob/master/src/grid/layout.ts#line&#x3D;21)
