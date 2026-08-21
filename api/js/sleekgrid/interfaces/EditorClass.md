[@serenity-is/sleekgrid](../README.md) / EditorClass

# Interface: EditorClass

Defined in: [src/core/editing.ts:135](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L135)

Constructor type for cell editors.

## Constructors

### Constructor

> **new EditorClass**(`options`): [`Editor`](Editor.md)

Defined in: [src/core/editing.ts:137](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L137)

Instantiates the editor for the given options.

#### Parameters

##### options

[`EditorOptions`](EditorOptions.md)

#### Returns

[`Editor`](Editor.md)

## Properties

### suppressClearOnEdit?

> `optional` **suppressClearOnEdit**: `boolean`

Defined in: [src/core/editing.ts:142](https://github.com/serenity-is/Serenity/blob/master/packages/sleekgrid/src/core/editing.ts#L142)

When `true`, the editor is not cleared on first key press; the existing
value is preserved and the key is forwarded to the editor.
