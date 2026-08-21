[@serenity-is/sleekgrid](../README.md) / EditorHost

# Interface: EditorHost

Defined in: [src/core/editing.ts:47](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L47)

Minimal grid/host surface required by cell editors to navigate and resolve editors.

## Extended by

- [`ISleekGrid`](ISleekGrid.md)

## Properties

### onCompositeEditorChange

> **onCompositeEditorChange**: [`EventEmitter`](../classes/EventEmitter.md)\<`any`\>

Defined in: [src/core/editing.ts:55](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L55)

Emits when a composite-editor field value changes; editors forward changes through this.

## Methods

### getActiveCell()

> **getActiveCell**(): [`RowCell`](RowCell.md)

Defined in: [src/core/editing.ts:49](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L49)

Returns the currently active cell, or `null` when no cell is active.

#### Returns

[`RowCell`](RowCell.md)

***

### getEditorFactory()

> **getEditorFactory**(): [`EditorFactory`](EditorFactory.md)

Defined in: [src/core/editing.ts:57](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L57)

Resolves the editor factory for a given column/row.

#### Returns

[`EditorFactory`](EditorFactory.md)

***

### navigateNext()

> **navigateNext**(): `boolean`

Defined in: [src/core/editing.ts:51](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L51)

Moves focus to the next focusable cell.

#### Returns

`boolean`

`true` if focus moved.

***

### navigatePrev()

> **navigatePrev**(): `boolean`

Defined in: [src/core/editing.ts:53](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L53)

Moves focus to the previous focusable cell.

#### Returns

`boolean`

`true` if focus moved.
