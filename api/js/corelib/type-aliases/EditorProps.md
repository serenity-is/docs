[@serenity-is/corelib](../README.md) / EditorProps

# Type Alias: EditorProps\<T\>

> **EditorProps**\<`T`\> = [`WidgetProps`](WidgetProps.md)\<`T`\> & `object`

Defined in: [src/ui/editors/editorwidget.ts:8](https://github.com/serenity-is/serenity/blob/master/packages/corelib/src/ui/editors/editorwidget.ts#L8)

Props for editor widgets, extending widget props with editor-specific options.

## Type Declaration

### initialValue?

> `optional` **initialValue**: `any`

Initial value for the editor.

### maxLength?

> `optional` **maxLength**: `number`

Maximum input length.

### name?

> `optional` **name**: `string`

Field name.

### placeholder?

> `optional` **placeholder**: `string`

Placeholder text.

### readOnly?

> `optional` **readOnly**: `boolean`

Whether the editor is read-only.

### required?

> `optional` **required**: `boolean`

Whether the field is required.

## Type Parameters

### T

`T`

Widget props type.
