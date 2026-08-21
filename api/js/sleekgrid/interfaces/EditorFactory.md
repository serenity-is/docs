[@serenity-is/sleekgrid](../README.md) / EditorFactory

# Interface: EditorFactory

Defined in: [src/core/editing.ts:101](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L101)

Factory that resolves an editor class for a given column/row.

## Methods

### getEditor()

> **getEditor**(`column`, `row?`): [`EditorClass`](EditorClass.md)

Defined in: [src/core/editing.ts:108](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L108)

Returns the editor class for the given column and optional row.

#### Parameters

##### column

[`Column`](Column.md)

Column to resolve an editor for.

##### row?

`number`

Optional row index for row-specific resolution.

#### Returns

[`EditorClass`](EditorClass.md)

Editor constructor.
