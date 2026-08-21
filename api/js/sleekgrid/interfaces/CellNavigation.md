[@serenity-is/sleekgrid](../README.md) / CellNavigation

# Interface: CellNavigation

Defined in: [src/core/cellnavigation.ts:14](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L14)

Contract for keyboard / programmatic navigation of the active cell.
Implemented by the grid so that editors, plugins and external code can move
focus without coupling to internal navigation logic.

## Extended by

- [`ISleekGrid`](ISleekGrid.md)

## Methods

### navigate()

> **navigate**(`dir`): `boolean`

Defined in: [src/core/cellnavigation.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L95)

Navigate the active cell in the specified direction.

#### Parameters

##### dir

[`CellNavigationDirection`](../type-aliases/CellNavigationDirection.md)

Navigation direction.

#### Returns

`boolean`

Whether navigation resulted in a change of the active cell.

***

### navigateBottom()

> **navigateBottom**(): `void`

Defined in: [src/core/cellnavigation.ts:18](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L18)

Moves the active cell to the last row of the data set.

#### Returns

`void`

***

### navigateDown()

> **navigateDown**(): `boolean`

Defined in: [src/core/cellnavigation.ts:24](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L24)

Moves the active cell one row down.

#### Returns

`boolean`

`true` if the active cell changed, `false` if already at the bottom or blocked.

***

### navigateLeft()

> **navigateLeft**(): `boolean`

Defined in: [src/core/cellnavigation.ts:30](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L30)

Moves the active cell one column to the left.

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/core/cellnavigation.ts:36](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L36)

Moves the active cell to the next focusable cell (row-major order, wrapping rows).

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigatePageDown()

> **navigatePageDown**(): `void`

Defined in: [src/core/cellnavigation.ts:41](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L41)

Scrolls one page down and moves the active cell accordingly.

#### Returns

`void`

***

### navigatePageUp()

> **navigatePageUp**(): `void`

Defined in: [src/core/cellnavigation.ts:46](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L46)

Scrolls one page up and moves the active cell accordingly.

#### Returns

`void`

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/core/cellnavigation.ts:52](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L52)

Moves the active cell to the previous focusable cell (reverse row-major order).

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateRight()

> **navigateRight**(): `boolean`

Defined in: [src/core/cellnavigation.ts:58](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L58)

Moves the active cell one column to the right.

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateRowEnd()

> **navigateRowEnd**(): `boolean`

Defined in: [src/core/cellnavigation.ts:64](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L64)

Moves the active cell to the last cell of the current row.

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateRowStart()

> **navigateRowStart**(): `boolean`

Defined in: [src/core/cellnavigation.ts:70](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L70)

Moves the active cell to the first cell of the current row.

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateTop()

> **navigateTop**(): `void`

Defined in: [src/core/cellnavigation.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L75)

Moves the active cell to the first row of the data set.

#### Returns

`void`

***

### navigateToRow()

> **navigateToRow**(`row`): `boolean`

Defined in: [src/core/cellnavigation.ts:82](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L82)

Moves the active cell to the specified row, keeping the current column if possible.

#### Parameters

##### row

`number`

Zero-based row index to navigate to.

#### Returns

`boolean`

`true` if the active cell changed.

***

### navigateUp()

> **navigateUp**(): `boolean`

Defined in: [src/core/cellnavigation.ts:88](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/cellnavigation.ts#L88)

Moves the active cell one row up.

#### Returns

`boolean`

`true` if the active cell changed.
