[@serenity-is/sleekgrid](../README.md) / EditorOptions

# Interface: EditorOptions

Defined in: [src/core/editing.ts:71](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L71)

Options passed to every editor instance on construction.

## Properties

### cancelChanges()?

> `optional` **cancelChanges**: () => `void`

Defined in: [src/core/editing.ts:95](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L95)

Callback to cancel pending editor changes.

#### Returns

`void`

***

### column?

> `optional` **column**: [`Column`](Column.md)

Defined in: [src/core/editing.ts:81](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L81)

Column definition for the cell being edited.

***

### columnMetaData?

> `optional` **columnMetaData**: [`ColumnMetadata`](ColumnMetadata.md)\<`any`\>

Defined in: [src/core/editing.ts:83](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L83)

Metadata overrides for the column/row being edited.

***

### commitChanges()?

> `optional` **commitChanges**: () => `void`

Defined in: [src/core/editing.ts:93](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L93)

Callback to commit pending editor changes.

#### Returns

`void`

***

### compositeEditorOptions?

> `optional` **compositeEditorOptions**: [`CompositeEditorOptions`](CompositeEditorOptions.md)

Defined in: [src/core/editing.ts:85](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L85)

Options from a parent composite editor, if any.

***

### container?

> `optional` **container**: `HTMLElement`

Defined in: [src/core/editing.ts:87](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L87)

DOM container the editor should render into.

***

### editorCellNavOnLRKeys?

> `optional` **editorCellNavOnLRKeys**: `boolean`

Defined in: [src/core/editing.ts:79](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L79)

Whether left/right arrow keys should navigate between cells while editing.

***

### event?

> `optional` **event**: [`EventData`](../type-aliases/EventData.md)

Defined in: [src/core/editing.ts:91](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L91)

Event that triggered the edit, if available.

***

### grid

> **grid**: [`EditorHost`](EditorHost.md)

Defined in: [src/core/editing.ts:73](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L73)

Host grid instance the editor operates within.

***

### gridPosition?

> `optional` **gridPosition**: [`Position`](Position.md)

Defined in: [src/core/editing.ts:75](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L75)

Bounds of the entire grid container in viewport coordinates.

***

### item?

> `optional` **item**: `any`

Defined in: [src/core/editing.ts:89](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L89)

Data item (row) being edited.

***

### position?

> `optional` **position**: [`Position`](Position.md)

Defined in: [src/core/editing.ts:77](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L77)

Bounds of the target cell where the editor should be positioned.
